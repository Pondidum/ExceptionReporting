<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBugTrackerSilent = New System.Windows.Forms.Button()
        Me.btnBugTrackerCustom = New System.Windows.Forms.Button()
        Me.btnBugTrackerLoud = New System.Windows.Forms.Button()
        Me.grpBugTracker = New System.Windows.Forms.GroupBox()
        Me.grpLazyBugTracker = New System.Windows.Forms.GroupBox()
        Me.btnLazyBugTrackerSilent = New System.Windows.Forms.Button()
        Me.btnLazyBugTrackerCustom = New System.Windows.Forms.Button()
        Me.btnLazyBugTrackerLoud = New System.Windows.Forms.Button()
        Me.grpCascasedBugTracker = New System.Windows.Forms.GroupBox()
        Me.btnCascadedBugTrackerSilent = New System.Windows.Forms.Button()
        Me.btnCascadedBugTrackerCustom = New System.Windows.Forms.Button()
        Me.btnCascadedBugTrackerLoud = New System.Windows.Forms.Button()
        Me.grpBugTracker.SuspendLayout()
        Me.grpLazyBugTracker.SuspendLayout()
        Me.grpCascasedBugTracker.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBugTrackerSilent
        '
        Me.btnBugTrackerSilent.Location = New System.Drawing.Point(6, 19)
        Me.btnBugTrackerSilent.Name = "btnBugTrackerSilent"
        Me.btnBugTrackerSilent.Size = New System.Drawing.Size(140, 23)
        Me.btnBugTrackerSilent.TabIndex = 0
        Me.btnBugTrackerSilent.Text = "Silent Exception"
        Me.btnBugTrackerSilent.UseVisualStyleBackColor = True
        '
        'btnBugTrackerCustom
        '
        Me.btnBugTrackerCustom.Location = New System.Drawing.Point(6, 48)
        Me.btnBugTrackerCustom.Name = "btnBugTrackerCustom"
        Me.btnBugTrackerCustom.Size = New System.Drawing.Size(140, 23)
        Me.btnBugTrackerCustom.TabIndex = 1
        Me.btnBugTrackerCustom.Text = "Custom Exception"
        Me.btnBugTrackerCustom.UseVisualStyleBackColor = True
        '
        'btnBugTrackerLoud
        '
        Me.btnBugTrackerLoud.Location = New System.Drawing.Point(6, 77)
        Me.btnBugTrackerLoud.Name = "btnBugTrackerLoud"
        Me.btnBugTrackerLoud.Size = New System.Drawing.Size(140, 23)
        Me.btnBugTrackerLoud.TabIndex = 2
        Me.btnBugTrackerLoud.Text = "Loud Exception"
        Me.btnBugTrackerLoud.UseVisualStyleBackColor = True
        '
        'grpBugTracker
        '
        Me.grpBugTracker.Controls.Add(Me.btnBugTrackerSilent)
        Me.grpBugTracker.Controls.Add(Me.btnBugTrackerLoud)
        Me.grpBugTracker.Controls.Add(Me.btnBugTrackerCustom)
        Me.grpBugTracker.Location = New System.Drawing.Point(12, 12)
        Me.grpBugTracker.Name = "grpBugTracker"
        Me.grpBugTracker.Size = New System.Drawing.Size(152, 106)
        Me.grpBugTracker.TabIndex = 0
        Me.grpBugTracker.TabStop = False
        Me.grpBugTracker.Text = "BugTracker"
        '
        'grpLazyBugTracker
        '
        Me.grpLazyBugTracker.Controls.Add(Me.btnLazyBugTrackerSilent)
        Me.grpLazyBugTracker.Controls.Add(Me.btnLazyBugTrackerCustom)
        Me.grpLazyBugTracker.Controls.Add(Me.btnLazyBugTrackerLoud)
        Me.grpLazyBugTracker.Location = New System.Drawing.Point(170, 12)
        Me.grpLazyBugTracker.Name = "grpLazyBugTracker"
        Me.grpLazyBugTracker.Size = New System.Drawing.Size(152, 106)
        Me.grpLazyBugTracker.TabIndex = 1
        Me.grpLazyBugTracker.TabStop = False
        Me.grpLazyBugTracker.Text = "LazyBugTracker"
        '
        'btnLazyBugTrackerSilent
        '
        Me.btnLazyBugTrackerSilent.Location = New System.Drawing.Point(6, 19)
        Me.btnLazyBugTrackerSilent.Name = "btnLazyBugTrackerSilent"
        Me.btnLazyBugTrackerSilent.Size = New System.Drawing.Size(140, 23)
        Me.btnLazyBugTrackerSilent.TabIndex = 0
        Me.btnLazyBugTrackerSilent.Text = "Silent Exception"
        Me.btnLazyBugTrackerSilent.UseVisualStyleBackColor = True
        '
        'btnLazyBugTrackerCustom
        '
        Me.btnLazyBugTrackerCustom.Location = New System.Drawing.Point(6, 48)
        Me.btnLazyBugTrackerCustom.Name = "btnLazyBugTrackerCustom"
        Me.btnLazyBugTrackerCustom.Size = New System.Drawing.Size(140, 23)
        Me.btnLazyBugTrackerCustom.TabIndex = 1
        Me.btnLazyBugTrackerCustom.Text = "Custom Exception"
        Me.btnLazyBugTrackerCustom.UseVisualStyleBackColor = True
        '
        'btnLazyBugTrackerLoud
        '
        Me.btnLazyBugTrackerLoud.Location = New System.Drawing.Point(6, 77)
        Me.btnLazyBugTrackerLoud.Name = "btnLazyBugTrackerLoud"
        Me.btnLazyBugTrackerLoud.Size = New System.Drawing.Size(140, 23)
        Me.btnLazyBugTrackerLoud.TabIndex = 2
        Me.btnLazyBugTrackerLoud.Text = "Loud Exception"
        Me.btnLazyBugTrackerLoud.UseVisualStyleBackColor = True
        '
        'grpCascasedBugTracker
        '
        Me.grpCascasedBugTracker.Controls.Add(Me.btnCascadedBugTrackerSilent)
        Me.grpCascasedBugTracker.Controls.Add(Me.btnCascadedBugTrackerCustom)
        Me.grpCascasedBugTracker.Controls.Add(Me.btnCascadedBugTrackerLoud)
        Me.grpCascasedBugTracker.Location = New System.Drawing.Point(328, 12)
        Me.grpCascasedBugTracker.Name = "grpCascasedBugTracker"
        Me.grpCascasedBugTracker.Size = New System.Drawing.Size(152, 106)
        Me.grpCascasedBugTracker.TabIndex = 2
        Me.grpCascasedBugTracker.TabStop = False
        Me.grpCascasedBugTracker.Text = "CascadedBugTracker"
        '
        'btnCascadedBugTrackerSilent
        '
        Me.btnCascadedBugTrackerSilent.Location = New System.Drawing.Point(6, 19)
        Me.btnCascadedBugTrackerSilent.Name = "btnCascadedBugTrackerSilent"
        Me.btnCascadedBugTrackerSilent.Size = New System.Drawing.Size(140, 23)
        Me.btnCascadedBugTrackerSilent.TabIndex = 0
        Me.btnCascadedBugTrackerSilent.Text = "Silent Exception"
        Me.btnCascadedBugTrackerSilent.UseVisualStyleBackColor = True
        '
        'btnCascadedBugTrackerCustom
        '
        Me.btnCascadedBugTrackerCustom.Location = New System.Drawing.Point(6, 48)
        Me.btnCascadedBugTrackerCustom.Name = "btnCascadedBugTrackerCustom"
        Me.btnCascadedBugTrackerCustom.Size = New System.Drawing.Size(140, 23)
        Me.btnCascadedBugTrackerCustom.TabIndex = 1
        Me.btnCascadedBugTrackerCustom.Text = "Custom Exception"
        Me.btnCascadedBugTrackerCustom.UseVisualStyleBackColor = True
        '
        'btnCascadedBugTrackerLoud
        '
        Me.btnCascadedBugTrackerLoud.Location = New System.Drawing.Point(6, 77)
        Me.btnCascadedBugTrackerLoud.Name = "btnCascadedBugTrackerLoud"
        Me.btnCascadedBugTrackerLoud.Size = New System.Drawing.Size(140, 23)
        Me.btnCascadedBugTrackerLoud.TabIndex = 2
        Me.btnCascadedBugTrackerLoud.Text = "Loud Exception"
        Me.btnCascadedBugTrackerLoud.UseVisualStyleBackColor = True
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 130)
        Me.Controls.Add(Me.grpBugTracker)
        Me.Controls.Add(Me.grpLazyBugTracker)
        Me.Controls.Add(Me.grpCascasedBugTracker)
        Me.Name = "MainView"
        Me.Text = "MainView"
        Me.grpBugTracker.ResumeLayout(False)
        Me.grpLazyBugTracker.ResumeLayout(False)
        Me.grpCascasedBugTracker.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBugTrackerSilent As System.Windows.Forms.Button
    Friend WithEvents btnBugTrackerCustom As System.Windows.Forms.Button
    Friend WithEvents btnBugTrackerLoud As System.Windows.Forms.Button
    Friend WithEvents grpBugTracker As System.Windows.Forms.GroupBox
    Friend WithEvents grpLazyBugTracker As System.Windows.Forms.GroupBox
    Friend WithEvents btnLazyBugTrackerSilent As System.Windows.Forms.Button
    Friend WithEvents btnLazyBugTrackerLoud As System.Windows.Forms.Button
    Friend WithEvents btnLazyBugTrackerCustom As System.Windows.Forms.Button
    Friend WithEvents grpCascasedBugTracker As System.Windows.Forms.GroupBox
    Friend WithEvents btnCascadedBugTrackerSilent As System.Windows.Forms.Button
    Friend WithEvents btnCascadedBugTrackerLoud As System.Windows.Forms.Button
    Friend WithEvents btnCascadedBugTrackerCustom As System.Windows.Forms.Button

End Class
