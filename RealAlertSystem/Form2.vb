Public Class Form2
    Public strTime As String
    Private Sub btnDismiss_Click(sender As Object, e As EventArgs) Handles btnDismiss.Click
        Dim sngFind As Single = Array.IndexOf(Form1.msgArray, Me.lblAlert.Text)
        Form1.msgArray(sngFind) = Nothing
        ReDim Preserve Form1.msgArray(Form1.msgArray.Length - 1)
        ReDim Preserve Form1.frmArray(Form1.msgArray.Length)
        Form1.frmArray(sngFind).Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateTime.Now.ToShortTimeString = strTime Then
            Me.Visible = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub
End Class