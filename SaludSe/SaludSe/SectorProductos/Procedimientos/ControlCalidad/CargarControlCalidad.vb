Imports System.Data.Odbc
Public Class CargarControlCalidad
    Dim sql, dir, tel, mail, cont As String
    Dim idProv As String
    Dim cal As Integer
    Public numero As Integer
    Dim rta As OdbcDataReader
    Private Sub Cargar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        actualizarGrilla()
    End Sub

    Public Sub actualizarGrilla()

        sql = " select idOrden , p.nombre Nombre, fecha Fecha, prioridad Prioridad from proveedores p, orden o where o.idproveedor=p.idproveedor and cargado=0 and pagado=1"
        ListaControl.DataSource = llenarGrilla(sql)
        ListaControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        numero = 0
        ListaControl.ClearSelection()

    End Sub

    Private Sub ListaControl_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaControl.CellClick

        Try
            numero = ListaControl.Rows(e.RowIndex).Cells("idOrden").Value.ToString
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        If numero <> 0 Then
            CargaControlCalidad2.Show()
            CargaControlCalidad2.actualizarGrilla()
            Me.Hide()
        Else
            MsgBox("No se ha seleccionado ninguna orden")
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        ControlCalidad.Show()
        Me.Hide()

    End Sub
End Class