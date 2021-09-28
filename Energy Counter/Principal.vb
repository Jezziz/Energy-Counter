Public Class Principal


    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub


    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label1.Focus()
        If Label1.Text < 10 Then
            Label1.Text = Val(Label1.Text) + 1
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Focus()
        If Label1.Text > 0 Then
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Focus()
        Label5.Text = Val(Label5.Text) + 1
        If Label1.Text <= 8 Then
            Label1.Text = Val(Label1.Text) + 2
        End If
        If Label1.Text = 9 Then
            Label1.Text = Val(Label1.Text) + 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Focus()
        Label1.Text = 3
        Label5.Text = 1
    End Sub
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 43 Then
            Button4.PerformClick()
        End If
        If Asc(e.KeyChar) = 45 Then
            Button2.PerformClick()
        End If
        If Asc(e.KeyChar) = 13 Then
            Button3.PerformClick()
        End If
        If Asc(e.KeyChar) = 48 Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label1.Focus()
        Dim ayuda As New Ayuda
        ayuda.Show()

        ''MsgBox("EL PROGRAMA ESTÁ DISEÑADO PARA SER UTILIZADO EN AXIE INFINITY. ES ÚTIL PARA SABER CUANTA ENERGÍA TIENE EL RIVAL Y ADIVINAR SU PRÓXIMO MOVIMIENTO. CADA VEZ QUE EL RIVAL TE GASTÉ UNO, O DOS DE ENERGÍA, LO VAS A IR ANOTANDO ÁQUÍ. ASÍ MISMO, SI GANA ENERGÍA LO VAS A IR ANOTANDO AQUÍ PARA LLEVAR LAS CUENTAS DE SU ENERGÍA. ANOTAS TODO LO QUE GASTÓ EN LA RONDA Y LE DAS A SIGUIENTE RONDA PARA SUMAR LOS RESPECTIVOS 2 DE ENERGÍA AL MOMENTO DE PASAR DE RONDA. CUANDO HAYAS TERMINADO LA PARTIDA EN CURSO, LE DAS EN PARTIDA NUEVA PARA RESETEAR TODOS LOS CONTADORES.                                                                                                                                            TECLAS DE ATAJO                                                                             TECLA + >> SUMA 1 DE ENERGÍA.                                                TECLA - >> RESTA 1 DE ENERGÍA.                                          TECLA ENTER >> PASAR A LA SIGUIENTE RONDA                         TECLA 0 >> NUEVA PARTIDA                                                                                                                                                                  CADA VEZ QUE PRESIONES UN BOTÓN DEL PROGRAMA, SI QUIERES USAR LAS TECLAS DE ATAJO, TIENES QUE DARLE CLICK AL CHECKBOX DE DESBUGUEAR, ASÍ YA ESTÉ MARCADO.                                                                                                                      >> CREADO POR: GAVIDIA#6007 (DISCORD)", vbInformation, "AYUDA")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label1.Focus()
        Dim valor = Label2.Text
        If (valor = "CONTADOR DE ENERGÍA") Then
            If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Salir") = vbYes Then
                End
            End If
        End If
        If (valor = "ENERGY COUNTER") Then
            If MsgBox("You want to exit?", vbQuestion + vbYesNo, "Exit") = vbYes Then
                End
            End If
        End If
        If (valor = "METRO NG ENERHIYA") Then
            If MsgBox("Nais mo bang lumabas sa application?", vbQuestion + vbYesNo, "Labas") = vbYes Then
                End
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
