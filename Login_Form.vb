Public Class Login_Form
    Public Shared userid As String
    Public Shared pass As String

    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand

    Dim dr As System.Data.OleDb.OleDbDataReader

    Dim sqlstr As String

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home_Page.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        About_us.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Contact_us.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ComboBox1.Items.Add("User")
        ComboBox1.Items.Add("Admin")


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Sign_Up.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click


        If (ComboBox1.Text = "User") Then
            con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\visual basic lab assignment\jain travels\jain travels\JainTravels.accdb")
            'cmd = New OleDb.OleDbCommand(sqlstr, con)
            con.Open()
            sqlstr = "select userid,password from Sign_up where userid= '" & TextBox1.Text & "'and password = '" & TextBox2.Text & "'"
            cmd = New OleDb.OleDbCommand(sqlstr, con)
            dr = cmd.ExecuteReader()


            If dr.HasRows = True Then

                'MsgBox("Logged in Successfully !!", MsgBoxStyle.Information)

                con.Close()


                Userhomepage.Show()
                Me.Hide()
            Else
                Me.Show()
                MsgBox("invalid login or password !!", MsgBoxStyle.Critical)
            End If

        Else
            If (ComboBox1.Text = "Admin" And TextBox1.Text = "Jaintravels" And TextBox2.Text = "password") Then
                Admin.Show()
                Me.Hide()
            Else
                MsgBox("invalid login!!", MsgBoxStyle.Critical)

            End If
        End If
        userid = TextBox1.Text
        pass = TextBox2.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        Userhomepage.ComboBox1.Text = ""
        Userhomepage.ComboBox2.Text = ""
        Userhomepage.ComboBox3.Text = ""
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Userhomepage.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        End



    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Userhomepage.Show()
        Me.Hide()
    End Sub
End Class