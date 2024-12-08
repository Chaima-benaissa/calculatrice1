Public Class Form1
    Dim op As Char

    Private Sub bt_plus_Click(sender As Object, e As EventArgs) Handles bt_plus.Click
        op = "+"

    End Sub

    Private Sub bt_moin_Click(sender As Object, e As EventArgs) Handles bt_moin.Click
        op = "-"
    End Sub

    Private Sub bt_fois_Click(sender As Object, e As EventArgs) Handles bt_fois.Click
        op = "*"
    End Sub

    Private Sub bt_div_Click(sender As Object, e As EventArgs) Handles bt_div.Click
        op = "/"
    End Sub

    Private Sub equal_Click_1(sender As Object, e As EventArgs) Handles equal.Click
        If IsNumeric(txt_a.Text) And IsNumeric(txt_b.Text) Then

        End If
        Dim a = Integer.Parse(txt_a.Text)
        Dim b = Integer.Parse(txt_b.Text)
        Dim rest As Double
        Dim test = True
        If op = "+" Then
            rest = a + b
        ElseIf op = "-" Then
            rest = a + b
        ElseIf op = "-" Then
            rest = a - b
        ElseIf op = "*" Then
            rest = a * b
        ElseIf op = "/" And Not b = 0 Then
            rest = a / b
        Else
            MessageBox.Show("veuillez choisir un opérateur")
        End If
        If test = True Then
            resultat.Text = a.ToString + " " + op + " " + b.ToString + " =" + rest.ToString
        End If


    End Sub
End Class
