Public Class Form1
    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        txtResultIs.Text = Val(txtFirstNumber.Text) - Val(txtSecondNumber.Text)
    End Sub


    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txtResultIs.Text = Val(txtFirstNumber.Text) / Val(txtSecondNumber.Text)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtResultIs.Text = Val(txtFirstNumber.Text) * Val(txtSecondNumber.Text)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtResultIs.Text = Val(txtFirstNumber.Text) + Val(txtSecondNumber.Text)
    End Sub



End Class

