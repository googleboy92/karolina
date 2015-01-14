<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarUsuario
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
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtAministrador = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(201, 172)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(211, 20)
        Me.txtContraseña.TabIndex = 21
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(202, 108)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(211, 20)
        Me.txtUsuario.TabIndex = 20
        '
        'txtAministrador
        '
        Me.txtAministrador.Location = New System.Drawing.Point(202, 142)
        Me.txtAministrador.Name = "txtAministrador"
        Me.txtAministrador.Size = New System.Drawing.Size(211, 20)
        Me.txtAministrador.TabIndex = 19
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(202, 79)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(211, 20)
        Me.txtcodigo.TabIndex = 18
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(261, 214)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(59, 46)
        Me.cmdCancelar.TabIndex = 17
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminar.ForeColor = System.Drawing.Color.Black
        Me.cmdEliminar.Location = New System.Drawing.Point(158, 214)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(59, 46)
        Me.cmdEliminar.TabIndex = 16
        Me.cmdEliminar.Text = "Aceptar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(174, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Eliminar Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(106, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Usuario Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Administrador Cuenta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(77, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo Usuario"
        '
        'frmEliminarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 285)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtAministrador)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEliminarUsuario"
        Me.Text = "frmEliminarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtAministrador As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
