<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forside
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forside))
        Me.Lbl_ForsideTitel = New System.Windows.Forms.Label()
        Me.But_1G = New System.Windows.Forms.Button()
        Me.But_2G = New System.Windows.Forms.Button()
        Me.But_3G = New System.Windows.Forms.Button()
        Me.But_Highscore = New System.Windows.Forms.Button()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.Pbox_Lås3G = New System.Windows.Forms.PictureBox()
        Me.Pbox_Lås1G = New System.Windows.Forms.PictureBox()
        CType(Me.Pbox_Lås3G, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbox_Lås1G, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_ForsideTitel
        '
        Me.Lbl_ForsideTitel.AutoSize = True
        Me.Lbl_ForsideTitel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ForsideTitel.Location = New System.Drawing.Point(185, 63)
        Me.Lbl_ForsideTitel.Name = "Lbl_ForsideTitel"
        Me.Lbl_ForsideTitel.Size = New System.Drawing.Size(433, 33)
        Me.Lbl_ForsideTitel.TabIndex = 0
        Me.Lbl_ForsideTitel.Text = "Velkommen til MatematikGeniet!"
        '
        'But_1G
        '
        Me.But_1G.BackColor = System.Drawing.SystemColors.ControlDark
        Me.But_1G.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_1G.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_1G.Location = New System.Drawing.Point(346, 184)
        Me.But_1G.Name = "But_1G"
        Me.But_1G.Size = New System.Drawing.Size(111, 50)
        Me.But_1G.TabIndex = 1
        Me.But_1G.Text = "1.G"
        Me.But_1G.UseVisualStyleBackColor = False
        '
        'But_2G
        '
        Me.But_2G.BackColor = System.Drawing.SystemColors.ControlDark
        Me.But_2G.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_2G.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_2G.Location = New System.Drawing.Point(346, 253)
        Me.But_2G.Name = "But_2G"
        Me.But_2G.Size = New System.Drawing.Size(111, 50)
        Me.But_2G.TabIndex = 2
        Me.But_2G.Text = "2.G"
        Me.But_2G.UseVisualStyleBackColor = False
        '
        'But_3G
        '
        Me.But_3G.BackColor = System.Drawing.SystemColors.ControlDark
        Me.But_3G.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_3G.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_3G.Location = New System.Drawing.Point(346, 319)
        Me.But_3G.Name = "But_3G"
        Me.But_3G.Size = New System.Drawing.Size(111, 50)
        Me.But_3G.TabIndex = 3
        Me.But_3G.Text = "3.G"
        Me.But_3G.UseVisualStyleBackColor = False
        '
        'But_Highscore
        '
        Me.But_Highscore.BackColor = System.Drawing.SystemColors.ControlDark
        Me.But_Highscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_Highscore.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Highscore.Location = New System.Drawing.Point(646, 391)
        Me.But_Highscore.Name = "But_Highscore"
        Me.But_Highscore.Size = New System.Drawing.Size(103, 31)
        Me.But_Highscore.TabIndex = 4
        Me.But_Highscore.Text = "Highscore"
        Me.But_Highscore.UseVisualStyleBackColor = False
        '
        'Lbl_Info
        '
        Me.Lbl_Info.AutoSize = True
        Me.Lbl_Info.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info.Location = New System.Drawing.Point(295, 113)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(209, 18)
        Me.Lbl_Info.TabIndex = 5
        Me.Lbl_Info.Text = "Vælg din årgang nedenunder"
        '
        'Pbox_Lås3G
        '
        Me.Pbox_Lås3G.Image = CType(resources.GetObject("Pbox_Lås3G.Image"), System.Drawing.Image)
        Me.Pbox_Lås3G.InitialImage = Nothing
        Me.Pbox_Lås3G.Location = New System.Drawing.Point(463, 319)
        Me.Pbox_Lås3G.Name = "Pbox_Lås3G"
        Me.Pbox_Lås3G.Size = New System.Drawing.Size(54, 50)
        Me.Pbox_Lås3G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pbox_Lås3G.TabIndex = 6
        Me.Pbox_Lås3G.TabStop = False
        '
        'Pbox_Lås1G
        '
        Me.Pbox_Lås1G.Image = CType(resources.GetObject("Pbox_Lås1G.Image"), System.Drawing.Image)
        Me.Pbox_Lås1G.InitialImage = Nothing
        Me.Pbox_Lås1G.Location = New System.Drawing.Point(463, 184)
        Me.Pbox_Lås1G.Name = "Pbox_Lås1G"
        Me.Pbox_Lås1G.Size = New System.Drawing.Size(54, 50)
        Me.Pbox_Lås1G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pbox_Lås1G.TabIndex = 7
        Me.Pbox_Lås1G.TabStop = False
        '
        'Forside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Pbox_Lås1G)
        Me.Controls.Add(Me.Pbox_Lås3G)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.But_Highscore)
        Me.Controls.Add(Me.But_3G)
        Me.Controls.Add(Me.But_2G)
        Me.Controls.Add(Me.But_1G)
        Me.Controls.Add(Me.Lbl_ForsideTitel)
        Me.Name = "Forside"
        Me.Text = "Forside"
        CType(Me.Pbox_Lås3G, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbox_Lås1G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ForsideTitel As Label
    Friend WithEvents But_1G As Button
    Friend WithEvents But_2G As Button
    Friend WithEvents But_3G As Button
    Friend WithEvents But_Highscore As Button
    Friend WithEvents Lbl_Info As Label
    Friend WithEvents Pbox_Lås3G As PictureBox
    Friend WithEvents Pbox_Lås1G As PictureBox
End Class
