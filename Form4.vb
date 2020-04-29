Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        Dim pass As String = TextBox2.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        Dim pass As String = TextBox2.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            TextBox2.Text = "Type Password"
            TextBox2.ForeColor = Color.Black
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class