Public Class MenuProductos
    Dim Sql As String
    Dim rta, rta2 As Odbc.OdbcDataReader
    Private Sub MenuPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRecepcionarM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecepcionarM.Click
        Me.Hide()
        RecepcionarM.Show()
    End Sub

    Private Sub btnPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidos.Click
        Me.Hide()
        PedidosProductos.Show()
        PedidosProductos.cargarProductos()
    End Sub

    Private Sub btnControlC_Click(sender As System.Object, e As System.EventArgs) Handles btnControlC.Click
        Me.Hide()
        ControlCalidad.Show()


        Sql = " select idOrden , p.nombre Nombre, fecha Fecha, prioridad Prioridad from proveedores p, orden o where o.idproveedor=p.idproveedor and cargado=0 and pagado=1"
        CargarControlCalidad.ListaControl.DataSource = llenarGrilla(Sql)
        CargarControlCalidad.ListaControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CargarControlCalidad.numero = 0
        CargarControlCalidad.ListaControl.ClearSelection()



        Sql = "select count(*) from comprasP where fechaVencimiento<curdate() and chequeado = 0"
        rta = consulta(Sql)
        If rta.Read = True Then
            If rta(0) > 0 Then
                MsgBox("Pase por verificar, hay productos vencidos")
                Sql = "select * from ComprasP where fechavencimiento<curdate() and chequeado=0"
                rta2 = consulta(Sql)
                While rta2.Read = True
                    Sql = "update comprasP set estado=0 where idProducto=" & rta2(0) & " and fechaCarga='" & Format(rta2(2), "yyyy/MM/dd") & "' and idOrden=" & rta2(1) & ""
                    consulta(Sql)
                End While
            Else
                MsgBox("No hay productos vencidos")
            End If

        End If
    End Sub

    Private Sub btnProveedores_Click(sender As System.Object, e As System.EventArgs) Handles btnProveedores.Click
        Me.Hide()
        Proveedores.Show()
    End Sub

    Private Sub btnProductos_Click(sender As System.Object, e As System.EventArgs) Handles btnProductos.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub btnTipoP_Click(sender As System.Object, e As System.EventArgs) Handles btnTipoP.Click
        Me.Hide()
        TipoProducto.Show()
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        End
    End Sub
End Class
