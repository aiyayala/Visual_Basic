'Chunhong Lin Assignment6   CRN1430
Option Explicit On
'Option Strict On

Public Class frmRecords
    Dim x As Integer = 1
    Dim i As Integer = 0
    Dim y As Integer = count
    Dim score As Integer = 0
    Dim fscore As Long


    ' showquestion() present each question in the label
    Sub ShowQuestion()
        lblQuestion.Text = test(i).question
        opta.Text = test(i).choiceA
        optb.Text = test(i).choiceB
        optc.Text = test(i).choiceC
        optd.Text = test(i).choiceD
        opte.Text = test(i).choiceE
        hint = test(i).hint
        answerT = test(i).correctAnswer
        i = i + 1
    End Sub

    ' choice 
    Sub option1()
        If opta.Checked Then
            myanswer = test(i).choiceA
            myanswer = "A"
            opta.Checked = False
        ElseIf optb.Checked Then
            myanswer = test(i).choiceB
            myanswer = "B"
            optb.Checked = False
        ElseIf optc.Checked Then
            myanswer = test(i).choiceC
            myanswer = "C"
            optc.Checked = False
        ElseIf optd.Checked Then
            myanswer = test(i).choiceD
            myanswer = "D"
            optd.Checked = False
        ElseIf opte.Checked Then
            myanswer = test(i).choiceE
            myanswer = "E"
            opte.Checked = False
        Else
            myanswer = "*"
        End If
        myanswerarr(i) = myanswer
    End Sub

    'record the final score 
    Sub finalscore()
        If CStr(answerT) = myanswer Then
            score = score + (10 / y)
        ElseIf CStr(myanswer) = "*" Then
            score = score
        Else
            score = score - (5 / y)
        End If

    End Sub

    'form load
    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowQuestion()
        option1()
        finalscore()
        'question index
        lblQstIndex.Text = CStr(x)
    End Sub

    ' Next-finished button & number index
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        lbl1stQ.Text = ""
        'next question ~~~~~~
        If count > 2 Then
            'next-finished button
            cmdNext.Text = "Next Question"
            count = count - 1
            'question index
            x = x + 1
            lblQstIndex.Text = CStr(x)
            option1()
            ShowQuestion()
            pbrqst.Increment(100 / y)
            lblpercent.Text = (x / y - 1 / y).ToString("#0.#%")
            finalscore()


            'last question ~~~~
        ElseIf count = 2 Then
            cmdNext.Text = "Finished"
            count = count - 1
            'question index
            x = x + 1
            lblQstIndex.Text = CStr(x)
            option1()
            ShowQuestion()
            pbrqst.Increment(100 / y)
            lblpercent.Text = (x / y - 1 / y).ToString("#0.#%")
            finalscore()

            'msgbox (result)
        ElseIf count < 2 Then
            'question index
            lblQstIndex.Text = CStr(x)
            option1()
            'msgbox
            Dim result As String = ""
            For i = 0 To x - 1
                result = result & "              " & CStr(test(i).correctAnswer) & "                      " & CStr(myanswerarr(i + 1)) & "      " & vbNewLine
            Next
            Dim report = MessageBox.Show("          Corrct             Your" & vbNewLine &
                                "          Answer             Answer" & vbNewLine & vbNewLine & result & vbNewLine & vbNewLine & vbNewLine &
                                "*indicates that you did not answer that question" & vbNewLine & vbNewLine & vbNewLine &
                                "Your score is: " & CStr(Math.Round(score)) & MsgBoxStyle.OkOnly, "Test Result")
            If report = MsgBoxResult.Ok Then
                frmMain.Show()
                Me.Hide()
            End If
            FileClose(1)
        End If
    End Sub

    'hint
    Private Sub cmdHint_Click(sender As Object, e As EventArgs) Handles cmdHint.Click
        frmHint.ShowDialog()
    End Sub

End Class