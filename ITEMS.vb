Imports MySql.Data.MySqlClient

Public Class ITEMS

    Dim connection As New connection()

    Function newinsert(ByVal name As String, ByVal price As Integer, ByVal qty As Integer) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `items`(`name`, `price`, `qty`) VALUES (@nm, @pr, @qt)", connection.getconnection())


        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@pr", MySqlDbType.Int32).Value = price
        command.Parameters.Add("@qt", MySqlDbType.Int32).Value = qty
       

        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeconnection()
            Return True
        Else
            connection.openconnection()
            Return False
        End If
    End Function

    Function getallitems() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim selectquery As String = "SELECT * FROM 'items' (`name)"

        command.CommandText = selectquery
        command.Connection = connection.getconnection()

        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table


    End Function


    Function additems(ByVal name As String, ByVal price As Integer, ByVal quantity As Integer) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `items`(`Name`, `Price`, `Quantity`) VALUES (@nm, @pr, @qt)", connection.getconnection())

        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@pr", MySqlDbType.Int32).Value = price
        command.Parameters.Add("@qt", MySqlDbType.Int32).Value = quantity

        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.openconnection()
            Return True
        Else
            connection.closeconnection()
            Return False
        End If
    End Function



    Function removeitems(ByVal cid As Integer) As Boolean



        Dim command As New MySqlCommand("DELETE FROM `items` WHERE `Product ID` =@cid", connection.getconnection())

        command.Parameters.AddWithValue("@cid", cid)

        connection.openconnection()


        If command.ExecuteNonQuery() > 0 Then
            connection.openconnection()
            Return True
        Else
            connection.closeconnection()
            Return False
        End If

    End Function

    Function clearitems() As Boolean


        Dim command As New MySqlCommand("DELETE FROM `items`", connection.getconnection())


        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.openconnection()
            Return True
        Else
            connection.closeconnection()
            Return False
        End If

    End Function

End Class
