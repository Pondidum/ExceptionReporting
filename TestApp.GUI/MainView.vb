Imports Core

Public Class MainView

    Private Sub btnSilent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBugTrackerSilent.Click
        BugTracker.Report(New ArgumentNullException("test", "This is a Silent exception"), BugTracker.Level.Silent)
    End Sub

    Private Sub btnCustom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBugTrackerCustom.Click
        BugTracker.Report(New ArgumentNullException("test", "This is a Custom exception"), BugTracker.Level.Custom)
    End Sub

    Private Sub btnLoud_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBugTrackerLoud.Click
        BugTracker.Report(New ArgumentNullException("test", "This is a Loud exception"), BugTracker.Level.Loud)
    End Sub

End Class
