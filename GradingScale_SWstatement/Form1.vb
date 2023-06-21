
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Second As New number2words
        Second.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub grade(sender As Object, e As EventArgs) Handles Button1.MouseClick

        Dim grade As Integer = If(IsNumeric(TextBox1.Text), TextBox1.Text, -1)

        If grade < 100 And grade > 0 Then
            Dim letterG As Char
            Select Case grade
                Case 90 To 100
                    letterG = "A"
                Case 80 To 89
                    letterG = "B"
                Case 70 To 79
                    letterG = "C"
                Case 60 To 69
                    letterG = "D"
                Case 0 To 59
                    letterG = "F"
            End Select
            alphaGrade.Text = CStr(grade) + " is Equivalent to grade: " + letterG
            Return
        End If

        alphaGrade.Text = ""
        MessageBox.Show("Input Grade must be between 0 - 100 to able to proceed")

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Dispose()
    End Sub


End Class
