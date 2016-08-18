<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginScreen
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.user_box = New System.Windows.Forms.TextBox()
        Me.pass_box = New System.Windows.Forms.TextBox()
        Me.login_button = New System.Windows.Forms.Button()
        Me.change_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'user_box
        '
        Me.user_box.Location = New System.Drawing.Point(73, 22)
        Me.user_box.Name = "user_box"
        Me.user_box.Size = New System.Drawing.Size(149, 20)
        Me.user_box.TabIndex = 2
        '
        'pass_box
        '
        Me.pass_box.Location = New System.Drawing.Point(73, 66)
        Me.pass_box.Name = "pass_box"
        Me.pass_box.Size = New System.Drawing.Size(149, 20)
        Me.pass_box.TabIndex = 3
        Me.pass_box.UseSystemPasswordChar = True
        '
        'login_button
        '
        Me.login_button.Location = New System.Drawing.Point(28, 115)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(75, 23)
        Me.login_button.TabIndex = 4
        Me.login_button.Text = "Login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'change_button
        '
        Me.change_button.Location = New System.Drawing.Point(132, 115)
        Me.change_button.Name = "change_button"
        Me.change_button.Size = New System.Drawing.Size(75, 23)
        Me.change_button.TabIndex = 5
        Me.change_button.Text = "Change"
        Me.change_button.UseVisualStyleBackColor = True
        '
        'LoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 162)
        Me.Controls.Add(Me.change_button)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.pass_box)
        Me.Controls.Add(Me.user_box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents user_box As TextBox
    Friend WithEvents pass_box As TextBox
    Friend WithEvents login_button As Button
    Friend WithEvents change_button As Button
End Class
