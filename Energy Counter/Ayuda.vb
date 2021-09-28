Public Class Ayuda

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim valor = Me.ComboBox1.Text
        If (valor = "Español") Then
            Label2.Text = "ESTE PROGRAMA ES ÚTIL PARA LLEVAR LAS CUENTAS DE CUANTA ENERGÍA TIENE TU RIVAL Y PODER ANTICIPARTE A SUS MOVIMIENTOS"
            Label1.Text = "EL BOTÓN +1 ϟ SE CLICKEA CUANDO TU OPONENTE GANÓ 1 DE ENERGÍA"
            Label3.Text = "EL BOTÓN -1 ϟ SE CLICKEA CUANDO LE ROBAS ENERGÍA A TU OPONENTE, O CUANDO GASTA"
            Label4.Text = "EL BOTÓN PRÓXIMA RONDA, ES PARA CUANDO PASAS A LA SIGUIENTE RONDA, SE TE SUMARÁ 2 DE ENERGÍA"
            Label5.Text = "EL BOTÓN NUEVA PARTIDA ES PARA CUANDO TERMINAS LA PARTIDA Y QUIERES EMPEZAR UN NUEVO JUEGO"
            Label6.Text = "TECLAS DE ATAJO"
            Label7.Text = "TECLA [-] : Restará 1 de energía"
            Label8.Text = "TECLA [+] : Sumará 1 de energía"
            Label9.Text = "TECLA [ENTER] : Pasará a la siguiente ronda."
            Label10.Text = "TECLA [0] : Empezará una nueva partida"
            Label11.Text = "IDIOMA"
            Label12.Text = "CREADO POR GAVIDIA#6007"
            Label13.Text = "SI QUIERES APORTAR ALGO EN AGRADECIMIENTO, PUEDES HACERLO A TRAVÉS DE MI RONIN [CLICK PARA COPIAR]"
            ''Form1
            Principal.Label2.Text = "CONTADOR DE ENERGÍA"
            Principal.Label4.Text = "RONDA"
            Principal.Button3.Text = "PRÓXIMA RONDA"
            Principal.Button1.Text = "NUEVO JUEGO"

        End If
        If (valor = "English") Then
            Label2.Text = "THIS PROGRAM IS USEFUL TO KEEP TRACK OF HOW MUCH ENERGY YOUR RIVAL HAS AND TO BE ABLE TO ANTICIPATE HIS MOVEMENTS."
            Label1.Text = "THE +1 ϟ BUTTON CLICKS WHEN YOUR OPPONENT GAINS 1 ENERGY"
            Label3.Text = "THE -1 ϟ BUTTON CLICKS WHEN YOU STEAL ENERGY FROM YOUR OPPONENT OR EXPEND ENERGY"
            Label4.Text = "THE NEXT ROUND BUTTON WILL ADD TWO ENERGY AND GO TO NEXT ROUND"
            Label5.Text = "THE NEW GAME BUTTON IS FOR WHEN YOU FINISH A GAME AND WANT TO START NEW GAME"
            Label6.Text = "SHORTCUT KEYS"
            Label7.Text = "KEY [-] : WILL SUBTRACT 1 ENERGY"
            Label8.Text = "KEY [+] : WILL ADD 1 ENERGY"
            Label9.Text = "KEY [ENTER] : WILL GO TO THE NEXT ROUND."
            Label10.Text = "KEY [0] : START A NEW GAME"
            Label11.Text = "LANGUAGE"
            Label12.Text = "CREATED BY GAVIDIA#6007"
            Label13.Text = "IF YOU WANT TO CONTRIBUTE SOMETHING IN GRATITUDE, YOU CAN DO IT THROUGH MY RONIN [CLICK TO COPY]"
            ''Form1
            Principal.Label2.Text = "ENERGY COUNTER"
            Principal.Label4.Text = "ROUND"
            Principal.Button3.Text = "NEXT ROUND"
            Principal.Button1.Text = "NEW GAME"

        End If

        If (valor = "Tagalog") Then
            Label2.Text = "ANG PROGRAM NA ITO AY KAPAKI-PAKINABANG UPANG SUBAYBAYAN KUNG GAANO KARAMING LAKAS ANG MAYROON ANG IYONG KARIBAL AT MAASAHAN ANG KANYANG MGA PAGGALAW"
            Label1.Text = "ANG +1 ϟ NA PINDUTAN AY NA-CLICK KAPAG NAKAKUHA NG 1 ENERHIYA ANG IYONG KALABAN"
            Label3.Text = "ANG -1 ϟ NA PINDUTAN AY NA-CLICK KAPAG NAKAWIN ANG ENERHIYA MULA SA IYONG KALABAN O GUMASTOS NG ENERHIYA"
            Label4.Text = "ANG SUSUNOD NA PINDUTAN NG PAG-IKOT AY NAGDARAGDAG NG DALAWANG ENERHIYA AT PUPUNTA SA SUSUNOD NA PAG-IKOT"
            Label5.Text = "ANG BAGONG PINDUTAN NG LARO AY PARA SA KAPAG NATAPOS MO ANG ISANG LARO AT NAIS MONG MAGSIMULA NG ISA PA"
            Label6.Text = "MGA SHORTCUT KEY"
            Label7.Text = "SUSI [-] : IBABAWAS ANG 1 ENERHIYA"
            Label8.Text = "SUSI [+] : AY MAGDAGDAG NG 1 ENERHIYA"
            Label9.Text = "SUSI [ENTER] : UPANG PUMUNTA SA SUSUNOD NA PAG-IKOT"
            Label10.Text = "KEY [0] : MAGSIMULA NG ISANG BAGONG LARO"
            Label11.Text = "IDYOMA"
            Label12.Text = "NILIKHA NI GAVIDIA#6007"
            Label13.Text = "KUNG NAIS MONG MAG-AMBAG NG ISANG BAGAY BILANG PASASALAMAT, MAGAGAWA MO ITO SA PAMAMAGITAN NG AKING RONIN [I-CLICK UPANG KOPYAHIN]"

            ''Form1
            Principal.Label2.Text = "METRO NG ENERHIYA"
            Principal.Label4.Text = "BILOG"
            Principal.Button3.Text = "SA SUSUNOD NA ROUND"
            Principal.Button1.Text = "BAGONG LARO"

        End If
    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub


    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Dim valor = ComboBox1.Text
        If (valor = "Español") Then
            My.Computer.Clipboard.SetText("ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")
            MsgBox("¡Texto copiado! ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")

        ElseIf (valor = "English") Then
            My.Computer.Clipboard.SetText("ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")
            MsgBox("¡Text copied! ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")

        ElseIf (valor = "Tagalog") Then
            My.Computer.Clipboard.SetText("ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")
            MsgBox("¡Text copied! ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")

        ElseIf (valor = "") Then
            My.Computer.Clipboard.SetText("ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")
            MsgBox("¡Texto copiado! ronin:38b9b028bf926427d1cbbb3eb25c4732428becb1")
        End If





    End Sub
End Class