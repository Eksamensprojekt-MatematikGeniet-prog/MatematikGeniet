﻿Public Class Trigonomiske_funktioner
    Private Sub Pbox_Tilbage_TrigonomiskeFunktioner_Click(sender As Object, e As EventArgs) Handles Pbox_Tilbage_TrigonomiskeFunktioner.Click
        Andenårgang.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub

    Private Sub But_opg1a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1a_tjek.Click
        If Txtbox_opg1a.Text = "57,2958" Then
            Lbl_statusOpg1a.Text = "Rigtig"
            But_opg1a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg1a.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg1b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1b_tjek.Click
        If Txtbox_opg1b.Text = "134,4617" Then
            Lbl_statusOpg1b.Text = "Rigtig"
            But_opg1b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg1b.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg1c_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1c_tjek.Click
        If Txtbox_opg1c.Text = "231,7958" Then
            Lbl_statusOpg1c.Text = "Rigtig"
            But_opg1c_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg1c.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg1d_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1d_tjek.Click
        If Txtbox_opg1d.Text = "342,2392" Then
            Lbl_statusOpg1d.Text = "Rigtig"
            But_opg1d_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg1d.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg2a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2a_tjek.Click
        If Txtbox_opg2a.Text = "0,9460" Then
            Lbl_statusOpg2a.Text = "Rigtig"
            But_opg2a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg2a.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg2b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2b_tjek.Click
        If Txtbox_opg2b.Text = "2,3702" Then
            Lbl_statusOpg2b.Text = "Rigtig"
            But_opg2b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg2b.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg2c_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2c_tjek.Click
        If Txtbox_opg2c.Text = "4,4803" Then
            Lbl_statusOpg2c.Text = "Rigtig"
            But_opg2c_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg2c.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg2d_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2d_tjek.Click
        If Txtbox_opg2d.Text = "5,9638" Then
            Lbl_statusOpg2d.Text = "Rigtig"
            But_opg2d_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg2d.Text = "Forkert"
        End If
    End Sub
End Class