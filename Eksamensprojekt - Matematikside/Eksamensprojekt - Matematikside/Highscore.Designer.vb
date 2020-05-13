<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highscore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Highscore))
        Me.Pbox_Tilbage_Highscore = New System.Windows.Forms.PictureBox()
        Me.Lbl_TitelHighscore = New System.Windows.Forms.Label()
        Me.Lbl_Navn = New System.Windows.Forms.Label()
        Me.Lbl_Highscore = New System.Windows.Forms.Label()
        Me.Lbl_Hscore = New System.Windows.Forms.Label()
        Me.Lbl_Brugernavn = New System.Windows.Forms.Label()
        CType(Me.Pbox_Tilbage_Highscore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pbox_Tilbage_Highscore
        '
        Me.Pbox_Tilbage_Highscore.Image = CType(resources.GetObject("Pbox_Tilbage_Highscore.Image"), System.Drawing.Image)
        Me.Pbox_Tilbage_Highscore.Location = New System.Drawing.Point(12, 12)
        Me.Pbox_Tilbage_Highscore.Name = "Pbox_Tilbage_Highscore"
        Me.Pbox_Tilbage_Highscore.Size = New System.Drawing.Size(35, 35)
        Me.Pbox_Tilbage_Highscore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pbox_Tilbage_Highscore.TabIndex = 6
        Me.Pbox_Tilbage_Highscore.TabStop = False
        '
        'Lbl_TitelHighscore
        '
        Me.Lbl_TitelHighscore.AutoSize = True
        Me.Lbl_TitelHighscore.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TitelHighscore.Location = New System.Drawing.Point(325, 20)
        Me.Lbl_TitelHighscore.Name = "Lbl_TitelHighscore"
        Me.Lbl_TitelHighscore.Size = New System.Drawing.Size(120, 27)
        Me.Lbl_TitelHighscore.TabIndex = 7
        Me.Lbl_TitelHighscore.Text = "Highscore"
        '
        'Lbl_Navn
        '
        Me.Lbl_Navn.AutoSize = True
        Me.Lbl_Navn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Navn.Location = New System.Drawing.Point(161, 154)
        Me.Lbl_Navn.Name = "Lbl_Navn"
        Me.Lbl_Navn.Size = New System.Drawing.Size(57, 22)
        Me.Lbl_Navn.TabIndex = 8
        Me.Lbl_Navn.Text = "Navn:"
        '
        'Lbl_Highscore
        '
        Me.Lbl_Highscore.AutoSize = True
        Me.Lbl_Highscore.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Highscore.Location = New System.Drawing.Point(161, 193)
        Me.Lbl_Highscore.Name = "Lbl_Highscore"
        Me.Lbl_Highscore.Size = New System.Drawing.Size(101, 22)
        Me.Lbl_Highscore.TabIndex = 9
        Me.Lbl_Highscore.Text = "Highscore:"
        '
        'Lbl_Hscore
        '
        Me.Lbl_Hscore.AutoSize = True
        Me.Lbl_Hscore.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Hscore.Location = New System.Drawing.Point(268, 193)
        Me.Lbl_Hscore.Name = "Lbl_Hscore"
        Me.Lbl_Hscore.Size = New System.Drawing.Size(21, 22)
        Me.Lbl_Hscore.TabIndex = 10
        Me.Lbl_Hscore.Text = "0"
        '
        'Lbl_Brugernavn
        '
        Me.Lbl_Brugernavn.AutoSize = True
        Me.Lbl_Brugernavn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Brugernavn.Location = New System.Drawing.Point(233, 154)
        Me.Lbl_Brugernavn.Name = "Lbl_Brugernavn"
        Me.Lbl_Brugernavn.Size = New System.Drawing.Size(0, 22)
        Me.Lbl_Brugernavn.TabIndex = 11
        '
        'Highscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Brugernavn)
        Me.Controls.Add(Me.Lbl_Hscore)
        Me.Controls.Add(Me.Lbl_Highscore)
        Me.Controls.Add(Me.Lbl_Navn)
        Me.Controls.Add(Me.Lbl_TitelHighscore)
        Me.Controls.Add(Me.Pbox_Tilbage_Highscore)
        Me.Name = "Highscore"
        Me.Text = "Highscore"
        CType(Me.Pbox_Tilbage_Highscore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pbox_Tilbage_Highscore As PictureBox
    Friend WithEvents Lbl_TitelHighscore As Label
    Friend WithEvents Lbl_Navn As Label
    Friend WithEvents Lbl_Highscore As Label
    Friend WithEvents Lbl_Hscore As Label
    Friend WithEvents Lbl_Brugernavn As Label
End Class
