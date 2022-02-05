<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gpbParamteres = New System.Windows.Forms.GroupBox()
        Me.gpbParamNote = New System.Windows.Forms.GroupBox()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.chkBemol = New System.Windows.Forms.CheckBox()
        Me.chkDiese = New System.Windows.Forms.CheckBox()
        Me.lblRepetition = New System.Windows.Forms.Label()
        Me.lblNbNote = New System.Windows.Forms.Label()
        Me.gpbVoix = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HVitesse = New System.Windows.Forms.HScrollBar()
        Me.lblVitesse = New System.Windows.Forms.Label()
        Me.gpbDélai = New System.Windows.Forms.GroupBox()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.gpbAfficheNote = New System.Windows.Forms.GroupBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.tmrNote = New System.Windows.Forms.Timer(Me.components)
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.splitDebug = New System.Windows.Forms.SplitContainer()
        Me.splitParamNote = New System.Windows.Forms.SplitContainer()
        Me.nupRepetitionNote = New Pratique_de_Note.MyNup()
        Me.nupNbNote = New Pratique_de_Note.MyNup()
        Me.nupVolume = New Pratique_de_Note.MyNup()
        Me.nupInterval = New Pratique_de_Note.MyNup()
        Me.tmrDecompte = New Pratique_de_Note.TimerDecompte(Me.components)
        Me.gpbParamteres.SuspendLayout()
        Me.gpbParamNote.SuspendLayout()
        Me.gpbVoix.SuspendLayout()
        Me.gpbDélai.SuspendLayout()
        Me.gpbAfficheNote.SuspendLayout()
        CType(Me.splitDebug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitDebug.Panel1.SuspendLayout()
        Me.splitDebug.Panel2.SuspendLayout()
        Me.splitDebug.SuspendLayout()
        CType(Me.splitParamNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitParamNote.Panel1.SuspendLayout()
        Me.splitParamNote.Panel2.SuspendLayout()
        Me.splitParamNote.SuspendLayout()
        CType(Me.nupRepetitionNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNbNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbParamteres
        '
        Me.gpbParamteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gpbParamteres.Controls.Add(Me.gpbParamNote)
        Me.gpbParamteres.Controls.Add(Me.gpbVoix)
        Me.gpbParamteres.Controls.Add(Me.gpbDélai)
        Me.gpbParamteres.Controls.Add(Me.btnDebug)
        Me.gpbParamteres.Controls.Add(Me.btnStart)
        Me.gpbParamteres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbParamteres.Location = New System.Drawing.Point(0, 0)
        Me.gpbParamteres.Margin = New System.Windows.Forms.Padding(15)
        Me.gpbParamteres.Name = "gpbParamteres"
        Me.gpbParamteres.Size = New System.Drawing.Size(602, 530)
        Me.gpbParamteres.TabIndex = 0
        Me.gpbParamteres.TabStop = False
        Me.gpbParamteres.Text = "Paramètres"
        '
        'gpbParamNote
        '
        Me.gpbParamNote.Controls.Add(Me.lblMax)
        Me.gpbParamNote.Controls.Add(Me.chkBemol)
        Me.gpbParamNote.Controls.Add(Me.chkDiese)
        Me.gpbParamNote.Controls.Add(Me.nupRepetitionNote)
        Me.gpbParamNote.Controls.Add(Me.lblRepetition)
        Me.gpbParamNote.Controls.Add(Me.lblNbNote)
        Me.gpbParamNote.Controls.Add(Me.nupNbNote)
        Me.gpbParamNote.Location = New System.Drawing.Point(12, 162)
        Me.gpbParamNote.Name = "gpbParamNote"
        Me.gpbParamNote.Size = New System.Drawing.Size(573, 207)
        Me.gpbParamNote.TabIndex = 1
        Me.gpbParamNote.TabStop = False
        Me.gpbParamNote.Text = "Paramètres notes"
        '
        'lblMax
        '
        Me.lblMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMax.AutoSize = True
        Me.lblMax.ForeColor = System.Drawing.Color.Red
        Me.lblMax.Location = New System.Drawing.Point(501, 143)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(36, 39)
        Me.lblMax.TabIndex = 12
        Me.lblMax.Text = "6"
        '
        'chkBemol
        '
        Me.chkBemol.AutoSize = True
        Me.chkBemol.Location = New System.Drawing.Point(175, 40)
        Me.chkBemol.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.chkBemol.Name = "chkBemol"
        Me.chkBemol.Size = New System.Drawing.Size(136, 43)
        Me.chkBemol.TabIndex = 1
        Me.chkBemol.Text = "Avec ♭"
        Me.chkBemol.UseVisualStyleBackColor = True
        '
        'chkDiese
        '
        Me.chkDiese.AutoSize = True
        Me.chkDiese.Location = New System.Drawing.Point(13, 40)
        Me.chkDiese.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.chkDiese.Name = "chkDiese"
        Me.chkDiese.Size = New System.Drawing.Size(142, 43)
        Me.chkDiese.TabIndex = 0
        Me.chkDiese.Text = "Avec ♯"
        Me.chkDiese.UseVisualStyleBackColor = True
        '
        'lblRepetition
        '
        Me.lblRepetition.AutoSize = True
        Me.lblRepetition.Location = New System.Drawing.Point(13, 149)
        Me.lblRepetition.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblRepetition.Name = "lblRepetition"
        Me.lblRepetition.Size = New System.Drawing.Size(363, 39)
        Me.lblRepetition.TabIndex = 11
        Me.lblRepetition.Text = "Limite répétition (max)"
        '
        'lblNbNote
        '
        Me.lblNbNote.AutoSize = True
        Me.lblNbNote.Location = New System.Drawing.Point(13, 90)
        Me.lblNbNote.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblNbNote.Name = "lblNbNote"
        Me.lblNbNote.Size = New System.Drawing.Size(157, 39)
        Me.lblNbNote.TabIndex = 6
        Me.lblNbNote.Text = "Quantité "
        '
        'gpbVoix
        '
        Me.gpbVoix.Controls.Add(Me.nupVolume)
        Me.gpbVoix.Controls.Add(Me.Label1)
        Me.gpbVoix.Controls.Add(Me.HVitesse)
        Me.gpbVoix.Controls.Add(Me.lblVitesse)
        Me.gpbVoix.Location = New System.Drawing.Point(12, 375)
        Me.gpbVoix.Name = "gpbVoix"
        Me.gpbVoix.Size = New System.Drawing.Size(573, 145)
        Me.gpbVoix.TabIndex = 2
        Me.gpbVoix.TabStop = False
        Me.gpbVoix.Text = "Paramètres Voix"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Volume"
        '
        'HVitesse
        '
        Me.HVitesse.Cursor = System.Windows.Forms.Cursors.Default
        Me.HVitesse.LargeChange = 3
        Me.HVitesse.Location = New System.Drawing.Point(341, 44)
        Me.HVitesse.Maximum = 10
        Me.HVitesse.Minimum = -10
        Me.HVitesse.Name = "HVitesse"
        Me.HVitesse.Size = New System.Drawing.Size(165, 38)
        Me.HVitesse.TabIndex = 0
        Me.HVitesse.Value = 6
        '
        'lblVitesse
        '
        Me.lblVitesse.AutoSize = True
        Me.lblVitesse.Location = New System.Drawing.Point(20, 43)
        Me.lblVitesse.Name = "lblVitesse"
        Me.lblVitesse.Size = New System.Drawing.Size(293, 39)
        Me.lblVitesse.TabIndex = 6
        Me.lblVitesse.Text = "Vitesse de lecture"
        '
        'gpbDélai
        '
        Me.gpbDélai.Controls.Add(Me.nupInterval)
        Me.gpbDélai.Location = New System.Drawing.Point(12, 46)
        Me.gpbDélai.Name = "gpbDélai"
        Me.gpbDélai.Size = New System.Drawing.Size(258, 110)
        Me.gpbDélai.TabIndex = 0
        Me.gpbDélai.TabStop = False
        Me.gpbDélai.Text = "Délai en Bpm"
        '
        'btnDebug
        '
        Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDebug.Location = New System.Drawing.Point(390, 109)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(195, 49)
        Me.btnDebug.TabIndex = 4
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(334, 36)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(251, 61)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "C'est parti"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'gpbAfficheNote
        '
        Me.gpbAfficheNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gpbAfficheNote.Controls.Add(Me.lblNote)
        Me.gpbAfficheNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbAfficheNote.Location = New System.Drawing.Point(0, 0)
        Me.gpbAfficheNote.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.gpbAfficheNote.Name = "gpbAfficheNote"
        Me.gpbAfficheNote.Padding = New System.Windows.Forms.Padding(20)
        Me.gpbAfficheNote.Size = New System.Drawing.Size(602, 189)
        Me.gpbAfficheNote.TabIndex = 1
        Me.gpbAfficheNote.TabStop = False
        Me.gpbAfficheNote.Text = "Note"
        '
        'lblNote
        '
        Me.lblNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNote.BackColor = System.Drawing.Color.White
        Me.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(20, 60)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(15)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(562, 109)
        Me.lblNote.TabIndex = 0
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrNote
        '
        Me.tmrNote.Interval = 1000
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(10, 98)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(262, 605)
        Me.txtTotal.TabIndex = 2
        '
        'btnFont
        '
        Me.btnFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFont.Location = New System.Drawing.Point(22, 12)
        Me.btnFont.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(250, 69)
        Me.btnFont.TabIndex = 8
        Me.btnFont.Text = "Police"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'splitDebug
        '
        Me.splitDebug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitDebug.Location = New System.Drawing.Point(0, 0)
        Me.splitDebug.Name = "splitDebug"
        '
        'splitDebug.Panel1
        '
        Me.splitDebug.Panel1.Controls.Add(Me.splitParamNote)
        '
        'splitDebug.Panel2
        '
        Me.splitDebug.Panel2.Controls.Add(Me.btnFont)
        Me.splitDebug.Panel2.Controls.Add(Me.txtTotal)
        Me.splitDebug.Panel2MinSize = 0
        Me.splitDebug.Size = New System.Drawing.Size(888, 723)
        Me.splitDebug.SplitterDistance = 602
        Me.splitDebug.TabIndex = 3
        '
        'splitParamNote
        '
        Me.splitParamNote.BackColor = System.Drawing.Color.PeachPuff
        Me.splitParamNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitParamNote.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitParamNote.Location = New System.Drawing.Point(0, 0)
        Me.splitParamNote.Name = "splitParamNote"
        Me.splitParamNote.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitParamNote.Panel1
        '
        Me.splitParamNote.Panel1.Controls.Add(Me.gpbParamteres)
        '
        'splitParamNote.Panel2
        '
        Me.splitParamNote.Panel2.Controls.Add(Me.gpbAfficheNote)
        Me.splitParamNote.Size = New System.Drawing.Size(602, 723)
        Me.splitParamNote.SplitterDistance = 530
        Me.splitParamNote.TabIndex = 0
        '
        'nupRepetitionNote
        '
        Me.nupRepetitionNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupRepetitionNote.BackColor = System.Drawing.Color.Black
        Me.nupRepetitionNote.ForeColor = System.Drawing.Color.LawnGreen
        Me.nupRepetitionNote.Location = New System.Drawing.Point(378, 141)
        Me.nupRepetitionNote.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.nupRepetitionNote.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nupRepetitionNote.Name = "nupRepetitionNote"
        Me.nupRepetitionNote.Size = New System.Drawing.Size(99, 47)
        Me.nupRepetitionNote.TabIndex = 3
        Me.nupRepetitionNote.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'nupNbNote
        '
        Me.nupNbNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupNbNote.BackColor = System.Drawing.Color.Black
        Me.nupNbNote.ForeColor = System.Drawing.Color.LawnGreen
        Me.nupNbNote.Location = New System.Drawing.Point(378, 88)
        Me.nupNbNote.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.nupNbNote.Name = "nupNbNote"
        Me.nupNbNote.Size = New System.Drawing.Size(99, 47)
        Me.nupNbNote.TabIndex = 2
        Me.nupNbNote.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nupVolume
        '
        Me.nupVolume.BackColor = System.Drawing.Color.Black
        Me.nupVolume.ForeColor = System.Drawing.Color.LawnGreen
        Me.nupVolume.Location = New System.Drawing.Point(378, 91)
        Me.nupVolume.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.nupVolume.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nupVolume.Name = "nupVolume"
        Me.nupVolume.Size = New System.Drawing.Size(99, 47)
        Me.nupVolume.TabIndex = 1
        Me.nupVolume.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'nupInterval
        '
        Me.nupInterval.BackColor = System.Drawing.Color.Black
        Me.nupInterval.ForeColor = System.Drawing.Color.LawnGreen
        Me.nupInterval.Location = New System.Drawing.Point(13, 52)
        Me.nupInterval.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.nupInterval.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nupInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupInterval.Name = "nupInterval"
        Me.nupInterval.Size = New System.Drawing.Size(189, 47)
        Me.nupInterval.TabIndex = 0
        Me.nupInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nupInterval.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'tmrDecompte
        '
        Me.tmrDecompte.Max = 4
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(888, 723)
        Me.Controls.Add(Me.splitDebug)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "Principale"
        Me.Text = "Générateur de note de musique"
        Me.gpbParamteres.ResumeLayout(False)
        Me.gpbParamNote.ResumeLayout(False)
        Me.gpbParamNote.PerformLayout()
        Me.gpbVoix.ResumeLayout(False)
        Me.gpbVoix.PerformLayout()
        Me.gpbDélai.ResumeLayout(False)
        Me.gpbAfficheNote.ResumeLayout(False)
        Me.splitDebug.Panel1.ResumeLayout(False)
        Me.splitDebug.Panel2.ResumeLayout(False)
        Me.splitDebug.Panel2.PerformLayout()
        CType(Me.splitDebug, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitDebug.ResumeLayout(False)
        Me.splitParamNote.Panel1.ResumeLayout(False)
        Me.splitParamNote.Panel2.ResumeLayout(False)
        CType(Me.splitParamNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitParamNote.ResumeLayout(False)
        CType(Me.nupRepetitionNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNbNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbParamteres As GroupBox
    Friend WithEvents gpbAfficheNote As GroupBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblNote As Label
    Friend WithEvents tmrNote As Timer
    Friend WithEvents chkBemol As CheckBox
    Friend WithEvents chkDiese As CheckBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblNbNote As Label
    Friend WithEvents btnFont As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents btnDebug As Button
    Friend WithEvents splitDebug As SplitContainer
    Friend WithEvents splitParamNote As SplitContainer
    Friend WithEvents gpbDélai As GroupBox
    Friend WithEvents lblVitesse As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HVitesse As HScrollBar
    Friend WithEvents lblRepetition As Label
    Friend WithEvents gpbParamNote As GroupBox
    Friend WithEvents gpbVoix As GroupBox
    Friend WithEvents nupInterval As MyNup
    Friend WithEvents nupNbNote As MyNup
    Friend WithEvents nupVolume As MyNup
    Friend WithEvents nupRepetitionNote As MyNup
    Friend WithEvents lblMax As Label
    Friend WithEvents tmrDecompte As TimerDecompte
End Class
