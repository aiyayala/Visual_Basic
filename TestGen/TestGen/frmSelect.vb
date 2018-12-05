'Chunhong Lin Assignment6   CRN1430
Option Explicit On
'Option Strict On
Public Class frmSelect

    'select 5 
    Private Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo_quest.SelectedIndex = 0
    End Sub

    Private Sub cmdBegin_Click(sender As Object, e As EventArgs) Handles cmdBegin.Click
        frmRecords.Show()
        Me.Hide()
    End Sub

    Private Sub Combo_quest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_quest.SelectedIndexChanged

        If Combo_quest.SelectedIndex = 0 Then
            count = 5
        ElseIf Combo_quest.SelectedIndex = 1 Then
            count = 6
        ElseIf Combo_quest.SelectedIndex = 2 Then
            count = 7
        ElseIf Combo_quest.SelectedIndex = 3 Then
            count = 8
        ElseIf Combo_quest.SelectedIndex = 4 Then
            count = 9
        ElseIf Combo_quest.SelectedIndex = 5 Then
            count = 10
        End If

    End Sub
End Class