Public Class MenuStock

    Private Sub btnRepos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepos.Click
        Reposicion.Show()
        Me.Hide()

    End Sub

    Private Sub btnDevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevo.Click
        PedidosDevolucion.Show()
        Me.Hide()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuAdministrador.Show()
        Me.Hide()

    End Sub
End Class