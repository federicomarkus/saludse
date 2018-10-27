Public Class MenuAdministrador



    Private Sub AdministracionContablevb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Funciones.conexion()


    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        MenuStock.Show()

        Me.Hide()

    End Sub

    Private Sub btnPersonalYEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonalYEmpleados.Click
        Empleado.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        ABMs.Show()

    End Sub

    Private Sub btnVerificacionesYControles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificacionesYControles.Click
        Me.Hide()
        MenuDeVerificaciones.Show()

    End Sub
End Class