Public Class RecepcionarM

    Dim sql, proveedor As String
    Dim nroOrden, importe, totalParcial, total As Integer
    Dim rta As Odbc.OdbcDataReader
    Dim dobleClick As Boolean

    Private Sub RecepcionarM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        sql = "select idOrden NroOrden, p.nombre Proveedor, fecha Fecha, prioridad Prioridad,  pagado Pagado from Orden o , Proveedores p where (p.idProveedor = o.idProveedor) and pagado = 0 "
        Me.dgvRecepcionarM.DataSource = Funciones.llenarGrilla(sql)

        btnRecepcionarM.Enabled = False
        btnVolverOrdenes.Enabled = False
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuProductos.Show()

        lblProveedor2.Text = ""
        lblOrden2.Text = ""
        lblInporteT2.Text = ""
        lblError.Text = ""
        btnRecepcionarM.Enabled = False
    End Sub

    Private Sub dgvRecepcionarM_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepcionarM.CellClick

        lblError.Text = ""
        total = 0
        totalParcial = 0

        Try
            nroOrden = dgvRecepcionarM.Rows(e.RowIndex).Cells("NroOrden").Value.ToString()
            proveedor = dgvRecepcionarM.Rows(e.RowIndex).Cells("Proveedor").Value.ToString()

            If nroOrden = 0 Then
                btnRecepcionarM.Enabled = False
            Else
                btnRecepcionarM.Enabled = True
            End If

            sql = "select idProducto, precioUnitario, cantidad from Orden o, OrdenProducto op where (op.idOrden=o.idOrden) and op.idOrden = " & nroOrden
            rta = consulta(sql)

            While rta.Read = True

                totalParcial += rta(1) * rta(2)
                total += totalParcial

                totalParcial = 0

            End While


            lblProveedor2.Text = proveedor
            lblOrden2.Text = nroOrden
            lblInporteT2.Text = total

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnRecepcionarM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecepcionarM.Click

       

        sql = "update Orden set pagado = 1 where idOrden = " & nroOrden
        consulta(sql)

        sql = "select idProducto, precioUnitario, cantidad from Orden o, OrdenProducto op where (op.idOrden=o.idOrden) and op.idOrden = " & nroOrden
        rta = consulta(sql)

        While rta.Read = True

            sql = "update Productos set stock = stock + " & rta(2) & " where idProducto= " & rta(0)
            consulta(sql)

        End While


        sql = "select idOrden NroOrden, p.nombre Proveedor, fecha Fecha, prioridad Prioridad,  pagado Pagado from Orden o , Proveedores p where (p.idProveedor = o.idProveedor) and pagado = 0"
        Me.dgvRecepcionarM.DataSource = Funciones.llenarGrilla(sql)

        lblProveedor2.Text = ""
        lblOrden2.Text = ""
        lblInporteT2.Text = ""
        lblError.Text = "Mercaderia Recepcionada - Stock Actualizado"
        btnRecepcionarM.Enabled = False

    End Sub

    Private Sub dgvRecepcionarM_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepcionarM.CellDoubleClick

        sql = "select  p.nombre Producto, precioUnitario Precio_Unitario, cantidad Cantidad from Orden o , Productos p, OrdenProducto op where (o.idOrden = op.idOrden) and (p.idProducto = op.idProducto) and op.idOrden = " & nroOrden
        Me.dgvRecepcionarM.DataSource = Funciones.llenarGrilla(sql)

        dobleClick = True

        btnVolverOrdenes.Enabled = True

    End Sub


    Private Sub dgvRecepcionarM_CellToolTipTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles dgvRecepcionarM.CellToolTipTextNeeded

        If dobleClick = False Then
            e.ToolTipText = "Doble click para ver el detalle de esta orden"
        Else
            e.ToolTipText = "Click en Ver Ordenes para volver"
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverOrdenes.Click

        sql = "select idOrden NroOrden, p.nombre Proveedor, fecha Fecha, prioridad Prioridad,  pagado Pagado from Orden o , Proveedores p where (p.idProveedor = o.idProveedor) and pagado = 0 "
        Me.dgvRecepcionarM.DataSource = Funciones.llenarGrilla(sql)

        dobleClick = False

        btnVolverOrdenes.Enabled = False


    End Sub
End Class