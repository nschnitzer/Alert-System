Public Class Form1
    Public Shared msgArray(100) As String
    Public Shared frmArray(100) As Form2
    Public Shared sngRemoveIndex As Single = -1
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Static sngTracker As Single = 0
        Dim frm As New Form2
        frm.strTime = dtmPicker1.Value.ToShortTimeString
        frm.lblAlert.Text = txtInput.Text
        ReDim Preserve msgArray(sngTracker)
        ReDim Preserve frmArray(sngTracker)
        msgArray(sngTracker) = txtInput.Text
        frmArray(sngTracker) = frm
        txtInput.ResetText()
        dtmPicker1.Value = DateTime.Now
        sngTracker = sngTracker + 1
    End Sub

    Private Sub mnuResetAll_Click(sender As Object, e As EventArgs) Handles mnuResetAll.Click
        txtInput.ResetText()
        dtmPicker1.Value = DateTime.Now
    End Sub

    Private Sub mnuResetMessage_Click(sender As Object, e As EventArgs) Handles mnuResetMessage.Click
        txtInput.ResetText()
    End Sub

    Private Sub mnuResetTime_Click(sender As Object, e As EventArgs) Handles mnuResetTime.Click
        dtmPicker1.Value = DateTime.Now
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    Private Sub mnuRemoveAlert_Click(sender As Object, e As EventArgs) Handles mnuRemoveAlert.Click
        Dim newFrm As New Form3
        newFrm.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class
