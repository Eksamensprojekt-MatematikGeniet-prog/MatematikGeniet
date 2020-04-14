Public Class Forside
    Private Sub But_2G_Click(sender As Object, e As EventArgs) Handles But_2G.Click
        Andenårgang.Show() 'Hvis man trykker på knappen vil siden komme frem
        Me.Hide() 'Samtidig vil denne side gemme sig så man ikke kan se den
    End Sub

    Private Sub But_Highscore_Click(sender As Object, e As EventArgs) Handles But_Highscore.Click
        Highscore.Show() 'Hvis man trykker på knappen vil siden komme frem
        Me.Hide() 'Denne side vil så gemme sig så man ikke kan se den 
    End Sub
End Class