Public Class ABMcurso

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        Me.Hide()
        cursoAlta.Show()

    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Me.Hide()
        cursoBaja.Show()

    End Sub

    Private Sub btnModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificacion.Click
        Me.Hide()
        cursoModificacion.Show()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        ABMs.Show()
        Me.Hide()

    End Sub
End Class