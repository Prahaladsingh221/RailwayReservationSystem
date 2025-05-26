Imports System.Data.SqlClient

Public Class form5
    Dim connectionString As String = "Server=ASUSVIVOBOOK\SQLEXPRESS;Database=RailwayDB;Integrated Security=True"

    Private Sub form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStations()
        LoadTrains()
    End Sub

    Private Sub LoadStations()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT StationID, StationName FROM Stations"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            cmbSourceStationID.DataSource = dt.Copy()
            cmbSourceStationID.DisplayMember = "StationName"
            cmbSourceStationID.ValueMember = "StationID"

            cmbDestinationStationID.DataSource = dt
            cmbDestinationStationID.DisplayMember = "StationName"
            cmbDestinationStationID.ValueMember = "StationID"
        End Using
    End Sub

    Private Sub LoadTrains()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT 
                    T.TrainID, 
                    T.TrainName AS [Train Name],
                    S1.StationName AS [Source Station], 
                    S2.StationName AS [Destination Station], 
                    T.DepartureTime AS [Departure Time], 
                    T.ArrivalTime AS [Arrival Time]
                FROM 
                    Trains T
                INNER JOIN 
                    Stations S1 ON T.SourceStationID = S1.StationID
                INNER JOIN 
                    Stations S2 ON T.DestinationStationID = S2.StationID
            "
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()

            Try
                conn.Open()
                adapter.Fill(table)
                dgvTrains.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnAddTrain_Click(sender As Object, e As EventArgs) Handles btnAddTrain.Click
        If TextBox2.Text.Trim() = "" Or cmbSourceStationID.SelectedIndex = -1 Or cmbDestinationStationID.SelectedIndex = -1 Then
            MessageBox.Show("Please enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If cmbSourceStationID.SelectedValue = cmbDestinationStationID.SelectedValue Then
            MessageBox.Show("Source and Destination stations must be different.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Combine date and time from separate pickers
        Dim departureDateTime As DateTime = dtpDepartureDate.Value.Date.Add(dtpDepartureTime.Value.TimeOfDay)
        Dim arrivalDateTime As DateTime = dtpArrivalDate.Value.Date.Add(dtpArrivalTime.Value.TimeOfDay)

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "
                    INSERT INTO Trains (TrainName, SourceStationID, DestinationStationID, DepartureTime, ArrivalTime) 
                    VALUES (@TrainName, @SourceStationID, @DestinationStationID, @DepartureTime, @ArrivalTime)
                "
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TrainName", TextBox2.Text.Trim())
                    cmd.Parameters.AddWithValue("@SourceStationID", cmbSourceStationID.SelectedValue)
                    cmd.Parameters.AddWithValue("@DestinationStationID", cmbDestinationStationID.SelectedValue)
                    cmd.Parameters.AddWithValue("@DepartureTime", departureDateTime)
                    cmd.Parameters.AddWithValue("@ArrivalTime", arrivalDateTime)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Train added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadTrains()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnDeleteTrain_Click(sender As Object, e As EventArgs) Handles btnDeleteTrain.Click
        If dgvTrains.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a train to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim trainID As Integer = Convert.ToInt32(dgvTrains.SelectedRows(0).Cells("TrainID").Value)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this train?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then Exit Sub

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM Trains WHERE TrainID = @TrainID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TrainID", trainID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Train deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadTrains()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnRefreshStations_Click(sender As Object, e As EventArgs) Handles btnRefreshStations.Click
        LoadStations()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
