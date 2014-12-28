Public Class frmLogin
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsuario.Focus()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        If txtUsuario.Text = "" Then

            txtUsuario.BackColor = Color.Red
            'Se pasa el mensaje que se quiere mostrar a la funcion de aviso en caso de que la contraceña no este correcta
            AvisoCritico(" Introduzca el Usuario")
            txtUsuario.Focus()


        ElseIf mtbPass.Text = " " Then
            mtbPass.BackColor = Color.Red
            'Se pasa el mensaje que se quiere mostrar a la funcion de aviso en caso de que la contraceña no este correcta
            AvisoCritico(" Introduzca la Contraceña")
            mtbPass.Focus()
        End If
        Conexion.Open()
        Login(txtUsuario.Text, mtbPass.Text)

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Cierra el Programa
        End
    End Sub
End Class
