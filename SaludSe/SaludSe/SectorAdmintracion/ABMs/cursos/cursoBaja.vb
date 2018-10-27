Option Explicit On
Imports System.Data.Odbc
Public Class cursoBaja
    Dim sql As String
    Dim rsIdCurso As OdbcDataReader
    Private Sub btnGenerarBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarBaja.Click
        If (cboIdCurso.Text = "") Then
            MsgBox("Debe rellenar todos los espacios")

        Else
            sql = "update  Curso set disponible=0 where idCurso=" & cboIdCurso.Text
            consulta(sql)
            MsgBox("Curso dado de baja")
        End If
    End Sub

    Private Sub cursoBaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdCurso.Items.Clear()

        sql = "select idCurso from Curso"
        rsIdCurso = consulta(sql)
        While rsIdCurso.Read = True
            cboIdCurso.Items.Add(rsIdCurso(0))
        End While
        cboIdCurso.Items.Add("")
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        ABMcurso.Show()
    End Sub
End Class