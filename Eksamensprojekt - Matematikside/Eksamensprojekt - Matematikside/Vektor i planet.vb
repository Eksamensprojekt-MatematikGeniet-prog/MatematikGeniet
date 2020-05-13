Public Class Vektor_i_planet
    Private Sub Pbox_Tilbage_TrigonomiskeFunktioner_Click(sender As Object, e As EventArgs) Handles Pbox_Tilbage_TrigonomiskeFunktioner.Click
        Andenårgang.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub

    Private Sub But_opg1a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1a_tjek.Click
        If Txtbox_opg1a.Text = "5,8310" Then 'Hvis man skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1a.Text = "Rigtig" 'vil status skrive rigtig
            But_opg1a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else 'Hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1a.Text = "Forkert" 'vil status skrive forkert
        End If
    End Sub

    Private Sub But_opg1b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1b_tjek.Click
        If Txtbox_opg1b.Text = "7, -2" Then 'Hvis man skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1b.Text = "Rigtig" 'vil status skrive rigtig
            But_opg1b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else 'Hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1b.Text = "Forkert" 'vil status skrive forkert
        End If
    End Sub

    Private Sub But_opg2a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2a_tjek.Click
        If Txtbox_opg2a.Text = "4,4721" Then 'Hvis man skriver den rigtige værdi ind i tekstfeltet 
            Lbl_statusOpg2a.Text = "Rigtig" 'vil status skrive rigtig
            But_opg2a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else 'Hvis man ikke skriver den rigtige værdi ind i tekstfeltet 
            Lbl_statusOpg2a.Text = "Forkert" 'vil status skrive forkert
        End If
    End Sub

    Private Sub But_opg2b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2b_tjek.Click
        If Txtbox_opg2b.Text = "5, 3" Then 'Hvis man skriver den rigtige værdi ind i tekstfeltet 
            Lbl_statusOpg2b.Text = "Rigtig" 'vil status skrive rigtig
            But_opg2b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        Else 'Hvis man ikke skriver den rigtige værdi ind i tekstfeltet 
            Lbl_statusOpg2b.Text = "Forkert" 'vil status skrive forkert
        End If
    End Sub
End Class