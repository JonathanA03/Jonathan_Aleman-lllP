Public Class frmLogin
    Dim conexion As New conexion
    Private Sub ingresarMenu()
        Dim userName, psw As String
        userName = txtUsuario.Text
        psw = txtPsw.Text
        Try
            If (conexion.validarUsuario(userName, psw)) Then
                MsgBox("Correcto")
                frmUsuario.Show()
                Me.Hide()
            Else
                MsgBox("Usuario/Contraseña inválida")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        ingresarMenu()
    End Sub
End Class