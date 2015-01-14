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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnDetalleFactura = New System.Windows.Forms.Button()
        Me.btnAnularFactura = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtFacturaNumero = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(70, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(70, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo de Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(348, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(348, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Factura #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(70, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(70, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Identificacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(116, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(116, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(71, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(116, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Sub-Total"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(433, 107)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 69)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnDetalleFactura
        '
        Me.btnDetalleFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDetalleFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleFactura.Location = New System.Drawing.Point(433, 194)
        Me.btnDetalleFactura.Name = "btnDetalleFactura"
        Me.btnDetalleFactura.Size = New System.Drawing.Size(78, 69)
        Me.btnDetalleFactura.TabIndex = 11
        Me.btnDetalleFactura.Text = "Detalle Factura"
        Me.btnDetalleFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalleFactura.UseVisualStyleBackColor = False
        '
        'btnAnularFactura
        '
        Me.btnAnularFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnularFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnularFactura.Location = New System.Drawing.Point(433, 276)
        Me.btnAnularFactura.Name = "btnAnularFactura"
        Me.btnAnularFactura.Size = New System.Drawing.Size(78, 69)
        Me.btnAnularFactura.TabIndex = 12
        Me.btnAnularFactura.Text = "Anular Factura"
        Me.btnAnularFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnularFactura.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(433, 358)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 69)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtFacturaNumero
        '
        Me.txtFacturaNumero.Location = New System.Drawing.Point(411, 9)
        Me.txtFacturaNumero.Name = "txtFacturaNumero"
        Me.txtFacturaNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtFacturaNumero.TabIndex = 14
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(411, 43)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 15
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(179, 216)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(191, 20)
        Me.txtTelefono.TabIndex = 16
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(188, 312)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 18
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(188, 375)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 21
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(179, 191)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(191, 20)
        Me.txtIdentificacion.TabIndex = 20
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(188, 344)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 23
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(179, 160)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(191, 20)
        Me.txtDireccion.TabIndex = 22
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(179, 132)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(191, 20)
        Me.txtNombreCliente.TabIndex = 25
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(179, 101)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoCliente.TabIndex = 24
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.karolina.My.Resources.Resources.factura
        Me.ClientSize = New System.Drawing.Size(555, 456)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtFacturaNumero)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnularFactura)
        Me.Controls.Add(Me.btnDetalleFactura)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnDetalleFactura As System.Windows.Forms.Button
    Friend WithEvents btnAnularFactura As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtFacturaNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
End Class
