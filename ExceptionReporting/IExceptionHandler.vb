
Public Interface IExceptionHandler

    ReadOnly Property [Continue] As Boolean

    Sub Report(ByVal ex As Exception, ByVal level As BugTracker.Level)

End Interface
