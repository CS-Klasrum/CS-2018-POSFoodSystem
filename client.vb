Imports MySql.Data.MySqlClient
Public Class client

    Dim connection As New connection()

    Function newclient(ByVal lastname As String, ByVal firstname As String, ByVal number As String, ByVal username As String, ByVal password As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `clients`(`LASTNAME`, `FIRSTNAME`, `NUMBER`, `USERNAME`, `PASSWORD`) VALUES(@ln, @fn, @phn, @un,@pas)", connection.getconnection())

        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastname
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstname
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = number
        command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = password

        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeconnection()
            Return True
        Else
            connection.openconnection()
            Return False
        End If
    End Function

    Function newclient() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim selectquery As String = "SELECT *FROM `clients`"


        command.CommandText = selectquery
        command.Connection = connection.getconnection()

        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table

    End Function


End Class
