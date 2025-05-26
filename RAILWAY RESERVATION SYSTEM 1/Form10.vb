Public Class Form10
    Public Sub LoadReceiptHTML(passengerName As String, trainName As String, seat As String,
                                fromStation As String, toStation As String,
                                departure As DateTime, arrival As DateTime,
                                amount As Decimal, paymentMethod As String)

        Dim html As String = $"
        <html>
        <head>
            <style>
                body {{
                    font-family: Arial, sans-serif;
                    background: url('ticket_bg.jpg') no-repeat center center;
                    background-size: cover;
                    padding: 40px;
                    color: #000;
                }}
                .ticket {{
                    width: 700px;
                    margin: auto;
                    background-color: rgba(255, 255, 255, 0.8);
                    padding: 20px;
                    border-radius: 10px;
                }}
                h2 {{
                    text-align: center;
                }}
                table {{
                    width: 100%;
                    font-size: 16px;
                }}
                td {{
                    padding: 6px;
                }}
            </style>
        </head>
        <body>
            <div class='ticket'>
                <h2>Indian Railway Ticket Receipt</h2>
                <table>
                    <tr><td><b>Passenger Name:</b></td><td>{passengerName}</td></tr>
                    <tr><td><b>Train Name:</b></td><td>{trainName}</td></tr>
                    <tr><td><b>Seat Number:</b></td><td>{seat}</td></tr>
                    <tr><td><b>From:</b></td><td>{fromStation}</td></tr>
                    <tr><td><b>To:</b></td><td>{toStation}</td></tr>
                    <tr><td><b>Departure:</b></td><td>{departure:dd-MM-yyyy HH:mm}</td></tr>
                    <tr><td><b>Arrival:</b></td><td>{arrival:dd-MM-yyyy HH:mm}</td></tr>
                    <tr><td><b>Amount Paid:</b></td><td>₹{amount:F2}</td></tr>
                    <tr><td><b>Payment Method:</b></td><td>{paymentMethod}</td></tr>
                    <tr><td><b>Date of Payment:</b></td><td>{DateTime.Now:dd-MM-yyyy}</td></tr>
                </table>
                <br /><center><i>Thank you for booking with Indian Railways!</i></center>
            </div>
        </body>
        </html>
        "

        webReceipt.DocumentText = html
    End Sub
End Class
