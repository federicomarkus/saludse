Public Class Empleado

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub btnGestionarAusencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionarAusencias.Click
        Me.Hide()
        GestionarAusencias.Show()

    End Sub

    Private Sub btnRegistrarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarEmpleado.Click
        Me.Hide()
        AdministrarPersonal.Show()

    End Sub

    Private Sub btnCapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapa.Click
        Capacitacion.Show()
        Me.Hide()

    End Sub
End Class