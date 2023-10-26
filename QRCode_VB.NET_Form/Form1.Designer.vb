<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        QRCode = New PictureBox()
        Text_Input = New TextBox()
        CType(QRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' QRCode
        ' 
        QRCode.AccessibleName = ""
        QRCode.BackColor = Color.White
        QRCode.Location = New Point(256, 25)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(252, 213)
        QRCode.SizeMode = PictureBoxSizeMode.Zoom
        QRCode.TabIndex = 0
        QRCode.TabStop = False
        ' 
        ' Text_Input
        ' 
        Text_Input.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Text_Input.Location = New Point(231, 263)
        Text_Input.Multiline = True
        Text_Input.Name = "Text_Input"
        Text_Input.Size = New Size(304, 95)
        Text_Input.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Text_Input)
        Controls.Add(QRCode)
        Name = "Form1"
        Text = "Form1"
        CType(QRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents QRCode As PictureBox
    Friend WithEvents Text_Input As TextBox
End Class
