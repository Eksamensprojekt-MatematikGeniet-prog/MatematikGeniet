Public Class Highscore
    Private Sub Highscore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Lbl_Brugernavn.Text = Login.Txtbox_Brugernavn.Text 'Lbl_Brugernavn.Text opdateres til, hvad der skrevet i Txtbox__Brugernavn på loginsiden
    End Sub

    Private Sub Pbox_Tilbage_Highscore_Click(sender As Object, e As EventArgs) Handles Pbox_Tilbage_Highscore.Click
        Forside.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub
End Class