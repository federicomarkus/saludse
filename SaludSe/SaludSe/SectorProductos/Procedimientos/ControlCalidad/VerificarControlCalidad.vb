Imports System.Data.Odbc
Public Class VerificarControlCalidad
    Dim sql As String
    Dim producto, orden, rta As Integer
    Dim rs As OdbcDataReader
    Private Sub VerificarControlCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        actualizarGrilla()
    End Sub
    Public Sub actualizarGrilla()
        sql = "select p.idProducto IdProducto,p.nombre, o.idOrden, fechaVencimiento FechaVencimiento,p.marca Marca,p.CantMedida Cantidad, p.TipoMedida Unidad, c.cantidad stock from productos p, orden o, ComprasP c where c.idOrden = o.idOrden and c.idProducto=p.idProducto and fechavencimiento<curdate() and c.chequeado=0"
        ListaOrdenProd.DataSource = llenarGrilla(sql)
        ListaOrdenProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ListaOrdenProd.ClearSelection()
    End Sub

    Private Sub ListaOrdenProd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaOrdenProd.CellClick
        Try
            producto = ListaOrdenProd.Rows(e.RowIndex).Cells("idProducto").Value.ToString
            orden = ListaOrdenProd.Rows(e.RowIndex).Cells("idOrden").Value.ToString
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        rta= MsgBox("Seguro que desea borrar todos los productos vencidos?",MsgBoxStyle.YesNo)
        If (rta = 6) Then
            sql = "update comprasP set chequeado=1 where estado=0 and fechavencimiento<curdate()"
            consulta(sql)
            actualizarGrilla()
            MsgBox("Se han borrado todos los productos vencidos")
            sql = "update verificacion set fecha=curdate()"
            consulta(sql)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If orden <> 0 Then
            rta = MsgBox("Seguro que desea borrar el producto seleccionado?", MsgBoxStyle.YesNo)
            If (rta = 6) Then
                sql = "update comprasP set chequeado=1 where idOrden=" & orden & " and idProducto=" & producto & ""
                consulta(sql)
                orden = 0
                actualizarGrilla()
                sql = "update verificacion set fecha=curdate()"
                consulta(sql)
            End If
        Else
            MsgBox("Seleccione un producto")
        End If

    End Sub


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        ControlCalidad.fechaV()
        ControlCalidad.Show()
    End Sub
End Class