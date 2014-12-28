Public Class frmModificarUsuario

    Private Sub frmModificarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCodigo.Select()

    End Sub
    ''procedimiento para limpiar cajas
    Private Sub limpiarCajas()
        txtAdministrador.Text = ""
        txtCodigo.Text = ""
        txtContraseña.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        ''Validar que se haya escrito el codigo
        If txtCodigo.Text = "" Then
            MsgBox("El campo codigo no puede estar vacio", MsgBoxStyle.Critical, "AVISO")
            txtCodigo.Select()
        Else
            ''Dimensionar las variables correspondientes a cada caja de texto
            Dim CodigoA As Integer
            Dim AdministradorA As String
            Dim UsuarioA As String
            Dim ContraseñaA As String

            ''Asigna a cada variable lo que hay en cada caja de texto
            CodigoA = txtCodigo.Text
            AdministradorA = txtAdministrador.Text
            UsuarioA = txtNombre.Text
            ContraseñaA = txtContraseña.Text

            ''Dar al command el tipo de texto
            Comando.CommandType = CommandType.Text
            ''Dar al command la conexion 
            Comando.Connection = Conexion

            ''Crear la consulta en la variable SqlVar
            SqlVar = "Update Usuarios set "
            SqlVar += "Administrador= '" & AdministradorA & "',"
            SqlVar += "Usuario= '" & UsuarioA & "',"
            SqlVar += "Contraseña='" & ContraseñaA & "'"
            SqlVar += "Where Id_Usuario=" & CodigoA & ""
            ''MsgBox(Sqlvar)

            ''Pasarle la consulta que asiignada a la variable al command
            Comando.CommandText = SqlVar
            Try
                ''Ejecutar la consulta que esta en el command
                Comando.ExecuteNonQuery()
                MsgBox("Registro Actualizado Correctamente", MsgBoxStyle.Information, "Actualizacion")
                ''Llamar al sub a limpiar las cajas 
                limpiarCajas()

            Catch ex As Exception
                ''capturar el error y convertirlo en cadena para saber que error es 
                MsgBox(ex.ToString)

            End Try

        End If
    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        ''Validar que la caja de texto  sea diferente de vacio
        If txtCodigo.Text <> "" Then
            ''llamar al procedimiento consultar usuario y pasarle como parametro lo que hay en la caja de texto codigo
            ConsultarUsuario(txtCodigo.Text)
            ''validar si el datareader tiene datos entonces pase esos datos a las cajas de texto correspondientes
            If DLector.Read Then
                txtNombre.Text = DLector(0).ToString
                txtAdministrador.Text = DLector(1).ToString
                txtContraseña.Text = DLector(2).ToString
                ''si no tiene nada que envie el mensaje
            Else
                MsgBox("No se encentrò el regisdtro en la base de datos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                ''limpiar las cajas de texto
                txtCodigo.Text = ""
                ''seleccionar la caja de texto
                txtCodigo.Select()
            End If
        End If
        ''cerrar el datareader
        DLector.Close()

    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        limpiarCajas()

    End Sub

     
End Class
