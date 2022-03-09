Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("An error occured.", MsgBoxStyle.Critical)
        Me.Hide()
        Form1.Show()
    End Sub
End Class