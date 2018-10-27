Option Explicit On
Imports System.Data.Odbc
Public Class IngresarEmpleado
    Dim sql As String

    Dim cancelar As Integer
    Dim rsSectores As OdbcDataReader
    Dim rsSucursales As OdbcDataReader
    Private Sub IngresarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "select IdSector from Sectores"
        rsSectores = consulta(sql)
        cboIdSector.Items.Clear()
        While rsSectores.Read

            cboIdSector.Items.Add(rsSectores(0))
        End While
        cboIdSector.Items.Add("")

      


    End Sub

    Private Sub txtSueldo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlyNum(e)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar = MsgBox("Está seguro que desea cancelar el ingreso del empleado?", MsgBoxStyle.YesNo)
        If cancelar = 6 Then
            Me.Close()
            AdministrarPersonal.Close()
            AdministrarPersonal.Show()

        End If
    End Sub

    Private Sub btnGenerarEmpleado_Click(sender As Object, e As EventArgs) Handles btnGenerarEmpleado.Click


        If (cboIdSector.Text = "") Then
            MsgBox("Debe rellenar todos los espacios")
        Else
            sql = "insert into Empleados values(''," & AdministrarPersonal.idPersonal & "," & cboIdSector.Text & ",1,1,1)"
            consulta(sql)
            MsgBox("Se ha registrado el nuevo empleado")
            Me.Close()

            GenerarContratoEmpleado.Show()


        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class