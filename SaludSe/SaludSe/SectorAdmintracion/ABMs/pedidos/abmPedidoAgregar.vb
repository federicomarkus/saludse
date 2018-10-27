Option Explicit On
Imports System.Data.Odbc
Public Class abmPedidoAgregar
    Dim rsControlCorrecto As OdbcDataReader
    Dim rsNombreSucursal As OdbcDataReader
    Dim rsNombreMenu As OdbcDataReader
    Dim rsIdMenu As OdbcDataReader
    Dim rsPrecio As OdbcDataReader
    Dim precioMenu As Integer
    Dim rsIdSucursal As OdbcDataReader
    Dim rsIdPedido As OdbcDataReader
    Dim IdMenu As Integer
    Dim idSucursal As Integer
    Dim verificar As Boolean
    Dim entro As Boolean
    Dim cantidad As Integer

    Private Sub abmPedidoAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()

        cmbSeleSucu.Items.Clear()
        sql = "select nombre,idSucursal from sucursales where disponible=1"
        rsNombreSucursal = consulta(sql)
        While rsNombreSucursal.Read = True

            cmbSeleSucu.Items.Add(rsNombreSucursal(0))

        End While
        cmbSeleSucu.Items.Add(" ")
        cmbMenu.Items.Clear()
        sql = "select nombre,idMenu from Menu"
        rsNombreMenu = consulta(sql)
        While rsNombreMenu.Read = True

            cmbMenu.Items.Add(rsNombreMenu(0))
        End While
        cmbMenu.Items.Add(" ")

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

      
        Try
            sql = "select p.precio,mp.idmenu,mp.cantidad from productos p, menu m, menuProductos mp where p.idproducto=mp.idproducto and m.idmenu=mp.idmenu and mp.idmenu='" & IdMenu & "'"
            rsPrecio = consulta(sql)
            While rsPrecio.Read = True

                precioMenu = precioMenu + (rsPrecio(0) * rsPrecio(2))

            End While

            lblMonto.Text = (precioMenu * TextBox1.Text) & " Pesos"
            cantidad = TextBox1.Text
        Catch ex As Exception
            TextBox1.Text = " "
            lblMonto.Text = " "
        End Try

            


        precioMenu = 0

    End Sub

    Private Sub cmbMenu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMenu.SelectedIndexChanged
        sql = "select idMenu from menu where nombre= '" & cmbMenu.Text & "'"
        rsIdMenu = consulta(sql)
        While rsIdMenu.Read = True
            IdMenu = rsIdMenu(0)
            sql = "select p.precio,mp.idmenu,mp.cantidad from productos p, menu m, menuProductos mp where p.idproducto=mp.idproducto and m.idmenu=mp.idmenu and mp.idmenu='" & rsIdMenu(0) & "'"
            rsPrecio = consulta(sql)
            While rsPrecio.Read = True

                precioMenu = precioMenu + (rsPrecio(0) * rsPrecio(2))

            End While
        End While
        lblPrecioMenu.Text = precioMenu & " Pesos"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If (cmbSeleSucu.Text = "" Or cmbSeleSucu.Text = " ") Then
            MsgBox("Debe elegir una sucursal", vbCritical)
        ElseIf (cmbMenu.Text = "" Or cmbMenu.Text = " ") Then
            MsgBox("Debe elegir un menu", vbCritical)
        ElseIf (TextBox1.Text = "0" Or TextBox1.Text = "" Or TextBox1.Text = " ") Then

            MsgBox("Complete el campo, la cantidad de pedido, correctamente, el valor debe ser mayor a 0", vbCritical)
        Else

            sql = "select idSucursal from sucursales where nombre='" & cmbSeleSucu.Text & "'"
            rsIdSucursal = consulta(sql)
            While rsIdSucursal.Read = True
                sql = "insert into Pedido values('','" & rsIdSucursal(0) & "','" & Format(Date.Today, "yyyy/MM/dd") & "',0)"
                cmd = New OdbcCommand(sql, cnn)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteReader()
                cmd.Dispose()
                sql = "select max(idPedido) from pedido"
                rsIdPedido = consulta(sql)
                While rsIdPedido.Read = True

                    sql = "insert into PedidosDetalle values('" & rsIdPedido(0) & "','" & IdMenu & "','" & cantidad & "')"
                    cmd = New OdbcCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteReader()
                    cmd.Dispose()
                    MsgBox("Pedido realizado correctamente", vbInformation)
                    TextBox1.Text = " "
                    cmbMenu.Text = " "
                    cmbSeleSucu.Text = " "
                    lblMonto.Text = " "
                    lblPrecioMenu.Text = " "
                End While

            End While



        End If




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmPed.Show()
    End Sub
End Class