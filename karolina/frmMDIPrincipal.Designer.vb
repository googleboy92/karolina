<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDIPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ReportesDeVentasToolStripMenuItem, Me.OpcionesDeUsuarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(715, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarStockToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "&Inventario"
        '
        'AgregarStockToolStripMenuItem
        '
        Me.AgregarStockToolStripMenuItem.Name = "AgregarStockToolStripMenuItem"
        Me.AgregarStockToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarStockToolStripMenuItem.Text = "Agregar Stock"
        '
        'ReportesDeVentasToolStripMenuItem
        '
        Me.ReportesDeVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiaToolStripMenuItem, Me.SemanaToolStripMenuItem, Me.MesToolStripMenuItem})
        Me.ReportesDeVentasToolStripMenuItem.Name = "ReportesDeVentasToolStripMenuItem"
        Me.ReportesDeVentasToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ReportesDeVentasToolStripMenuItem.Text = "Reportes de Ventas"
        '
        'DiaToolStripMenuItem
        '
        Me.DiaToolStripMenuItem.Name = "DiaToolStripMenuItem"
        Me.DiaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DiaToolStripMenuItem.Text = "Dia"
        '
        'SemanaToolStripMenuItem
        '
        Me.SemanaToolStripMenuItem.Name = "SemanaToolStripMenuItem"
        Me.SemanaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SemanaToolStripMenuItem.Text = "Semana"
        '
        'MesToolStripMenuItem
        '
        Me.MesToolStripMenuItem.Name = "MesToolStripMenuItem"
        Me.MesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MesToolStripMenuItem.Text = "Mes"
        '
        'OpcionesDeUsuarioToolStripMenuItem
        '
        Me.OpcionesDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.OpcionesDeUsuarioToolStripMenuItem.Name = "OpcionesDeUsuarioToolStripMenuItem"
        Me.OpcionesDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.OpcionesDeUsuarioToolStripMenuItem.Text = "Opciones de Usuario"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.AnularFacturaToolStripMenuItem, Me.CierreDeCajaToolStripMenuItem})
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturacionToolStripMenuItem.Text = "&Facturacion"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva Venta"
        '
        'AnularFacturaToolStripMenuItem
        '
        Me.AnularFacturaToolStripMenuItem.Name = "AnularFacturaToolStripMenuItem"
        Me.AnularFacturaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AnularFacturaToolStripMenuItem.Text = "Anular Factura"
        '
        'CierreDeCajaToolStripMenuItem
        '
        Me.CierreDeCajaToolStripMenuItem.Name = "CierreDeCajaToolStripMenuItem"
        Me.CierreDeCajaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CierreDeCajaToolStripMenuItem.Text = "Cierre de Ventas"
        '
        'frmMDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMDIPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
