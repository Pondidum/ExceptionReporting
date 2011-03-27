<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExceptionOptionView
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
        Me.pctIcon = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnStore = New System.Windows.Forms.Button()
        CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctIcon
        '
        Me.pctIcon.Image = Global.TestApp.GUI.My.Resources.Resources.bug
        Me.pctIcon.Location = New System.Drawing.Point(12, 12)
        Me.pctIcon.Name = "pctIcon"
        Me.pctIcon.Size = New System.Drawing.Size(48, 48)
        Me.pctIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctIcon.TabIndex = 1
        Me.pctIcon.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.Location = New System.Drawing.Point(66, 12)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(302, 72)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Label1"
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(112, 87)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnEmail.TabIndex = 3
        Me.btnEmail.Text = "Email"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(193, 87)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(75, 23)
        Me.btnStore.TabIndex = 4
        Me.btnStore.Text = "Store"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'ExceptionOptionView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 122)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStore)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.pctIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExceptionOptionView"
        Me.ShowInTaskbar = False
        Me.Text = "ExceptionView"
        CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents btnStore As System.Windows.Forms.Button
End Class
