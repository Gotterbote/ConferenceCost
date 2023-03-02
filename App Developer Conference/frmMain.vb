Public Class frmMain
    'Name:
    'Developer:
    'Date:

    'This program calculates the cost of attending a conference.
    'Rates vary based on multiple registrants. A discount is
    'offered for companies that have attended the conference
    'before.

    'Program constants
    Const _cdblFeeOne As Double = 795.0R                'Fee for one registrant
    Const _cdblFeeTwoToFour As Double = 645.0R          'Fee for 2-4 registrants
    Const _cdblFeeFivetoSeven As Double = 475.0R        'Fee for 5-7 registrants
    Const _cdblFeeEightToSixteen As Double = 385.0R     'Fee for 8-16 registrants

    Const _cdblDiscountRate As Double = 0.85R
    Const _strInitialMessage As String = "Please complete the registration form."

    Dim _dblGrossFee As Double
    Dim _dblNetFee As Double

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset the form

        txtRegQty.Text = ""
        lblMessage.Text = _strInitialMessage

        txtRegQty.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intRegQty As Integer

        If IsNumeric(txtRegQty.Text) Then
            'Input is valid
            intRegQty = Convert.ToInt32(txtRegQty.Text)

            If (intRegQty > 0) And (intRegQty <= 16) Then
                'Input is within the range of 1 - 16
                Select Case intRegQty
                    Case 1
                        _dblGrossFee = intRegQty * _cdblFeeOne
                    Case 2 To 4
                        _dblGrossFee = intRegQty * _cdblFeeTwoToFour
                    Case 5 To 7
                        _dblGrossFee = intRegQty * _cdblFeeFivetoSeven
                    Case 8 To 16
                        _dblGrossFee = intRegQty * _cdblFeeEightToSixteen
                    Case Else
                        MessageBox.Show("Error in processing , please contact administrator", "Fatal Error")
                End Select

                If radRepeat.Checked Then
                    'Apply Discount
                    _dblNetFee = _dblGrossFee * _cdblDiscountRate
                Else
                    'No discount applied
                    _dblNetFee = _dblGrossFee
                End If

                'Display Results
                lblMessage.Text = "The cost to attend the conference for" & intRegQty.ToString("n0") & " is " & _dblNetFee.ToString("c")

            Else
                'Input is not within the range 1 - 16
                MessageBox.Show("Please enter a number of registrants between 1 - 16", "Number of Registrants")
            End If
        Else
            'Input is not a valid number.
            MessageBox.Show("Please enter a valid number", "Number of Registrants")
        End If
    End Sub
End Class
