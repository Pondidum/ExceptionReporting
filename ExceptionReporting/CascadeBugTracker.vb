
Public Class CascadeBugTracker

    Private Shared ReadOnly _tracker As CascadeBugTrackerImpl

    Shared Sub New()
        _tracker = New CascadeBugTrackerImpl()
    End Sub

    Public Shared Sub SetHandler(ByVal handler As ICascadeExceptionHandler)
        _tracker.SetHandler(handler)
    End Sub

    Public Shared Sub Report(ByVal ex As Exception)
        _tracker.Report(ex)
    End Sub

    Public Shared Sub Report(ByVal ex As Exception, ByVal level As CascadeBugTracker.Level)
        _tracker.Report(ex, level)
    End Sub

    Public Enum Level
        Silent
        Custom
        Loud
    End Enum

End Class
