Public Class frmAgregarUsuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarUsuario.Click
        ''Validar las cajas de texto
        If txtAdministrador.Text = "" Or txtUsuario.Text = "" Or txtContraseñaCuenta.Text = "" Then
            MsgBox("Introducir todos los datos del usuario", MsgBoxStyle.Exclamation, "AVISO")
            ''poner el cursor en Administrador
            txtAdministrador.Select()
        Else
            ''paso 1:declarar las variables que enviaran los datos a la BD para mejor orden
            Dim VAdministrador As String
            Dim VUsuario As String
            Dim VContraseña As String

            ''paso 2:dar los valores a cada variable correspondientes con las cajas de texto
            VAdministrador = txtAdministrador.Text
            VUsuario = txtUsuario.Text
            VContraseña = txtContraseñaCuenta.Text

            ''paso 3:configurar el comand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text

            ''paso 4:crear la consulta sql
            SqlVar = "Insert into Usuarios(Administrador, Usuario, Contraseña)  Values('" & VAdministrador & "', '" & VUsuario & "', '" & VContraseña & "')"
            ''MsgBox(SqlVar)

            ''paso 5:pasarle la consulta al comand
            Comando.CommandText = SqlVar

            ''paso 6:ejecutar la consulta sql y hacer captura de errores con try
            ''ejecuta y graba los datos en la BD
            Try
                Comando.ExecuteNonQuery()
                MsgBox("Los datos se agregaron correctamente", MsgBoxStyle.Information, "AVISO")
                txtAdministrador.Text = ""
                txtUsuario.Text = ""
                txtContraseñaCuenta.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub
End Class