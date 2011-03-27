Namespace ExceptionHandlers

    Public Class DatabaseExceptionHandler
        Implements IExceptionHandler

        Public ReadOnly Property [Continue] As Boolean Implements IExceptionHandler.Continue
            Get

            End Get
        End Property

        Public Sub Report(ByVal ex As System.Exception, ByVal level As BugTracker.Level) Implements IExceptionHandler.Report

        End Sub

    End Class

End Namespace
