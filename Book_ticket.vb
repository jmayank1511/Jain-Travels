Public Class Book_ticket

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        Label7.Text = "AXIS Bank"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Hide()
        Panel1.Show()
        Panel2.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  Panel1.Hide()
        Panel2.Show()
        '  Panel1.Hide()

    End Sub

    Private Sub Book_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Jan")
        ComboBox1.Items.Add("Feb")
        ComboBox1.Items.Add("Mar")
        ComboBox1.Items.Add("Apr")
        ComboBox1.Items.Add("May")
        ComboBox1.Items.Add("Jun")
        ComboBox1.Items.Add("Jul")
        ComboBox1.Items.Add("Aug")
        ComboBox1.Items.Add("Sep")
        ComboBox1.Items.Add("Oct")
        ComboBox1.Items.Add("Nov")
        ComboBox1.Items.Add("Dec")
        ComboBox2.Items.Add("2015")
        ComboBox2.Items.Add("2016")
        ComboBox2.Items.Add("2017")
        ComboBox2.Items.Add("2018")
        ComboBox2.Items.Add("2019")
        ComboBox2.Items.Add("2020")
        ComboBox2.Items.Add("2021")
        ComboBox2.Items.Add("2022")
        ComboBox2.Items.Add("2023")
        ComboBox2.Items.Add("2024")
        ComboBox2.Items.Add("2025")
        ComboBox2.Items.Add("2026")
        ComboBox2.Items.Add("2027")
        ComboBox2.Items.Add("2028")
        ComboBox2.Items.Add("2029")
        ComboBox2.Items.Add("2030")
        ComboBox2.Items.Add("2031")
        ComboBox2.Items.Add("2032")
        ComboBox2.Items.Add("2033")
        ComboBox2.Items.Add("2034")
        ComboBox2.Items.Add("2035")
        ComboBox2.Items.Add("2036")
        ComboBox2.Items.Add("2037")
        ComboBox2.Items.Add("2038")
        ComboBox2.Items.Add("2039")
        ComboBox2.Items.Add("2040")
        ComboBox2.Items.Add("2041")
        ComboBox2.Items.Add("2042")
        ComboBox2.Items.Add("2043")
        ComboBox2.Items.Add("2044")
        ComboBox2.Items.Add("2045")
        ComboBox2.Items.Add("2046")
        ComboBox2.Items.Add("2047")
        ComboBox2.Items.Add("2048")
        ComboBox2.Items.Add("2049")
        ComboBox2.Items.Add("2050")

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        Label7.Text = "HDFC Bank"
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Label7.Text = "ICICI Bank"
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Label7.Text = "CITI Bank"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        Label7.Text = "SBI Bank"
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Label7.Text = "KOTAK Bank"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Enter Username and password correctly !! ", MsgBoxStyle.Critical)

        Else
            Me.Hide()
            Pay_Now.Show()

        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then

            MsgBox("Enter details properly", MsgBoxStyle.Exclamation)
        ElseIf Len(TextBox4.Text) <> 4 Or IsNumeric(TextBox4.Text) = False Then
            MsgBox("Invalid Pin", MsgBoxStyle.Critical)
        ElseIf Len(TextBox3.Text) <> 3 Or IsNumeric(TextBox3.Text) = False Then
            MsgBox("Incorrect CVV", MsgBoxStyle.Critical)
        Else
            Me.Hide()
            Pay_Now.Show()
        End If



        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""


        Me.Hide()
        bus_details.Show()

    End Sub
End Class