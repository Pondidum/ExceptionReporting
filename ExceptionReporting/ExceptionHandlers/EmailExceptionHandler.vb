Namespace ExceptionHandlers

    Public Class EmailExceptionHandler
        Implements IExceptionHandler

        Public ReadOnly Property [Continue] As Boolean Implements IExceptionHandler.Continue
            Get
                Return True
            End Get
        End Property

        Public Sub Report(ByVal ex As System.Exception, ByVal level As BugTracker.Level) Implements IExceptionHandler.Report

            Dim message = New Net.Mail.MailMessage()

            message.To.Add("errors@example.com")
            message.Subject = ex.Message
            message.Body = ex.ToString
            'message.Attachments.Add(New Net.Mail.Attachment(ex.SerializeToXml())

            Dim smpt = New Net.Mail.SmtpClient()
            'smpt.Send(message)
            
        End Sub

    End Class

End Namespace
