<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.txtPassengerName = New System.Windows.Forms.TextBox()
        Me.txtTrainID = New System.Windows.Forms.TextBox()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbBookingID = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTrainName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSeatNumber = New System.Windows.Forms.TextBox()
        Me.sourcestation = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.dtpArrival = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGenerateReceipt = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " PaymentID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PassengerName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TrainID"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.Location = New System.Drawing.Point(335, 100)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(143, 22)
        Me.txtPaymentID.TabIndex = 4
        '
        'txtPassengerName
        '
        Me.txtPassengerName.Location = New System.Drawing.Point(335, 172)
        Me.txtPassengerName.Name = "txtPassengerName"
        Me.txtPassengerName.Size = New System.Drawing.Size(143, 22)
        Me.txtPassengerName.TabIndex = 5
        '
        'txtTrainID
        '
        Me.txtTrainID.Location = New System.Drawing.Point(335, 246)
        Me.txtTrainID.Name = "txtTrainID"
        Me.txtTrainID.Size = New System.Drawing.Size(143, 22)
        Me.txtTrainID.TabIndex = 6
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(335, 405)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(143, 24)
        Me.cmbPaymentMethod.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(335, 348)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(143, 22)
        Me.txtAmount.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PaymentMethod"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "BookingID"
        '
        'cmbBookingID
        '
        Me.cmbBookingID.FormattingEnabled = True
        Me.cmbBookingID.Location = New System.Drawing.Point(335, 27)
        Me.cmbBookingID.Name = "cmbBookingID"
        Me.cmbBookingID.Size = New System.Drawing.Size(143, 24)
        Me.cmbBookingID.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(0, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 44)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTrainName
        '
        Me.txtTrainName.Location = New System.Drawing.Point(335, 297)
        Me.txtTrainName.Name = "txtTrainName"
        Me.txtTrainName.Size = New System.Drawing.Size(100, 22)
        Me.txtTrainName.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(145, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 22)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Trainname"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(640, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "SeatNumber"
        '
        'txtSeatNumber
        '
        Me.txtSeatNumber.Location = New System.Drawing.Point(788, 72)
        Me.txtSeatNumber.Name = "txtSeatNumber"
        Me.txtSeatNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtSeatNumber.TabIndex = 19
        '
        'sourcestation
        '
        Me.sourcestation.AutoSize = True
        Me.sourcestation.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourcestation.Location = New System.Drawing.Point(619, 140)
        Me.sourcestation.Name = "sourcestation"
        Me.sourcestation.Size = New System.Drawing.Size(133, 22)
        Me.sourcestation.TabIndex = 20
        Me.sourcestation.Text = "Sourcestation"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(788, 140)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(100, 22)
        Me.txtSource.TabIndex = 21
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(788, 206)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(100, 22)
        Me.txtDestination.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(646, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 22)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Destination"
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Location = New System.Drawing.Point(574, 424)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(200, 22)
        Me.dtpDeparture.TabIndex = 24
        '
        'dtpArrival
        '
        Me.dtpArrival.Location = New System.Drawing.Point(901, 424)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(200, 22)
        Me.dtpArrival.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(608, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 22)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Departure date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(945, 390)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 22)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "arrival date"
        '
        'btnGenerateReceipt
        '
        Me.btnGenerateReceipt.FlatAppearance.BorderSize = 3
        Me.btnGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReceipt.Location = New System.Drawing.Point(230, 490)
        Me.btnGenerateReceipt.Name = "btnGenerateReceipt"
        Me.btnGenerateReceipt.Size = New System.Drawing.Size(190, 52)
        Me.btnGenerateReceipt.TabIndex = 32
        Me.btnGenerateReceipt.Text = "GenerateReceipt"
        Me.btnGenerateReceipt.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(500, 490)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 49)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'picQRCode
        '
        Me.picQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picQRCode.Image = CType(resources.GetObject("picQRCode.Image"), System.Drawing.Image)
        Me.picQRCode.Location = New System.Drawing.Point(1010, 113)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(166, 164)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQRCode.TabIndex = 35
        Me.picQRCode.TabStop = False
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(788, 313)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtCardNumber.TabIndex = 36
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(633, 313)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(119, 22)
        Me.lblCardNumber.TabIndex = 37
        Me.lblCardNumber.Text = "cardnumber"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1253, 640)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.picQRCode)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGenerateReceipt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpArrival)
        Me.Controls.Add(Me.dtpDeparture)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.sourcestation)
        Me.Controls.Add(Me.txtSeatNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTrainName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbBookingID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPaymentMethod)
        Me.Controls.Add(Me.txtTrainID)
        Me.Controls.Add(Me.txtPassengerName)
        Me.Controls.Add(Me.txtPaymentID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents txtPassengerName As TextBox
    Friend WithEvents txtTrainID As TextBox
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbBookingID As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTrainName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSeatNumber As TextBox
    Friend WithEvents sourcestation As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents dtpArrival As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnGenerateReceipt As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblCardNumber As Label
End Class
