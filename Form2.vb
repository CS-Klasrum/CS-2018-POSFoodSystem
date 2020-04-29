Public Class Form2
    Dim admin As New admin()

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim employeeid As String = TextBox1.Text
        Dim employeename As String = TextBox2.Text
        Dim employeeposition As String = TextBox3.Text
        Dim number As String = TextBox4.Text
        Dim address As String = TextBox5.Text
        Dim username As String = TextBox6.Text
        Dim password As String = TextBox7.Text

        If number.Length < 11 Then
            MessageBox.Show("Incorrect Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If employeeid.Trim().Equals("") Or employeename.Trim().Equals("") Or employeeposition.Trim().Equals("") Or number.Trim().Equals("") Or address.Trim().Equals("") Or username.Trim().Equals("") Or password.Trim().Equals("") Then
                MessageBox.Show("Required", " Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If admin.newadmin(employeeid, employeename, employeeposition, address, number, username, password) Then
                    MessageBox.Show("Success Admin Access", "Success Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Form10.Show()

                End If
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox6.Clear()
                TextBox5.Clear()
                TextBox7.Clear()

            End If
        End If
      

    End Sub

    Private Sub TextBox7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Leave
        Dim pass As String = TextBox7.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            TextBox7.Text = "Password"
            TextBox7.ForeColor = Color.Black
            TextBox7.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub TextBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Enter
        Dim pass As String = TextBox6.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            TextBox6.Text = ""
            TextBox6.ForeColor = Color.Black
            TextBox6.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox7.UseSystemPasswordChar = True Then
            TextBox7.UseSystemPasswordChar = False
        Else
            TextBox7.UseSystemPasswordChar = True
        End If
    End Sub


End Class