Imports System.Data.SqlClient

Public Class Form6
    Dim connectionString As String = "Server=ASUSVIVOBOOK\SQLEXPRESS;Database=RailwayDB;Integrated Security=True"

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTrainIDs()
    End Sub

    Private Sub LoadTrainIDs()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT TrainID, TrainName FROM Trains"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "TrainID"
            ComboBox1.ValueMember = "TrainID"
        End Using
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        ' Load Train Name on selection
        Dim selectedRow As DataRowView = CType(ComboBox1.SelectedItem, DataRowView)
        txtTrainName.Text = selectedRow("TrainName").ToString()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If ComboBox1.SelectedValue IsNot Nothing Then
            Dim selectedTrainID As Integer
            If Integer.TryParse(ComboBox1.SelectedValue.ToString(), selectedTrainID) Then
                LoadScheduleDetails(selectedTrainID)
            End If
        End If
    End Sub

    Private Sub LoadScheduleDetails(trainID As Integer)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT 
                    vs.ScheduleID, 
                    vs.TrainID, 
                    t.TrainName, 
                    FORMAT(vs.DepartureDate, 'dd-MM-yyyy HH:mm') AS DepartureDate, 
                    FORMAT(vs.ArrivalDate, 'dd-MM-yyyy HH:mm') AS ArrivalDate
                FROM 
                    ViewSchedule vs
                INNER JOIN Trains t ON vs.TrainID = t.TrainID
                WHERE 
                    vs.TrainID = @TrainID
            "

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TrainID", trainID)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)
                dgvSchedule.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading schedule: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ComboBox1.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a Train ID.")
            Return
        End If

        Dim trainID As Integer = Convert.ToInt32(ComboBox1.SelectedValue)
        Dim departure As DateTime = dtpDeparture.Value
        Dim arrival As DateTime = dtpArrival.Value

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO ViewSchedule (TrainID, DepartureDate, ArrivalDate) VALUES (@TrainID, @Departure, @Arrival)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TrainID", trainID)
            cmd.Parameters.AddWithValue("@Departure", departure)
            cmd.Parameters.AddWithValue("@Arrival", arrival)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Schedule added successfully.")
                LoadScheduleDetails(trainID)
            Catch ex As Exception
                MessageBox.Show("Error adding schedule: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class
