<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDetalleFactura = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnImprimirFactura = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(101, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(263, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(361, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Factura #"
        '
        'btnDetalleFactura
        '
        Me.btnDetalleFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleFactura.Location = New System.Drawing.Point(113, 347)
        Me.btnDetalleFactura.Name = "btnDetalleFactura"
        Me.btnDetalleFactura.Size = New System.Drawing.Size(78, 69)
        Me.btnDetalleFactura.TabIndex = 3
        Me.btnDetalleFactura.Text = "Detalle de Factura"
        Me.btnDetalleFactura.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnular.Location = New System.Drawing.Point(12, 347)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(78, 69)
        Me.btnAnular.TabIndex = 4
        Me.btnAnular.Text = "Anular Factura"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'btnImprimirFactura
        '
        Me.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirFactura.Location = New System.Drawing.Point(211, 347)
        Me.btnImprimirFactura.Name = "btnImprimirFactura"
        Me.btnImprimirFactura.Size = New System.Drawing.Size(78, 69)
        Me.btnImprimirFactura.TabIndex = 4
        Me.btnImprimirFactura.Text = "Imprimir"
        Me.btnImprimirFactura.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(307, 347)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 69)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(270, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(255, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(101, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(101, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Codigo de Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(361, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(101, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Telefono"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(431, 16)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroFactura.TabIndex = 11
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(431, 46)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 12
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(211, 70)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(93, 20)
        Me.txtCodigoCliente.TabIndex = 13
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(211, 99)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(196, 20)
        Me.txtNombreCliente.TabIndex = 14
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(211, 131)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(196, 20)
        Me.txtDireccion.TabIndex = 15
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(211, 187)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(196, 20)
        Me.txtTelefono.TabIndex = 16
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(307, 226)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 17
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(307, 255)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(100, 20)
        Me.txtIva.TabIndex = 18
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(307, 283)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 19
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(211, 160)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(196, 20)
        Me.txtCedula.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(101, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Cedula"
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.karolina.My.Resources.Resources.factura
        Me.ClientSize = New System.Drawing.Size(547, 456)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtNumeroFactura)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimirFactura)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnDetalleFactura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFactura"
        Me.Text = "frmFactura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDetalleFactura As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnImprimirFactura As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
