Public Class TimerDecompte
    Inherits Timer
    Public Event Completed()
    Public Event ReadValue(value As Short)
    Private m_actual As Short

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(_ctnr As System.ComponentModel.IContainer)
        MyBase.New(_ctnr)
    End Sub
    Public Property Max As Integer = 4
    Protected Sub ReadActual()
        RaiseEvent ReadValue(m_actual)
    End Sub
    Public Overloads Sub Start()
        m_actual = 1
        ReadActual()
        MyBase.Start()

    End Sub

    Private Sub TimerDecompte_Tick(sender As Object, e As EventArgs) Handles Me.Tick
        m_actual += 1
        If m_actual <= Max Then
            ReadActual()
        Else
            MyBase.Stop()
            RaiseEvent Completed()
        End If
    End Sub
End Class
