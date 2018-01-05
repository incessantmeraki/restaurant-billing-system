Public Class Validator
    Private Shared m_Title As String = "Entry Error"

    'code for checking if the textbox is empty
    Public Shared Function IsPresent(ByVal textbox As TextBox) As Boolean
        If textbox.Text.Trim = "" Then
            MessageBox.Show(textbox.Tag.ToString & " is a required field", m_Title, MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
            textbox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    'code for checking if the entered value in textbox is decimal
    Public Shared Function IsDecimal(ByVal textbox As TextBox) As Boolean
        Try
            Convert.ToDecimal(textbox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(textbox.Tag.ToString & " must be a decimal value.", m_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Select(0, textbox.Text.Length)
            Return False
        End Try
    End Function

    'code for checking if the number entered in textbox lies between given range
    Public Shared Function IsWithinRange(ByVal textbox As TextBox, ByVal min As Decimal, ByVal max As Decimal) As Boolean
        Dim number As Decimal = CDec(textbox.Text)
        If number < min OrElse number > max Then
            MessageBox.Show(textbox.Tag & " must be between " & min & " and " & max & ".", m_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Select()
            textbox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    'code for checking whether string of suitable length was added
    Public Shared Function LengthCheck(ByVal textbox As TextBox) As Boolean
        If textbox.Text.Trim.Length > 30 Then
            MessageBox.Show(textbox.Tag.ToString & " cannot be longer than 30 character", m_Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Select()
            Return False
        Else
            Return True
        End If
    End Function

End Class
