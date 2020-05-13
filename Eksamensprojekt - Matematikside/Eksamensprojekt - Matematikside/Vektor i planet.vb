Public Class Vektor_i_planet
    Dim buttonClickCount As Integer = 0 'Vi laver en variabel der kan holde styr på hvor mange gange man trykker på en knap. Dens startværdi bliver sat til 0
    Private Sub Pbox_Tilbage_TrigonomiskeFunktioner_Click(sender As Object, e As EventArgs) Handles Pbox_Tilbage_TrigonomiskeFunktioner.Click
        Andenårgang.Show() 'Når man trykker på knappen vil denne side vises
        Me.Hide() 'Når man trykker på knappen vil denne side gemmes, så den ikke kan ses
    End Sub

    Private Sub But_opg1a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1a_tjek.Click
        buttonClickCount += 1 'Den tæller 1 op, når man trykker på knappen "tjek"
        Dim fileReader As String 'fileReader bliver sat til string, da det skal bruges senere i et tekstdokument

        If buttonClickCount = 1 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 1 gang og hvis man skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100
        ElseIf buttonClickCount = 2 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 2 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 10 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 10 = 90
        ElseIf buttonClickCount = 3 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 3 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 20 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 20 = 80
        ElseIf buttonClickCount = 4 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 4 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 30 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 30 = 70
        ElseIf buttonClickCount = 5 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 5 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 40 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 40 = 60
        ElseIf buttonClickCount = 6 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 6 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 50 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 50 = 50
        ElseIf buttonClickCount = 7 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 7 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 60 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 60 = 40
        ElseIf buttonClickCount = 8 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 8 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 70 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 70 = 30
        ElseIf buttonClickCount = 9 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 9 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 80 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 80 = 20
        ElseIf buttonClickCount = 10 And Txtbox_opg1a.Text = "5,8310" Then 'Hvis tjek knappen trykkes 10 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 90 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 90 = 10
        ElseIf buttonClickCount = 11 And Txtbox_opg2b.Text = "5,8310" Then 'Hvis tjek knappen trykkes 11 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
        End If

        If Txtbox_opg1a.Text = "5,8310" Then 'hvis man skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1a.Text = "Rigtig" 'vil status skrive rigtig
            But_opg1a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        ElseIf buttonClickCount > 10 Then 'hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1a.Text = "Forkert" 'vil status skrive forkert
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
            But_opg1a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        End If

        If Highscore.Lbl_Hscore.Text > 0 Then 'Hvis scoren i Lbl_HScore er større end 0, så:
            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
               Login.Txtbox_Brugernavn.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")

            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
                 Highscore.Lbl_Hscore.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")
        End If
    End Sub

    Private Sub But_opg1b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg1b_tjek.Click
        buttonClickCount += 1 'Den tæller 1 op, når man trykker på knappen "tjek"
        Dim fileReader As String 'fileReader bliver sat til string, da det skal bruges senere i et tekstdokument

        If buttonClickCount = 1 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 1 gang og hvis man skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100
        ElseIf buttonClickCount = 2 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 2 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 10 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 10 = 90
        ElseIf buttonClickCount = 3 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 3 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 20 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 20 = 80
        ElseIf buttonClickCount = 4 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 4 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 30 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 30 = 70
        ElseIf buttonClickCount = 5 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 5 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 40 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 40 = 60
        ElseIf buttonClickCount = 6 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 6 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 50 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 50 = 50
        ElseIf buttonClickCount = 7 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 7 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 60 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 60 = 40
        ElseIf buttonClickCount = 8 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 8 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 70 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 70 = 30
        ElseIf buttonClickCount = 9 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 9 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 80 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 80 = 20
        ElseIf buttonClickCount = 10 And Txtbox_opg1b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 10 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 90 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 90 = 10
        ElseIf buttonClickCount = 11 And Txtbox_opg2b.Text = "7, -2" Then 'Hvis tjek knappen trykkes 11 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
        End If

        If Txtbox_opg1b.Text = "7, -2" Then 'Hvis man skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1b.Text = "Rigtig" 'vil status skrive rigtig
            But_opg1b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        ElseIf buttonClickCount = 11 Then 'hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg1b.Text = "Forkert" 'vil status skrive forkert
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
            But_opg1b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        End If

        If Highscore.Lbl_Hscore.Text > 0 Then 'Hvis scoren i Lbl_HScore er større end 0, så:
            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
               Login.Txtbox_Brugernavn.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")

            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
                 Highscore.Lbl_Hscore.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")
        End If
    End Sub

    Private Sub But_opg2a_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2a_tjek.Click
        buttonClickCount += 1 'Den tæller 1 op, når man trykker på knappen "tjek"
        Dim fileReader As String 'fileReader bliver sat til string, da det skal bruges senere i et tekstdokument

        If buttonClickCount = 1 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 1 gang og hvis man skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100
        ElseIf buttonClickCount = 2 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 2 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 10 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 10 = 90
        ElseIf buttonClickCount = 3 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 3 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 20 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 20 = 80
        ElseIf buttonClickCount = 4 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 4 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 30 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 30 = 70
        ElseIf buttonClickCount = 5 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 5 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 40 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 40 = 60
        ElseIf buttonClickCount = 6 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 6 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 50 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 50 = 50
        ElseIf buttonClickCount = 7 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 7 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 60 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 60 = 40
        ElseIf buttonClickCount = 8 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 8 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 70 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 70 = 30
        ElseIf buttonClickCount = 9 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 9 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 80 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 80 = 20
        ElseIf buttonClickCount = 10 And Txtbox_opg2a.Text = "4,4721" Then 'Hvis tjek knappen trykkes 10 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 90 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 90 = 10
        ElseIf buttonClickCount = 11 And Txtbox_opg2b.Text = "4,4721" Then 'Hvis tjek knappen trykkes 11 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
        End If

        If Txtbox_opg2a.Text = "4,4721" Then 'Hvis man skriver den rigtige værdi ind i tekstfeltet 
            Lbl_statusOpg2a.Text = "Rigtig" 'vil status skrive rigtig
            But_opg2a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        ElseIf buttonClickCount = 11 Then 'hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg2a.Text = "Forkert" 'vil status skrive forkert
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
            But_opg2a_tjek.Enabled = False 'Man kan ikke klikke på knappen
        End If

        If Highscore.Lbl_Hscore.Text > 0 Then 'Hvis scoren i Lbl_HScore er større end 0, så:
            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
               Login.Txtbox_Brugernavn.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")

            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
                 Highscore.Lbl_Hscore.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")
        End If
    End Sub

    Private Sub But_opg2b_tjek_Click(sender As Object, e As EventArgs) Handles But_opg2b_tjek.Click
        buttonClickCount += 1 'Den tæller 1 op, når man trykker på knappen "tjek"
        Dim fileReader As String 'fileReader bliver sat til string, da det skal bruges senere i et tekstdokument

        If buttonClickCount = 1 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 1 gang og hvis man skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100
        ElseIf buttonClickCount = 2 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 2 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 10 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 10 = 90
        ElseIf buttonClickCount = 3 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 3 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 20 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 20 = 80
        ElseIf buttonClickCount = 4 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 4 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 30 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 30 = 70
        ElseIf buttonClickCount = 5 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 5 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 40 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 40 = 60
        ElseIf buttonClickCount = 6 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 6 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 50 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 50 = 50
        ElseIf buttonClickCount = 7 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 7 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 60 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 60 = 40
        ElseIf buttonClickCount = 8 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 8 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 70 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 70 = 30
        ElseIf buttonClickCount = 9 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 9 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 80 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 80 = 20
        ElseIf buttonClickCount = 10 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 10 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 90 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 90 = 10
        ElseIf buttonClickCount = 11 And Txtbox_opg2b.Text = "5, 3" Then 'Hvis tjek knappen trykkes 11 gange og hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
        End If

        If Txtbox_opg2b.Text = "5, 3" Then 'Hvis man skriver den rigtige værdi ind i tekstfeltet 
            Lbl_statusOpg2b.Text = "Rigtig" 'vil status skrive rigtig
            But_opg2b_tjek.Enabled = False 'Man kan ikke klikke på knappen
        ElseIf buttonClickCount = 11 Then 'hvis man ikke skriver den rigtige værdi ind i tekstfeltet
            Lbl_statusOpg2b.Text = "Forkert" 'vil status skrive forkert
            Highscore.Lbl_Hscore.Text = score2 - 100 'den sætter Lbl.Hscore til score2, som er en variabel sat til 100 - 100 = 0
            But_opg2b_tjek.Enabled = False 'Man kan ikke klikke på knappe
        End If

        If Highscore.Lbl_Hscore.Text > 0 Then 'Hvis scoren i Lbl_HScore er større end 0, så:
            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
               Login.Txtbox_Brugernavn.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")

            My.Computer.FileSystem.WriteAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore",
                 Highscore.Lbl_Hscore.Text, True)
            fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Bruger\Downloads\HTX\HTX 2g\Programmering\Eksamensprojekt - Matematikside\Highscore")
        End If
    End Sub
End Class