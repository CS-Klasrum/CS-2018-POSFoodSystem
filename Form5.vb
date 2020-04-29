Imports MySql.Data.MySqlClient


Public Class Form5


    Dim items As New ITEMS()
    Dim fooditems As New fooditems()



    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim mg, drinks As Integer
        Try
            If cb1.Checked = True Then
                mg = mg + 50
            End If
            If cb2.Checked = True Then
                mg = mg + 55
            End If
            If cb3.Checked = True Then
                mg = mg + 250
            End If
            If cb4.Checked = True Then
                mg = mg + 150
            End If
            If cb5.Checked = True Then
                mg = mg + 55
            End If
            If cb6.Checked = True Then
                mg = mg + 30
            End If

            If cb7.Checked = True Then
                drinks = drinks + 20
            End If
            If cb8.Checked = True Then
                drinks = drinks + 20
            End If
            If cb9.Checked = True Then
                drinks = drinks + 20
            End If
            If cb10.Checked = True Then
                drinks = drinks + 30
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Textbox1.Text = mg + drinks

    End Sub

    Dim h1, h2, h3, h4, h5, h6, h7, h8, h9, h10 As Integer
    Dim totalfries, totalburger, totalpizza, totalcake, totalshawarma, totaldonut, totalorange, totalbuko, totalcola, totalsoda As Integer
    Dim fries, burger, pizza, cake, shawarma, donut, orange, soda, buko, cola As Integer
    Dim total, total1, total2, total3, total4, total5, total6, total7, total8, total9 As Integer

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        DataGridView1.DataSource = fooditems.getfooditems()

    End Sub

    Private Sub cb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.CheckedChanged


        Dim price As String = Label2.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label3.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=foodhaus")

        Dim command As New MySqlCommand("SELECT SUM(price * quantity ) FROM `items`", connection)

        connection.open()

        Textbox1.Text = command.ExecuteScalar().ToString

        connection.Close()
    End Sub

    Private Sub cb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.CheckedChanged

        Dim price As String = Label5.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label4.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb3.CheckedChanged

        Dim price As String = Label7.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label6.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb4.CheckedChanged

        Dim price As String = Label8.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label9.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb5.CheckedChanged

        Dim price As String = Label10.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label11.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb6.CheckedChanged

        Dim price As String = Label2.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label13.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb7.CheckedChanged

        Dim price As String = Label14.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label15.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb8.CheckedChanged

        Dim price As String = Label16.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label17.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb9.CheckedChanged

        Dim price As String = Label18.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label19.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub cb10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb10.CheckedChanged

        Dim price As String = Label20.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label21.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim price As String = Label2.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label3.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
   
        Dim price As String = Label5.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label4.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim price As String = Label7.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label6.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim price As String = Label8.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label9.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim price As String = Label10.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label11.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Dim price As String = Label2.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label13.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Dim price As String = Label14.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label15.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        Dim price As String = Label16.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label17.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Dim price As String = Label18.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label19.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        Dim price As String = Label20.Text
        Dim qty As Integer = InputBox("How many?")
        Dim name As String = Label21.Text

        If items.additems(name, price, qty) Then
            MessageBox.Show("New Product")
            DataGridView1.DataSource = fooditems.getfooditems()
        End If

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()

    End Sub


    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim id As Integer = Convert.ToInt32(TextBox2.Text)

        items.removeitems(id)

        MessageBox.Show("Item deleted succesfully.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DataGridView1.DataSource = fooditems.getfooditems()

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        Dim order As DialogResult

        order = MessageBox.Show("Thank you. Enjoy!", "Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Form6.Show()
        Me.Hide()
    End Sub



    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        items.clearitems()

        MessageBox.Show("Item cleared succesfully.", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DataGridView1.DataSource = fooditems.getfooditems()

    End Sub


    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form4.Show()
        Me.Hide()

    End Sub
End Class