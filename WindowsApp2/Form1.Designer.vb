<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.QRCode = New System.Windows.Forms.PictureBox()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        CType(Me.QRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QRCode
        '
        Me.QRCode.BackColor = System.Drawing.Color.White
        Me.QRCode.Location = New System.Drawing.Point(117, 12)
        Me.QRCode.Name = "QRCode"
        Me.QRCode.Size = New System.Drawing.Size(265, 245)
        Me.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.QRCode.TabIndex = 0
        Me.QRCode.TabStop = False
        '
        'TxtInput
        '
        Me.TxtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInput.Location = New System.Drawing.Point(117, 280)
        Me.TxtInput.Multiline = True
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(265, 54)
        Me.TxtInput.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 394)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.QRCode)
        Me.Name = "Form1"
        Me.Text = "QR Code Generator"
        CType(Me.QRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QRCode As PictureBox
    Friend WithEvents TxtInput As TextBox
End Class
