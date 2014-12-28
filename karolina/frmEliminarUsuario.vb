Public Class frmEliminarUsuario

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        ''crear una variable para capturar el codigo de usuario
        Dim CodigoE As Integer
        CodigoE = txtcodigo.Text
        ''se hace la captura de lo q se excribe en txtcodigo

        ''asignamos al commmand el tipo y la conexion 
        Comando.CommandType = CommandType.Text
        Comando.Connection = Conexion

        ''en la variable sqlvar creamos la consulta de eliminacion 
        SqlVar = "delete from usuarios where Id_Usuario= " & CodigoE & ""

        ''asignamos al commmand la consulta a traves de la variable 
        Comando.CommandText = SqlVar

        ''ejecutamos la consulta y hacemos la captura de errores
        If MsgBox("Desea eliminar el Registro", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CONFIRMAR") = MsgBoxResult.Yes Then

            Try
                Comando.ExecuteNonQuery()
                MsgBox("Se ha elimminado el registro correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmacion")
                txtcodigo.Text = "" ''Limpiamos la caja de texto\

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            txtcodigo.Text = ""
        End If
    End Sub
    Private Sub TxtCodigo_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.Leave
        ''Hacer la validacion de que haya algo escrito en el còdigo
        If TxtCodigo.Text <> "" Then
            ConsultarUsuario(TxtCodigo.Text)

            ''Pasar a las cajas de texto la informacion del usuario que tiene ese codigo a medida que va leyendo el datareader
            If DLector.Read() Then
                txtAministrador.Text = DLector(0).ToString
                TxtUsuario.Text = DLector(1).ToString
                txtContraseña.Text = DLector(2).ToString
            Else
                MsgBox("No se encontro el registro", MsgBoxStyle.Exclamation, "AVISO")
            End If
        Else
            MsgBox("Ingrese el codigo del usuario a eliminar", MsgBoxStyle.Exclamation, "AVISO")

        End If
        DLector.Close() ''CERRAR EL DATAREADER
    End Sub

    Private Sub frmEliminarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class