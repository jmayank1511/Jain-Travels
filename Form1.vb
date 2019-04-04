Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value <= 25% Then
            Label4.Text = "Loading forms......"
        ElseIf ProgressBar1.Value <= 50% Then
            Label4.Text = "Loading Database......"
        ElseIf ProgressBar1.Value <= 75% Then
            Label4.Text = "Connecting Database......"
        ElseIf ProgressBar1.value <= 99% Then
            Label4.Text = "Loading User Details...."
        End If
        if  ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Close()
            MsgBox("Welcome")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
