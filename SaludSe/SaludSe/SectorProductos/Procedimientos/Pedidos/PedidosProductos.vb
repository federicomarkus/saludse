Public Class PedidosProductos

    Dim sql, descripcion, proveedor, tipo, busqueda As String
    Dim codigo, stockD, stockC, precio, monto, precioU, codigoOrdenNueva, importeTotal, n, codigoProv, precioT, flag, x, total1 As Integer
    Dim rta, rta2 As Odbc.OdbcDataReader
    Dim array As ArrayList = New ArrayList()
    Dim totalParcial As Integer
    Dim var, fin, orden As Boolean
    Public totalImporte As Integer

    Private Sub Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        gbInfoInsumo.Enabled = False
        gbxDatosOrden.Enabled = False

        sql = "select p.idProducto Codigo, p.nombre Nombre_Producto,  marca Marca, pr.nombre Proveedor, t.descripcion Tipo_Producto , stock Stock, puntopedido Punto_Pedido, precio Precio_Unitario, p.calificacion Calificacion from Productos p, tipoProducto t, ProvProd pp, proveedores pr where (t.idTipoProducto = p.idTipoProducto) and (pp.idProveedor=pr.idProveedor) and (p.idProducto=pp.idProducto) and p.estado=1"
        Me.dgvPedidos.DataSource = Funciones.llenarGrilla(sql)

    End Sub

    Public Sub cargarProductos()

        sql = "select p.idProducto Codigo, p.nombre Nombre_Producto,  marca Marca, pr.nombre Proveedor, t.descripcion Tipo_Producto , stock Stock, puntopedido Punto_Pedido, precio Precio_Unitario, p.calificacion Calificacion from Productos p, tipoProducto t, ProvProd pp, proveedores pr where (t.idTipoProducto = p.idTipoProducto) and (pp.idProveedor=pr.idProveedor) and (p.idProducto=pp.idProducto) and p.estado=1"
        busqueda = sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            busqueda &= " and p.nombre like '%" & txtBuscador.Text & "%' "
            dgvPedidos.DataSource = Funciones.llenarGrilla(busqueda)
        Else
            dgvPedidos.DataSource = Funciones.llenarGrilla(sql)
        End If

        For Each fila As DataGridViewRow In dgvPedidos.Rows
            If fila.Cells("Stock").Value < 50 Then
                fila.DefaultCellStyle.BackColor = Color.Tomato
            ElseIf fila.Cells("Stock").Value < 100 Then
                fila.DefaultCellStyle.BackColor = Color.Yellow
            Else

            End If

        Next

    End Sub

    Private Sub btnSolicitarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitarP.Click
        gbInfoInsumo.Enabled = True
        gbxDatosOrden.Enabled = True
        txtStockC.Enabled = False
        btnSolicitarP.Enabled = False

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Dim result As DialogResult

        If orden Then

            result = MsgBox("Orden de compra en proceso...", MsgBoxStyle.YesNoCancel, "Advertencia")

            If result = MsgBoxResult.Yes Then

                confirmarPedido()
                Me.Hide()
                MenuProductos.Show()
                txtCodigo.Text = ""
                txtDescripcion.Text = ""
                txtPrecioU.Text = ""
                txtProveedor.Text = ""
                txtTipo.Text = ""
                txtStockD.Text = ""
                txtStockC.Text = ""
                txtPrecioT.Text = ""
                txtStockC.Enabled = False

                txtProveedor2.Text = ""
                txtImporteTotal.Text = ""
                txtNroOrden.Text = ""

                total1 = 0
                totalParcial = 0

                gbInfoInsumo.Enabled = False
                gbxDatosOrden.Enabled = False

                btnSolicitarP.Enabled = True

                orden = False

            ElseIf result = MsgBoxResult.No Then

                cancelarPedido()
                Me.Hide()
                MenuProductos.Show()
                txtCodigo.Text = ""
                txtDescripcion.Text = ""
                txtPrecioU.Text = ""
                txtProveedor.Text = ""
                txtTipo.Text = ""
                txtStockD.Text = ""
                txtStockC.Text = ""
                txtPrecioT.Text = ""
                txtStockC.Enabled = False

                txtProveedor2.Text = ""
                txtImporteTotal.Text = ""
                txtNroOrden.Text = ""

                total1 = 0
                totalParcial = 0

                gbInfoInsumo.Enabled = False
                gbxDatosOrden.Enabled = False

                btnSolicitarP.Enabled = True

                orden = False

            Else


            End If

        Else
            Me.Hide()
            MenuProductos.Show()
            txtCodigo.Text = ""
            txtDescripcion.Text = ""
            txtPrecioU.Text = ""
            txtProveedor.Text = ""
            txtTipo.Text = ""
            txtStockD.Text = ""
            txtStockC.Text = ""
            txtPrecioT.Text = ""
            txtStockC.Enabled = False

            txtProveedor2.Text = ""
            txtImporteTotal.Text = ""
            txtNroOrden.Text = ""

            total1 = 0
            totalParcial = 0

            gbInfoInsumo.Enabled = False
            gbxDatosOrden.Enabled = False

            btnSolicitarP.Enabled = True

            orden = False

        End If

    End Sub

    Private Sub dgvPedidos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        Try
            codigo = dgvPedidos.Rows(e.RowIndex).Cells("Codigo").Value.ToString()
            descripcion = dgvPedidos.Rows(e.RowIndex).Cells("Nombre_Producto").Value.ToString()
            stockD = dgvPedidos.Rows(e.RowIndex).Cells("Stock").Value.ToString()
            proveedor = dgvPedidos.Rows(e.RowIndex).Cells("Proveedor").Value.ToString()
            precioU = dgvPedidos.Rows(e.RowIndex).Cells("Precio_Unitario").Value.ToString()
            tipo = dgvPedidos.Rows(e.RowIndex).Cells("Tipo_Producto").Value.ToString()

            txtStockC.Enabled = True
            txtPrecioT.Text = ""


            If gbInfoInsumo.Enabled = True Then

                txtCodigo.Text = codigo
                txtDescripcion.Text = descripcion
                txtPrecioU.Text = precioU
                txtProveedor.Text = proveedor
                txtTipo.Text = tipo
                txtStockD.Text = stockD

                var = array.Contains(codigo)

                If var = True Then
                    btnAgregarP.Enabled = False
                    txtStockC.Enabled = False
                Else
                    txtStockC.Enabled = True
                    btnAgregarP.Enabled = True
                End If

            End If
        Catch ex As Exception


        End Try

        If lstProductosSolicitados.Items.Count = 0 Then
            fin = True
        Else
            fin = False
        End If



    End Sub

    Private Sub txtStockC_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtStockC.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub txtStockC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockC.TextChanged
        If txtStockC.Text <> "" And txtPrecioU.Text <> "" Then
            txtPrecioT.Text = txtPrecioU.Text * txtStockC.Text

            precioT = txtPrecioT.Text

        End If

        If txtStockC.Text = "" Or txtStockC.Enabled = False Then

            btnAgregarP.Enabled = False
        Else
            btnAgregarP.Enabled = True


        End If


    End Sub

    Private Sub btnVaciarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaciarC.Click
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecioU.Text = ""
        txtProveedor.Text = ""
        txtTipo.Text = ""
        txtStockD.Text = ""
        txtStockC.Text = ""
        txtPrecioT.Text = ""
        txtStockC.Enabled = False
    End Sub

    Private Sub btnAgregarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarP.Click

        orden = True

        If txtStockC.Text = "" Then

            MsgBox("Indique el stock a comprar", MsgBoxStyle.Critical, "ERROR")

        Else

            btnCancelar.Enabled = True
            btnConfirmar.Enabled = True

            If fin = True Then

                sql = "select max(idOrden) from Orden"
                rta = consulta(sql)

                If rta.Read = True Then
                    txtNroOrden.Text = rta(0) + 1
                    codigoOrdenNueva = rta(0) + 1
                End If

                fin = False

            End If

            lstProductosSolicitados.Items.Add(txtDescripcion.Text)
            array.Add(codigo)



            txtProveedor2.Text = proveedor
            totalParcial = precioT
            txtImporteTotal.Text = totalParcial + total1
            total1 = total1 + totalParcial


            sql = "select idProveedor from Proveedores where nombre ='" & txtProveedor2.Text & "'"
            rta2 = consulta(sql)

            If rta2.Read = True Then
                codigoProv = rta2(0)
            End If

            If flag = 0 Then
                sql = "insert into Orden values ('', " & codigoProv & ", '" & Format(Date.Today, "yyyy/MM/dd") & "', 0 , 0, 0)"
                consulta(sql)
                flag = 1

                sql = "select max(idOrden) from Orden"
                rta = consulta(sql)

                If rta.Read = True Then
                    txtNroOrden.Text = rta(0)
                    codigoOrdenNueva = rta(0)
                End If

            End If

            sql = "insert into OrdenProducto values (" & codigoOrdenNueva & ", " & codigo & ", " & precioU & ", '" & txtStockC.Text & "', 0)"
            consulta(sql)

            txtCodigo.Text = ""
            txtDescripcion.Text = ""
            txtPrecioU.Text = ""
            txtProveedor.Text = ""
            txtTipo.Text = ""
            txtStockD.Text = ""
            txtStockC.Text = ""
            txtPrecioT.Text = ""
            txtStockC.Enabled = False

            sql = "select p.idProducto Codigo, p.nombre Nombre_Producto,  marca Marca, pr.nombre Proveedor, t.descripcion Tipo_Producto , stock Stock, puntopedido Punto_Pedido, precio Precio_Unitario, p.calificacion Calificacion from Productos p, tipoProducto t, ProvProd pp, proveedores pr where (t.idTipoProducto = p.idTipoProducto) and (pp.idProveedor=pr.idProveedor) and (p.idProducto=pp.idProducto) and pr.nombre='" & txtProveedor2.Text & "'"
            Me.dgvPedidos.DataSource = Funciones.llenarGrilla(sql)

        End If

        totalParcial = 0

    End Sub

    Private Sub cancelarPedido()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecioU.Text = ""
        txtProveedor.Text = ""
        txtTipo.Text = ""
        txtStockD.Text = ""
        txtStockC.Text = ""
        txtPrecioT.Text = ""
        txtStockC.Enabled = False

        txtProveedor2.Text = ""
        txtImporteTotal.Text = ""
        txtNroOrden.Text = ""

        total1 = 0
        totalParcial = 0
        flag = 0

        gbInfoInsumo.Enabled = False
        gbxDatosOrden.Enabled = False

        btnSolicitarP.Enabled = True

        btnCancelar.Enabled = False
        btnConfirmar.Enabled = False

        array.Clear()

        sql = "delete from OrdenProducto where idOrden = " & codigoOrdenNueva
        consulta(sql)

        sql = "delete from Orden where idOrden = " & codigoOrdenNueva
        consulta(sql)


        sql = "select p.idProducto Codigo, p.nombre Nombre_Producto,  marca Marca, pr.nombre Proveedor, t.descripcion Tipo_Producto , stock Stock, puntopedido Punto_Pedido, precio Precio_Unitario, p.calificacion Calificacion from Productos p, tipoProducto t, ProvProd pp, proveedores pr where (t.idTipoProducto = p.idTipoProducto) and (pp.idProveedor=pr.idProveedor) and (p.idProducto=pp.idProducto)"
        Me.dgvPedidos.DataSource = Funciones.llenarGrilla(sql)

        lstProductosSolicitados.Items.Clear()

        MsgBox("Orden de pedido Cancelada", MsgBoxStyle.Exclamation, "CANCELAR")
        orden = False

    End Sub

    Private Sub confirmarPedido()
        fin = True
        MsgBox("Orden de compra Finalizada", MsgBoxStyle.Exclamation, "ORDEN FINALIZADA")

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecioU.Text = ""
        txtProveedor.Text = ""
        txtTipo.Text = ""
        txtStockD.Text = ""
        txtStockC.Text = ""
        txtPrecioT.Text = ""
        txtStockC.Enabled = False

        txtProveedor2.Text = ""
        txtImporteTotal.Text = ""
        txtNroOrden.Text = ""

        total1 = 0
        totalParcial = 0

        gbInfoInsumo.Enabled = False
        gbxDatosOrden.Enabled = False

        btnSolicitarP.Enabled = True

        array.Clear()

        btnCancelar.Enabled = False
        btnConfirmar.Enabled = False

        flag = 0

        sql = "select p.idProducto Codigo, p.nombre Nombre_Producto,  marca Marca, pr.nombre Proveedor, t.descripcion Tipo_Producto , stock Stock, puntopedido Punto_Pedido, precio Precio_Unitario, p.calificacion Calificacion from Productos p, tipoProducto t, ProvProd pp, proveedores pr where (t.idTipoProducto = p.idTipoProducto) and (pp.idProveedor=pr.idProveedor) and (p.idProducto=pp.idProducto)"
        Me.dgvPedidos.DataSource = Funciones.llenarGrilla(sql)

        lstProductosSolicitados.Items.Clear()
        orden = False

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        cancelarPedido()

        orden = False

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        confirmarPedido()
        cargarProductos()
        OrdenCompra.Show()

        sql = "select o.*,p.nombre from Orden o, Proveedores p where (p.idproveedor=o.idproveedor) and idorden=(select max(idorden) from Orden)"
        rta = consulta(sql)

        If rta.Read = True Then

            OrdenCompra.lblNroOrden.Text = rta(0)
            OrdenCompra.lblFecha1.Text = rta(2).ToString.Remove(11)
            OrdenCompra.lblNombreProveedor.Text = rta("nombre")
            OrdenCompra.lblAutorizado.Text = "SaludSe"
            OrdenCompra.lblFirma.Text = "SaludSe"
            OrdenCompra.lblComentarios.Text = "-"


            sql = "select o.cantidad, o.precioUnitario, p.nombre from OrdenProducto o, Productos p where (p.idProducto=o.idProducto) and idorden=" & rta(0) & ""
            rta2 = consulta(sql)

            Do While rta2.Read = True

                totalImporte = totalImporte + (rta2(0) * rta2(1))
                x = x + 1

                If x = 1 Then
                    OrdenCompra.lblCantidad1.Text = rta2(0)
                    OrdenCompra.lblDescripcion1.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario1.Text = rta2(1)
                    OrdenCompra.lblImporte1.Text = rta2(0) * rta2(1)
                End If
                If x = 2 Then
                    OrdenCompra.lblCantidad2.Text = rta2(0)
                    OrdenCompra.lblDescripcion2.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario2.Text = rta2(1)
                    OrdenCompra.lblImporte2.Text = rta2(0) * rta2(1)
                End If
                If x = 3 Then
                    OrdenCompra.lblCantidad3.Text = rta2(0)
                    OrdenCompra.lblDescripcion3.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario3.Text = rta2(1)
                    OrdenCompra.lblImporte3.Text = rta2(0) * rta2(1)
                End If
                If x = 4 Then
                    OrdenCompra.lblCantidad4.Text = rta2(0)
                    OrdenCompra.lblDescripcion4.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario4.Text = rta2(1)
                    OrdenCompra.lblImporte4.Text = rta2(0) * rta2(1)
                End If
                If x = 5 Then
                    OrdenCompra.lblCantidad5.Text = rta2(0)
                    OrdenCompra.lblDescripcion5.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario5.Text = rta2(1)
                    OrdenCompra.lblImporte5.Text = rta2(0) * rta2(1)
                End If
                If x = 6 Then
                    OrdenCompra.lblCantidad6.Text = rta2(0)
                    OrdenCompra.lblDescripcion6.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario6.Text = rta2(1)
                    OrdenCompra.lblImporte6.Text = rta2(0) * rta2(1)
                End If
                If x = 7 Then
                    OrdenCompra.lblCantidad7.Text = rta2(0)
                    OrdenCompra.lblDescripcion7.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario7.Text = rta2(1)
                    OrdenCompra.lblImporte7.Text = rta2(0) * rta2(1)
                End If
                If x = 8 Then
                    OrdenCompra.lblCantidad8.Text = rta2(0)
                    OrdenCompra.lblDescripcion8.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario8.Text = rta2(1)
                    OrdenCompra.lblImporte8.Text = rta2(0) * rta2(1)
                End If
                If x = 9 Then
                    OrdenCompra.lblCantidad9.Text = rta2(0)
                    OrdenCompra.lblDescripcion9.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario9.Text = rta2(1)
                    OrdenCompra.lblImporte9.Text = rta2(0) * rta2(1)
                End If
                If x = 10 Then
                    OrdenCompra.lblCantidad10.Text = rta2(0)
                    OrdenCompra.lblDescripcion10.Text = rta2(2)
                    OrdenCompra.lblCostoUnitario10.Text = rta2(1)
                    OrdenCompra.lblImporte10.Text = rta2(0) * rta2(1)
                End If

            Loop

            OrdenCompra.lblTotal.Text = totalImporte

            x = 0

        End If


    End Sub

    Private Sub txtBuscador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarProductos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPedidosP.Click
        Me.Hide()
        PedidosSolicitados.Show()
        PedidosSolicitados.cargarSolicitudes()
    End Sub
End Class