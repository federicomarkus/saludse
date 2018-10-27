Option Explicit On
Imports System.Data.Odbc
Public Class cursoAlta
    Dim sql As String
    Dim rsIdCapacitacion As OdbcDataReader

    Private Sub cursoAlta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdCapacitacion.Items.Clear()

        sql = "select idCapacitacion from Capacitacion"
        rsIdCapacitacion = consulta(sql)
        While rsIdCapacitacion.Read = True
            cboIdCapacitacion.Items.Add(rsIdCapacitacion(0))
        End While
        cboIdCapacitacion.Items.Add("")
    End Sub

    Private Sub txtDuracion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDuracion.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub txtHora_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtHora.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDuracion.Click

    End Sub

    Private Sub btnGenerarAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarAlta.Click
        If (txtDescripcion.Text = "" Or txtDuracion.Text = "" Or txtHora.Text = "" Or txtNombre.Text = "" Or txtTipo.Text = "" Or dtpFecha.Text = "" Or cboIdCapacitacion.Text = "") Then
            MsgBox("Debe rellenar todos los espacios")
        Else
            If (dtpFecha.Text < Date.Today) Then
                MsgBox("La fecha debe ser mayor a la fecha actual")
            Else


                sql = "insert into Curso values(''," & cboIdCapacitacion.Text & ",'" & txtNombre.Text & "','" & txtDescripcion.Text & "'," & txtDuracion.Text & "," & txtHora.Text & ",'" & txtTipo.Text & "','" & dtpFecha.Text & "',1)"
                consulta(sql)

                MsgBox("Curso agregado correctamente")
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        ABMcurso.Show()

    End Sub
End Class