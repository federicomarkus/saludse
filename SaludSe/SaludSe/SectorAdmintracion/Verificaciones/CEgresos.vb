Option Explicit On
Imports System.Data.Odbc


Public Class CEgresos
    Dim rsNS As OdbcDataReader
    Dim rsSuma As OdbcDataReader
    Dim rsTicket As OdbcDataReader
    Dim rsFechaHoy As OdbcDataReader
    Dim rsIdMenu As OdbcDataReader
    Dim rsPrecio As OdbcDataReader
    Dim precioMenu As Integer
    Dim total As Integer
    Dim TotalT As Integer
    Dim rsSucursal As OdbcDataReader
    Dim rsPagos As OdbcDataReader
    Dim pagos As Integer
    Dim totaltotal As Integer
    Dim entro As Boolean
    Dim entro1 As Boolean





    Private Sub CEgresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        cmbSeleSucu.Items.Clear()

        sql = "select nombre from sucursales where disponible=1"
        rsNS = consulta(sql)
        While rsNS.Read = True

            cmbSeleSucu.Items.Add(rsNS(0))
        End While
        cmbSeleSucu.Items.Add(" ")

        lstMontos.Visible = False
        btnControlar.Visible = False

    End Sub

    Private Sub btnControlar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlar.Click
        lstMontos.Items.Clear()
        precioMenu = 0
        total = 0
        TotalT = 0
        totaltotal = 0
        pagos = 0
        entro = False
        entro1 = False
        sql = "select idsucursal from sucursales where nombre='" & cmbSeleSucu.Text & "'"
        rsSucursal = consulta(sql)
        While rsSucursal.Read = True
            sql = "select pd.idmenu,sum(cantidad),m.nombre from pedido p, PedidosDetalle pd, sucursales s , menu m where m.idmenu=pd.idmenu and s.disponible=1 and pd.idpedido=p.idpedido and pedidof=1 and p.idsucursal=s.idsucursal and p.idsucursal='" & rsSucursal(0) & "'group by m.idmenu"
            rsIdMenu = consulta(sql)
                lstMontos.Items.Add("EGRESOS POR PEDIDO DE STOCK:")
                entro = True
                While rsIdMenu.Read = True
                    sql = "select p.precio,mp.idmenu,mp.cantidad from productos p, menu m, menuProductos mp where p.idproducto=mp.idproducto and m.idmenu=mp.idmenu and mp.idmenu='" & rsIdMenu(0) & "'"
                    rsPrecio = consulta(sql)
                    While rsPrecio.Read = True

                        precioMenu = precioMenu + (rsPrecio(0) * rsPrecio(2))

                    End While

                    total = precioMenu * rsIdMenu(1)
                    lstMontos.Items.Add("PEDIDO: " & rsIdMenu(2) & " ||| MONTO TOTAL DEL MENU: " & precioMenu & " ||| CANTIDAD PEDIDA: " & rsIdMenu(1) & " ||| TOTAL: " & total)

                    TotalT = TotalT + total
                    precioMenu = 0
                    total = 0
            End While
            If (entro = True) Then
                lstMontos.Items.Add("Total de los egresos por pedido de stock: " & TotalT)
                lstMontos.Items.Add("-----------------------------------------------------")
          
            End If

            sql = "select p.monto,descripcion from pagos p, pagossucursal ps where p.idpagos=ps.idpagos and ps.idsucursal='" & rsSucursal(0) & "'"
            rsPagos = consulta(sql)
            lstMontos.Items.Add("EGRESOS POR PAGOS:")
                entro1 = True
                While rsPagos.Read = True
                    lstMontos.Items.Add(rsPagos(1) & ": " & rsPagos(0))
                    pagos = pagos + rsPagos(0)
            End While
            If (entro1 = True) Then
                lstMontos.Items.Add("Total de los egresos por pagos de las sucursales: " & pagos)
                lstMontos.Items.Add("-----------------------------------------------------")
                totaltotal = TotalT + pagos
                lstMontos.Items.Add("Total de egresos de la  " & cmbSeleSucu.Text & " es: " & totaltotal)
            
            End If





            If (entro = False And entro1 = False) Then
                lstMontos.Items.Add("Esta sucursal no realizo ningun egreso")
            End If

        End While

    End Sub

    Private Sub cmbSeleSucu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSeleSucu.SelectedIndexChanged
        If (cmbSeleSucu.Text = " ") Then
            btnControlar.Visible = False
            lstMontos.Visible = False
            MsgBox("No selecciono ninguna sucursal", vbCritical)


        Else
            lstMontos.Visible = True
            btnControlar.Visible = True
            lstMontos.Items.Clear()
        End If
    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Close()
        MenuDeVerificaciones.Show()
    End Sub
End Class