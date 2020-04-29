Imports MySql.Data.MySqlClient
Public Class Form10
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New connection

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim selectquery As String = "SELECT * FROM `admin` WHERE `UserName` =@un AND `PassWord` =@pass"

        command.CommandText = selectquery
        command.Connection = connection.getconnection()

        command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Form7.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class