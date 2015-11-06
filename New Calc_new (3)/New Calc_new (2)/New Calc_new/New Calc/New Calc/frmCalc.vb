Public Class frmCalc

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#Region "oldbuttoncode"
    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(1)
        'txtResult.Text = "1" comment
        'txtResult.Text = txtResult.Text & "1"
        'txtResult.Text &= "1"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "1"
        'Else
        '    txtResult.Text &= "1"
        'End If
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(3)
        'txtResult.Text &= "3"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "3"
        'Else
        '    txtResult.Text &= "3"
        'End If
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(5)
        'txtResult.Text &= "5"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "5"
        'Else
        '    txtResult.Text &= "5"
        'End If
    End Sub

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(0)
        'txtResult.Text &= "0"
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(7)

        'txtResult.Text &= "7"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "7"
        'Else
        '    txtResult.Text &= "7"
        'End If
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) 'took the Handles part out when you change from property
        AppendDigit(8)

        'txtResult.Text &= "8"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "8"
        'Else
        '    txtResult.Text &= "8"
        'End If
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) 'Handles btn9.Click
        AppendDigit(9)
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "9"
        'Else
        '    txtResult.Text &= "9"
        'End If
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(4)

        ''txtResult.Text &= "4"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "4"
        'Else
        '    txtResult.Text &= "4"
        'End If
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(6)

        'txtResult.Text &= "6"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "6"
        'Else
        '    txtResult.Text &= "6"
        'End If
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs)
        AppendDigit(2)

        ''txtResult.Text &= "2"
        'If txtResult.Text = "0" Then
        '    txtResult.Text = "2"
        'Else
        '    txtResult.Text &= "2"
        'End If

    End Sub
#End Region
   


    Private Sub btnDigit_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn4.Click, btn6.Click, btn5.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click 'add all of them in property by event select this
        Dim objDigitButton As Button = CType(sender, Button) 'create var and converts to button
        AppendDigit(objDigitButton.Text)

        'If txtResult.Text = "0" Then
        '    txtResult.Text = "9"
        'Else
        '    txtResult.Text &= "9"
        'End If
    End Sub
    Private Sub btnDivide_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        lblPrevValue.Text = CDbl(lblPrevValue.Text) / CDbl(txtResult.Text)
        txtResult.Text = "0"
    End Sub

    Private Sub btnMultiply_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiply.Click

    End Sub

    Private Sub BtnSubstr_Click(sender As System.Object, e As System.EventArgs) Handles BtnSubstr.Click

    End Sub

    Private Sub BtnAddition_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddition.Click
        lblPrevValue.Text = CDbl(lblPrevValue.Text) + CDbl(txtResult.Text)
        txtResult.Text = "0"
    End Sub

    Private Sub BtnEqual_Click(sender As System.Object, e As System.EventArgs) Handles BtnEqual.Click
        txtResult.Text = lblPrevValue.Text
        lblPrevValue.Text = "0"
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtResult.Text = "0"
    End Sub

    Private Sub btnDecimal_Click(sender As System.Object, e As System.EventArgs) Handles btnDecimal.Click
        'txtResult.Text &= "."
        If Not txtResult.Text.Contains(".") Then
            txtResult.Text &= "."
        Else
        End If
    End Sub

    Private Sub txtResult_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub frmCalc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Tip As ToolTip = New ToolTip()
        Tip.SetToolTip(btnClear, "Clears the Result Box")
        Tip.SetToolTip(btnDecimal, "Adds decimal if not there")
        Tip.SetToolTip(lblPrevValue, "Previous Value Shows here")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Dim Counter
        'Counter = 777
        'Counter &= "abc"
        'MessageBox.Show("Counter=" & Counter)
        Dim Counter As Integer
        Counter = 777
        Counter += 5
        'Counter = Counter+5 alternative method to add 5 to the counter
        'Counter &= "abc" this will throw error if you declare the var as integer
        MessageBox.Show("Counter=" & Counter)

        Dim Cntr2 As Integer = 555
        MessageBox.Show("Cntr2=" & Cntr2)

        Dim a(3, 2)
        MessageBox.Show(a(3, 2))
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim idx As Integer
        ListBox1.Items.Clear()
        For idx = 0 To 20 Step 2
            ListBox1.Items.Add(idx)
        Next
    End Sub

    Private Sub lblPrevValue_Click(sender As System.Object, e As System.EventArgs) Handles lblPrevValue.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub


    Private Sub ShappedButton1_Load(sender As System.Object, e As System.EventArgs) Handles ShappedButton1.Load

    End Sub

    Private Sub OvalShape1_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape1.Click

    End Sub

    Private Sub AppendDigit(NumberToAppend As String) 'new procedure-just added on oct 28 to optimize our code
        If txtResult.Text = "0" Then
            txtResult.Text = NumberToAppend ' "2"
        Else
            txtResult.Text &= NumberToAppend '"2"
        End If
    End Sub

End Class
