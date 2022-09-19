Imports QRCoder
Public Class Form1
    Private Sub TxtInput_TextChanged(sender As Object, e As EventArgs) Handles TxtInput.TextChanged
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(TxtInput.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        QRCode.Image = code.GetGraphic(6)
    End Sub
End Class
