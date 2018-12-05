'ChunhongLin assignment6 crn1430
Option Explicit On
'Option Strict On

Public Class frmMain
    'exit 
    Private Sub lblExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    'Public test(MaxNoOfQuestions - 1) As testQuestion

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        If click1 < 1 Then
            frmSelect.Show()
            Me.Hide()
            click1 = click1 + 1
        Else
            MsgBox("You already took the test!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Testing Error")
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "test1.dat", OpenMode.Random,,, Len(test(0)))
        For i = 0 To test.Length - 1
            FileGet(1, test(i))
        Next
        FileClose(1)
    End Sub
End Class
