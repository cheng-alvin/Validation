Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Check(Val(txt.Text) <= 2999 And Val(txt.Text) > 3999)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Check(IsNumeric(txt.Text))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Check(LCase(txt.Text) = "yes" Or LCase(txt.Text) = "no")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt.Text = ""
        res.Text = "-"
    End Sub

    Function Check(condition As Boolean)
        If condition = True Then
            res.Text = "✅"
        Else
            res.Text = "❌"
        End If
    End Function
End Class
