<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vektor_i_planet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vektor_i_planet))
        Me.Pbox_Tilbage_TrigonomiskeFunktioner = New System.Windows.Forms.PictureBox()
        Me.Lbl_TitelVektorIPlanet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Pbox_Tilbage_TrigonomiskeFunktioner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pbox_Tilbage_TrigonomiskeFunktioner
        '
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Image = CType(resources.GetObject("Pbox_Tilbage_TrigonomiskeFunktioner.Image"), System.Drawing.Image)
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Location = New System.Drawing.Point(12, 12)
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Name = "Pbox_Tilbage_TrigonomiskeFunktioner"
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Size = New System.Drawing.Size(35, 35)
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.TabIndex = 5
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.TabStop = False
        '
        'Lbl_TitelVektorIPlanet
        '
        Me.Lbl_TitelVektorIPlanet.AutoSize = True
        Me.Lbl_TitelVektorIPlanet.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TitelVektorIPlanet.Location = New System.Drawing.Point(63, 12)
        Me.Lbl_TitelVektorIPlanet.Name = "Lbl_TitelVektorIPlanet"
        Me.Lbl_TitelVektorIPlanet.Size = New System.Drawing.Size(142, 24)
        Me.Lbl_TitelVektorIPlanet.TabIndex = 6
        Me.Lbl_TitelVektorIPlanet.Text = "Vektor i planet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "242 og 243"
        '
        'Vektor_i_planet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_TitelVektorIPlanet)
        Me.Controls.Add(Me.Pbox_Tilbage_TrigonomiskeFunktioner)
        Me.Name = "Vektor_i_planet"
        Me.Text = "Vektor i planet"
        CType(Me.Pbox_Tilbage_TrigonomiskeFunktioner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pbox_Tilbage_TrigonomiskeFunktioner As PictureBox
    Friend WithEvents Lbl_TitelVektorIPlanet As Label
    Friend WithEvents Label1 As Label
End Class
