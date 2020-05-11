Public Class Vektor_i_planet
    Private Sub Pbox_Tilbage_TrigonomiskeFunktioner_Click(sender As Object, e As EventArgs) Handles Pbox_Tilbage_TrigonomiskeFunktioner.Click
        Andenårgang.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub

    Private Sub But_opg1a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1a_tjek.Click
        If Txtbox_opg1a.Text = "5,8310" Then 'Sætter tekstboxen en værdi
            Lbl_statusOpg1a.Text = "Rigtig"
            But_opg1a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg1a.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg1b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1b_tjek.Click
        If Txtbox_opg1b.Text = "7, -2" Then
            Lbl_statusOpg1b.Text = "Rigtig"
            But_opg1b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg1b.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg2a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2a_tjek.Click
        If Txtbox_opg2a.Text = "4,4721" Then
            Lbl_statusOpg2a.Text = "Rigtig"
            But_opg2a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg2a.Text = "Forkert"
        End If
    End Sub

    Private Sub But_opg2b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2b_tjek.Click
        If Txtbox_opg2b.Text = "5, 3" Then
            Lbl_statusOpg2b.Text = "Rigtig"
            But_opg2b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else
            Lbl_statusOpg2b.Text = "Forkert"
        End If
    End Sub
End Class