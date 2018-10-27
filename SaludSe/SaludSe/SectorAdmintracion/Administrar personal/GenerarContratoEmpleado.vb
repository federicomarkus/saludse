Option Explicit On
Imports System.Data.Odbc
Public Class GenerarContratoEmpleado
    Dim sql As String
    Public rsEmpleado As OdbcDataReader
    Public idEmpleado As Integer
    Dim rta As Integer

    Private Sub GenerarContratoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub btnGenerarContrato_Click(sender As Object, e As EventArgs) Handles btnGenerarContrato.Click
        If (txtMonto.Text = "" Or dtpVigencia.Text = "") Then
            MsgBox("Debe rellenar todos los espacios")
        Else
            If (txtMonto.Text > 100) Then


                If (dtpVigencia.Text < Date.Today) Then
                    MsgBox("La vigencia del contrato debe ser mayor a la fecha actual")
                Else
                    sql = "select max(idEmpleado) from Empleados"
                    rsEmpleado = consulta(sql)
                    While rsEmpleado.Read
                        sql = "insert into ContratoEmpleado values(''," & rsEmpleado(0) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "'," & txtMonto.Text & ",'" & Format(dtpVigencia.Value, "yyyy/MM/dd") & "')"
                        consulta(sql)
                        idEmpleado = rsEmpleado(0)
                        MsgBox("Contrato generado correctamente")


                        ContratoEmpleado.Show()
                        Me.Hide()




                    End While

                End If
            Else
                MsgBox("El sueldo del empleado debe ser mayor a 100")
            End If

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        rta = MsgBox("Está seguro que desea cancelar la creación del contrato? Si lo hace se borrará el empleado", MsgBoxStyle.YesNo)
        If (rta = 6) Then
            sql = "select max(idEmpleado) from Empleados"
            rsEmpleado = consulta(sql)
            While rsEmpleado.Read
                sql = "delete from Empleados where idEmpleado=" & rsEmpleado(0)
                consulta(sql)
                MsgBox("Empleado borrado con exito")
            End While
           

            Me.Close()
            IngresarEmpleado.Close()
            AdministrarPersonal.Close()
            Empleado.Show()

        End If

    End Sub

    Private Sub dtpVigencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpVigencia.ValueChanged

    End Sub

    Private Sub txtMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.TextChanged

    End Sub
End Class