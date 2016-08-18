Imports MySql.Data.MySqlClient

Public Class LoginScreen
    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        If user_box.Text = "" Then
            MsgBox("Please insert your username first")
        ElseIf pass_box.Text = "" Then
            MsgBox("Please insert your password")
        Else
            ConnectDatabase()
            Dim selectuser As String = "select * from master_login where username = '" & user_box.Text & "' and pwd = '" & pass_box.Text & "'"
            Dim dc As MySqlCommand = New MySqlCommand(selectuser, conn)
            Dim dr As MySqlDataReader = dc.ExecuteReader

            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While

            If count = 1 Then
                Dim MM = New MainMenu()
                MM.Show()
                Me.Close()
            Else
                MsgBox("Data user & password tidak ditemukan")
                user_box.Clear()
                pass_box.Clear()
            End If
        End If

    End Sub
End Class
