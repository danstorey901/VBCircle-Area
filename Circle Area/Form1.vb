' ***************************************************
' <William Dan Storey>
' Area of Circle
' **************************************************


Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' create local variables
        Dim dblRadius As Double
        Dim dblSum As Double

        ' assign value from text box to variable
        dblRadius = txtRadius.Text


        ' do calculation
        dblSum = (dblRadius ^ 2) * 3.14

        ' display output
        lblSum.Text = "Area of circle with radius of " & dblRadius & " inches is " & dblSum & " square inches."

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clear out the controls
        txtRadius.Clear()
        lblSum.ResetText()

        'set focus into first text box
        txtRadius.Focus()

    End Sub
End Class