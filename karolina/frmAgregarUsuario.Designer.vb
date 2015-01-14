<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAgregarUsuario = New System.Windows.Forms.Button()
        Me.txtContraseñaCuenta = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtAdministrador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(220, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar un Nuevo Usuario"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(88, 93)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(521, 295)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.cmdCancelar)
        Me.TabPage1.Controls.Add(Me.cmdAgregarUsuario)
        Me.TabPage1.Controls.Add(Me.txtContraseñaCuenta)
        Me.TabPage1.Controls.Add(Me.txtUsuario)
        Me.TabPage1.Controls.Add(Me.txtAdministrador)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(513, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos de Usuario"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.Silver
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(247, 195)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(109, 54)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAgregarUsuario
        '
        Me.cmdAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarUsuario.Location = New System.Drawing.Point(125, 195)
        Me.cmdAgregarUsuario.Name = "cmdAgregarUsuario"
        Me.cmdAgregarUsuario.Size = New System.Drawing.Size(105, 54)
        Me.cmdAgregarUsuario.TabIndex = 6
        Me.cmdAgregarUsuario.Text = "Agregar Usuario"
        Me.cmdAgregarUsuario.UseVisualStyleBackColor = False
        '
        'txtContraseñaCuenta
        '
        Me.txtContraseñaCuenta.Location = New System.Drawing.Point(271, 119)
        Me.txtContraseñaCuenta.Name = "txtContraseñaCuenta"
        Me.txtContraseñaCuenta.Size = New System.Drawing.Size(190, 29)
        Me.txtContraseñaCuenta.TabIndex = 5
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(271, 72)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(190, 29)
        Me.txtUsuario.TabIndex = 4
        '
        'txtAdministrador
        '
        Me.txtAdministrador.Location = New System.Drawing.Point(271, 26)
        Me.txtAdministrador.Name = "txtAdministrador"
        Me.txtAdministrador.Size = New System.Drawing.Size(190, 29)
        Me.txtAdministrador.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(21, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Contraseña  de la cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(44, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Usuario de  la Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(37, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Administrador de la cuenta"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(513, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Permisos de Usuario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(697, 444)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmAgregarUsuario"
        Me.Text = "frmAgregarUsuario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarUsuario As System.Windows.Forms.Button
    Friend WithEvents txtContraseñaCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtAdministrador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
