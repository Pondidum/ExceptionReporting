Public Class BugTracker

    Private Shared ReadOnly _tracker As BugTrackerImpl

    Shared Sub New()
        _tracker = New BugTrackerImpl
    End Sub

    Public Shared Sub [AddHandler](ByVal handler As IExceptionHandler)
        _tracker.AddHandler(handler)
    End Sub

    Public Shared Sub Report(ByVal ex As Exception)
        _tracker.Report(ex)
    End Sub

    Public Shared Sub Report(ByVal ex As Exception, ByVal level As BugTracker.Level)
        _tracker.Report(ex, level)
    End Sub

    Public Enum Level
        Silent
        Custom
        Loud
    End Enum

End Class