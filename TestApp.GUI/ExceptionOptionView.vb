Imports Core

Public Class ExceptionOptionView
    Implements Core.ICascadeExceptionHandler

    Private ReadOnly _emailHandler As ICascadeExceptionHandler
    Private ReadOnly _storeHandler As ICascadeExceptionHandler

    Private _nextHandler As Core.ICascadeExceptionHandler

    Public Sub New(ByVal emailHandler As ICascadeExceptionHandler, ByVal storeHandler As ICascadeExceptionHandler)

        InitializeComponent()

        If emailHandler Is Nothing Then Throw New ArgumentNullException("emailHandler")
        If storeHandler Is Nothing Then Throw New ArgumentNullException("storeHandler")

        _emailHandler = emailHandler
        _storeHandler = storeHandler

        _nextHandler = _emailHandler

    End Sub

    Public ReadOnly Property NextHandler As Core.ICascadeExceptionHandler Implements Core.ICascadeExceptionHandler.NextHandler
        Get
            Return _nextHandler
        End Get
    End Property

    Public Sub Report(ByVal ex As System.Exception, ByVal level As Core.BugTracker.Level) Implements Core.ICascadeExceptionHandler.Report
        Debug.WriteLine(String.Format("Reporting from {0} [{1}]", Me.GetType().Name, level))

        Me.Text = ex.Message
        lblMessage.Text = ex.ToString()

        _nextHandler = _emailHandler

        If level = Core.BugTracker.Level.Loud Then
            Me.ShowDialog()
        End If

    End Sub
    
    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        _nextHandler = _emailHandler
        Me.Close()
    End Sub

    Private Sub btnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStore.Click
        _nextHandler = _storeHandler
        Me.Close()
    End Sub

End Class
