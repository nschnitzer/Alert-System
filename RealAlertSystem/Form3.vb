Public Class Form3
    Dim strArray(Form1.msgArray.Length) As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For sngCounter As Single = 0 To Form1.msgArray.Length - 1
            If testValid(sngCounter) Then
                lstAlerts.Items.Add(Form1.msgArray(sngCounter))
                lstAlerts.Refresh()
            Else
                MessageBox.Show("No Alerts Set")
                Me.Close()
                Exit For
            End If
        Next sngCounter
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim sngFinder As Single = lstAlerts.SelectedIndex
        Form1.frmArray(sngFinder).Close()
        Form1.msgArray(sngFinder) = Nothing
        ReDim Preserve Form1.msgArray(Form1.msgArray.Length - 1)
        ReDim Preserve Form1.frmArray(Form1.msgArray.Length)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Function testValid(sngCounter) As Boolean
        Try
            lstAlerts.Items.Add(Form1.msgArray(sngCounter))
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class