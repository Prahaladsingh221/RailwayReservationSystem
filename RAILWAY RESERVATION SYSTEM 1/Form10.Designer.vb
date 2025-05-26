<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.webReceipt = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webReceipt
        '
        Me.webReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webReceipt.Location = New System.Drawing.Point(0, 0)
        Me.webReceipt.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webReceipt.Name = "webReceipt"
        Me.webReceipt.Size = New System.Drawing.Size(800, 450)
        Me.webReceipt.TabIndex = 0
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.webReceipt)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webReceipt As WebBrowser
End Class
