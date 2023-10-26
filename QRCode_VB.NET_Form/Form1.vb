Imports QRCoder

Public Class Form1
    Private Sub Text_Input_TextChanged(sender As Object, e As EventArgs) Handles Text_Input.TextChanged

        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(Text_Input.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        QRCode.Image = code.GetGraphic(6)



    End Sub
End Class
