
Public Interface ICascadeExceptionHandler

    ReadOnly Property NextHandler As ICascadeExceptionHandler

    Sub Report(ByVal ex As Exception, ByVal level As BugTracker.Level)

End Interface