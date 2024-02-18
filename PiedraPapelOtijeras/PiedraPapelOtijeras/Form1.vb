Public Class Form1

    Dim jugador As Integer
    Dim computador As Integer

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Juego.Location = New Point(12, 12)
    End Sub

    Private Sub Piedra_Click_1(sender As Object, e As EventArgs) Handles Piedra.Click
        jugador = 1
        eleccion.Text = "Piedra"
    End Sub

    Private Sub Papel_Click_1(sender As Object, e As EventArgs) Handles Papel.Click
        jugador = 2
        eleccion.Text = "Papel"
    End Sub

    Private Sub Tijera_Click_1(sender As Object, e As EventArgs) Handles Tijera.Click
        jugador = 3
        eleccion.Text = "Tijera"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        computador = Int((3 * Rnd()) + 1)

        If computador = 1 Then
            Label5.Text = "Piedra"
        ElseIf computador = 2 Then
            Label5.Text = "Papel"
        ElseIf computador = 3 Then
            Label5.Text = "Tijera"
        End If

        ' 1 = piedra
        ' 2 = papel
        ' 3 = tijera
        If (jugador = 1) And (computador = 3) Then
            resultado.Text = "ganaste"
            jugador = 0
        ElseIf (jugador = 2) And (computador = 1) Then
            resultado.Text = "ganaste"
            jugador = 0
        ElseIf (jugador = 3) And (computador = 2) Then
            resultado.Text = "ganaste"
            jugador = 0
        ElseIf jugador = computador Then
            resultado.Text = "Empate"
            jugador = 0
        Else
            resultado.Text = "Perdiste"
            jugador = 0
        End If
    End Sub
End Class
