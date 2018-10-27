Option Explicit On
Imports System.Data.Odbc
Public Class RegistroAusenciavb
    Dim rsAusencia As OdbcDataReader
    Dim rsEmpleado As OdbcDataReader
    Dim sql As String


    Private Sub RegistroAusenciavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub RegistroAusenciavb_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        sql = "select max(idAusencia) from Ausencia where idEmpleado=" & GestionarAusencias.cboIdEmpleado.Text
        rsAusencia = consulta(sql)
        While rsAusencia.Read
            lblTextoIdAusencia.Text = rsAusencia(0)
        End While

        sql = "select nombre, apellido from Personas where idPersona=(select idPersona from Empleados where idEmpleado=" & GestionarAusencias.cboIdEmpleado.Text & ")"
        rsEmpleado = consulta(sql)
        While rsEmpleado.Read
            lblTextoEmpleado.Text = rsEmpleado(0) & " " & rsEmpleado(1)
        End While


        lblTextoDescripcion.Text = GestionarAusencias.txtDescripcion.Text
        lblTextoDuracion.Text = GestionarAusencias.txtDurecion.Text & " días"
        lblTextoFecha.Text = Format(Date.Today, "yyyy/MM/dd")



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
        GestionarAusencias.Show()
        GestionarAusencias.cboIdEmpleado.Text = ""
        GestionarAusencias.txtDescripcion.Text = ""
        GestionarAusencias.txtDurecion.Text = ""
    End Sub
End Class