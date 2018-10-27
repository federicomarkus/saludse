Option Explicit On
Imports System.Data.Odbc
Public Class ContratoEmpleado
    Dim sql As String
    Dim rsEmpleado As OdbcDataReader
    Dim rsContrato As OdbcDataReader


    Private Sub ContratoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ContratoEmpleado_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        sql = "select max(idContratoE) from ContratoEmpleado"
        rsContrato = consulta(sql)
        While rsContrato.Read
            lblTextoIdContrato.Text = rsContrato(0)
        End While

        sql = "select nombre, apellido from Personas p, Empleados e where p.idPersona=e.idPersona and e.idEmpleado=" & GenerarContratoEmpleado.idEmpleado
        rsEmpleado = consulta(sql)
        While rsEmpleado.Read
            lblTextoEmpleado.Text = rsEmpleado(0) & " " & rsEmpleado(1)
        End While

        lblTextoFecha.Text = Format(Date.Today, "yyyy/MM/dd")

        lblTextoMonto.Text = GenerarContratoEmpleado.txtMonto.Text

        lblTextoVigencia.Text = Format(GenerarContratoEmpleado.dtpVigencia.Value, "yyyy/MM/dd")

        GenerarContratoEmpleado.Close()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        btnVolver.Visible = False
        PrintForm1.Print()
        btnImprimir.Visible = True
        btnVolver.Visible = True


    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        Empleado.Show()

    End Sub
End Class