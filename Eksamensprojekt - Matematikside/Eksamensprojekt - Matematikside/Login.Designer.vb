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
        Me.Lbl_status = New System.Windows.Forms.Label()
        Me.But_login = New System.Windows.Forms.Button()
        Me.Txtbox_Brugernavn = New System.Windows.Forms.TextBox()
        Me.Txtbox_Adgangskode = New System.Windows.Forms.TextBox()
        Me.Lbl_Brugernavn = New System.Windows.Forms.Label()
        Me.Lbl_Adgangskode = New System.Windows.Forms.Label()
        Me.Lbl_LoginTitel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_status
        '
        Me.Lbl_status.AutoSize = True
        Me.Lbl_status.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_status.ForeColor = System.Drawing.Color.Red
        Me.Lbl_status.Location = New System.Drawing.Point(268, 124)
        Me.Lbl_status.Name = "Lbl_status"
        Me.Lbl_status.Size = New System.Drawing.Size(239, 16)
        Me.Lbl_status.TabIndex = 1
        Me.Lbl_status.Text = "Brugernavn eller adgangskode er forkert!"
        '
        'But_login
        '
        Me.But_login.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_login.Location = New System.Drawing.Point(336, 286)
        Me.But_login.Name = "But_login"
        Me.But_login.Size = New System.Drawing.Size(95, 33)
        Me.But_login.TabIndex = 2
        Me.But_login.Text = "Login"
        Me.But_login.UseVisualStyleBackColor = True
        '
        'Txtbox_Brugernavn
        '
        Me.Txtbox_Brugernavn.Location = New System.Drawing.Point(311, 170)
        Me.Txtbox_Brugernavn.Name = "Txtbox_Brugernavn"
        Me.Txtbox_Brugernavn.Size = New System.Drawing.Size(146, 20)
        Me.Txtbox_Brugernavn.TabIndex = 3
        '
        'Txtbox_Adgangskode
        '
        Me.Txtbox_Adgangskode.Location = New System.Drawing.Point(311, 222)
        Me.Txtbox_Adgangskode.Name = "Txtbox_Adgangskode"
        Me.Txtbox_Adgangskode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtbox_Adgangskode.Size = New System.Drawing.Size(146, 20)
        Me.Txtbox_Adgangskode.TabIndex = 4
        '
        'Lbl_Brugernavn
        '
        Me.Lbl_Brugernavn.AutoSize = True
        Me.Lbl_Brugernavn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Brugernavn.Location = New System.Drawing.Point(202, 170)
        Me.Lbl_Brugernavn.Name = "Lbl_Brugernavn"
        Me.Lbl_Brugernavn.Size = New System.Drawing.Size(87, 17)
        Me.Lbl_Brugernavn.TabIndex = 5
        Me.Lbl_Brugernavn.Text = "Brugernavn:"
        '
        'Lbl_Adgangskode
        '
        Me.Lbl_Adgangskode.AutoSize = True
        Me.Lbl_Adgangskode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Adgangskode.Location = New System.Drawing.Point(202, 222)
        Me.Lbl_Adgangskode.Name = "Lbl_Adgangskode"
        Me.Lbl_Adgangskode.Size = New System.Drawing.Size(100, 17)
        Me.Lbl_Adgangskode.TabIndex = 6
        Me.Lbl_Adgangskode.Text = "Adgangskode:"
        '
        'Lbl_LoginTitel
        '
        Me.Lbl_LoginTitel.AutoSize = True
        Me.Lbl_LoginTitel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LoginTitel.Location = New System.Drawing.Point(209, 54)
        Me.Lbl_LoginTitel.Name = "Lbl_LoginTitel"
        Me.Lbl_LoginTitel.Size = New System.Drawing.Size(353, 33)
        Me.Lbl_LoginTitel.TabIndex = 7
        Me.Lbl_LoginTitel.Text = "Login på MatematikGeniet"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_LoginTitel)
        Me.Controls.Add(Me.Lbl_Adgangskode)
        Me.Controls.Add(Me.Lbl_Brugernavn)
        Me.Controls.Add(Me.Txtbox_Adgangskode)
        Me.Controls.Add(Me.Txtbox_Brugernavn)
        Me.Controls.Add(Me.But_login)
        Me.Controls.Add(Me.Lbl_status)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_status As Label
    Friend WithEvents But_login As Button
    Friend WithEvents Txtbox_Brugernavn As TextBox
    Friend WithEvents Txtbox_Adgangskode As TextBox
    Friend WithEvents Lbl_Brugernavn As Label
    Friend WithEvents Lbl_Adgangskode As Label
    Friend WithEvents Lbl_LoginTitel As Label
End Class
