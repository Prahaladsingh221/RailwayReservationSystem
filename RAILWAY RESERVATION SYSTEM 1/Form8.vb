Imports System.Data.SqlClient

Public Class Form8
    Dim connectionString As String = "Server=ASUSVIVOBOOK\SQLEXPRESS;Database=RailwayDB;Integrated Security=True;"

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStations()
    End Sub

    Private Sub LoadStations()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT StationName FROM Stations"
            Using cmd As New SqlCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbSourceStation.Items.Add(reader("StationName").ToString())
                        cmbDestinationStation.Items.Add(reader("StationName").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSearchTrain_Click(sender As Object, e As EventArgs) Handles btnSearchTrain.Click
        If cmbSourceStation.Text = "" Or cmbDestinationStation.Text = "" Then
            MessageBox.Show("Please select both Source and Destination stations.")
            Exit Sub
        End If

        cmbTrainID.Items.Clear()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "
                SELECT t.TrainID, t.TrainName 
                FROM Trains t
                INNER JOIN ViewSchedule vs ON t.TrainID = vs.TrainID
                INNER JOIN Stations s1 ON t.SourceStationID = s1.StationID
                INNER JOIN Stations s2 ON t.DestinationStationID = s2.StationID
                WHERE s1.StationName = @Source AND s2.StationName = @Dest 
                  AND CONVERT(date, vs.DepartureDate) = @Date"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Source", cmbSourceStation.Text)
                cmd.Parameters.AddWithValue("@Dest", cmbDestinationStation.Text)
                cmd.Parameters.AddWithValue("@Date", dtpTravelDate.Value.Date)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbTrainID.Items.Add(reader("TrainID").ToString() & " - " & reader("TrainName").ToString())
                    End While
                End Using
            End Using
        End Using

        If cmbTrainID.Items.Count = 0 Then
            MessageBox.Show("No trains available on the selected date.")
        Else
            MessageBox.Show("Trains found. Please select one.")
        End If
    End Sub

    Private Sub btnBookTicket_Click(sender As Object, e As EventArgs) Handles btnBookTicket.Click
        If txtPassengerName.Text = "" Or cmbTrainID.Text = "" Or txtSeatNumber.Text = "" Then
            MessageBox.Show("Please fill in all the booking details.")
            Exit Sub
        End If

        Dim trainID As Integer = CInt(Split(cmbTrainID.Text, " - ")(0))

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Get ScheduleID
            Dim scheduleID As Integer
            Dim scheduleQuery As String = "
                SELECT ScheduleID 
                FROM ViewSchedule 
                WHERE TrainID = @TrainID AND CONVERT(date, DepartureDate) = @Date"

            Using cmd As New SqlCommand(scheduleQuery, conn)
                cmd.Parameters.AddWithValue("@TrainID", trainID)
                cmd.Parameters.AddWithValue("@Date", dtpTravelDate.Value.Date)
                Dim result = cmd.ExecuteScalar()
                If result Is Nothing Then
                    MessageBox.Show("Schedule not found for the selected date.")
                    Exit Sub
                End If
                scheduleID = Convert.ToInt32(result)
            End Using

            ' Insert Booking
            Dim insertQuery As String = "
                INSERT INTO Bookings (PassengerName, TrainID, ScheduleID, BookingDate, SeatNumber) 
                VALUES (@Name, @TrainID, @ScheduleID, @Date, @Seat)"

            Using cmd As New SqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@Name", txtPassengerName.Text)
                cmd.Parameters.AddWithValue("@TrainID", trainID)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
                cmd.Parameters.AddWithValue("@Date", dtpTravelDate.Value.Date)
                cmd.Parameters.AddWithValue("@Seat", txtSeatNumber.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Booking successful!")
            Me.Hide()
            Form9.Show()
        End Using
    End Sub

    Private Sub btnViewBookings_Click(sender As Object, e As EventArgs) Handles btnViewBookings.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = ""
                query &= "SELECT b.BookingID, b.PassengerName, t.TrainName, s1.StationName AS Source, s2.StationName AS Destination, "
                query &= "vs.DepartureDate, vs.ArrivalDate, b.SeatNumber "
                query &= "FROM Bookings b "
                query &= "JOIN Trains t ON b.TrainID = t.TrainID "
                query &= "JOIN Stations s1 ON t.SourceStationID = s1.StationID "
                query &= "JOIN Stations s2 ON t.DestinationStationID = s2.StationID "
                query &= "JOIN ViewSchedule vs ON b.ScheduleID = vs.ScheduleID"

                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No bookings found.")
                End If

                dgvBookings.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnEditBooking_Click(sender As Object, e As EventArgs) Handles btnEditBooking.Click
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to edit.")
            Exit Sub
        End If

        Dim selectedRow = dgvBookings.SelectedRows(0)
        Dim bookingID = selectedRow.Cells("BookingID").Value

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim updateQuery As String = "
                UPDATE Bookings 
                SET PassengerName = @Name, SeatNumber = @Seat 
                WHERE BookingID = @BookingID"

            Using cmd As New SqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@Name", txtPassengerName.Text)
                cmd.Parameters.AddWithValue("@Seat", txtSeatNumber.Text)
                cmd.Parameters.AddWithValue("@BookingID", bookingID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Booking updated successfully.")
        btnViewBookings.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class



