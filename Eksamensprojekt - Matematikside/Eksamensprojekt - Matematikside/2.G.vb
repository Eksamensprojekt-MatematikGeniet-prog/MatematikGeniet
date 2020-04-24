Public Class Andenårgang
    Private Sub But_TrigonomiskeFunktioner_Click(sender As Object, e As EventArgs) Handles But_TrigonomiskeFunktioner.Click
        Trigonomiske_funktioner.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub

    Private Sub But_VektorIPlanet_Click(sender As Object, e As EventArgs) Handles But_VektorIPlanet.Click
        Vektor_i_planet.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub

    Private Sub Pbox_Tilbage_2G_Click(sender As Object, e As EventArgs) Handles Pbox_Tilbage_2G.Click
        Forside.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub
End Class