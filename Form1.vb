Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Function Assert(condition As Boolean, msg As String) As Boolean
        If condition = False Then
            MsgBox(msg)
            Return False
        End If

        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resTitle As String = LCase(title.Text)
        Dim okay As Boolean = False
        okay = Assert(resTitle = "mr" Or resTitle = "ms" Or resTitle = "miss" Or resTitle = "mrs",
                       "The title is incorrect, it must be either Mr, Miss, Mrs or Ms!")
        okay = Assert(Val(Len(surname.Text)) > 0 And Val(Len(surname.Text)) < 15,
                        "Your surname should be at least 1 character long and no more than 15!")
        okay = Assert((Val(test1.Text) + Val(test2.Text)) < 200, "The sum should be less than 200")
        okay = Assert(Val(test1.Text) >= 0 And Val(test1.Text) <= 100, "The first test should be between 0 and 100")
        okay = Assert(Val(test2.Text) >= 0 And Val(test2.Text) <= 100, "The second test should be between 0 and 100")

        If okay Then
            Label6.Text = "The student " + title.Text + " " + surname.Text + " has been validated!"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        title.Text = ""
        surname.Text = ""
        test1.Text = ""
        test2.Text = ""
        Label6.Text = "-"
    End Sub
End Class
