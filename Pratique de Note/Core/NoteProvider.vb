Public Enum Note
    Unknown = -1
    [Do] '= 0
    Re '= 2
    Mi '= 4
    Fa '= 5
    Sol '= 7
    La '= 9
    Si '= 11

    Do_diese '= 1
    Re_diese '= 3
    Mi_diese '= 5
    Fa_diese '= 6
    Sol_diese '= 8
    La_diese '= 10
    Si_diese '= 0

    Do_bemol '= 11
    Re_bemol '= 1
    Mi_bemol '= 3
    Fa_bemol '= 4
    Sol_bemol ' = 6
    La_bemol '= 8
    Si_bemol '= 10

    '♭
    '♯
End Enum

Public Class NoteProvider
    Private Shared ms_randomize As New Random
    Private m_previous As System.Collections.Queue
    Private m_blocRepetition As Short
    Public ReadOnly NotesDisponibles As List(Of Note)

    Public Sub New(_blocRepetition As Short, _avecDiese As Boolean, _avecBemol As Boolean)
        m_blocRepetition = _blocRepetition
        m_previous = New Queue()
        NotesDisponibles = GetNotesDisponibles(_avecDiese, _avecBemol)
    End Sub

    Public Shared Function GetNotesDisponibles(_avecDiese As Boolean, _avecBemol As Boolean) As List(Of Note)
        Dim values As New List(Of Note)
        values.AddRange(GetNoteDeBase())
        If _avecDiese Then values.AddRange(GetNotesDieses())
        If _avecBemol Then values.AddRange(GetNotesBemols())
        Return values
    End Function

    Public Function GetUneNote() As Note
        'Dim rnd As New Random()
        Dim max As Integer = NotesDisponibles.Count
        Dim result As Integer = ms_randomize.Next(max)
        If m_previous.Count > m_blocRepetition Then m_previous.Dequeue()
        While m_previous.Contains(result)
            result = ms_randomize.Next(max)
        End While
        m_previous.Enqueue(result)
        Return NotesDisponibles(result)
    End Function

    Public Shared Function GetLibelle(_note As Note) As String
        Select Case _note
            Case Note.Do_bemol : Return "Do ♭"
            Case Note.Re_bemol : Return "Ré ♭"
            Case Note.Mi_bemol : Return "Mi ♭"
            Case Note.Fa_bemol : Return "Fa ♭"
            Case Note.Sol_bemol : Return "Sol ♭"
            Case Note.La_bemol : Return "La ♭"
            Case Note.Si_bemol : Return "Si ♭"

            Case Note.Do_diese : Return "Do ♯"
            Case Note.Re_diese : Return "Ré ♯"
            Case Note.Mi_diese : Return "Mi ♯"
            Case Note.Fa_diese : Return "Fa ♯"
            Case Note.Sol_diese : Return "Sol ♯"
            Case Note.La_diese : Return "La ♯"
            Case Note.Si_diese : Return "Si ♯"
        End Select
        Return _note.ToString()
    End Function

    Public Shared Function GetAudioNote(_note As Note) As String
        Select Case _note
            Case Note.Do_bemol : Return "Do bémol"
            Case Note.Re_bemol : Return "Ré bémol"
            Case Note.Mi_bemol : Return "Mi bémol"
            Case Note.Fa_bemol : Return "Fa bémol"
            Case Note.Sol_bemol : Return "Sol bémol"
            Case Note.La_bemol : Return "La bémol"
            Case Note.Si_bemol : Return "Si bémol"

            Case Note.Do_diese : Return "Do dièse"
            Case Note.Re_diese : Return "Ré dièse"
            Case Note.Mi_diese : Return "Mi dièse"
            Case Note.Fa_diese : Return "Fa dièse"
            Case Note.Sol_diese : Return "Sol dièse"
            Case Note.La_diese : Return "La dièse"
            Case Note.Si_diese : Return "Si dièse"

            Case Note.Re : Return "Ré"

        End Select
        Return _note.ToString()
    End Function



    Private Shared Function GetNotesBemols() As IEnumerable(Of Note)
        Return {Note.Do_bemol, Note.Re_bemol, Note.Mi_bemol, Note.Fa_bemol, Note.Sol_bemol, Note.La_bemol, Note.Si_bemol}
    End Function

    Private Shared Function GetNotesDieses() As IEnumerable(Of Note)
        Return {Note.Do_diese, Note.Re_diese, Note.Mi_diese, Note.Fa_diese, Note.Sol_diese, Note.La_diese, Note.Si_diese}
    End Function

    Private Shared Function GetNoteDeBase() As IEnumerable(Of Note)
        Return {Note.Do, Note.Re, Note.Mi, Note.Fa, Note.Sol, Note.La, Note.Si}
    End Function
End Class
