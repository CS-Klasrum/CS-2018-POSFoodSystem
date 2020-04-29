Imports MySql.Data.MySqlClient

Public Class Form7

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim out As DialogResult

        out = MessageBox.Show("Confirm if you want to exit.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If out = DialogResult.Yes Then
            Application.Exit()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form8.Show()
        Me.Hide()

       

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form10.Show()
        Me.Hide()

    End Sub
End Class