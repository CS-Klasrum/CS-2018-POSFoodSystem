Imports MySql.Data.MySqlClient
Public Class Form9

    Dim client As New client()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    
        Dim clientacc As DialogResult

        clientacc = MessageBox.Show("Here is the Admin Account List", "Admin Account", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DataGridView3.DataSource = client.newclient

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim out As DialogResult

        out = MessageBox.Show("Confirm if you want to exit.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If out = DialogResult.Yes Then
            Application.Exit()
        Else
            Me.Show()
        End If

    End Sub
End Class