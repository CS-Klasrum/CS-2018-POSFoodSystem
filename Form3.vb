Public Class Form3
    Dim client As New client()

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim lastname As String = TextBox1.Text
        Dim firstname As String = TextBox2.Text
        Dim number As String = TextBox3.Text
        Dim username As String = TextBox4.Text
        Dim password As String = TextBox5.Text

        If number.Length < 11 Then
            MessageBox.Show("Incorrect Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If lastname.Trim().Equals("") Or firstname.Trim().Equals("") Or number.Trim().Equals("") Or username.Trim().Equals("") Then
                MessageBox.Show("Required Valid Phone Number")

            Else
                If client.newclient(lastname, firstname, number, username, password) Then
                    MessageBox.Show("Success!")
                    Me.Close()
                    Form4.Show()

                End If



            End If

        End If


    End Sub

    Private Sub TextBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.Enter
        Dim pass As String = TextBox5.Text

        If pass.Trim().ToLower() = "Password" Or pass.Trim() = "" Then

            TextBox5.Text = ""
            TextBox5.ForeColor = Color.Black
            TextBox5.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub TextBox5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.Leave
        Dim pass As String = TextBox5.Text

        If pass.Trim().ToLower() = "Password" Or pass.Trim() = "" Then

            TextBox5.Text = "Password"
            TextBox5.ForeColor = Color.Black
            TextBox5.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox5.UseSystemPasswordChar = True Then
            TextBox5.UseSystemPasswordChar = False
        Else
            TextBox5.UseSystemPasswordChar = True
        End If
    End Sub
End Class