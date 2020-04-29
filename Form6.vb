Public Class Form6

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim out As DialogResult

        out = MessageBox.Show("Confirm if you want to exit.", "Thankyou!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If out = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()

    End Sub

End Class