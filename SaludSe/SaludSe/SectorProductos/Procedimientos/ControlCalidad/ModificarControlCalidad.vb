Imports System.Data.Odbc
Public Class ModificarControlCalidad
    Dim sql As String
    Dim orden, producto, rta As Integer
    Dim rs As OdbcDataReader

    Private Sub ModificarCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        actualizarGrilla()
    End Sub
    Public Sub actualizarGrilla()
        sql = " select c.idOrden IdOrden, c.idProducto, p.nombre NombreProducto,c.fechaVencimiento FechaVencimiento, p.marca Marca from productos p, ComprasP c where c.idProducto=p.idProducto and c.estado=1 order by fechaCarga desc"
        ListaOrdenProd.DataSource = llenarGrilla(sql)
        ListaOrdenProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ListaOrdenProd.ClearSelection()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        rta = MsgBox("Seguro que desea cancelar la carga del producto?", MsgBoxStyle.YesNo)
        If rta = 6 Then
            sql = "delete from comprasP where idOrden=" & orden & " and idProducto= " & producto & ""
            consulta(sql)
            sql = "update OrdenProducto set cargado=0 where idOrden=" & orden & " and idProducto= " & producto & ""
            consulta(sql)
            sql = "update orden set cargado=0 where idOrden=" & orden & ""
            consulta(sql)
            MsgBox("Carga modificada")
            actualizarGrilla()
            CargarControlCalidad.actualizarGrilla()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        ControlCalidad.Show()
        CargarControlCalidad.actualizarGrilla()
    End Sub

    Private Sub ListaOrdenProd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaOrdenProd.CellClick
        Try
            producto = ListaOrdenProd.Rows(e.RowIndex).Cells("idProducto").Value.ToString
            orden = ListaOrdenProd.Rows(e.RowIndex).Cells("idOrden").Value.ToString
        Catch ex As Exception

        End Try
    End Sub


End Class