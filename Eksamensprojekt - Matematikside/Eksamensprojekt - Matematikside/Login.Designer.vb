<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.But_test = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'But_test
        '
        Me.But_test.BackColor = System.Drawing.Color.Turquoise
        Me.But_test.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_test.Location = New System.Drawing.Point(640, 372)
        Me.But_test.Name = "But_test"
        Me.But_test.Size = New System.Drawing.Size(75, 23)
        Me.But_test.TabIndex = 0
        Me.But_test.Text = "Test"
        Me.But_test.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.But_test)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents But_test As Button
End Class
