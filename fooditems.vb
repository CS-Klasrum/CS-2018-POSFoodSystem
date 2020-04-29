Imports MySql.Data.MySqlClient

Public Class fooditems

    Dim connection As New connection()



    Function getfooditems() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim selectquery As String = "SELECT *FROM `items`"


        command.CommandText = selectquery
        command.Connection = connection.getconnection()

        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table

    End Function


    Function newfooditems(ByVal foodid As String, ByVal foodname As String, ByVal stocks As String, ByVal total As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `fooditems`(`FoodID`, `FoodName`, `Stocks/Day`, `Total`) VALUES(@fi, @fd, @sd, @tl)", connection.getconnection())

        command.Parameters.Add("@fi", MySqlDbType.VarChar).Value = foodid
        command.Parameters.Add("@fd", MySqlDbType.VarChar).Value = foodname
        command.Parameters.Add("@sd", MySqlDbType.VarChar).Value = stocks
        command.Parameters.Add("@tl", MySqlDbType.VarChar).Value = total

        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeconnection()
            Return True
        Else
            connection.openconnection()
            Return False
        End If
    End Function


End Class
