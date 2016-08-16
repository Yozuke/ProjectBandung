Imports MySql.Data.MySqlClient

Module Connection
    Public conn As New MySqlConnection

    Public Sub ConnectDatabase()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "DATABASE=" & My.Settings.myDB & amp;amp;amp; ";" _
                  & "SERVER=" & My.Settings.myServer & ";user id=" & My.Settings.myUsername _
                  & ";password=" & My.Settings.myPassword &amp;amp;amp;";port=" & _
                  My.Settings.myPort &amp;amp;amp; ";charset=utf8"
                conn.Open()
            End If

        Catch myerror As Exception
            MessageBox.Show("Error Connecting to the database", "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException

        End Try
    End Sub
End Module
