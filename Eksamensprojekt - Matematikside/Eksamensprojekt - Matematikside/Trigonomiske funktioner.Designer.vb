﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trigonomiske_funktioner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trigonomiske_funktioner))
        Me.Lbl_TitelTrigonomiskeFunktioner = New System.Windows.Forms.Label()
        Me.Pbox_Tilbage_TrigonomiskeFunktioner = New System.Windows.Forms.PictureBox()
        CType(Me.Pbox_Tilbage_TrigonomiskeFunktioner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_TitelTrigonomiskeFunktioner
        '
        Me.Lbl_TitelTrigonomiskeFunktioner.AutoSize = True
        Me.Lbl_TitelTrigonomiskeFunktioner.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TitelTrigonomiskeFunktioner.Location = New System.Drawing.Point(63, 12)
        Me.Lbl_TitelTrigonomiskeFunktioner.Name = "Lbl_TitelTrigonomiskeFunktioner"
        Me.Lbl_TitelTrigonomiskeFunktioner.Size = New System.Drawing.Size(230, 24)
        Me.Lbl_TitelTrigonomiskeFunktioner.TabIndex = 0
        Me.Lbl_TitelTrigonomiskeFunktioner.Text = "Trigonomiske funktioner"
        '
        'Pbox_Tilbage_TrigonomiskeFunktioner
        '
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Image = CType(resources.GetObject("Pbox_Tilbage_TrigonomiskeFunktioner.Image"), System.Drawing.Image)
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Location = New System.Drawing.Point(12, 12)
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Name = "Pbox_Tilbage_TrigonomiskeFunktioner"
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.Size = New System.Drawing.Size(35, 35)
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.TabIndex = 4
        Me.Pbox_Tilbage_TrigonomiskeFunktioner.TabStop = False
        '
        'Trigonomiske_funktioner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 447)
        Me.Controls.Add(Me.Pbox_Tilbage_TrigonomiskeFunktioner)
        Me.Controls.Add(Me.Lbl_TitelTrigonomiskeFunktioner)
        Me.Name = "Trigonomiske_funktioner"
        Me.Text = "Trigonomiske funktioner"
        CType(Me.Pbox_Tilbage_TrigonomiskeFunktioner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_TitelTrigonomiskeFunktioner As Label
    Friend WithEvents Pbox_Tilbage_TrigonomiskeFunktioner As PictureBox
End Class
