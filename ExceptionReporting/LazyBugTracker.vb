
Public Class LazyBugTracker

    Private Shared ReadOnly _tracker As LazyBugTrackerImpl

    Shared Sub New()
        _tracker = New LazyBugTrackerImpl
    End Sub

    Public Shared Sub [AddHandler](ByVal handler As Func(Of IExceptionHandler))
        _tracker.AddHandler(handler)
    End Sub

    Public Shared Sub Report(ByVal ex As Exception)
        _tracker.Report(ex)
    End Sub

    Public Shared Sub Report(ByVal ex As Exception, ByVal level As Level)
        _tracker.Report(ex, level)
    End Sub

    Public Enum Level
        Silent
        Custom
        Loud
    End Enum


End Class
