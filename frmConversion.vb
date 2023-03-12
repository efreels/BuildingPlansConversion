Public Class frmConversion

    'Form load calls the clear button as they do the same thing
    Private Sub frmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear_Click(sender, e)
    End Sub

    'Clears any results, resets the radio buttons to Inches to Meters, and makes the results label invisible
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResults.Visible = False
        radInToM.Checked = True
        radMToIn.Checked = False
        txtUnitInput.Focus()
        txtUnitInput.Text = ""
    End Sub

    'Closes the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    'Calculates the conversion
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decEntry As Decimal
        Dim strMeasure As String
        Dim decResult As Decimal
        Dim strResult As String = ""

        strMeasure = txtUnitInput.Text

        'Determines if the input is numeric
        If IsNumeric(strMeasure) Then
            'Converts the input to a decimal
            decEntry = Convert.ToDecimal(strMeasure)
            'Determines if the input is positive
            If decEntry > 0 Then
                'Performs the inches to meters conversion if radio button is selected, rounded to 3 places
                If radInToM.Checked Then
                    decResult = decEntry * 0.0254
                    strResult = decEntry & " inches is " & decResult.ToString("F3") & " meters."
                Else
                    'Performs the meters to inches conversion if radio button is selected, rounded to 3 places
                    decResult = decEntry / 0.0254
                    strResult = decEntry & " meters is " & decResult.ToString("F3") & " inches."
                End If
            Else
                'Displays error message for a non-positive number entered
                MsgBox("Enter a positive measurement to convert",, "Invalid measurement entered")
            End If
        Else
            'Diplsays error message for non-numeric value entered
            MsgBox("Enter a numeric value for the measurement",, "Invalid entry")
        End If

        'Diplays the results
        lblResults.Visible = True
        lblResults.Text = strResult
    End Sub
End Class
