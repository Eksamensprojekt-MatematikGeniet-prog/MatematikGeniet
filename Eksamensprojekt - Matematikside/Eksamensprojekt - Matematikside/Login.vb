Public Class Login
    Dim user As String '"user" bliver sat til en variabel, så den kan bruges senere
    Dim pass As String '"pass" bliver sat til en variabel, så den kan bruges senere
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_status.Visible = False 'Bliver Lbl_status usynlig
    End Sub
    Private Sub But_Login_Click(sender As Object, e As EventArgs) Handles But_login.Click 'Hvis man klikker på knappen, sker det nedenstående
        user = "admin" 'Variablen "user" bliver sat til "admin"
        pass = "admin" 'Variablen "pass" bliver sat til "admin"
        If (user = Txtbox_Brugernavn.Text And pass = Txtbox_Adgangskode.Text) Then 'Hvis både teksten der skrives til username og password er ens, så:
            Me.Hide() 'Lukker formen for login-siden
            Forside.Show() 'Viser formen for hovedsiden
        ElseIf (user <> Txtbox_Brugernavn.Text And pass <> Txtbox_Adgangskode.Text) Then 'Ellers hvis brugernavn og adgangskode ikke er rigtigt så:
            Lbl_status.Visible = True 'Bliver Lbl_status synlig
        End If
    End Sub
End Class