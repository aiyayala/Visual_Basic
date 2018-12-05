'ChunhongLin assignment6 crn1430
Option Explicit On
'Option Strict On

Module myModule

    Structure testQuestion
        <VBFixedString(100)> Public question As String
        <VBFixedString(20)> Public choiceA As String
        <VBFixedString(20)> Public choiceB As String
        <VBFixedString(20)> Public choiceC As String
        <VBFixedString(20)> Public choiceD As String
        <VBFixedString(20)> Public choiceE As String
        <VBFixedString(1)> Public correctAnswer As String
        <VBFixedString(55)> Public hint As String
    End Structure
    Public Const MaxNoOfQuestions = 10
    Public test(MaxNoOfQuestions - 1) As testQuestion
    Public count As Integer

    Public click1 As Integer = 0
    Public hint As String
    Public answerT As String
    Public myanswer As String
    Public myanswerarr(MaxNoOfQuestions - 1) As String

End Module
