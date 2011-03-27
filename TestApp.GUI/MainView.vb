Imports Core

Public Class MainView

    Private Sub btnBugTrackerSilent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBugTrackerSilent.Click
        BugTracker.Report(New ArgumentNullException("test", "This is a Silent exception"), BugTracker.Level.Silent)
    End Sub

    Private Sub btnBugTrackerCustom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBugTrackerCustom.Click
        BugTracker.Report(New ArgumentNullException("test", "This is a Custom exception"), BugTracker.Level.Custom)
    End Sub

    Private Sub btnBugTrackerLoud_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBugTrackerLoud.Click
        BugTracker.Report(New ArgumentNullException("test", "This is a Loud exception"), BugTracker.Level.Loud)
    End Sub



    Private Sub btnLazyBugTrackerSilent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLazyBugTrackerSilent.Click
        LazyBugTracker.Report(New ArgumentNullException("test", "This is a lazy Silent exception"), LazyBugTracker.Level.Silent)
    End Sub

    Private Sub btnLazyBugTrackerCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLazyBugTrackerCustom.Click
        LazyBugTracker.Report(New ArgumentNullException("test", "This is a lazy Custom exception"), LazyBugTracker.Level.Custom)
    End Sub

    Private Sub btnLazyBugTrackerLoud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLazyBugTrackerLoud.Click
        LazyBugTracker.Report(New ArgumentNullException("test", "This is a lazy Loud exception"), LazyBugTracker.Level.Loud)
    End Sub



    Private Sub btnCascadedBugTrackerSilent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCascadedBugTrackerSilent.Click
        CascadeBugTracker.Report(New ArgumentNullException("test", "This is a cascade Silent exception"), CascadeBugTracker.Level.Silent)
    End Sub

    Private Sub btnCascadedBugTrackerCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCascadedBugTrackerCustom.Click
        CascadeBugTracker.Report(New ArgumentNullException("test", "This is a cascade Custom exception"), CascadeBugTracker.Level.Custom)
    End Sub

    Private Sub btnCascadedBugTrackerLoud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCascadedBugTrackerLoud.Click
        CascadeBugTracker.Report(New ArgumentNullException("test", "This is a cascade Loud exception"), CascadeBugTracker.Level.Loud)
    End Sub

End Class
