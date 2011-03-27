Namespace ExceptionHandlers

    Public Class DatabaseExceptionHandler
        Implements IExceptionHandler

        Public ReadOnly Property [Continue] As Boolean Implements IExceptionHandler.Continue
            Get
                Return True
            End Get
        End Property

        Public Sub Report(ByVal ex As System.Exception, ByVal level As BugTracker.Level) Implements IExceptionHandler.Report
            Debug.WriteLine(String.Format("Reporting from {0} [{1}]", Me.GetType().Name, level))
        End Sub

    End Class

End Namespace
