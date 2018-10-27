Option Explicit On
Imports System.Data.Odbc

Public Class AdministrarPersonal
    Dim sql As String
    Dim rsIdPersonal As OdbcDataReader
    Dim rsExistePersonal As Boolean
    Dim rsExisteEmpleado As Boolean
    Public idPersonal As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboIdPersonal.Items.Clear()

        sql = "select idPersona from Personas"
        rsIdPersonal = consulta(sql)
        While rsIdPersonal.Read = True
            cboIdPersonal.Items.Add(rsIdPersonal(0))
        End While
        cboIdPersonal.Items.Add("")

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Empleado.Show()

    End Sub

    Private Sub btnGenerarSolicitud_Click(sender As Object, e As EventArgs) Handles btnGenerarSolicitud.Click
        If (cboIdPersonal.Text = "") Then
            MsgBox("Debe rellenar todos los espacios")
        Else
            rsExisteEmpleado = consultaExiste("select count(*)  from Empleados where idPersona=" & cboIdPersonal.Text)
            If (rsExisteEmpleado) Then
                MsgBox("El personal ingresado ya está registrado como empleado")
            Else
                rsExistePersonal = consultaExiste("select count(*)  from CursoPersonal where idPersona=" & cboIdPersonal.Text & " and finalizado=true")

                If rsExistePersonal = True Then

                    MsgBox("El personal ha terminado el curso, por lo tanto se ingresará como empleado y se generará el contrato") '
                    idPersonal = CInt(cboIdPersonal.Text)
                    Me.Hide()
                    IngresarEmpleado.Show()



                Else
                    MsgBox("El personal no está capacitado, solicitud rechazada")
                End If
            End If

        End If







    End Sub
End Class