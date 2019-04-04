Public Class busDatabase

    Private Sub busDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds.bus_details' table. You can move, or remove it, as needed.
        Me.Bus_detailsTableAdapter.Fill(Me.Ds.bus_details)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BusdetailsBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BusdetailsBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BusdetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BusdetailsBindingSource.EndEdit()
        Bus_detailsTableAdapter.Update(Ds.bus_details)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Admin.Show()
    End Sub
End Class