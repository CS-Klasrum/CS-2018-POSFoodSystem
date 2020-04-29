Imports MySql.Data.MySqlClient
Public Class connection

    Private connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=foodhaus")

    Function getconnection() As MySqlConnection

        Return connection

    End Function

    Sub openconnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    Sub closeconnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()

        End If
    End Sub
End Class
