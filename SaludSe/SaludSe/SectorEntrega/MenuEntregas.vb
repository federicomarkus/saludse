Public Class MenuEntregas

    '(ENTREGAS)
    'El POINT sirve para ir hacia atrás.
    Private pointP As String
    Private pointC As String
    Private pointD As String
    Private pointE As String
    Private circuito As String

    Private dgv As String
    Private doubleClic As Boolean = False 'Detecta que no se haga doble click mas de una vez en el datagrigview.
    Private monto As Integer = 0
    Private nro As Integer = 0
    'OPTIMO SIZE 1039; 619 1327; 705


    Private Sub Entregas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        AsignarTurnos()
        CargarCircuitos("Pedidos")
        CargarCircuitos("Cobros")
        CargarCircuitos("Empleados")

    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'CARGA DE CIRCUITOS

    Private Sub CargarCircuitos(ByVal circuitos As String)
        Select Case circuitos
            Case "Pedidos"
                'Circuito PEDIDOS
                sql = "Select e.idpedido Código,fechaped Fecha,horaped Hora,monto Total,pc.estado Estado from envios e, pedidosclientes pc,clienteventas cv,ticket t where e.idpedido=pc.idpedido and pc.idclienteventas=cv.idclienteventas and pc.idpedido=t.idpedido and pc.idpedido IN (select idpedido from envios) and cv.tipocli = 'Delivery' and cv.estado = 1 and pc.estado != 'Cancelado' and pc.estado != 'Entregado' and pc.estado != 'Enviado' and e.entregado = 0 order by fechaped,horaped"
                data(Me.dgvPedidos, False)
                sql = "select ve.idvehi Vehiculo,count(idenvio) Pedidos from vehiculoenvios ve,vehiculo v where(ve.idvehi = v.idvehi) and disponibilidad = 1 and activa = 0 and ve.activo = 1 group by ve.idvehi"
                data(Me.dgvP_VehiculoPedidos, False)
                lblP_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
                dgv = "Pedidos"
                circuito = "Pedido"
                btnPedidos.BackColor = Color.AntiqueWhite

                sql = "select count(idenvio) from envios where entregado = 1"
                carga(sql, False)
                If rs.Read = True Then
                    lblP_WidgetEntregados.Text = rs(0)
                End If
                sql = "select count(idpedido) from pedidosclientes where estado = 'Enviado'"
                carga(sql, False)
                If rs.Read = True Then
                    lblP_WidgetEnviados.Text = rs(0)
                End If
                sql = "select count(idpedido) from pedidosclientes where estado = 'Cancelado'"
                carga(sql, False)
                If rs.Read = True Then
                    lblP_WidgetCancelados.Text = rs(0)
                End If
                sql = "select count(idpedido) from pedidosclientes where estado = 'Activo'"
                carga(sql, False)
                If rs.Read = True Then
                    lblP_WidgetActivos.Text = rs(0)
                End If
                sql = "select sum(monto) from pedidosclientes pc, ticket t where pc.idpedido = t.idpedido and pc.estado = 'Entregado'"
                carga(sql, False)
                If rs.Read = True And rs(0).ToString <> "" Then
                    lblP_WidgetCobrado.Text = "$ " & rs(0)
                Else
                    lblP_WidgetCobrado.Text = "$ 0"
                End If

            Case "Cobros"
                'Circuito COBROS
                sql = "select e.idpedido Código,Fechaped Fecha, horaped Hora,monto Total from pedidosclientes pc,envios e, ticket t where pc.idpedido=e.idpedido and pc.idpedido=t.idpedido and fechaenvio != 'NULL' and entregado = 0"
                data(Me.dgvCobros, False)

                'Circuito DELIVERY
                sql = "select idvehi Código, Marca, Modelo, Patente, tipovehi Tipo, activa EnServicio from vehiculo where disponibilidad = 1 and activo = 1"
                data(Me.dgvDelivey, False)
                sql = "select count(distinct idvehi) from mantenimiento"
                carga(sql, False)
                If rs.Read = True Then
                    sql = "select idvehi CódigoVehículo, fechaegreso Egreso,fechaingreso Ingreso, Motivo from mantenimiento where activo = 1 order by fechaegreso DESC LIMIT " & rs(0)
                    data(Me.dgvDelivery_Mantenimiento, False)
                End If
            Case "Empleados"
                'Circuito EMPLEADOS
                sql = "select idEmpleado Código, Nombre,Apellido,Cargo from empleados e,personas p where e.idpersona=p.idpersona and idsector = (select idsector from sectores where sector = 'Entrega') and cargo = 'Repartidor' and estado = 1"
                data(Me.dgvEmpleados, False)
                sql = "select idempleado Código,Fecha,HoraInicio Entrada,HoraFin Salida,Turno from turno t, empleadoturno et where t.idturno=et.idturno order by idemptur"
                data(Me.dgvE_TurnoEmpleados, False)
                'RendimientoEmpleado()
        End Select






    End Sub

    ' FIN CARGA DE CIRCUITOS
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    'Blanquear
    Public Sub Limpiar()
        'PEDIDOS
        lblP_Nro.Text = "Nro"
        lblP_Nombre.Text = "Sr/a:"
        lblP_Direccion.Text = "Dirección:"
        lbP_Nombre.Items.Clear()
        lbP_Cantidad.Items.Clear()
        lbP_PrecioU.Items.Clear()
        lbP_Total.Items.Clear()
        txtP_Total.Text = "$ "

        'COBROS
        lblC_Nro.Text = "Nro"
        lblC_Nombre.Text = "Sr/a:"
        lblC_Direccion.Text = "Dirección:"
        lbC_Nombre.Items.Clear()
        lbC_Cantidad.Items.Clear()
        lbC_PrecioU.Items.Clear()
        lbC_Total.Items.Clear()
        txtC_Total.Text = "$ "
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'ATRAS

    'btnATRAS
    Private Sub btnBackLeft_Click() Handles btnBackLeft.Click
        Select Case circuito
            Case "Pedido"
                AtrasPedido()
            Case "Cobro"
                AtrasCobro()
            Case "Delivery"
                AtrasDelivery()
            Case Else
                AtrasEmpleado()
        End Select
    End Sub

    Public Sub AtrasPedido()
        Select Case pointP
            Case "DetallePedido"
                sql = "Select e.idpedido Código,fechaped Fecha,horaped Hora,monto Total,pc.estado Estado from envios e, pedidosclientes pc,clienteventas cv,ticket t where e.idpedido=pc.idpedido and pc.idclienteventas=cv.idclienteventas and pc.idpedido=t.idpedido and pc.idpedido IN (select idpedido from envios) and cv.tipocli = 'Delivery' and cv.estado = 1 and pc.estado != 'Cancelado' and pc.estado != 'Entregado' and pc.estado != 'Enviado' and e.entregado = 0 order by fechaped,horaped"
                data(Me.dgvPedidos, False)
                dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                lblDesc.Text = "Confección de pedidos y ordenes de entregas."
                doubleClic = False
                dgv = "Pedidos"
                btnActivo.Visible = True
                btnEnviado.Visible = True
                btnCancelado.Visible = True
                btnEnviado.Text = "Enviado"
                btnEnviado.BackColor = Color.FromArgb(253, 206, 169)
                btnCancelado.Text = "Cancelado"
                pointP = ""
                btnP_Generar.Text = "Generar"
                btnP_Generar.Enabled = True
                CargarCircuitos("Pedidos")
            Case "DetalleMoto"
                dgv = "Motos"
                sql = "select ve.idvehi Vehiculo,count(idenvio) Pedidos ,activa Activa from vehiculoenvios ve,vehiculo v where(ve.idvehi = v.idvehi) and disponibilidad = 1 and activa = 0 group by ve.idvehi"
                data(Me.dgvPedidos, False)
                pointP = "DetallePedido"
                doubleClic = False
            Case Else

        End Select
    End Sub

    Private Sub AtrasDelivery()
        Select Case pointD
            Case "VehiculosNoDisponibles"
                sql = "select idvehi Código, Marca, Modelo, Patente, tipovehi Tipo, activa EnServicio from vehiculo where disponibilidad = 1"
                data(Me.dgvDelivey, False)
                pointD = ""
            Case "AgregarVehiculo"
                pnlD_AgregarVehiculo.Visible = False
                btnD_AgregarVehiculo.Visible = True
                pointD = ""
            Case Else

        End Select
    End Sub

    Private Sub AtrasCobro()
        Select Case pointC

        End Select
    End Sub

    Private Sub AtrasEmpleado()
        Select Case pointE

        End Select
    End Sub

    'FIN ATRAS
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'DISEÑO DE DATAGRIDVIEW (Por circuito)

    ' ----------
    '| PEDIDOS  |
    ' ----------
    Private Sub dgvPedidos_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvPedidos.CellFormatting

        Select Case dgv
            Case "DetallePedido"

            Case "Pedidos"

                If e.RowIndex < Me.dgvPedidos.RowCount - 1 Then
                    Select Case Me.dgvPedidos.Item(4, e.RowIndex).Value.ToString
                        Case "Activo"
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.FromArgb(153, 185, 152)
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.FromArgb(153, 185, 152)
                        Case "Enviado"
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.FromArgb(253, 206, 169)
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.FromArgb(253, 206, 169)
                        Case "Cancelado"
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.FromArgb(234, 73, 95)
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.FromArgb(234, 73, 95)
                        Case Else
                    End Select
                End If

            Case "Motos"
                If e.RowIndex < Me.dgvPedidos.RowCount - 1 Then
                    Select Case Me.dgvPedidos.Item(2, e.RowIndex).Value.ToString
                        Case "0"
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.FromArgb(153, 185, 152)
                            Me.dgvPedidos.Rows(e.RowIndex).Cells(2).Style.ForeColor = Color.FromArgb(153, 185, 152)
                    End Select
                End If
        End Select

    End Sub


    'FIN DISEÑO DE DATAGRIDVIEW (Por circuito)
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub dgvPedidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPedidos.DoubleClick
        If doubleClic = False Then
            Select Case dgv
                Case "Pedidos"
                    If dgvPedidos.CurrentRow.Cells(1).Value.ToString <> "" Then
                        dgv = "DetallePedido"
                        sql = "select m.nombre Nombre,pm.observacion Observación,pm.cant Cantidad,mv.precioVenta PrecioUnitario,mv.precioVenta*pm.cant Total from PedidoMenu pm, MenuVenta mv, menu m where pm.idMenuVenta=mv.idMenuVenta and mv.idmenu=m.idmenu and idPedido=" & dgvPedidos.CurrentRow.Cells(0).Value
                        data(Me.dgvPedidos, False)
                        pointP = "DetallePedido"
                        doubleClic = True
                    End If
                Case "Motos"
                    If dgvPedidos.CurrentRow.Cells(0).Selected = True Then
                        sql = "select idVehi Codigo,marca Marca, modelo Modelo, patente Patente from vehiculo where idvehi =" & dgvPedidos.CurrentRow.Cells(0).Value
                        data(Me.dgvPedidos, False)
                        pointP = "DetalleMoto"
                        doubleClic = True
                    ElseIf dgvPedidos.CurrentRow.Cells(1).Selected = True Then
                        sql = "select pc.idPedido Código, fechaPed Fecha, horaPed Hora, monto Precio, pc.estado Estado from PedidosClientes pc, ticket t, envios e, vehiculoenvios ve where pc.idpedido = t.idpedido and pc.idpedido=e.idpedido and e.idenvio=ve.idenvio and idvehi = 4"
                        data(Me.dgvPedidos, False)
                        pointP = "DetalleMoto"
                        doubleClic = True
                    End If
            End Select
        Else

        End If
    End Sub

    Private Sub btnActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivo.Click
        sql = "select idPedido Código, fechaPed Fecha, horaPed Hora, precioTot Precio, pc.estado Estado from PedidosClientes pc, ClienteVentas cv where pc.idClienteVentas=cv.idClienteVentas and tipoCli = 'Delivery' and cv.estado = 1 and pc.estado = 'Activo'"
        data(Me.dgvPedidos, False)
        lblDesc.Text = "Pedidos activos."
        btnP_Generar.Enabled = False
        pointP = "DetallePedido"
    End Sub

    Private Sub btnEnviado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviado.Click
        sql = "Select e.idpedido Código,fechaped Fecha,horaped Hora,preciotot Total,pc.estado Estado from envios e, pedidosclientes pc,clienteventas cv where e.idpedido=pc.idpedido and pc.idclienteventas=cv.idclienteventas and pc.idpedido IN (select idpedido from envios) and cv.tipocli = 'Delivery' and cv.estado = 1 and pc.estado != 'Cancelado' and pc.estado != 'Activo' order by e.idpedido"
        data(Me.dgvPedidos, False)
        lblDesc.Text = "Pedidos pendientes."
        btnP_Generar.Enabled = False
        pointP = "DetallePedido"
    End Sub

    Private Sub btnCancelado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelado.Click
        sql = "select idPedido Código, fechaPed Fecha, horaPed Hora, precioTot Precio, pc.estado Estado from PedidosClientes pc, ClienteVentas cv where pc.idClienteVentas=cv.idClienteVentas and tipoCli = 'Delivery' and cv.estado = 1 and pc.estado = 'Cancelado'"
        data(Me.dgvPedidos, False)
        lblDesc.Text = "Pedidos cancelado."
        btnP_Generar.Enabled = False
        pointP = "DetallePedido"
    End Sub

    Private Sub dgvPedidos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        Select Case dgv
            Case "Pedidos"
                If doubleClic = False And dgvPedidos.CurrentRow.Cells(0).Value.ToString <> "" And dgvPedidos.CurrentRow.Cells(4).Value.ToString <> "Cancelado" Then
                    btnP_Generar.Enabled = True
                    OrdenDeEntrega.lblOE_Fecha.Text = lblP_Fecha.Text
                    lblP_Nro.Text = dgvPedidos.CurrentRow.Cells(0).Value
                    OrdenDeEntrega.lblOE_Nro.Text = lblP_Nro.Text
                    sql = "select nombre, apellido,direEnvio from pedidosclientes pc, clienteventas cv, personas p, envios e where(pc.idClienteVentas = cv.idClienteVentas And cv.idPersona = p.idPersona And pc.idpedido = e.idpedido) and cv.idClienteVentas = (select idClienteVentas from pedidosclientes where idpedido=" & dgvPedidos.CurrentRow.Cells(0).Value & ")"
                    carga(sql, False)
                    If rs.Read = True Then
                        lblP_Nombre.Text = "Sr/a: " & rs(0) & " " & rs(1)
                        lblP_Direccion.Text = "Dirección: " & rs(2)

                        OrdenDeEntrega.lblOE_Nombre.Text = lblP_Nombre.Text
                        OrdenDeEntrega.lblOE_Direccion.Text = lblP_Direccion.Text

                    End If
                    sql = "select m.nombre Nombre,pm.cant Cantidad,mv.precioVenta PrecioUnitario,mv.precioVenta*pm.cant Total from PedidoMenu pm, MenuVenta mv, menu m where pm.idMenuVenta=mv.idMenuVenta and mv.idmenu=m.idmenu and idPedido=" & dgvPedidos.CurrentRow.Cells(0).Value
                    carga(sql, False)
                    lbP_Nombre.Items.Clear()
                    lbP_Cantidad.Items.Clear()
                    lbP_PrecioU.Items.Clear()
                    lbP_Total.Items.Clear()
                    monto = 0
                    While rs.Read = True
                        lbP_Nombre.Items.Add(rs(0))
                        lbP_Cantidad.Items.Add(rs(1))
                        lbP_PrecioU.Items.Add(rs(2))
                        lbP_Total.Items.Add(rs(3))
                        monto += rs(3)

                        OrdenDeEntrega.lbOE_Nombre.Items.Add(rs(0))
                        OrdenDeEntrega.lbOE_Cantidad.Items.Add(rs(1))
                        OrdenDeEntrega.lbOE_PrecioU.Items.Add(rs(2))
                        OrdenDeEntrega.lbOE_Total.Items.Add(rs(3))

                    End While
                    txtP_Total.Text = "$ " & monto
                    OrdenDeEntrega.txtOE_Total.Text = txtP_Total.Text
                Else
                    Limpiar()
                    btnP_Generar.Enabled = False
                End If
            Case "Moto"

        End Select
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP_Generar.Click
        If btnP_Generar.Text = "Generar" Then
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.CellSelect
            If lblP_Nro.Text <> "" Then
                sql = "select count(*) from pedidosclientes where estado = 'cancelado' and idpedido = " & lblP_Nro.Text
                carga(sql, False)
                If rs.Read = True And rs(0) = 0 Then
                    dgv = "Motos"
                    sql = "select ve.idvehi Vehiculo,count(idenvio) Pedidos ,activa Activa from vehiculoenvios ve,vehiculo v where(ve.idvehi = v.idvehi) and disponibilidad = 1 and activa = 0 group by ve.idvehi"
                    data(Me.dgvPedidos, False)
                    pointP = "DetallePedido"
                    btnActivo.Visible = False
                    btnEnviado.Visible = False
                    btnCancelado.Visible = False
                    btnP_Generar.Text = "Finalizar"
                Else
                    MsgBox("El pedido ha sido cancelado.", MsgBoxStyle.Critical, "Pedidos")
                End If
            End If
        Else
            If dgvPedidos.CurrentRow.Cells(0).Selected = True And dgvPedidos.CurrentRow.Cells(0).Value.ToString <> "" Then
                sql = "select idEnvio from Envios where idPedido = " & lblP_Nro.Text
                carga(sql, False)
                If rs.Read = True Then
                    sql = "insert into VehiculoEnvios values (''," & dgvPedidos.CurrentRow.Cells(0).Value & "," & rs(0) & ",1)"
                    carga(sql, True)
                    sql = "update Envios set fechaEnvio = '" & DateTime.Now.ToString("yyyy/MM/dd") & "' where idEnvio=" & rs(0)
                    carga(sql, True)
                    sql = "update pedidosclientes set estado = 'Enviado' where idpedido = " & lblP_Nro.Text
                    carga(sql, False)
                    MsgBox("Pedido asignado con éxito!", MsgBoxStyle.Information, "Pedidos")
                    OrdenDeEntrega.Show()
                    Limpiar()
                    btnP_Generar.Text = "Generar"
                    AtrasPedido()
                End If
            End If
        End If
    End Sub

    Private Sub btnAtrasAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAct.Click
        If pointP = "" Then
            pointP = "DetallePedido"
            AtrasPedido()
        End If
    End Sub

    'Private Sub DataGridGrupo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellContentClick
    '    If e.RowIndex < 0 Or Not e.ColumnIndex = 0 Then Exit Sub
    '    If Convert.ToBoolean(dgvPedidos.Rows(e.RowIndex).Cells(0).Value) Then
    '        dgvPedidos.Rows(e.RowIndex).Cells(0).Value = False
    '    Else
    '        dgvPedidos.Rows(e.RowIndex).Cells(0).Value = True
    '    End If
    'End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'SWITCH SCREENs

    Private Sub btnPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidos.Click
        SwitchScreen("Pedidos")
        lblTitulo.Text = "Pedidos"
        lblDesc.Text = "Confección de pedidos y ordenes de entregas."
        circuito = "Pedido"
        CargarCircuitos("Pedidos")
    End Sub

    Private Sub btnCobros_Click() Handles btnCobros.Click
        SwitchScreen("Cobros")
        lblTitulo.Text = "Cobros"
        lblDesc.Text = "Gestión de cobros y rendición de cuentas."
        circuito = "Cobro"
    End Sub

    Private Sub btnDelivery_Click() Handles btnDelivery.Click
        SwitchScreen("Delivery")
        lblTitulo.Text = "Delivery"
        lblDesc.Text = "Gestión de vehiculos y mantenimiento."
        circuito = "Delivery"
    End Sub

    Private Sub btnEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpleados.Click
        SwitchScreen("Empleados")
        lblTitulo.Text = "Empleados"
        lblDesc.Text = "Gestión de empleados y asignación de turnos."
        circuito = "Empleado"
    End Sub

    Private Sub SwitchScreen(ByVal screen As String)
        Select Case screen
            Case "Empleados"
                btnPedidos.BackColor = Color.Linen
                btnCobros.BackColor = Color.Linen
                btnDelivery.BackColor = Color.Linen
                btnEmpleados.BackColor = Color.AntiqueWhite
                pnlPedidos.Visible = False
                pnlCobros.Visible = False
                pnlDelivery.Visible = False
                pnlEmpleados.Visible = True
            Case "Delivery"
                btnPedidos.BackColor = Color.Linen
                btnCobros.BackColor = Color.Linen
                btnEmpleados.BackColor = Color.Linen
                btnDelivery.BackColor = Color.AntiqueWhite
                pnlPedidos.Visible = False
                pnlCobros.Visible = False
                pnlEmpleados.Visible = False
                pnlDelivery.Visible = True
            Case "Cobros"
                btnPedidos.BackColor = Color.Linen
                btnDelivery.BackColor = Color.Linen
                btnEmpleados.BackColor = Color.Linen
                btnCobros.BackColor = Color.AntiqueWhite
                pnlPedidos.Visible = False
                pnlDelivery.Visible = False
                pnlEmpleados.Visible = False
                pnlCobros.Visible = True
            Case Else
                btnCobros.BackColor = Color.Linen
                btnDelivery.BackColor = Color.Linen
                btnEmpleados.BackColor = Color.Linen
                btnPedidos.BackColor = Color.AntiqueWhite
                pnlPedidos.Visible = True
        End Select
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'TXT SOLO LETRA & SOLO NUMERO

    Private Sub txtC_OE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC_OE.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtC_Cobrado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC_Cobrado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtC_NroEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC_NroEmpleado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtD_NroVehiculo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD_NroVehiculo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtE_NroEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtE_NroEmpleado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtE_TurnoNroEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtE_TurnoNroEmpleado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtD_ManteNroVehiculo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD_ManteNroVehiculo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbD_InsertEstadoVehiculo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbD_InsertEstadoVehiculo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbD_InsertTipoVehiculo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbD_InsertTipoVehiculo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbD_ManteMotivoMatenimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbD_ManteMotivoMatenimiento.KeyPress
        e.Handled = True
    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    Private Sub txtC_OE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtC_OE.KeyUp

        If txtC_OE.Text = "" Then
            sql = "select e.idpedido Código,Fechaped Fecha, horaped Hora,preciotot Total from pedidosclientes pc,envios e where pc.idpedido=e.idpedido and fechaenvio != 'NULL' and entregado = 0"
            data(Me.dgvCobros, False)
        Else
            sql = "select e.idpedido Código,Fechaped Fecha, horaped Hora,preciotot Total from pedidosclientes pc,envios e where pc.idpedido=e.idpedido and fechaenvio != 'NULL' and entregado = 0 and e.idPedido = " & CInt(txtC_OE.Text)
            data(Me.dgvCobros, False)
        End If

    End Sub

    Private Sub dgvCobros_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCobros.CellClick
        If dgvCobros.CurrentRow.Cells(0).Value.ToString <> "" Then
            lblC_Nro.Text = dgvCobros.CurrentRow.Cells(0).Value
            sql = "select nombre, apellido,direEnvio,fechaenvio from pedidosclientes pc, clienteventas cv, personas p, envios e where(pc.idClienteVentas = cv.idClienteVentas And cv.idPersona = p.idPersona And pc.idpedido = e.idpedido) and cv.idClienteVentas = (select idClienteVentas from pedidosclientes where idpedido=" & dgvCobros.CurrentRow.Cells(0).Value & ") and fechaenvio != 'NULL'"
            carga(sql, False)
            If rs.Read = True Then
                lblC_Nombre.Text = "Sr/a: " & rs(0) & " " & rs(1)
                lblC_Direccion.Text = "Dirección: " & rs(2)
                lblC_Fecha.Text = rs(3)
            End If
            sql = "select m.nombre Nombre,pm.cant Cantidad,mv.precioVenta PrecioUnitario,mv.precioVenta*pm.cant Total from PedidoMenu pm, MenuVenta mv, menu m where pm.idMenuVenta=mv.idMenuVenta and mv.idmenu=m.idmenu and idPedido=" & dgvCobros.CurrentRow.Cells(0).Value
            carga(sql, False)
            lbC_Nombre.Items.Clear()
            lbC_Cantidad.Items.Clear()
            lbC_PrecioU.Items.Clear()
            lbC_Total.Items.Clear()
            monto = 0
            While rs.Read = True
                lbC_Nombre.Items.Add(rs(0))
                lbC_Cantidad.Items.Add(rs(1))
                lbC_PrecioU.Items.Add(rs(2))
                lbC_Total.Items.Add(rs(3))
                monto += rs(3)
            End While
            txtC_Total.Text = "$ " & monto
        End If
    End Sub

    Private Sub btnOE_Confirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC_Confirmar.Click
        If lblC_Nro.Text <> "" Then
            nro = 0
            nro = lblC_Nro.Text
            lblC_Cobrar.Text = monto
            lblC_BienMal.Text = ""
            txtC_Cobrado.Text = ""
            txtC_NroEmpleado.Text = ""
            lblC_BienMalCobrado.Text = ""
            lblC_NombreEmpleado.Text = ""
            lblC_ApellidoEmpleado.Text = ""
            lblC_CargoEmpleado.Text = ""
        Else
            lblC_BienMal.Text = "Seleccione una orden."
        End If
    End Sub



    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtC_Cobrado.KeyUp
        If txtC_Cobrado.Text <> "" And lblC_Cobrar.Text <> "" Then
            If CInt(txtC_Cobrado.Text) > CInt(lblC_Cobrar.Text) Then
                lblC_BienMalCobrado.Text = "Se ha cobrado de más."
                lblC_BienMalCobrado.ForeColor = Color.Brown
            ElseIf CInt(txtC_Cobrado.Text) < CInt(lblC_Cobrar.Text) Then
                lblC_BienMalCobrado.Text = "Se ha cobrado de menos."
                lblC_BienMalCobrado.ForeColor = Color.Brown
            Else
                lblC_BienMalCobrado.Text = "Se ha cobrado correctamente."
                lblC_BienMalCobrado.ForeColor = Color.SeaGreen
            End If
        Else
            lblC_BienMalCobrado.Text = ""
        End If
    End Sub

    Private Sub TextBox1_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtC_NroEmpleado.KeyUp
        If txtC_NroEmpleado.Text <> "" And lblC_Cobrar.Text <> "" Then
            sql = "select Nombre,Apellido,Cargo from empleados e,personas p where e.idpersona=p.idpersona and idsector = (select idsector from sectores where sector = 'Entrega') and cargo = 'Repartidor' and idempleado =" & txtC_NroEmpleado.Text
            carga(sql, False)
            If rs.Read = True Then
                lblC_NombreEmpleado.Text = rs(0)
                lblC_ApellidoEmpleado.Text = rs(1)
                lblC_CargoEmpleado.Text = rs(2)
            Else
                lblC_NombreEmpleado.Text = ""
                lblC_ApellidoEmpleado.Text = ""
                lblC_CargoEmpleado.Text = ""
            End If
        Else
            lblC_NombreEmpleado.Text = ""
            lblC_ApellidoEmpleado.Text = ""
            lblC_CargoEmpleado.Text = ""
        End If
    End Sub

    Private Sub btnC_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC_Registrar.Click
        If lblC_Cobrar.Text <> "" Then
            If txtC_Cobrado.Text <> "" Then
                If lblC_NombreEmpleado.Text <> "" And lblC_ApellidoEmpleado.Text <> "" And lblC_CargoEmpleado.Text <> "" Then

                    sql = "select count(*) from PedidosClientes where idPedido = " & nro
                    carga(sql, False)
                    If rs.Read = True And rs(0) = 1 Then
                        sql = "select monto from PedidosClientes pc,ticket t where pc.idpedido = t.idpedido and pc.idPedido = " & nro
                        carga(sql, False)
                        If rs.Read = True And CInt(txtC_Cobrado.Text) = rs(0) Then
                            sql = "insert into PagosCorrectoEntrega values (''," & nro & "," & txtC_NroEmpleado.Text & "," & txtC_Cobrado.Text & ",'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                            carga(sql, False)
                            sql = "update PedidosClientes set estado = 'Entregado' where idPedido = " & nro
                            carga(sql, False)
                            sql = "update Envios set entregado = 1 where idpedido = " & nro
                            carga(sql, False)
                            sql = "update ticket set fechaPago= '" & Format(Date.Today, "yyyy/MM/dd") & "', horaPago = '" & Now.ToString("HH:mm:ss") & "' where idpedido = " & nro
                            carga(sql, False)
                            sql = "update vehiculoenvios set activo = 0 where idenvio = (select idenvio from envios where idpedido = " & nro & ")"
                            carga(sql, False)
                            MsgBox("Cobro registrado.", MsgBoxStyle.Information, "Cobros")
                        Else
                            If txtC_Cobrado.Text > rs(0) Then
                                'COBRADO DE MAS
                                'txtC_Cobrado.Text - rs(0)
                                sql = "insert into PagosIncorrectoEntrega values (''," & nro & "," & txtC_NroEmpleado.Text & ",'" & Format(Date.Today, "yyyy/MM/dd") & "'," & rs(0) & "," & txtC_Cobrado.Text & "," & txtC_Cobrado.Text - rs(0) & ")"
                                carga(sql, False)
                                sql = "update PedidosClientes set estado = 'Entregado' where idPedido = " & nro
                                carga(sql, False)
                                sql = "update Envios set entregado = 1 where idpedido = " & nro
                                carga(sql, False)
                                sql = "update ticket set fechaPago= '" & Format(Date.Today, "yyyy/MM/dd") & "', horapago = '" & Now.ToString("HH:mm:ss") & "' where idpedido = " & nro
                                carga(sql, False)
                                sql = "update vehiculoenvios set activo = 0 where idpedido = " & nro
                                carga(sql, False)
                                MsgBox("Cobro registrado.", MsgBoxStyle.Information, "Cobros")
                            Else
                                'COBRADO DE MENOS
                                'rs(0) - txtC_Cobrado.Text
                                sql = "insert into PagosIncorrectoEntrega values (''," & nro & "," & txtC_NroEmpleado.Text & ",'" & Format(Date.Today, "yyyy/MM/dd") & "'," & rs(0) & "," & txtC_Cobrado.Text & "," & rs(0) - txtC_Cobrado.Text & ")"
                                carga(sql, False)
                                sql = "update PedidosClientes set estado = 'Entregado' where idPedido = " & nro
                                carga(sql, False)
                                sql = "update Envios set entregado = 1 where idpedido = " & nro
                                carga(sql, False)
                                sql = "update ticket set fechaPago= '" & Format(Date.Today, "yyyy/MM/dd") & "', horapago = '" & Now.ToString("HH:mm:ss") & "' where idpedido = " & nro
                                carga(sql, False)
                                sql = "update vehiculoenvios set activo = 0 where idpedido = " & nro
                                carga(sql, False)
                                MsgBox("Cobro registrado.", MsgBoxStyle.Information, "Cobros")
                            End If

                        End If

                        btnC_Cancelar_Click()
                        btnCobros_Click()
                        Limpiar()
                    End If
                Else
                    lblC_BienMal.Text = "Ingrese un número de empleado válido."
                End If
            Else
                lblC_BienMal.Text = "Ingrese monto cobrado."
            End If
        Else
            lblC_BienMal.Text = "Primero seleccione una orden."
        End If
    End Sub

    Private Sub btnC_Cancelar_Click() Handles btnC_Cancelar.Click
        If lblC_Cobrar.Text <> "" Then
            lblC_Cobrar.Text = ""
            txtC_Cobrado.Text = ""
            lblC_BienMalCobrado.Text = ""
            txtC_NroEmpleado.Text = ""
            lblC_NombreEmpleado.Text = ""
            lblC_ApellidoEmpleado.Text = ""
            lblC_CargoEmpleado.Text = ""
            lblC_BienMal.Text = ""
        End If
    End Sub

    Private Sub txtD_NroVehiculo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtD_NroVehiculo.KeyUp
        If txtD_NroVehiculo.Text <> "" Then
            sql = "select idvehi Código, Marca, Modelo, Patente, tipovehi Tipo, activa EnServicio from vehiculo where disponibilidad = 1 and idvehi = " & txtD_NroVehiculo.Text
            data(Me.dgvDelivey, False)
        Else
            sql = "select idvehi Código, Marca, Modelo, Patente, tipovehi Tipo, activa EnServicio from vehiculo where disponibilidad = 1"
            data(Me.dgvDelivey, False)
        End If
    End Sub

    Private Sub dgvDelivey_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDelivey.CellClick
        lblD_NroVehiculo.Text = dgvDelivey.CurrentRow.Cells(0).Value.ToString
        sql = "select disponibilidad from vehiculo where idvehi = " & dgvDelivey.CurrentRow.Cells(0).Value
        carga(sql, False)
        If rs.Read = True And rs(0) = 1 Then
            pnlD_DisponibleVehiculo.BackColor = Color.ForestGreen
            lblD_DisponibleVehiculo.Text = "Habilitada"
        Else
            pnlD_DisponibleVehiculo.BackColor = Color.Firebrick
            lblD_DisponibleVehiculo.Text = "Deshabilitada"
        End If
        lblD_PatenteVehiculo.Text = dgvDelivey.CurrentRow.Cells(3).Value.ToString
        lblD_MarcaVehiculo.Text = dgvDelivey.CurrentRow.Cells(1).Value.ToString
        lblD_ModeloVehiculo.Text = dgvDelivey.CurrentRow.Cells(2).Value.ToString
        sql = "select count(fechaingreso), max(fechaingreso) from mantenimiento where idvehi = " & dgvDelivey.CurrentRow.Cells(0).Value
        carga(sql, False)
        If rs.Read = True And rs(0) = 1 Then
            lblD_UltimoMantenimientoVehiculo.Text = Format(rs(1), "dd/MM/yyyy")
        Else
            sql = "select fechaing from vehiculo where idvehi = " & dgvDelivey.CurrentRow.Cells(0).Value
            carga(sql, False)
            If rs.Read = True Then
                lblD_UltimoMantenimientoVehiculo.Text = Format(rs(0), "dd/MM/yyyy")
            End If
        End If
        lblD_ProximoMantenimientoVehiculo.Text = Convert.ToDateTime(lblD_UltimoMantenimientoVehiculo.Text).AddDays(31)
    End Sub

    Private Sub btnD_DisponibleVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_DisponibleVehiculo.Click
        sql = "select idvehi Código, Marca, Modelo, Patente, tipovehi Tipo, activa EnServicio from vehiculo where disponibilidad = 1"
        data(Me.dgvDelivey, False)
    End Sub

    Private Sub btnD_FueraDeServicioVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_FueraDeServicioVehiculo.Click
        sql = "select idvehi Código, Marca, Modelo, Patente, tipovehi Tipo, activa EnServicio from vehiculo where disponibilidad = 0"
        data(Me.dgvDelivey, False)
        pointD = "VehiculosNoDisponibles"
    End Sub

    Private Sub btnC_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC_Cancelar.Click

    End Sub

    Private Sub btnD_AgregarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_AgregarVehiculo.Click
        pointD = "AgregarVehiculo"
        pnlD_AgregarVehiculo.Visible = True
        btnD_AgregarVehiculo.Visible = False

        sql = "select max(idvehi) from vehiculo"
        carga(sql, False)
        If rs.Read = True Then
            lblD_InsertNroVehiculo.Text = rs(0) + 1
        End If
    End Sub



    Private Sub cbD_InsertEstadoVehiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbD_InsertEstadoVehiculo.SelectedIndexChanged
        If cbD_InsertEstadoVehiculo.Text = "Nuevo" Then
            lblD_InsertDisponibleVehiculo.Text = "Habilitado"
            pnlD_InsertDisponibleVehiculo.BackColor = Color.ForestGreen
        Else
            lblD_InsertDisponibleVehiculo.Text = "Deshabilitado"
            pnlD_InsertDisponibleVehiculo.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub btnD_CancelarInsertVehiculo_Click() Handles btnD_CancelarInsertVehiculo.Click
        If btnD_AgregarVehiculo.Text = "Agregar" Then
            lblD_InsertNroVehiculo.Text = ""
            pnlD_InsertDisponibleVehiculo.BackColor = Color.DodgerBlue
            lblD_InsertDisponibleVehiculo.Text = ""
            txtD_InsertPatenteVehiculo.Text = ""
            txtD_InsertMarcaVehiculo.Text = ""
            txtD_InsertModeloVehiculo.Text = ""
            cbD_InsertTipoVehiculo.Text = ""
            cbD_InsertEstadoVehiculo.Text = ""
            lblD_InsertBienMal.Text = ""
            btnD_InsertarVehiculo.Text = "Agregar"
            AtrasDelivery()
        Else
            lblD_InsertNroVehiculo.Text = ""
            pnlD_InsertDisponibleVehiculo.BackColor = Color.DodgerBlue
            lblD_InsertDisponibleVehiculo.Text = ""
            txtD_InsertPatenteVehiculo.Text = ""
            txtD_InsertMarcaVehiculo.Text = ""
            txtD_InsertModeloVehiculo.Text = ""
            cbD_InsertTipoVehiculo.Text = ""
            cbD_InsertEstadoVehiculo.Text = ""
            lblD_InsertBienMal.Text = ""
            btnD_InsertarVehiculo.Text = "Agregar"
            pnlD_AgregarVehiculo.Visible = False
        End If
    End Sub

    Private Sub btnD_InsertarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_InsertarVehiculo.Click
        If btnD_InsertarVehiculo.Text = "Agregar" Then
            If txtD_InsertPatenteVehiculo.Text <> "" Then
                If txtD_InsertMarcaVehiculo.Text <> "" Then
                    If txtD_InsertModeloVehiculo.Text <> "" Then
                        If cbD_InsertTipoVehiculo.Text <> "" Then
                            If cbD_InsertEstadoVehiculo.Text <> "" Then

                                If cbD_InsertEstadoVehiculo.Text = "Nuevo" Then
                                    sql = "insert into vehiculo values ('','" & txtD_InsertMarcaVehiculo.Text & "','" & txtD_InsertModeloVehiculo.Text & "','" & txtD_InsertPatenteVehiculo.Text & "','" & cbD_InsertTipoVehiculo.Text & "','" & Format(Date.Today, "yyyy/MM/dd") & "',0,1,1)"
                                    carga(sql, False)
                                    sql = "insert into mantenimiento values(''," & lblD_InsertNroVehiculo.Text & ",'" & Format(Date.Today, "yyyy/MM/dd") & "','" & Format(Date.Today, "yyyy/MM/dd") & "','Rutina',1)"
                                    carga(sql, False)
                                    MsgBox("Se ha agregado el vehículo con éxito!")
                                    btnD_CancelarInsertVehiculo_Click()
                                Else
                                    lblD_InsertBienMal.Text = "Los vehículos usados deben ser enviados a mantenimiento."
                                    sql = "insert into vehiculo values ('','" & txtD_InsertMarcaVehiculo.Text & "','" & txtD_InsertModeloVehiculo.Text & "','" & txtD_InsertPatenteVehiculo.Text & "','" & cbD_InsertTipoVehiculo.Text & "','" & Format(Date.Today, "yyyy/MM/dd") & "',0,0,1)"
                                    carga(sql, False)
                                    sql = "select max(idvehi) from vehiculo"
                                    carga(sql, False)
                                    If rs.Read = True Then
                                        sql = "insert into mantenimiento values (''," & rs(0) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "',NULL,'Rutina',1)"
                                        carga(sql, False)
                                    End If
                                    MsgBox("Se ha agregado el vehículo con éxito!")
                                    btnD_CancelarInsertVehiculo_Click()
                                    btnDelivery_Click()
                                End If

                            Else
                                lblD_InsertBienMal.Text = "Ingrese estado del vehículo."
                            End If
                        Else
                            lblD_InsertBienMal.Text = "Ingrese el tipo de vehículo."
                        End If
                    Else
                        lblD_InsertBienMal.Text = "Ingrese modelo del vehículo."
                    End If
                Else
                    lblD_InsertBienMal.Text = "Ingrese marca del vehículo."
                End If
            Else
                lblD_InsertBienMal.Text = "Ingrese patente del vehículo."
            End If
        Else

            sql = "select encargado from empleados where idempleado = " & idEmpleado
            carga(sql, False)
            If rs.Read = True And rs(0) = 1 Then
                sql = "update vehiculo set marca = '" & txtD_InsertMarcaVehiculo.Text & "', modelo = '" & txtD_InsertModeloVehiculo.Text & "', patente = '" & txtD_InsertPatenteVehiculo.Text & "', tipovehi= '" & cbD_InsertTipoVehiculo.Text & "' where idvehi = " & lblD_InsertNroVehiculo.Text
                carga(sql, False)
                MsgBox("El vehículo se modificó con exito!", MsgBoxStyle.Information, "Delivery - Vehículos")
            Else
                MsgBox("No tiene privilegios para realiazar esta acción.", MsgBoxStyle.Critical, "Delivery - Vehículos")
                btnD_CancelarInsertVehiculo_Click()
            End If
        End If
    End Sub

    Private Sub btnD_EliminarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_EliminarVehiculo.Click
        sql = "select encargado from empleados where idempleado = " & idEmpleado
        carga(sql, False)
        If rs.Read = True And rs(0) = 1 Then
            sql = "update vehiculoenvios set activo = 0 where idvehi = " & lblD_NroVehiculo.Text
            carga(sql, False)
            sql = "update mantenimiento set activo = 0 where idvehi = " & lblD_NroVehiculo.Text
            carga(sql, False)
            sql = "update vehiculo set activo = 0 where idvehi = " & lblD_NroVehiculo.Text
            carga(sql, False)

            MsgBox("El vehículo se eliminó con exito!", MsgBoxStyle.Information, "Delivery - Vehículos")
            btnDelivery_Click()
            lblD_NroVehiculo.Text = ""
            pnlD_DisponibleVehiculo.BackColor = Color.White
            lblD_DisponibleVehiculo.Text = ""
            lblD_PatenteVehiculo.Text = ""
            lblD_MarcaVehiculo.Text = ""
            lblD_ModeloVehiculo.Text = ""
            lblD_UltimoMantenimientoVehiculo.Text = ""
            lblD_ProximoMantenimientoVehiculo.Text = ""
        Else
            MsgBox("No tiene privilegios para realiazar esta acción.", MsgBoxStyle.Critical, "Delivery - Vehículos")
        End If
    End Sub

    Private Sub btnD_EditarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_EditarVehiculo.Click
        pnlD_AgregarVehiculo.Visible = True
        lblD_InsertNroVehiculo.Text = lblD_NroVehiculo.Text
        txtD_InsertPatenteVehiculo.Text = lblD_PatenteVehiculo.Text
        txtD_InsertMarcaVehiculo.Text = lblD_MarcaVehiculo.Text
        txtD_InsertModeloVehiculo.Text = lblD_ModeloVehiculo.Text
        cbD_InsertTipoVehiculo.Text = dgvDelivey.CurrentRow.Cells(4).Value.ToString
        GroupBox31.Visible = False
        btnD_AgregarVehiculo.Visible = False
        btnD_InsertarVehiculo.Text = "Confirmar"
        pointD = "AgregarVehiculo"
    End Sub


    Private Sub dgvDelivery_Mantenimiento_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDelivery_Mantenimiento.CellClick
        lblD_ManteNNroVehiculo.Text = dgvDelivery_Mantenimiento.CurrentRow.Cells(0).Value.ToString
        sql = "select disponibilidad from vehiculo where idvehi = " & dgvDelivery_Mantenimiento.CurrentRow.Cells(0).Value
        carga(sql, False)
        If rs.Read = True And rs(0) = 1 Then
            pnlD_ManteDisponibleVehiculo.BackColor = Color.ForestGreen
            lblD_ManteDisponibleVehiculo.Text = "Habilitada"
        Else
            pnlD_ManteDisponibleVehiculo.BackColor = Color.Firebrick
            lblD_ManteDisponibleVehiculo.Text = "Deshabilitada"
        End If

        sql = "select count(fechaingreso), max(fechaingreso) from mantenimiento where idvehi = " & dgvDelivery_Mantenimiento.CurrentRow.Cells(0).Value
        carga(sql, False)
        If rs.Read = True And rs(0) <> 0 Then
            If Convert.ToDateTime(rs(1)).AddDays(31) > Date.Today Then
                lblD_MantenimientoSiNo.Text = "Aún no debe realizarse mantenimiento."
                lblD_MantenimientoSiNo.ForeColor = Color.ForestGreen
                lblD_ManteProximoMantenimiento.Text = Convert.ToDateTime(rs(1)).AddDays(31)
                cbD_ManteMotivoMatenimiento.Visible = False
            Else
                lblD_MantenimientoSiNo.Text = "Debe realizarse mantenimiento."
                lblD_MantenimientoSiNo.ForeColor = Color.Firebrick
                lblD_ManteProximoMantenimiento.Text = Convert.ToDateTime(rs(1)).AddDays(31)
                cbD_ManteMotivoMatenimiento.Visible = True
            End If
        Else
            lblD_MantenimientoSiNo.Text = "El vehiculo se encuentra en mantenimiento."
            lblD_MantenimientoSiNo.ForeColor = Color.Firebrick
            cbD_ManteMotivoMatenimiento.Visible = False
        End If
    End Sub

    Private Sub btnD_ManteHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_ManteHabilitar.Click

        sql = "select count(fechaingreso), max(fechaingreso) from mantenimiento where idvehi = " & dgvDelivery_Mantenimiento.CurrentRow.Cells(0).Value
        carga(sql, False)
        If rs.Read = True And rs(0) = 0 Then
            sql = "select count(*) from mantenimiento where idvehi = " & dgvDelivery_Mantenimiento.CurrentRow.Cells(0).Value
            carga(sql, False)
            If rs.Read = True And rs(0) <> 0 Then
                sql = "select max(fechaEgreso) from mantenimiento where idvehi = " & lblD_ManteNNroVehiculo.Text
                carga(sql, False)
                If rs.Read = True And Format(rs(0), "dd/MM/yyyy") < Date.Today Then

                    sql = "update vehiculo set disponibilidad = 1 where idvehi= " & lblD_ManteNNroVehiculo.Text
                    carga(sql, False)
                    sql = "update mantenimiento set fechIngreso = '" & Format(Date.Today, "yyyy/MM/dd ") & "' where idvehi= " & lblD_ManteNNroVehiculo.Text
                    carga(sql, False)

                Else
                    MsgBox("Debe haber un día de diferencia con la fecha en que se envio el vehiculo a mantenimiento.", MsgBoxStyle.Information, "Mantenimiento")
                End If
            End If
        End If

    End Sub

    Private Sub btnD_ManteDeshabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD_ManteDeshabilitar.Click

        sql = "select count(fechaingreso), max(fechaingreso) from mantenimiento where idvehi = " & dgvDelivery_Mantenimiento.CurrentRow.Cells(0).Value
        carga(sql, False)
        If rs.Read = True And rs(0) <> 0 Then

            If Convert.ToDateTime(rs(1)).AddDays(31) < Date.Today Then

                If cbD_ManteMotivoMatenimiento.Text = "Rutina" Then

                    sql = "select max(fechIngreso) from mantenimiento where idVehi = " & lblD_ManteNNroVehiculo.Text
                    carga(sql, False)

                    If rs.Read = True And Format("yyyy/MM/dd", Date.Today) >= DateAdd(DateInterval.Day, 30, rs(0)) Then

                        sql = "insert into mantenimiento values('','" & lblD_ManteNNroVehiculo.Text & "','" & Format(Date.Today, "yyyy/MM/dd") & "','null','" & cbD_ManteMotivoMatenimiento.Text & "','1')"
                        carga(sql, False)
                        sql = "update vehiculo set disponibilidad = 0 where idvehi= " & lblD_ManteNNroVehiculo.Text
                        carga(sql, False)
                        MsgBox("Vehiculo enviado a mantenimiento con éxito!", MsgBoxStyle.Exclamation, "Mantenimiento")

                    End If

                Else

                    sql = "insert into mantenimiento values('','" & lblD_ManteNNroVehiculo.Text & "','" & Format(Date.Today, "yyyy/MM/dd") & "','null','" & cbD_ManteMotivoMatenimiento.Text & "','1')"
                    carga(sql, False)
                    MsgBox("Vehiculo enviado a mantenimiento con éxito!", MsgBoxStyle.Exclamation, "Mantenimiento")

                End If

            Else

                MsgBox("El vehículo no está en fecha de ir a mantenimiento.", MsgBoxStyle.Information, "Mantenimiento")

            End If

        End If

    End Sub

    Private Sub txtE_NroEmpleado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtE_NroEmpleado.KeyUp
        If txtE_NroEmpleado.Text <> "" Then
            sql = "select idEmpleado Código, Nombre,Apellido,Cargo from empleados e,personas p where e.idpersona=p.idpersona and idsector = (select idsector from sectores where sector = 'Entrega') and cargo = 'Repartidor' and estado = 1 and idempleado = " & txtE_NroEmpleado.Text
            data(Me.dgvEmpleados, False)
        Else
            sql = "select idEmpleado Código, Nombre,Apellido,Cargo from empleados e,personas p where e.idpersona=p.idpersona and idsector = (select idsector from sectores where sector = 'Entrega') and cargo = 'Repartidor' and estado = 1"
            data(Me.dgvEmpleados, False)
        End If
    End Sub

    Private Sub txtE_TurnoNroEmpleado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtE_TurnoNroEmpleado.KeyUp
        If txtE_TurnoNroEmpleado.Text <> "" Then
            sql = "select idempleado Código,Fecha,HoraInicio Entrada,HoraFin Salida,Turno from turno t, empleadoturno et where t.idturno=et.idturno and idempleado = " & txtE_TurnoNroEmpleado.Text & " order by idemptur"
            data(Me.dgvE_TurnoEmpleados, False)
        Else
            sql = "select idempleado Código,Fecha,HoraInicio Entrada,HoraFin Salida,Turno from turno t, empleadoturno et where t.idturno=et.idturno order by idemptur"
            data(Me.dgvE_TurnoEmpleados, False)
        End If
    End Sub

    Private Sub dgvEmpleados_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        sql = "select e.idempleado,p.nombre,p.apellido,e.cargo,s.sector,t.turno,max(et.fecha),et.idturno,estado from empleados e, personas p, sectores s, turno t, empleadoturno et where(p.idpersona = e.idpersona And e.idsector = s.idsector And e.idempleado = et.idEmpleado And et.idturno = t.idturno) and e.idempleado = " & dgvEmpleados.CurrentRow.Cells(0).Value
        carga(sql, False)
        If rs.Read = True Then
            lblE_NroEmpleado.Text = rs(0)
            If rs(8) = 1 Then
                lblE_ActivoEmpleado.Text = "Activo"
                pnlE_ActivoEmpleado.BackColor = Color.ForestGreen
            Else
                lblE_ActivoEmpleado.Text = "Inactivo"
                pnlE_ActivoEmpleado.BackColor = Color.Firebrick
            End If
            lblE_NombreApellidoEmpleado.Text = rs(1) & " " & rs(2)
            lblE_CargoEmpleado.Text = rs(3)
            lblE_SectorEmpleado.Text = rs(4)
            lblE_FechaUltimoTurno.Text = rs(6)
            lblE_UltimoTurnoEmpleado.Text = rs(5)
            lblE_FechaProximoTurno.Text = Convert.ToDateTime(rs(6)).AddDays(7)
            If rs(7) = 1 Then
                lblE_ProximoTurnoEmpleado.Text = "Tarde"
            ElseIf rs(7) = 2 Then
                lblE_ProximoTurnoEmpleado.Text = "Noche"
            Else
                lblE_ProximoTurnoEmpleado.Text = "Mañana"
            End If
        End If
    End Sub

    Private Sub txtD_ManteNroVehiculo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtD_ManteNroVehiculo.KeyUp
        If txtD_ManteNroVehiculo.Text <> "" Then
            sql = "select idvehi CódigoVehículo, fechaegreso Egreso,fechaingreso Ingreso, Motivo from mantenimiento where activo = 1  and idvehi = " & txtD_ManteNroVehiculo.Text & " order by fechaegreso DESC"
            data(Me.dgvDelivery_Mantenimiento, False)
        Else
            sql = "select count(distinct idvehi) from mantenimiento"
            carga(sql, False)
            If rs.Read = True Then
                sql = "select idvehi CódigoVehículo, fechaegreso Egreso,fechaingreso Ingreso, Motivo from mantenimiento where activo = 1 order by fechaegreso DESC LIMIT " & rs(0)
                data(Me.dgvDelivery_Mantenimiento, False)
            End If
        End If
    End Sub

    Private Sub AsignarTurnos()
        Dim B As Boolean = False
        Dim fechaMin As Date = Convert.ToDateTime(Date.Today).AddDays(-7)
        Dim min As Integer = 0
        Dim sector As Integer = 0
        sql = "select idempleado,cargo from empleados where capacitado = 1 and estado = 1 and idsector = (select idsector from sectores where sector = 'Entrega')"
        carga(sql, False)
        While rs.Read = True
            sql = "select count(*) from empleadoturno where idempleado = " & rs(0)
            carga(sql, True)
            If rsEntrega.Read = True And rsEntrega(0) > 0 Then
                sql = "select max(fecha),idturno from empleadoturno where idempleado = " & rs(0)
                carga(sql, True)
                If rsEntrega.Read = True And Convert.ToDateTime(Format(rsEntrega(0), "dd/MM/yyyy")).AddDays(7) = Date.Today Then
                    If rsEntrega(1) = 1 Then
                        sql = "insert into empleadoturno values(''," & rs(0) & ",2,'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                        carga(sql, True)
                    ElseIf rsEntrega(1) = 2 Then
                        sql = "insert into empleadoturno values(''," & rs(0) & ",3,'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                        carga(sql, True)
                    Else
                        sql = "insert into empleadoturno values(''," & rs(0) & ",1,'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                        carga(sql, True)
                    End If
                End If
            Else
                If rs(1) = "Encargado" Then
                    sql = "select idturno from empleadoturno et, empleados e where et.idempleado = e.idempleado and idsector = (select idsector from sectores where sector = 'Entrega') and cargo = 'Encargado' and fecha BETWEEN '" & Format(fechaMin, "yyyy/MM/dd") & "' and '" & Format(Date.Today, "yyyy/MM/dd") & "' and estado = 1 order by idturno"
                    carga(sql, True)
                    If rsEntrega.Read = True And rsEntrega(0) = 1 Then
                        If rsEntrega(0) = 2 Then
                            If rsEntrega(0) = 3 Then

                            Else
                                sql = "insert into empleadoturno values (''," & rs(0) & ",3,'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                                carga(sql, True)
                            End If
                        Else
                            sql = "insert into empleadoturno values (''," & rs(0) & ",2,'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                            carga(sql, True)
                        End If
                    Else
                        sql = "insert into empleadoturno values (''," & rs(0) & ",1,'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                        carga(sql, True)
                    End If

                Else
                    For i As Integer = 0 To 3 Step +1
                        sql = "select count(idempleado) from empleadoturno where idturno = " & i & " and fecha BETWEEN '" & Format(fechaMin, "yyyy/MM/dd") & "' and '" & Format(Date.Today, "yyyy/MM/dd") & "'"
                        carga(sql, True)
                        If rsEntrega.Read = True Then
                            If B = False Then
                                min = rsEntrega(0)
                                sector = i
                            Else
                                If rsEntrega(0) < min Then
                                    min = rsEntrega(0)
                                    sector = i
                                End If
                            End If
                        End If
                    Next
                    sql = "insert into empleadoturno values (''," & rs(0) & "," & sector & ",'" & Format(Date.Today, "yyyy/MM/dd") & "')"
                    carga(sql, True)
                End If
                MsgBox("Actualización de turnos finalizada.", MsgBoxStyle.Information, "Empleados")
            End If
        End While
    End Sub

    Private Sub dgvP_VehiculoPedidos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvP_VehiculoPedidos.CellClick
        If dgvP_VehiculoPedidos.CurrentRow.Cells(0).Value.ToString <> "" Then
            lbP_HRCodigoEnvio.Items.Clear()
            lbP_HRDireccion.Items.Clear()
            sql = "select idenvio Pedidos from vehiculoenvios ve,vehiculo v where(ve.idvehi = v.idvehi) and disponibilidad = 1 and activa = 0 and ve.activo = 1 and v.idvehi = " & dgvP_VehiculoPedidos.CurrentRow.Cells(0).Value
            carga(sql, False)
            While rs.Read = True
                lbP_HRCodigoEnvio.Items.Add(rs(0))
                HojaDeRuta.lbP_HRCodigoEnvio.Items.Add(rs(0))
                sql = "select direenvio from envios where idenvio = " & rs(0)
                carga(sql, True)
                If rsEntrega.Read = True Then
                    lbP_HRDireccion.Items.Add(rsEntrega(0))
                    HojaDeRuta.lbP_HRDireccion.Items.Add(rsEntrega(0))
                End If
            End While
        End If
    End Sub

    Private Sub btnP_HojaReparto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP_HojaReparto.Click
        HojaDeRuta.Show()
    End Sub
End Class


