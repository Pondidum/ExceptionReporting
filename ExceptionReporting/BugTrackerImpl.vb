
Friend Class BugTrackerImpl

    Private ReadOnly _handlers As List(Of IExceptionHandler)

    Public Sub New()
        _handlers = New List(Of IExceptionHandler)
    End Sub

    Public Sub [AddHandler](ByVal handler As IExceptionHandler)

        If handler Is Nothing Then Throw New ArgumentNullException("handler")
        _handlers.Add(handler)

    End Sub

    Public Sub Report(ByVal ex As Exception)
        Report(ex, BugTracker.Level.Loud)
    End Sub

    Public Sub Report(ByVal ex As Exception, ByVal level As BugTracker.Level)

        For Each handler In _handlers

            handler.Report(ex, level)

            If Not handler.Continue Then
                Exit For
            End If

        Next

    End Sub

End Class