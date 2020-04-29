Imports MySql.Data.MySqlClient
Public Class admin
    Dim connection As New connection()

    Function newadmin(ByVal employeeid As String, ByVal employeename As String, ByVal employeeposition As String, ByVal contactnumber As String, ByVal address As String, ByVal username As String, ByVal password As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `admin`(`EmployeeID`, `EmployeeName`, `EmployeePosition`, `ContactNumber`, `Address`, `Username`, `Password`) VALUES(@eid, @en, @ep, @cn,@add,@un,@pw)", connection.getconnection())

        command.Parameters.Add("@eid", MySqlDbType.VarChar).Value = employeeid
        command.Parameters.Add("@en", MySqlDbType.VarChar).Value = employeename
        command.Parameters.Add("@ep", MySqlDbType.VarChar).Value = employeeposition
        command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = contactnumber
        command.Parameters.Add("@add", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password

        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeconnection()
            Return True
        Else
            connection.openconnection()
            Return False
        End If
    End Function


    Function newadmin() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim selectquery As String = "SELECT *FROM `admin`"


        command.CommandText = selectquery
        command.Connection = connection.getconnection()

        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table

    End Function


End Class
