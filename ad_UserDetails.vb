Public Class ad_UserDetails

    Private Sub ad_UserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds.Sign_up' table. You can move, or remove it, as needed.
        Me.Sign_upTableAdapter.Fill(Me.Ds.Sign_up)
        'TODO: This line of code loads data into the 'DataSet3.Sign_up' table. You can move, or remove it, as needed.


   
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SignupBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SignupBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SignupBindingSource.EndEdit()
        Sign_upTableAdapter.Update(Ds.Sign_up)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SignupBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class