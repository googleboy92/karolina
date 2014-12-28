Imports System.Data.SqlClient   ''Hacer la llamada a la libreria correspondiente para SQL server
Module Module1
    ''Crear cadena de conexion
    Public Conexion As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=db_karolina;Integrated Security=True")
    Public Comando As New SqlCommand ''declarar la variable comand y definiendola de tipo comando sql
    Public DLector As SqlDataReader ''declarar la variable DR y definirla de tipo datareader, en donde se almacenaran los resultados de comand
    ''Crear variable para usarla en todo el proyecto
    Public SqlVar As String = ""

    ''Crear sub de conexion
    Public Sub ConectarBD()

        ''Captura de errores en la conexion de la base de datos
        Try
            Conexion.Open() ''Abre la base de datos
            ''MsgBox("La conexion de la base de datos se a realizado correctamente")

        Catch ex As Exception
            MsgBox(ex.ToString)
            End

        End Try
    End Sub
    ''Crear un nuevo sub llamado login
    Public Sub Login(ByVal UsuarioVariable, ByVal ContraseñaVariable)
        ''Configurar el comand 
        ''Paso  1: Darle la conexion al comand para que pueda realizar la consulta

        Comando.Connection = Conexion
        ''paso 2: definir que tipo de comand es

        Comando.CommandType = CommandType.Text ''definirla como tipo texto
        ''paso 3: declarar la consulta sql... para ello declarar una variable de tipo texto

        Dim ConsultaLogin As String
        ConsultaLogin = "SELECT Usuario,Contraseña,Id_usuario from Usuarios WHERE Usuario = '" + UsuarioVariable + "'And Contraseña = '" + ContraseñaVariable + "'"

        ' MsgBox(ConsultaLogin) ''para probar la consulta

        ''paso 4: pasar la consulta al comand para q pueda ejecutarla
        Comando.CommandText = ConsultaLogin

        ''paso 5: ejecutar la consulta y verificar si trae resultados, si los trae entonces el login esta correcto
        ''para esto se utilizara el try

        Try
            ''ejecutar la consulta
            DLector = Comando.ExecuteReader ''aqui se ejecuta la consulta y los resultados se almacenan

            ''verificar si hay resultados
            If DLector.HasRows Then
                DLector.Close()

                ''Mostrar el principal y ocultar el login
                frmLogin.Hide()
                frmMDIPrincipal.Show()



            Else
                ''No tenemos el login correcto
                MsgBox("Los datos ingresados no son correctos", MsgBoxStyle.Critical, "ERROR DE ACCESO")
                End

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Public Sub ConsultarUsuario(ByRef Identificacion As Integer)
        '' asignar al command el tipo y la conexion
        Comando.CommandType = CommandType.Text
        Comando.Connection = Conexion

        ''crear la consulta en la variable sqlvar
        SqlVar = ""
        SqlVar = "Select Usuario, Administrador, Contraseña from Usuarios where Id_Usuario = " & Identificacion & ""

        ''Pasar al command la connsulta a traves de la variable
        Comando.CommandText = SqlVar

        ''ejecutar el datareader y hacer captura de errores 
        Try
            DLector = Comando.ExecuteReader()


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub



    'Funcion para mostrar avisos con Msgbox
    Public Sub AvisoCritico(ByRef MsgboxMensaje)
        MsgBox(MsgboxMensaje, MsgBoxStyle.Critical, "Error")
    End Sub

End Module
