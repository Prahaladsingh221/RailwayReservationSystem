Imports System.Data.SqlClient

Public Class Form9

    Dim connectionString As String = "Server=ASUSVIVOBOOK\SQLEXPRESS;Database=RailwayDB;Integrated Security=True"

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookingIDs()
        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.AddRange(New String() {"Cash", "Card", "UPI"})

        ' Hide card fields and QR code initially
        txtCardNumber.Visible = False
        lblCardNumber.Visible = False
        picQRCode.Visible = False
    End Sub

    Private Sub LoadBookingIDs()
        cmbBookingID.Items.Clear()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT BookingID FROM Bookings", conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbBookingID.Items.Add(reader("BookingID").ToString())
            End While
        End Using
    End Sub

    Private Sub cmbBookingID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookingID.SelectedIndexChanged
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("
                SELECT b.PassengerName, b.SeatNumber, 
                       t.TrainID, t.TrainName, s1.StationName AS Source, s2.StationName AS Destination,
                       v.DepartureDate, v.ArrivalDate
                FROM Bookings b
                JOIN Trains t ON b.TrainID = t.TrainID
                JOIN ViewSchedule v ON b.ScheduleID = v.ScheduleID
                JOIN Stations s1 ON t.SourceStationID = s1.StationID
                JOIN Stations s2 ON t.DestinationStationID = s2.StationID
                WHERE b.BookingID = @BookingID", conn)

            cmd.Parameters.AddWithValue("@BookingID", cmbBookingID.SelectedItem.ToString())

            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtPassengerName.Text = reader("PassengerName").ToString()
                txtSeatNumber.Text = reader("SeatNumber").ToString()
                txtTrainID.Text = reader("TrainID").ToString()
                txtTrainName.Text = reader("TrainName").ToString()
                txtSource.Text = reader("Source").ToString()
                txtDestination.Text = reader("Destination").ToString()
                dtpDeparture.Value = Convert.ToDateTime(reader("DepartureDate"))
                dtpArrival.Value = Convert.ToDateTime(reader("ArrivalDate"))
                txtAmount.Text = "500.00" ' Fixed or dynamic logic
            End If
            reader.Close()
        End Using

        LoadPaymentDetails()
    End Sub

    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        If cmbPaymentMethod.SelectedItem.ToString() = "UPI" Then
            picQRCode.Visible = True
            txtCardNumber.Visible = False
            lblCardNumber.Visible = False
        ElseIf cmbPaymentMethod.SelectedItem.ToString() = "Card" Then
            picQRCode.Visible = False
            txtCardNumber.Visible = True
            lblCardNumber.Visible = True
        Else ' Cash
            picQRCode.Visible = False
            txtCardNumber.Visible = False
            lblCardNumber.Visible = False
        End If
    End Sub

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs)
        Try
            If cmbBookingID.SelectedIndex = -1 Or cmbPaymentMethod.SelectedIndex = -1 Then
                MessageBox.Show("Please select BookingID and Payment Method.")
                Return
            End If

            Using conn As New SqlConnection(connectionString)
                Dim query As String = "
                    INSERT INTO Payments 
                    (BookingID, PassengerName, TrainID, TrainName, SeatNumber, Source, Destination, DepartureTime, ArrivalTime, Amount, PaymentMethod, PaymentDate)
                    VALUES 
                    (@BookingID, @PassengerName, @TrainID, @TrainName, @SeatNumber, @Source, @Destination, @DepartureTime, @ArrivalTime, @Amount, @PaymentMethod, @PaymentDate)"

                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BookingID", cmbBookingID.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@PassengerName", txtPassengerName.Text)
                cmd.Parameters.AddWithValue("@TrainID", txtTrainID.Text)
                cmd.Parameters.AddWithValue("@TrainName", txtTrainName.Text)
                cmd.Parameters.AddWithValue("@SeatNumber", txtSeatNumber.Text)
                cmd.Parameters.AddWithValue("@Source", txtSource.Text)
                cmd.Parameters.AddWithValue("@Destination", txtDestination.Text)
                cmd.Parameters.AddWithValue("@DepartureTime", dtpDeparture.Value)
                cmd.Parameters.AddWithValue("@ArrivalTime", dtpArrival.Value)
                cmd.Parameters.AddWithValue("@Amount", Decimal.Parse(txtAmount.Text))
                cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Payment recorded successfully!")

                LoadPaymentDetails()

                ' Show Receipt
                Dim receiptForm As New Form10()
                receiptForm.LoadReceiptHTML(
                    txtPassengerName.Text,
                    txtTrainName.Text,
                    txtSeatNumber.Text,
                    txtSource.Text,
                    txtDestination.Text,
                    dtpDeparture.Value,
                    dtpArrival.Value,
                    Decimal.Parse(txtAmount.Text),
                    cmbPaymentMethod.SelectedItem.ToString()
                )
                receiptForm.Show()
            End Using
        Catch ex As Exception
            MessageBox.Show("Payment failed: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPaymentDetails()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("SELECT TOP 1 * FROM Payments WHERE BookingID = @BookingID ORDER BY PaymentID DESC", conn)
                cmd.Parameters.AddWithValue("@BookingID", cmbBookingID.Text)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    txtPaymentID.Text = reader("PaymentID").ToString()
                    cmbPaymentMethod.Text = reader("PaymentMethod").ToString()
                Else
                    txtPaymentID.Text = ""
                    cmbPaymentMethod.SelectedIndex = -1
                End If

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payment details: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        cmbBookingID.SelectedIndex = -1
        txtPaymentID.Clear()
        txtPassengerName.Clear()
        txtTrainID.Clear()
        txtTrainName.Clear()
        txtSeatNumber.Clear()
        txtSource.Clear()
        txtDestination.Clear()
        txtAmount.Clear()
        cmbPaymentMethod.SelectedIndex = -1
        dtpDeparture.Value = DateTime.Now
        dtpArrival.Value = DateTime.Now

        txtCardNumber.Visible = False
        lblCardNumber.Visible = False
        picQRCode.Visible = False
    End Sub

    Private Sub btnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenerateReceipt.Click
        ' Validate fields before generating receipt
        If String.IsNullOrWhiteSpace(txtPassengerName.Text) OrElse
           String.IsNullOrWhiteSpace(txtTrainName.Text) OrElse
           String.IsNullOrWhiteSpace(txtSeatNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtSource.Text) OrElse
           String.IsNullOrWhiteSpace(txtDestination.Text) OrElse
           String.IsNullOrWhiteSpace(txtAmount.Text) OrElse
           cmbPaymentMethod.SelectedIndex = -1 Then

            MessageBox.Show("Please make sure all required fields are filled before generating the receipt.")
            Return
        End If

        ' Create and open Form10 with receipt
        Dim receiptForm As New Form10()
        receiptForm.LoadReceiptHTML(
            txtPassengerName.Text,
            txtTrainName.Text,
            txtSeatNumber.Text,
            txtSource.Text,
            txtDestination.Text,
            dtpDeparture.Value,
            dtpArrival.Value,
            Decimal.Parse(txtAmount.Text),
            cmbPaymentMethod.SelectedItem.ToString()
        )
        receiptForm.Show()
    End Sub

End Class
