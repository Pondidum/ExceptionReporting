Namespace ExceptionHandlers

    Public Class DatabaseCascadeExceptionHandler
        Implements ICascadeExceptionHandler

        Public ReadOnly Property NextHandler As ICascadeExceptionHandler Implements ICascadeExceptionHandler.NextHandler
            Get
                Return Nothing
            End Get
        End Property

        Public Sub Report(ByVal ex As System.Exception, ByVal level As BugTracker.Level) Implements ICascadeExceptionHandler.Report
            Debug.WriteLine(String.Format("Reporting from {0} [{1}]", Me.GetType().Name, level))
        End Sub

    End Class

End Namespace
