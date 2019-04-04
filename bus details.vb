Public Class bus_details
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Dim sqlstr1 As String
    Public Shared pr As Integer


    Private Sub bus_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\visual basic lab assignment\jain travels\jain travels\JainTravels.accdb")
        con.Open()
        sqlstr = "select * from bus_details where source ='" & Userhomepage.ComboBox1.Text & "'and destination = '" & Userhomepage.ComboBox2.Text & "'and type ='" & Userhomepage.ComboBox3.Text & "'"

        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read()
                Label1.Text = dr(0)
                    Label2.Text = dr(1)
                    Label3.Text = dr(2)
                    Label4.Text = dr(3)
                    Label5.Text = dr(4)
                    Label6.Text = dr(5)
                    Label17.Text = dr(6)
                    pr = Val(Label4.Text)

             


            End While
        End If

        Catch ex As Exception
            MsgBox("Choose Appropriate Entries")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        Me.Hide()
        Seat_availability.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login_Form.TextBox1.Text = ""
        Login_Form.TextBox2.Text = ""
        Login_Form.ComboBox1.Text = ""
        Me.Hide()
        Login_Form.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        About_us.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Home_Page.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Contact_us.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        
        Userhomepage.ComboBox1.Text = ""
        Userhomepage.ComboBox2.Text = ""
        Userhomepage.ComboBox3.Text = ""
        Me.Hide()
        Userhomepage.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class