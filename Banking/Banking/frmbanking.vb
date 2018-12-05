'CRN1430 Chunhong Lin  Assignment 5

Option Explicit On
Option Strict On
Imports System.IO


Public Class frmMain
    'declearation boolean
    Public ReadOnly Property EndOfStream As Boolean

    'strings 
    Dim fields(7), record, arrfirst(19), arrlast(19) As String
    Dim arrmon(19), arrtue(19), arrwed(19), arrtr(19), arrfri(19), arrbegin(19), arrending(19) As Integer
    Dim num As Integer = 0

    'openfile
    Private Sub MenuSTOpenFile_Click(sender As Object, e As EventArgs) Handles MenuSTOpenFile.Click
        Dim inFile As StreamReader
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "csv files (*.csv)|*.csv"

        If (openFileDialog1.ShowDialog() = DialogResult.Cancel) Then
            Exit Sub
        Else
            inFile = File.OpenText(openFileDialog1.FileName)
            Do Until inFile.EndOfStream
                'seperate from ,
                record = inFile.ReadLine
                fields = Split(record, ",")

                'list box name 
                lstBX.Items.Add(CStr(fields(1)) + "," + CStr(fields(0)))

                'connect the name with the choice
                arrlast(num) = CStr(fields(0))
                arrfirst(num) = CStr(fields(1))
                arrbegin(num) = CInt(fields(2))
                arrmon(num) = CInt(fields(3))
                arrtue(num) = CInt(fields(4))
                arrwed(num) = CInt(fields(5))
                arrtr(num) = CInt(fields(6))
                arrfri(num) = CInt(fields(7))
                arrending(num) = arrbegin(num) + arrmon(num) + arrtue(num) + arrwed(num) + arrtr(num) + arrfri(num)
                'outfile report
                num = num + 1
            Loop
            'Select the first one
            lstBX.SelectedIndex = 0
            inFile.Close()
        End If
    End Sub


    'outfile
    Private Sub MenuSTReport_Click(sender As Object, e As EventArgs) Handles MenuSTReport.Click
        Dim outFile As StreamWriter
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim i As Integer
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        saveFileDialog1.InitialDirectory = "c:\"
        saveFileDialog1.FileName = "report.txt"

        If (saveFileDialog1.ShowDialog() = DialogResult.OK) Then
            outFile = File.CreateText(saveFileDialog1.FileName)
            'timer for output reprot 
            outFile.WriteLine("Summary Report Created: " & Date.Now.ToString("dddd, MMMM d, yyyy"))
            'banner 
            outFile.WriteLine("  ")
            outFile.WriteLine(LSet(" ", 20) & LSet("Name", 20) & RSet("Beginning", 20) & RSet("Ending", 40))
            outFile.WriteLine(LSet(" ", 40) & RSet("Balance", 18) & RSet("Balance", 43))
            outFile.WriteLine("  ")
            For i = 0 To num - 1
                outFile.WriteLine(LSet(" ", 20) & LSet(arrlast(i) & " " & arrfirst(i), 20) & RSet(CType(FormatCurrency(arrbegin(i),,, TriState.False), String), 20) & RSet(CType(FormatCurrency(arrending(i),,, TriState.False), String), 40))
            Next i
            MsgBox("Summary Report has been created")
            outFile.Close()
        Else
        MsgBox("No Summary Reprot has been created")
        End If

    End Sub


    Private Sub PopulateLabels(i As Integer)
        lblmon.Text = FormatNumber(arrmon(i), 0)
        lbltue.Text = FormatNumber(arrtue(i), 0)
        lblwed.Text = FormatNumber(arrwed(i), 0)
        lbltr.Text = FormatNumber(arrtr(i), 0)
        lblfri.Text = FormatNumber(arrfri(i), 0)
        lblbegin.Text = FormatNumber(arrbegin(i), 0)
        lblending.Text = FormatNumber(arrending(i), 0)

    End Sub

    Private Sub lstBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBX.SelectedIndexChanged
        PopulateLabels(lstBX.SelectedIndex)
    End Sub

    'Menustrip Exit
    Private Sub MenuSTExt_Click(sender As Object, e As EventArgs) Handles MenuSTExt.Click

        Dim result = MsgBox("Are you sure you want to exit",
               MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Leaving?")
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
