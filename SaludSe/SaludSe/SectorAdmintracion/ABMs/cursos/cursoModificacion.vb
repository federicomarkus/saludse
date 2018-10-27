Option Explicit On
Imports System.Data.Odbc
Public Class cursoModificacion
    Dim sql As String
    Dim rsIdCurso As OdbcDataReader

    Private Sub lblIdPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFecha.Click

    End Sub

    Private Sub cursoModificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdCurso.Items.Clear()

        Sql = "select idCurso from Curso"
        rsIdCurso = consulta(Sql)
        While rsIdCurso.Read = True
            cboIdCurso.Items.Add(rsIdCurso(0))
        End While
        cboIdCurso.Items.Add("")
    End Sub

    Private Sub btnGenerarModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarModificacion.Click
        If (txtDescripcion.Text = "" Or txtDuracion.Text = "" Or txtHora.Text = "" Or txtNombre.Text = "" Or txtTipo.Text = "" Or dtpFecha.Text = "" Or cboIdCurso.Text = "") Then
            MsgBox("Debe rellenar todos los espacios")
        Else
            If (dtpFecha.Text < Date.Today) Then
                MsgBox("La fecha debe ser mayor a la fecha actual")
            Else


                sql = "update Curso set nombre='" & txtNombre.Text & "', descripcion='" & txtDescripcion.Text & "', duracion=" & txtDuracion.Text & ", hora=" & txtHora.Text & ", tipo='" & txtTipo.Text & "', fecha='" & Format(dtpFecha.Value, "yyyy/MM/dd") & "' where idCurso=" & cboIdCurso.Text
                consulta(sql)

                MsgBox("Curso modificado correctamente")
            End If
        End If
    End Sub

    Private Sub txtDuracion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDuracion.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub txtHora_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtHora.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        ABMcurso.Show()
    End Sub
End Class