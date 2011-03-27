
Public Class LazyBugTrackerImpl

    Private ReadOnly _handlers As List(Of Func(Of IExceptionHandler))

    Public Sub New()
        _handlers = New List(Of Func(Of IExceptionHandler))
    End Sub

    Public Sub [AddHandler](ByVal handler As Func(Of IExceptionHandler))

        If handler Is Nothing Then Throw New ArgumentNullException("handler")

        _handlers.Add(handler)

    End Sub

    Public Sub Report(ByVal ex As Exception)
        Report(ex, LazyBugTracker.Level.Loud)
    End Sub

    Public Sub Report(ByVal ex As Exception, ByVal level As LazyBugTracker.Level)

        For Each handler In _handlers

            Dim instance = handler.Invoke()

            instance.Report(ex, level)

            If Not instance.Continue Then
                Exit For
            End If

        Next

    End Sub

End Class
