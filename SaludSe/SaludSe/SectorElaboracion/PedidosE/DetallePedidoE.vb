Imports System.Data.Odbc

Public Class DetallePedidoE

    Public idPedidoSucursal As Integer
    Dim idPedido As Integer
    Dim sql As String
    Dim rs, rsProductos As OdbcDataReader
    Dim idMenus As ArrayList = New ArrayList
    Dim productos As ArrayList = New ArrayList

    Private Structure MenuPedidos
        Dim idMenu As Integer
        Dim cantidad As Integer
    End Structure

    Private Structure ProductosPedidos
        Dim idProducto As Integer
        Dim nombre As String
        Dim cantidad As Integer
    End Structure



    Public Sub cargarDatos()
        productos = New ArrayList
        idMenus = New ArrayList
        sql = "select nombre, fechaP, estado, ps.idpedido  from PedidosSucursales PS, Pedido P, Sucursales S where p.idpedido = ps.idpedido and s.idsucursal = p.idsucursal and idpedsucu = " & idPedidoSucursal & " "
        rs = Funciones.consulta(sql)

        If rs.Read Then
            txtSucursal.Text = rs(0)
            dtpFecha.Text = rs(1)
            txtEstado.Text = rs(2)
            idPedido = rs(3)
        End If

        Dim menuPedidos = New MenuPedidos

        sql = "select idMenu, cantidad from pedidosdetalle where idpedido = " & idPedido & ""
        rs = Funciones.consulta(sql)

        Do While rs.Read
            menuPedidos.idMenu = rs(0)
            menuPedidos.cantidad = rs(1)

            idMenus.Add(menuPedidos)
        Loop

        Dim productosPedidos = New ProductosPedidos

        For Each menu As MenuPedidos In idMenus

            sql = "select idElemento, cantidad, tipo from menuproductos where idmenu = " & menu.idMenu & ""
            rs = Funciones.consulta(sql)
            ' MULTIPLICAR POR LA CANTIDAD MENU.CANTIDAD
            Do While rs.Read

                If rs(2).Equals("Receta") Then

                    sql = "select p.idProducto, cantidad, p.nombre from recetasproductos r, productos p where p.idproducto=r.idproducto and idreceta =" & rs(0) & ""
                    rsProductos = Funciones.consulta(sql)

                    Do While rsProductos.Read

                        productosPedidos.idProducto = rsProductos(0)
                        productosPedidos.cantidad = rsProductos(1) * rs(1) * menu.cantidad
                        productosPedidos.nombre = rsProductos(2)

                        Dim existe As Boolean = False
                        Dim indice, indiceExiste As Integer
                        Dim prod As ProductosPedidos = New ProductosPedidos
                        For Each p In productos
                            If p.idProducto = productosPedidos.idProducto Then
                                indiceExiste = indice
                                prod = productos(indiceExiste)
                                prod.cantidad = prod.cantidad + productosPedidos.cantidad
                                existe = True
                            End If
                            indice = indice + 1
                        Next
                        If Not existe Then
                            productos.Add(productosPedidos)
                        End If
                        If existe Then
                            productos(indiceExiste) = prod
                        End If
                    Loop


                Else

                    sql = "select nombre from productos where idproducto = " & rs(0) & ""
                    rsProductos = Funciones.consulta(sql)

                    If rsProductos.Read Then

                        productosPedidos.idProducto = rs(0)
                        productosPedidos.cantidad = rs(1) * menu.cantidad
                        productosPedidos.nombre = rsProductos(0)
                        Dim existe As Boolean = False
                        Dim indice, indiceExiste As Integer
                        Dim prod As ProductosPedidos = New ProductosPedidos
                        For Each p As ProductosPedidos In productos
                            If p.idProducto = productosPedidos.idProducto Then
                                indiceExiste = indice
                                prod = productos(indiceExiste)
                                prod.cantidad = prod.cantidad + productosPedidos.cantidad
                                existe = True
                            End If
                            indice = indice + 1
                        Next
                        If Not existe Then
                            productos.Add(productosPedidos)
                        End If
                        If existe Then
                            Dim p As ProductosPedidos = productos(indiceExiste)
                            p.cantidad = p.cantidad + prod.cantidad
                            productos(indiceExiste) = p
                        End If

                    End If

                End If

            Loop


        Next
        dgvGrilla.Rows.Clear()
        For Each producto As ProductosPedidos In productos
            dgvGrilla.Rows.Add(producto.idProducto, producto.nombre, producto.cantidad)
        Next
        If dgvGrilla.Rows.Count > 0 Then
            dgvGrilla.Rows(0).Selected = False
        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuElaboracion.Show()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If txtEstado.Text = "Pendiente" Then
            Dim fecha, fechaEntrega As Date
            fecha = Format("yyyy/MM/dd", dtpFecha.Text)
            fechaEntrega = fecha.AddDays(2)

            sql = "insert into SolicitudesProducto values ('', 'Pedido de Productos', '" & fecha & "', '" & fechaEntrega & "', 'PENDIENTE')"
            Funciones.consulta(sql)

            sql = "select max(idsolicitud) from solicitudesproducto"
            rs = Funciones.consulta(sql)

            If rs.Read Then
                For Each producto As ProductosPedidos In productos
                    sql = "insert into DetalleSolicitudProductos values (" & rs(0) & ", " & producto.idProducto & ", " & producto.cantidad & ")"
                    Funciones.consulta(sql)
                Next
                sql = "update PedidosSucursales set estado = 'Productos Pedidos' where idpedsucu = " & idPedidoSucursal & ""
                Funciones.consulta(sql)
            End If

            MsgBox("Se envio el pedido al Sector de Productos")
            cargarDatos()
        Else
            MsgBox("El pedido ya ha sido generado")
        End If
    End Sub
End Class