<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lstAlerts = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAlerts
        '
        Me.lstAlerts.FormattingEnabled = True
        Me.lstAlerts.Location = New System.Drawing.Point(12, 41)
        Me.lstAlerts.Name = "lstAlerts"
        Me.lstAlerts.Size = New System.Drawing.Size(260, 147)
        Me.lstAlerts.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(197, 212)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstAlerts)
        Me.Name = "Form3"
        Me.Text = "Remove Alert"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAlerts As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCancel As Button
End Class
