Public Class PedidosSolicitados
    Dim sql As String
    Dim rta, rta2 As Odbc.OdbcDataReader
    Dim detalle, faltaStock As Boolean
    Dim estado As String
    Public idSolicitud, stock, cantidad As Integer
    Public sector As String = "Elaboracion" ' PROVISORIO

    Private Sub PedidosSolicitados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        cargarSolicitudes()
    End Sub

    Public Sub cargarSolicitudes()
        If sql = "Productos" Then
            sql = "select * from SolicitudesProducto where estado='PENDIENTE'"
        Else
            sql = "select * from SolicitudesProducto where estado='Entregado'"
        End If
        dgvPedidosS.DataSource = llenarGrilla(sql)

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        PedidosProductos.cargarProductos()

    End Sub

    Private Sub dgvPedidosS_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidosS.CellClick
        Try
            idSolicitud = dgvPedidosS.Rows(e.RowIndex).Cells("idSolicitud").Value.ToString
            estado = dgvPedidosS.Rows(e.RowIndex).Cells("estado").Value.ToString
            btnEnviarP.Enabled = True
        Catch ex As Exception
        End Try

        If estado = "Entregado" Then
            btnRecepcionar.Enabled = True
        Else
            btnRecepcionar.Enabled = False
        End If

    End Sub

    Private Sub dgvPedidosS_CellToolTipTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles dgvPedidosS.CellToolTipTextNeeded
        If detalle = True Then
            e.ToolTipText = "Click en ver solicitudes para volver"
        Else
            e.ToolTipText = "Doble click para ver el detalle de esta solicitud"
        End If

    End Sub

    Private Sub dgvPedidosS_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPedidosS.DoubleClick
        cargarDetalleS()
        detalle = True
        btnVerSolicitudes.Enabled = True
    End Sub

    Public Sub cargarDetalleS()
        sql = "select p.nombre, d.cantidad, s.fecha Fecha_Pedido from Productos p , SolicitudesProducto s, DetalleSolicitudProductos d where (p.idProducto=d.idProducto) and (s.idSolicitud=d.idSolicitud) and d.idSolicitud = " & idSolicitud
        dgvPedidosS.DataSource = llenarGrilla(sql)
    End Sub

    Private Sub btnVerSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerSolicitudes.Click
        detalle = False
        btnVerSolicitudes.Enabled = False
        cargarSolicitudes()
    End Sub

    Private Sub btnSolicitarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarP.Click
        MsgBox("Verificando stocks")

        sql = "select d.idProducto, p.nombre, d.cantidad, s.fecha Fecha_Pedido from Productos p , SolicitudesProducto s, DetalleSolicitudProductos d where (p.idProducto=d.idProducto) and (s.idSolicitud=d.idSolicitud) and d.idSolicitud = " & idSolicitud
        rta = consulta(sql)

        Do While rta.Read = True

            sql = "select p.stock from Productos p , SolicitudesProducto s, DetalleSolicitudProductos d where (p.idProducto=d.idProducto) and (s.idSolicitud=d.idSolicitud) and p.idProducto= " & rta(0)
            rta2 = consulta(sql)

            MsgBox(sql)
            If rta2.Read = True Then

                If rta2(0) > rta(2) Then

                    MsgBox("Hay stock para " + rta(1), MsgBoxStyle.Exclamation, "Hay stock")

                Else

                    MsgBox("Faltante de Stock para el producto: " + rta(1), MsgBoxStyle.Critical, "Falta de Stock")

                    faltaStock = True

                End If

            End If



        Loop

        If faltaStock = True Then
            MsgBox("No se puede entregar la mercaderia ya que no se dispone de stock para todos los productos", MsgBoxStyle.MsgBoxHelp)
            cargarSolicitudes()
            idSolicitud = 0
            btnEnviarP.Enabled = False
        Else
            MsgBox("Entregando Mercaderia...")


            sql = "select d.idProducto, d.cantidad from Productos p , SolicitudesProducto s, DetalleSolicitudProductos d where (p.idProducto=d.idProducto) and (s.idSolicitud=d.idSolicitud) and d.idSolicitud = " & idSolicitud
            rta = consulta(sql)

            Do While rta.Read = True

                sql = "select p.stock from Productos p , SolicitudesProducto s, DetalleSolicitudProductos d where (p.idProducto=d.idProducto) and (s.idSolicitud=d.idSolicitud) and p.idProducto= " & rta(0)
                rta2 = consulta(sql)

                cantidad = rta(1)

                If rta2.Read = True Then
                    stock = rta2(0)

                    stock = stock - cantidad
                    MsgBox("Actualizando " + CStr(rta(0)) + " del stock ")

                    sql = "update Productos set stock = " & stock & " where idProducto=" & rta(0)
                    consulta(sql)

                End If

            Loop

            sql = "update SolicitudesProducto set estado='Entregado' where idSolicitud = " & idSolicitud
            consulta(sql)

            cargarSolicitudes()
            PedidosProductos.cargarProductos()
            idSolicitud = 0
            btnEnviarP.Enabled = False

        End If


    End Sub

    Private Sub btnRecepcionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecepcionar.Click
        sql = "update solicitudesproducto set estado = 'Finalizado' where idSolicitud= " & idSolicitud & ""
        Funciones.consulta(sql)
        MsgBox("Finalizó el pedido Nº " & idSolicitud)
    End Sub
End Class