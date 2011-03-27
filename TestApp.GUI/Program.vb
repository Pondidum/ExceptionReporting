Imports Core

Public Module Program

    Sub Main()

        BugTracker.AddHandler(New ExceptionHandlers.EmailExceptionHandler())
        BugTracker.AddHandler(New ExceptionView())

        LazyBugTracker.AddHandler(Function() New ExceptionHandlers.EmailExceptionHandler())
        LazyBugTracker.AddHandler(Function() New ExceptionView())

        CascadeBugTracker.SetHandler(New ExceptionOptionView(New ExceptionHandlers.EmailCascadeExceptionHandler(),
                                                             New ExceptionHandlers.DatabaseCascadeExceptionHandler()))

        Application.Run(New MainView)

    End Sub

End Module