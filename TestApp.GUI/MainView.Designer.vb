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
        Me.btnSilent = New System.Windows.Forms.Button()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.btnLoud = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSilent
        '
        Me.btnSilent.Location = New System.Drawing.Point(12, 12)
        Me.btnSilent.Name = "btnSilent"
        Me.btnSilent.Size = New System.Drawing.Size(128, 23)
        Me.btnSilent.TabIndex = 0
        Me.btnSilent.Text = "Silent Exception"
        Me.btnSilent.UseVisualStyleBackColor = True
        '
        'btnCustom
        '
        Me.btnCustom.Location = New System.Drawing.Point(12, 41)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(128, 23)
        Me.btnCustom.TabIndex = 1
        Me.btnCustom.Text = "Custom Exception"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'btnLoud
        '
        Me.btnLoud.Location = New System.Drawing.Point(12, 70)
        Me.btnLoud.Name = "btnLoud"
        Me.btnLoud.Size = New System.Drawing.Size(128, 23)
        Me.btnLoud.TabIndex = 2
        Me.btnLoud.Text = "Loud Exception"
        Me.btnLoud.UseVisualStyleBackColor = True
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnLoud)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.btnSilent)
        Me.Name = "MainView"
        Me.Text = "MainView"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSilent As System.Windows.Forms.Button
    Friend WithEvents btnCustom As System.Windows.Forms.Button
    Friend WithEvents btnLoud As System.Windows.Forms.Button

End Class
