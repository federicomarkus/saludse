Imports System.Data.Odbc
Public Class Productos
    Dim sql As String
    Public idProducto As Integer
    Dim rta, rta2 As OdbcDataReader

  
    Public Sub actualizarGrilla()

        sql = "select * from productos where estado=1"
        ListaProductos.DataSource = llenarGrilla(sql)
        ListaProductos.AutoResizeColumns()
    End Sub
    Private Sub ListaProductos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaProductos.CellClick
        Try
            idProducto = ListaProductos.Rows(e.RowIndex).Cells("idProducto").Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Productos_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        actualizarGrilla()


    End Sub

    Private Sub btnCargarProv_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarProv.Click
        Me.Hide()
        ProductosAlta.Show()
    End Sub

    Private Sub btnModificarProv_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProv.Click
        If idProducto = 0 Then
            MsgBox("No se ha seleccionado ningun producto")
        Else

            sql = "select nombre,marca,idTipoProducto, CantMedida,TipoMedida,puntoPedido, stock, calificacion from productos where idProducto=" & idProducto
            rta = consulta(sql)
            If rta.Read = True Then

                ProductosModificar.txtNombreProd.Text = rta(0)
                ProductosModificar.txtMarca.Text = rta(1)
                ProductosModificar.cmbUnidad.Text = rta(4)
                ProductosModificar.txtCant.Text = rta(3)
                ProductosModificar.txtPuntoP.Text = rta(5)
                ProductosModificar.txtCalif.Text = rta(7)
                ProductosModificar.txtStock.Text = rta(6)

                sql = "select descripcion from tipoProducto where idTipoProducto=" & rta(2) & ""
                rta2 = consulta(sql)
                If rta2.Read = True Then
                    ProductosModificar.cmbTipo.Text = rta2(0)
                End If
            End If
            ProductosModificar.Show()
            ProductosModificar.actualizarListaC()

        End If
    End Sub

    Private Sub btnEliminarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.Click

        Dim eliminar As Integer

        If idProducto = 0 Then

            MsgBox("No se ha seleccionado ningun producto")

        Else

            sql = "select nombre from productos where idProducto=" & idProducto & ""
            rta = consulta(sql)

            If rta.Read = True Then

                eliminar = MsgBox("Esta seguro que quiere eliminar el producto '' " & rta(0) & "''?", MsgBoxStyle.YesNo)
                If eliminar = 6 Then

                    sql = "update productos set estado=0 where idProducto=" & idProducto & ""
                    consulta(sql)

                    actualizarGrilla()
                    idProducto = 0
                Else
                    idProducto = 0

                End If

            End If
        End If

    End Sub

    Private Sub VolverABM_Click(sender As System.Object, e As System.EventArgs) Handles VolverABM.Click
        Me.Hide()
        MenuProductos.Show()

    End Sub
End Class