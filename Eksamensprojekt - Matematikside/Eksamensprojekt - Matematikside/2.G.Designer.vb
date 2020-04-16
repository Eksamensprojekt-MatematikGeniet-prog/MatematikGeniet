<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Andenårgang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Andenårgang))
        Me.Lbl_Info2G = New System.Windows.Forms.Label()
        Me.But_TrigonomiskeFunktioner = New System.Windows.Forms.Button()
        Me.But_VektorIPlanet = New System.Windows.Forms.Button()
        Me.Pbox_Tilbage_2G = New System.Windows.Forms.PictureBox()
        Me.Lbl_Titel2G = New System.Windows.Forms.Label()
        CType(Me.Pbox_Tilbage_2G, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Info2G
        '
        Me.Lbl_Info2G.AutoSize = True
        Me.Lbl_Info2G.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info2G.Location = New System.Drawing.Point(352, 79)
        Me.Lbl_Info2G.Name = "Lbl_Info2G"
        Me.Lbl_Info2G.Size = New System.Drawing.Size(105, 18)
        Me.Lbl_Info2G.TabIndex = 0
        Me.Lbl_Info2G.Text = "Vælg et emne"
        '
        'But_TrigonomiskeFunktioner
        '
        Me.But_TrigonomiskeFunktioner.BackColor = System.Drawing.SystemColors.ControlDark
        Me.But_TrigonomiskeFunktioner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_TrigonomiskeFunktioner.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_TrigonomiskeFunktioner.Location = New System.Drawing.Point(323, 178)
        Me.But_TrigonomiskeFunktioner.Name = "But_TrigonomiskeFunktioner"
        Me.But_TrigonomiskeFunktioner.Size = New System.Drawing.Size(168, 53)
        Me.But_TrigonomiskeFunktioner.TabIndex = 1
        Me.But_TrigonomiskeFunktioner.Text = "Trigonomiske fuktioner"
        Me.But_TrigonomiskeFunktioner.UseVisualStyleBackColor = False
        '
        'But_VektorIPlanet
        '
        Me.But_VektorIPlanet.BackColor = System.Drawing.SystemColors.ControlDark
        Me.But_VektorIPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_VektorIPlanet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_VektorIPlanet.Location = New System.Drawing.Point(323, 270)
        Me.But_VektorIPlanet.Name = "But_VektorIPlanet"
        Me.But_VektorIPlanet.Size = New System.Drawing.Size(168, 53)
        Me.But_VektorIPlanet.TabIndex = 2
        Me.But_VektorIPlanet.Text = "Vektor i planet"
        Me.But_VektorIPlanet.UseVisualStyleBackColor = False
        '
        'Pbox_Tilbage_2G
        '
        Me.Pbox_Tilbage_2G.Image = CType(resources.GetObject("Pbox_Tilbage_2G.Image"), System.Drawing.Image)
        Me.Pbox_Tilbage_2G.Location = New System.Drawing.Point(12, 12)
        Me.Pbox_Tilbage_2G.Name = "Pbox_Tilbage_2G"
        Me.Pbox_Tilbage_2G.Size = New System.Drawing.Size(35, 35)
        Me.Pbox_Tilbage_2G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pbox_Tilbage_2G.TabIndex = 3
        Me.Pbox_Tilbage_2G.TabStop = False
        '
        'Lbl_Titel2G
        '
        Me.Lbl_Titel2G.AutoSize = True
        Me.Lbl_Titel2G.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titel2G.Location = New System.Drawing.Point(280, 39)
        Me.Lbl_Titel2G.Name = "Lbl_Titel2G"
        Me.Lbl_Titel2G.Size = New System.Drawing.Size(241, 24)
        Me.Lbl_Titel2G.TabIndex = 4
        Me.Lbl_Titel2G.Text = "Matematik for 2.G elever"
        '
        'Andenårgang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Titel2G)
        Me.Controls.Add(Me.Pbox_Tilbage_2G)
        Me.Controls.Add(Me.But_VektorIPlanet)
        Me.Controls.Add(Me.But_TrigonomiskeFunktioner)
        Me.Controls.Add(Me.Lbl_Info2G)
        Me.Name = "Andenårgang"
        Me.Text = "2.G"
        CType(Me.Pbox_Tilbage_2G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Info2G As Label
    Friend WithEvents But_TrigonomiskeFunktioner As Button
    Friend WithEvents But_VektorIPlanet As Button
    Friend WithEvents Pbox_Tilbage_2G As PictureBox
    Friend WithEvents Lbl_Titel2G As Label
End Class
