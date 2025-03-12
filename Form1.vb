Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(txt.Text) <= 2999 Or Val(txt.Text) > 3999 Then
            MsgBox("This does not fall into this category")
        Else
            MsgBox("This does fall into this category")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(txt.Text) Then
            MsgBox("This does fall into this category")
        Else
            MsgBox("This does not fall into this category")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LCase(txt.Text) = "yes" Or LCase(txt.Text) = "no" Then
            MsgBox("This does fall into this category")
        Else
            MsgBox("This does not fall into this category")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt.Text = ""
    End Sub
End Class
