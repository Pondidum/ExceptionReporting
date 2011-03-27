Imports Core

Public Module Program

    Sub Main()

        BugTracker.AddHandler(New ExceptionHandlers.EmailExceptionHandler())
        BugTracker.AddHandler(New ExceptionView())

        LazyBugTracker.AddHandler(Function() New ExceptionHandlers.EmailExceptionHandler())
        LazyBugTracker.AddHandler(Function() New ExceptionView())

        Application.Run(New MainView)

    End Sub

End Module