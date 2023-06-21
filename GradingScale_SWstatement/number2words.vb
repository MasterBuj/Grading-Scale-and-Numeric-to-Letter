Public Class number2words



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Form1.WindowState = FormWindowState.Normal
        Me.Dispose()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fd As Integer
        Dim sd As Integer
        Dim a As String
        Dim b As String

        If Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("You have to enter a number between 01 and 99 in the textbox.")
        ElseIf TextBox1.Text.Length <> 2 Then
            MessageBox.Show("You have to enter a 2 digit number (01-99) in the textbox.")
        Else
            fd = TextBox1.Text.Substring(0, 1)
            sd = TextBox1.Text.Substring(1, 1)
            result.Text = "First digit: " + CStr(fd) + "   Second digit: " + CStr(sd)

            Dim ones() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
            Dim tens() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
            Dim secD() As String = {"", "-one", "-two", "-three", "-four", "-five", "-six", "-seven", "-eight", "-nine"}
            Dim specialD() As String = {"", "eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}

            'input 01 - 09
            If fd = 0 And sd <= 9 Then
                a = ""
                b = ones(sd)
                result.Text = a + b
                Return
            End If


            If fd <= 9 Then

                '10,20,...,90
                If sd = 0 Then
                    result.Text = tens(fd)
                    Return
                End If

                '11 - 19
                If fd = 1 And sd <= 9 Then
                    result.Text = specialD(sd)
                    Return
                End If

                'etc
                If fd >= 2 And sd <= 9 Then
                    a = tens(fd)
                    b = secD(sd)
                    result.Text = a + b
                End If

            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub


End Class