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
        Me.components = New System.ComponentModel.Container()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.dtmPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTimeEnter = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetMessage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveAlert = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTimeLbl = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 49)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(116, 13)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Please Enter The Alert:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(15, 65)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(185, 59)
        Me.txtInput.TabIndex = 1
        '
        'dtmPicker1
        '
        Me.dtmPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmPicker1.Location = New System.Drawing.Point(12, 180)
        Me.dtmPicker1.Name = "dtmPicker1"
        Me.dtmPicker1.Size = New System.Drawing.Size(200, 20)
        Me.dtmPicker1.TabIndex = 2
        '
        'lblTimeEnter
        '
        Me.lblTimeEnter.AutoSize = True
        Me.lblTimeEnter.Location = New System.Drawing.Point(12, 164)
        Me.lblTimeEnter.Name = "lblTimeEnter"
        Me.lblTimeEnter.Size = New System.Drawing.Size(148, 13)
        Me.lblTimeEnter.TabIndex = 3
        Me.lblTimeEnter.Text = "Please Enter The Time (12hr):"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 217)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReset, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuReset
        '
        Me.mnuReset.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResetTime, Me.mnuResetMessage, Me.mnuResetAll})
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(102, 22)
        Me.mnuReset.Text = "Reset"
        '
        'mnuResetTime
        '
        Me.mnuResetTime.Name = "mnuResetTime"
        Me.mnuResetTime.Size = New System.Drawing.Size(120, 22)
        Me.mnuResetTime.Text = "Time"
        '
        'mnuResetMessage
        '
        Me.mnuResetMessage.Name = "mnuResetMessage"
        Me.mnuResetMessage.Size = New System.Drawing.Size(120, 22)
        Me.mnuResetMessage.Text = "Message"
        '
        'mnuResetAll
        '
        Me.mnuResetAll.Name = "mnuResetAll"
        Me.mnuResetAll.Size = New System.Drawing.Size(120, 22)
        Me.mnuResetAll.Text = "All"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRemoveAlert})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuRemoveAlert
        '
        Me.mnuRemoveAlert.Name = "mnuRemoveAlert"
        Me.mnuRemoveAlert.Size = New System.Drawing.Size(145, 22)
        Me.mnuRemoveAlert.Text = "Remove Alert"
        '
        'lblTimeLbl
        '
        Me.lblTimeLbl.AutoSize = True
        Me.lblTimeLbl.Location = New System.Drawing.Point(121, 222)
        Me.lblTimeLbl.Name = "lblTimeLbl"
        Me.lblTimeLbl.Size = New System.Drawing.Size(70, 13)
        Me.lblTimeLbl.TabIndex = 6
        Me.lblTimeLbl.Text = "Current Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(197, 222)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTimeLbl)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblTimeEnter)
        Me.Controls.Add(Me.dtmPicker1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents dtmPicker1 As DateTimePicker
    Friend WithEvents lblTimeEnter As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuReset As ToolStripMenuItem
    Friend WithEvents mnuResetTime As ToolStripMenuItem
    Friend WithEvents mnuResetMessage As ToolStripMenuItem
    Friend WithEvents mnuResetAll As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuProgram As ToolStripMenuItem
    Friend WithEvents mnuRemoveAlert As ToolStripMenuItem
    Friend WithEvents lblTimeLbl As Label
    Friend WithEvents lblTime As Label
End Class
