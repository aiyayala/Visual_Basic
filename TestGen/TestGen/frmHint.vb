'ChunhongLin assignment6 crn1430
Option Explicit On
'Option Strict On

Public Class frmHint

    'form link 
    Dim i As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
    End Sub

    Private Sub frmHint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblhint.Text = hint
    End Sub

End Class