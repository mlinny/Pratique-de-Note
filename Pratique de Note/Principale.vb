Imports System.Threading.Tasks

Public Class Principale

#Region "Load "
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        splitDebug.Panel2Collapsed = True
        nupInterval.Value = My.Settings.iDelai
        nupNbNote.Value = My.Settings.iRepetition
        If My.Settings.sFont IsNot Nothing Then
            'Me.Font = My.Settings.sFont
        End If
        ApplyTraitementActif(False)
        LoadSoundReader()
    End Sub
    Private Sub nupInterval_ValueChanged(sender As Object, e As EventArgs) Handles nupInterval.ValueChanged
        tmrNote.Interval = (60 / nupInterval.Value) * 1000
        tmrDecompte.Interval = tmrNote.Interval
        My.Settings.iDelai = nupInterval.Value

    End Sub
    Private m_sapi As Object
    Private Sub LoadSoundReader()
        m_sapi = CreateObject("SAPI.spvoice")
        m_sapi.Rate = HVitesse.Value
        m_sapi.Volume = nupVolume.Value * 10
    End Sub


#End Region

#Region " Recherche de note & Timer "

    Private Sub tmrNote_Tick(sender As Object, e As EventArgs) Handles tmrNote.Tick
        Try
            PerformNoteSearch()
            If nupNbNote.Value > 0 AndAlso m_count >= nupNbNote.Value Then
                PerformStop()
            End If
        Catch ex As Exception
            MessageBox.Show("Il y a eu une erreur pendant le traitement, le détail est en 'Debug'.", "Erreur dans le traitement", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotal.Text = ex.ToString()
        End Try

    End Sub

    Private Sub PerformNoteSearch()
        If m_notePvd Is Nothing Then Exit Sub
        Dim note As Note = m_notePvd.GetUneNote()
        lblNote.Text = NoteProvider.GetLibelle(note)
        txtTotal.Text += $"{lblNote.Text} "
        ReadNote(NoteProvider.GetAudioNote(note))
        m_count += 1

    End Sub

#End Region
    Private Sub ReadNote(_note As String)
        'Un using n'est pas possible, ca provoque des décalages dans la lecture
        Dim t As New Task(Sub() m_sapi.Speak(_note))
        t.Start()
    End Sub


#Region " Start/Stop & button "
    Private m_notePvd As NoteProvider
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If tmrNote.Enabled OrElse tmrDecompte.Enabled Then
            PerformStop()
        Else
            PerformStart()
        End If

    End Sub
    Private Sub PerformStart()
        m_iteration += 1
        m_count = 0
        m_notePvd = New NoteProvider(Short.Parse(nupRepetitionNote.Value), chkDiese.Checked, chkBemol.Checked)
        txtTotal.Text += $"Itération {m_iteration} {Environment.NewLine}"
        ActiveControles(False)
        tmrDecompte.Start()
        ApplyTraitementActif(True)


    End Sub
    Private Sub ActiveControles(_actif As Boolean)
        Me.gpbParamNote.Enabled = _actif
        gpbDélai.Enabled = _actif
    End Sub
    Private Sub PerformStop()
        tmrDecompte.Stop()
        tmrNote.Stop()
        txtTotal.Text += Environment.NewLine
        ActiveControles(True)
        ApplyTraitementActif(False)
    End Sub

    Private Sub ApplyTraitementActif(_actif As Boolean)
        If _actif Then
            btnStart.Text = "STOP"
        Else
            btnStart.Text = "START"
        End If
    End Sub

#End Region

    Private m_iteration As Short = 0
    Private m_count As Short = 0

    Private Sub nupNbNote_ValueChanged(sender As Object, e As EventArgs) Handles nupNbNote.ValueChanged
        My.Settings.iRepetition = nupNbNote.Value
    End Sub


#Region " Zone Debug"

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        FontDialog1.Font = Me.Font
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Me.Font = FontDialog1.Font
            My.Settings.sFont = Me.Font
        End If
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        splitDebug.Panel2Collapsed = Not splitDebug.Panel2Collapsed
    End Sub

    Private Sub lblNote_SizeChanged(sender As Object, e As EventArgs) Handles lblNote.SizeChanged
        Dim policeTaille As Single = lblNote.Height / 1.8
        lblNote.Font = New Font(Me.lblNote.Font.FontFamily, policeTaille)
    End Sub

    Private Sub nupVitesse_ValueChanged(sender As Object, e As EventArgs) Handles HVitesse.ValueChanged
        'Dim t As New SpeechLib.SpVoice
        If m_sapi Is Nothing Then Exit Sub
        m_sapi.Rate = HVitesse.Value
    End Sub

    Private Sub nupVolume_ValueChanged(sender As Object, e As EventArgs) Handles nupVolume.ValueChanged
        If m_sapi Is Nothing Then Exit Sub
        m_sapi.Volume = nupVolume.Value * 10
    End Sub

    Private Sub chkBemol_CheckedChanged(sender As Object, e As EventArgs) Handles chkBemol.CheckedChanged
        ActualiseMaxNoteDispo()
    End Sub
    Private Sub ActualiseMaxNoteDispo()
        lblMax.Text = NoteProvider.GetNotesDisponibles(chkDiese.Checked, chkBemol.Checked).Count - 1
    End Sub
    Private Sub chkDiese_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiese.CheckedChanged
        ActualiseMaxNoteDispo()
    End Sub

    Private Sub tmrDecompte_Completed() Handles tmrDecompte.Completed
        PerformNoteSearch() '1ère note à réaliser
        tmrNote.Start()
    End Sub

    Private Sub tmrDecompte_ReadValue(value As Short) Handles tmrDecompte.ReadValue
        ReadNote(value.ToString())
    End Sub

#End Region

End Class
