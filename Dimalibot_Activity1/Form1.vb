Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim a As Integer
        Dim b As Integer

        a = txtfirstnum.Text
        b = txtSecondnum.Text

        lblResult.Text = a + b


    End Sub
End Class