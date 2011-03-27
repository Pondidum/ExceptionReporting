Public Class ExceptionView
    Implements Core.IExceptionHandler

    Public ReadOnly Property [Continue] As Boolean Implements Core.IExceptionHandler.Continue
        Get
            Return False
        End Get
    End Property

    Public Sub Report(ByVal ex As System.Exception, ByVal level As Core.BugTracker.Level) Implements Core.IExceptionHandler.Report

        Debug.WriteLine(String.Format("Reporting from {0} [{1}]", Me.GetType().Name, level))

        Me.Text = ex.Message
        lblMessage.Text = ex.ToString()

        If level = Core.BugTracker.Level.Loud Then
            Me.ShowDialog()
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

End Class
