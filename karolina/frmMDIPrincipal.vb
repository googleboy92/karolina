Public Class frmMDIPrincipal

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AgregarStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarStockToolStripMenuItem.Click
        frmEstock.MdiParent = Me
        frmEstock.Show()
    End Sub

   
    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        frmAgregarUsuario.MdiParent = Me
        frmAgregarUsuario.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        frmEliminarUsuario.MdiParent = Me
        frmEliminarUsuario.Show()

    End Sub
End Class