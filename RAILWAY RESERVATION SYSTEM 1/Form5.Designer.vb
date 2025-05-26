<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form5
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form5))
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtTrainName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnAddTrain = New System.Windows.Forms.Button()
        Me.btnDeleteTrain = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvTrains = New System.Windows.Forms.DataGridView()
        Me.cmbSourceStationID = New System.Windows.Forms.ComboBox()
        Me.cmbDestinationStationID = New System.Windows.Forms.ComboBox()
        Me.dtpDepartureTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpArrivalTime = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRefreshStations = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDepartureDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpArrivalDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvTrains, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(-5, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(123, 27)
        Me.label1.TabIndex = 0
        Me.label1.Text = "  TrainID"
        '
        'txtTrainName
        '
        Me.txtTrainName.AutoSize = True
        Me.txtTrainName.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrainName.Location = New System.Drawing.Point(12, 78)
        Me.txtTrainName.Name = "txtTrainName"
        Me.txtTrainName.Size = New System.Drawing.Size(146, 27)
        Me.txtTrainName.TabIndex = 1
        Me.txtTrainName.Text = "TrainName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SourceStation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DestinationStation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DepartureTime"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(273, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 24)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(273, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 22)
        Me.TextBox2.TabIndex = 6
        '
        'btnAddTrain
        '
        Me.btnAddTrain.BackColor = System.Drawing.Color.Transparent
        Me.btnAddTrain.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddTrain.FlatAppearance.BorderSize = 4
        Me.btnAddTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTrain.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTrain.ForeColor = System.Drawing.Color.White
        Me.btnAddTrain.Location = New System.Drawing.Point(914, 403)
        Me.btnAddTrain.Name = "btnAddTrain"
        Me.btnAddTrain.Size = New System.Drawing.Size(175, 48)
        Me.btnAddTrain.TabIndex = 10
        Me.btnAddTrain.Text = "ADD"
        Me.btnAddTrain.UseVisualStyleBackColor = False
        '
        'btnDeleteTrain
        '
        Me.btnDeleteTrain.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteTrain.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeleteTrain.FlatAppearance.BorderSize = 4
        Me.btnDeleteTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTrain.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTrain.ForeColor = System.Drawing.Color.White
        Me.btnDeleteTrain.Location = New System.Drawing.Point(1114, 403)
        Me.btnDeleteTrain.Name = "btnDeleteTrain"
        Me.btnDeleteTrain.Size = New System.Drawing.Size(175, 48)
        Me.btnDeleteTrain.TabIndex = 11
        Me.btnDeleteTrain.Text = "DELETE"
        Me.btnDeleteTrain.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(20, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ArrivalTime"
        '
        'dgvTrains
        '
        Me.dgvTrains.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvTrains.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTrains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTrains.BackgroundColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrains.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTrains.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTrains.GridColor = System.Drawing.Color.LightSteelBlue
        Me.dgvTrains.Location = New System.Drawing.Point(497, 467)
        Me.dgvTrains.MultiSelect = False
        Me.dgvTrains.Name = "dgvTrains"
        Me.dgvTrains.ReadOnly = True
        Me.dgvTrains.RowHeadersVisible = False
        Me.dgvTrains.RowHeadersWidth = 51
        Me.dgvTrains.RowTemplate.Height = 24
        Me.dgvTrains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrains.Size = New System.Drawing.Size(807, 159)
        Me.dgvTrains.TabIndex = 14
        '
        'cmbSourceStationID
        '
        Me.cmbSourceStationID.FormattingEnabled = True
        Me.cmbSourceStationID.Location = New System.Drawing.Point(273, 133)
        Me.cmbSourceStationID.Name = "cmbSourceStationID"
        Me.cmbSourceStationID.Size = New System.Drawing.Size(200, 23)
        Me.cmbSourceStationID.TabIndex = 15
        '
        'cmbDestinationStationID
        '
        Me.cmbDestinationStationID.FormattingEnabled = True
        Me.cmbDestinationStationID.Location = New System.Drawing.Point(273, 188)
        Me.cmbDestinationStationID.Name = "cmbDestinationStationID"
        Me.cmbDestinationStationID.Size = New System.Drawing.Size(200, 23)
        Me.cmbDestinationStationID.TabIndex = 16
        '
        'dtpDepartureTime
        '
        Me.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpDepartureTime.Location = New System.Drawing.Point(273, 302)
        Me.dtpDepartureTime.Name = "dtpDepartureTime"
        Me.dtpDepartureTime.ShowUpDown = True
        Me.dtpDepartureTime.Size = New System.Drawing.Size(200, 22)
        Me.dtpDepartureTime.TabIndex = 17
        '
        'dtpArrivalTime
        '
        Me.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpArrivalTime.Location = New System.Drawing.Point(273, 411)
        Me.dtpArrivalTime.Name = "dtpArrivalTime"
        Me.dtpArrivalTime.ShowUpDown = True
        Me.dtpArrivalTime.Size = New System.Drawing.Size(200, 22)
        Me.dtpArrivalTime.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(0, 599)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 37)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRefreshStations
        '
        Me.btnRefreshStations.BackColor = System.Drawing.Color.Transparent
        Me.btnRefreshStations.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRefreshStations.FlatAppearance.BorderSize = 4
        Me.btnRefreshStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshStations.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshStations.ForeColor = System.Drawing.Color.Black
        Me.btnRefreshStations.Location = New System.Drawing.Point(20, 491)
        Me.btnRefreshStations.Name = "btnRefreshStations"
        Me.btnRefreshStations.Size = New System.Drawing.Size(175, 48)
        Me.btnRefreshStations.TabIndex = 20
        Me.btnRefreshStations.Text = "REFRESH"
        Me.btnRefreshStations.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(6, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "DepartureDate"
        '
        'dtpDepartureDate
        '
        Me.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDepartureDate.Location = New System.Drawing.Point(273, 243)
        Me.dtpDepartureDate.Name = "dtpDepartureDate"
        Me.dtpDepartureDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpDepartureDate.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 27)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ArrivalDate"
        '
        'dtpArrivalDate
        '
        Me.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpArrivalDate.Location = New System.Drawing.Point(273, 353)
        Me.dtpArrivalDate.Name = "dtpArrivalDate"
        Me.dtpArrivalDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpArrivalDate.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtpArrivalTime)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.dtpArrivalDate)
        Me.GroupBox1.Controls.Add(Me.txtTrainName)
        Me.GroupBox1.Controls.Add(Me.dtpDepartureDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDepartureTime)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbDestinationStationID)
        Me.GroupBox1.Controls.Add(Me.cmbSourceStationID)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 473)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1316, 639)
        Me.Controls.Add(Me.btnDeleteTrain)
        Me.Controls.Add(Me.dgvTrains)
        Me.Controls.Add(Me.btnAddTrain)
        Me.Controls.Add(Me.btnRefreshStations)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "form5"
        Me.Text = "Form5"
        CType(Me.dgvTrains, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtTrainName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnAddTrain As Button
    Friend WithEvents btnDeleteTrain As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvTrains As DataGridView
    Friend WithEvents cmbSourceStationID As ComboBox
    Friend WithEvents cmbDestinationStationID As ComboBox
    Friend WithEvents dtpDepartureTime As DateTimePicker
    Friend WithEvents dtpArrivalTime As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRefreshStations As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDepartureDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpArrivalDate As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
End Class
