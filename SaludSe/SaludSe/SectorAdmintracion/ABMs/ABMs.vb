Public Class ABMs

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuAdministrador.Show()

    End Sub

    Private Sub btnCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursos.Click
        Me.Hide()
        ABMcurso.Show()

    End Sub

    Private Sub btnSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSec.Click
        ABMSector.Show()
        Me.Hide()

    End Sub

    Private Sub btnPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPro.Click
        ABMProducto.Show()
        Me.Hide()


    End Sub

    Private Sub abmpedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abmpedido.Click
        Me.Hide()
        abmPed.Show()
    End Sub

    Private Sub abmPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abmPagos.Click
        Me.Hide()
        abmPag.Show()

    End Sub

    Private Sub abmServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abmServicios.Click
        Me.Hide()
        abmServi.Show()
    End Sub
End Class