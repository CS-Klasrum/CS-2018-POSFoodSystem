Imports MySql.Data.MySqlClient

Public Class Form8

    Dim admin As New admin()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim adminacc As DialogResult

        adminacc = MessageBox.Show("Here is the Admin Account List", "Admin Account", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DataGridView2.DataSource = admin.newadmin

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