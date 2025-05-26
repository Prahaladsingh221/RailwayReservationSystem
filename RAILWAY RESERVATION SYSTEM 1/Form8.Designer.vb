<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassengerName = New System.Windows.Forms.TextBox()
        Me.txtSeatNumber = New System.Windows.Forms.TextBox()
        Me.btnBookTicket = New System.Windows.Forms.Button()
        Me.btnViewBookings = New System.Windows.Forms.Button()
        Me.dtpTravelDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTrainID = New System.Windows.Forms.ComboBox()
        Me.cmbSourceStation = New System.Windows.Forms.ComboBox()
        Me.cmbDestinationStation = New System.Windows.Forms.ComboBox()
        Me.btnSearchTrain = New System.Windows.Forms.Button()
        Me.btnEditBooking = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BookingID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PassengerName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TrainID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SourceStation"
        '
        'txtPassengerName
        '
        Me.txtPassengerName.Location = New System.Drawing.Point(256, 101)
        Me.txtPassengerName.Name = "txtPassengerName"
        Me.txtPassengerName.Size = New System.Drawing.Size(187, 22)
        Me.txtPassengerName.TabIndex = 5
        '
        'txtSeatNumber
        '
        Me.txtSeatNumber.Location = New System.Drawing.Point(256, 399)
        Me.txtSeatNumber.Name = "txtSeatNumber"
        Me.txtSeatNumber.Size = New System.Drawing.Size(188, 22)
        Me.txtSeatNumber.TabIndex = 8
        '
        'btnBookTicket
        '
        Me.btnBookTicket.BackColor = System.Drawing.Color.Transparent
        Me.btnBookTicket.FlatAppearance.BorderSize = 4
        Me.btnBookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookTicket.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookTicket.ForeColor = System.Drawing.Color.White
        Me.btnBookTicket.Location = New System.Drawing.Point(225, 12)
        Me.btnBookTicket.Name = "btnBookTicket"
        Me.btnBookTicket.Size = New System.Drawing.Size(171, 56)
        Me.btnBookTicket.TabIndex = 9
        Me.btnBookTicket.Text = "BookTicket"
        Me.btnBookTicket.UseVisualStyleBackColor = False
        '
        'btnViewBookings
        '
        Me.btnViewBookings.FlatAppearance.BorderSize = 4
        Me.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBookings.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBookings.ForeColor = System.Drawing.Color.White
        Me.btnViewBookings.Location = New System.Drawing.Point(428, 13)
        Me.btnViewBookings.Name = "btnViewBookings"
        Me.btnViewBookings.Size = New System.Drawing.Size(203, 56)
        Me.btnViewBookings.TabIndex = 10
        Me.btnViewBookings.Text = "VIEW BOOKINGS"
        Me.btnViewBookings.UseVisualStyleBackColor = True
        '
        'dtpTravelDate
        '
        Me.dtpTravelDate.Location = New System.Drawing.Point(244, 331)
        Me.dtpTravelDate.Name = "dtpTravelDate"
        Me.dtpTravelDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpTravelDate.TabIndex = 11
        '
        'dgvBookings
        '
        Me.dgvBookings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Location = New System.Drawing.Point(526, 28)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.RowHeadersWidth = 51
        Me.dgvBookings.RowTemplate.Height = 24
        Me.dgvBookings.Size = New System.Drawing.Size(672, 461)
        Me.dgvBookings.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TravelDate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 399)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 29)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SeatNumber"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(256, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 22)
        Me.TextBox1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(0, 567)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 43)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "DestinationStation"
        '
        'cmbTrainID
        '
        Me.cmbTrainID.FormattingEnabled = True
        Me.cmbTrainID.Location = New System.Drawing.Point(256, 164)
        Me.cmbTrainID.Name = "cmbTrainID"
        Me.cmbTrainID.Size = New System.Drawing.Size(188, 24)
        Me.cmbTrainID.TabIndex = 17
        '
        'cmbSourceStation
        '
        Me.cmbSourceStation.FormattingEnabled = True
        Me.cmbSourceStation.Location = New System.Drawing.Point(256, 220)
        Me.cmbSourceStation.Name = "cmbSourceStation"
        Me.cmbSourceStation.Size = New System.Drawing.Size(188, 24)
        Me.cmbSourceStation.TabIndex = 18
        '
        'cmbDestinationStation
        '
        Me.cmbDestinationStation.FormattingEnabled = True
        Me.cmbDestinationStation.Location = New System.Drawing.Point(291, 284)
        Me.cmbDestinationStation.Name = "cmbDestinationStation"
        Me.cmbDestinationStation.Size = New System.Drawing.Size(152, 24)
        Me.cmbDestinationStation.TabIndex = 19
        '
        'btnSearchTrain
        '
        Me.btnSearchTrain.FlatAppearance.BorderSize = 4
        Me.btnSearchTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTrain.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTrain.ForeColor = System.Drawing.Color.White
        Me.btnSearchTrain.Location = New System.Drawing.Point(20, 12)
        Me.btnSearchTrain.Name = "btnSearchTrain"
        Me.btnSearchTrain.Size = New System.Drawing.Size(180, 56)
        Me.btnSearchTrain.TabIndex = 20
        Me.btnSearchTrain.Text = "SearchTrain "
        Me.btnSearchTrain.UseVisualStyleBackColor = True
        '
        'btnEditBooking
        '
        Me.btnEditBooking.FlatAppearance.BorderSize = 4
        Me.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBooking.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBooking.ForeColor = System.Drawing.Color.White
        Me.btnEditBooking.Location = New System.Drawing.Point(658, 12)
        Me.btnEditBooking.Name = "btnEditBooking"
        Me.btnEditBooking.Size = New System.Drawing.Size(183, 56)
        Me.btnEditBooking.TabIndex = 21
        Me.btnEditBooking.Text = "EditBookings"
        Me.btnEditBooking.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbDestinationStation)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpTravelDate)
        Me.GroupBox1.Controls.Add(Me.cmbSourceStation)
        Me.GroupBox1.Controls.Add(Me.txtSeatNumber)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbTrainID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtPassengerName)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 461)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnBookTicket)
        Me.Panel1.Controls.Add(Me.btnEditBooking)
        Me.Panel1.Controls.Add(Me.btnSearchTrain)
        Me.Panel1.Controls.Add(Me.btnViewBookings)
        Me.Panel1.Location = New System.Drawing.Point(181, 508)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 81)
        Me.Panel1.TabIndex = 23
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1210, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvBookings)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassengerName As TextBox
    Friend WithEvents txtSeatNumber As TextBox
    Friend WithEvents btnBookTicket As Button
    Friend WithEvents btnViewBookings As Button
    Friend WithEvents dtpTravelDate As DateTimePicker
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTrainID As ComboBox
    Friend WithEvents cmbSourceStation As ComboBox
    Friend WithEvents cmbDestinationStation As ComboBox
    Friend WithEvents btnSearchTrain As Button
    Friend WithEvents btnEditBooking As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
