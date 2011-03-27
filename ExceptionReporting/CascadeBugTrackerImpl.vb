
Friend Class CascadeBugTrackerImpl

    Private _handler As ICascadeExceptionHandler

    Public Sub SetHandler(ByVal handler As ICascadeExceptionHandler)

        If handler Is Nothing Then Throw New ArgumentNullException("handler")

        _handler = handler

    End Sub

    Public Sub Report(ByVal ex As Exception)
        Report(ex, CascadeBugTracker.Level.Loud)
    End Sub

    Public Sub Report(ByVal ex As Exception, ByVal level As CascadeBugTracker.Level)

        If _handler Is Nothing Then Throw New ArgumentNullException("handler", "SetHandler has not been called.")

        Dim handler = _handler

        Do

            handler.Report(ex, level)
            handler = handler.NextHandler

        Loop Until handler Is Nothing
        
    End Sub

End Class
