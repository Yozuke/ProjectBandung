Imports MySql.Data.MySqlClient

Module Connection
    Public conn As New MySqlConnection

    Public Sub ConnectDatabase()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=203.142.66.181;database=demo_web;username=demo_web;password=demoweb1"
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
