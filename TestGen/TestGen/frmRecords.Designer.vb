<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdHint = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.lblQstIndex = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.opte = New System.Windows.Forms.RadioButton()
        Me.optd = New System.Windows.Forms.RadioButton()
        Me.optc = New System.Windows.Forms.RadioButton()
        Me.optb = New System.Windows.Forms.RadioButton()
        Me.opta = New System.Windows.Forms.RadioButton()
        Me.pbrqst = New System.Windows.Forms.ProgressBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblpercent = New System.Windows.Forms.Label()
        Me.lbl1stQ = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the correct answer: "
        '
        'cmdHint
        '
        Me.cmdHint.Location = New System.Drawing.Point(15, 287)
        Me.cmdHint.Name = "cmdHint"
        Me.cmdHint.Size = New System.Drawing.Size(121, 27)
        Me.cmdHint.TabIndex = 4
        Me.cmdHint.Text = "Hint"
        Me.cmdHint.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(418, 287)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(121, 27)
        Me.cmdNext.TabIndex = 6
        Me.cmdNext.Text = "Next Question"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'lblQstIndex
        '
        Me.lblQstIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQstIndex.Location = New System.Drawing.Point(43, 44)
        Me.lblQstIndex.Name = "lblQstIndex"
        Me.lblQstIndex.Size = New System.Drawing.Size(31, 18)
        Me.lblQstIndex.TabIndex = 7
        '
        'lblQuestion
        '
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuestion.Location = New System.Drawing.Point(100, 44)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(387, 61)
        Me.lblQuestion.TabIndex = 8
        '
        'opte
        '
        Me.opte.AutoSize = True
        Me.opte.Location = New System.Drawing.Point(124, 255)
        Me.opte.Name = "opte"
        Me.opte.Size = New System.Drawing.Size(90, 17)
        Me.opte.TabIndex = 35
        Me.opte.TabStop = True
        Me.opte.Text = "RadioButton5"
        Me.opte.UseVisualStyleBackColor = True
        '
        'optd
        '
        Me.optd.AutoSize = True
        Me.optd.Location = New System.Drawing.Point(124, 220)
        Me.optd.Name = "optd"
        Me.optd.Size = New System.Drawing.Size(90, 17)
        Me.optd.TabIndex = 34
        Me.optd.TabStop = True
        Me.optd.Text = "RadioButton4"
        Me.optd.UseVisualStyleBackColor = True
        '
        'optc
        '
        Me.optc.AutoSize = True
        Me.optc.Location = New System.Drawing.Point(124, 182)
        Me.optc.Name = "optc"
        Me.optc.Size = New System.Drawing.Size(90, 17)
        Me.optc.TabIndex = 33
        Me.optc.TabStop = True
        Me.optc.Text = "RadioButton3"
        Me.optc.UseVisualStyleBackColor = True
        '
        'optb
        '
        Me.optb.AutoSize = True
        Me.optb.Location = New System.Drawing.Point(124, 146)
        Me.optb.Name = "optb"
        Me.optb.Size = New System.Drawing.Size(90, 17)
        Me.optb.TabIndex = 32
        Me.optb.TabStop = True
        Me.optb.Text = "RadioButton2"
        Me.optb.UseVisualStyleBackColor = True
        '
        'opta
        '
        Me.opta.AutoSize = True
        Me.opta.Location = New System.Drawing.Point(124, 108)
        Me.opta.Name = "opta"
        Me.opta.Size = New System.Drawing.Size(90, 17)
        Me.opta.TabIndex = 31
        Me.opta.TabStop = True
        Me.opta.Text = "RadioButton1"
        Me.opta.UseVisualStyleBackColor = True
        '
        'pbrqst
        '
        Me.pbrqst.ForeColor = System.Drawing.Color.SpringGreen
        Me.pbrqst.Location = New System.Drawing.Point(187, 282)
        Me.pbrqst.Name = "pbrqst"
        Me.pbrqst.Size = New System.Drawing.Size(191, 32)
        Me.pbrqst.TabIndex = 36
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(184, 322)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(21, 13)
        Me.label2.TabIndex = 37
        Me.label2.Text = "0%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "100%"
        '
        'lblpercent
        '
        Me.lblpercent.Location = New System.Drawing.Point(254, 287)
        Me.lblpercent.Name = "lblpercent"
        Me.lblpercent.Size = New System.Drawing.Size(52, 23)
        Me.lblpercent.TabIndex = 39
        Me.lblpercent.Text = "0%"
        Me.lblpercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1stQ
        '
        Me.lbl1stQ.AutoSize = True
        Me.lbl1stQ.Location = New System.Drawing.Point(108, 45)
        Me.lbl1stQ.Name = "lbl1stQ"
        Me.lbl1stQ.Size = New System.Drawing.Size(180, 13)
        Me.lbl1stQ.TabIndex = 40
        Me.lbl1stQ.Text = "The sum of the angles of a triangle is"
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl1stQ)
        Me.Controls.Add(Me.lblpercent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pbrqst)
        Me.Controls.Add(Me.opte)
        Me.Controls.Add(Me.optd)
        Me.Controls.Add(Me.optc)
        Me.Controls.Add(Me.optb)
        Me.Controls.Add(Me.opta)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblQstIndex)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdHint)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chunhong wishes you good Luck!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdHint As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents lblQstIndex As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents opte As RadioButton
    Friend WithEvents optd As RadioButton
    Friend WithEvents optc As RadioButton
    Friend WithEvents optb As RadioButton
    Friend WithEvents opta As RadioButton
    Friend WithEvents pbrqst As ProgressBar
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblpercent As Label
    Friend WithEvents lbl1stQ As Label
End Class
