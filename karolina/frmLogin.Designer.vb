<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbPass = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(137, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(133, 165)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(182, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(32, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(32, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraceña"
        '
        'mtbPass
        '
        Me.mtbPass.Location = New System.Drawing.Point(133, 190)
        Me.mtbPass.Name = "mtbPass"
        Me.mtbPass.PromptChar = Global.Microsoft.VisualBasic.ChrW(45)
        Me.mtbPass.Size = New System.Drawing.Size(182, 20)
        Me.mtbPass.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.AllowDrop = True
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancelar.FlatAppearance.BorderSize = 3
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(226, 269)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(59, 43)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Segoe Print", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Gold
        Me.lblLogin.Location = New System.Drawing.Point(131, 42)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(128, 65)
        Me.lblLogin.TabIndex = 7
        Me.lblLogin.Text = "Login"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.karolina.My.Resources.Resources.loginnegro
        Me.ClientSize = New System.Drawing.Size(382, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.mtbPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "frmLogin"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtbPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblLogin As System.Windows.Forms.Label

End Class
