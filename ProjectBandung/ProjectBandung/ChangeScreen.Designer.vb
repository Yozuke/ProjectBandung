<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeScreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.old_pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.new_pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.conf_pass = New System.Windows.Forms.TextBox()
        Me.Change_button = New System.Windows.Forms.Button()
        Me.Cancel_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Password"
        '
        'old_pass
        '
        Me.old_pass.Location = New System.Drawing.Point(114, 26)
        Me.old_pass.Name = "old_pass"
        Me.old_pass.Size = New System.Drawing.Size(158, 20)
        Me.old_pass.TabIndex = 1
        Me.old_pass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password"
        '
        'new_pass
        '
        Me.new_pass.Location = New System.Drawing.Point(114, 63)
        Me.new_pass.Name = "new_pass"
        Me.new_pass.Size = New System.Drawing.Size(158, 20)
        Me.new_pass.TabIndex = 3
        Me.new_pass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm Password"
        '
        'conf_pass
        '
        Me.conf_pass.Location = New System.Drawing.Point(114, 100)
        Me.conf_pass.Name = "conf_pass"
        Me.conf_pass.Size = New System.Drawing.Size(158, 20)
        Me.conf_pass.TabIndex = 5
        Me.conf_pass.UseSystemPasswordChar = True
        '
        'Change_button
        '
        Me.Change_button.Location = New System.Drawing.Point(28, 147)
        Me.Change_button.Name = "Change_button"
        Me.Change_button.Size = New System.Drawing.Size(75, 23)
        Me.Change_button.TabIndex = 6
        Me.Change_button.Text = "Change"
        Me.Change_button.UseVisualStyleBackColor = True
        '
        'Cancel_button
        '
        Me.Cancel_button.Location = New System.Drawing.Point(173, 147)
        Me.Cancel_button.Name = "Cancel_button"
        Me.Cancel_button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_button.TabIndex = 7
        Me.Cancel_button.Text = "Cancel"
        Me.Cancel_button.UseVisualStyleBackColor = True
        '
        'ChangeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 182)
        Me.Controls.Add(Me.Cancel_button)
        Me.Controls.Add(Me.Change_button)
        Me.Controls.Add(Me.conf_pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.new_pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.old_pass)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "ChangeScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents old_pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents new_pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents conf_pass As TextBox
    Friend WithEvents Change_button As Button
    Friend WithEvents Cancel_button As Button
End Class
