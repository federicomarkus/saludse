Imports System.Data.Odbc

Public Class PedidosE

    Dim rs As OdbcDataReader
    Dim sql As String
    Dim idPedidoSucursal As Integer
    Dim idPedido As Integer
    Dim estado As String

    Private Sub Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarPedidos()
    End Sub

    Public Sub cargarPedidos()
        ' Controlar emergencia y extraordinario??
        btnGenerar.Enabled = False
        sql = "select idPedSucu, nombre Sucursal, fechaP FechaPedido, estado Estado  from PedidosSucursales PS, Pedido P, Sucursales S where p.idpedido = ps.idpedido and s.idsucursal = p.idsucursal "
        dgvGrilla.DataSource = Funciones.llenarGrilla(sql)
    End Sub

    Private Sub dgvGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
        Try
            idPedidoSucursal = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
            estado = dgvGrilla.Rows(e.RowIndex).Cells(3).Value.ToString
        Catch ex As Exception
        End Try

        sql = "select idPedido from pedidossucursales where idpedsucu = " & idPedidoSucursal & ""
        rs = Funciones.consulta(sql)

        If rs.Read Then
            idPedido = rs(0)
        End If

        If estado = "Pendiente" Then
            btnGenerar.Enabled = True
            btnFinalizar.Enabled = False
        End If
        If estado = "En Produccion" Then
            btnFinalizar.Enabled = True
            btnGenerar.Enabled = False
        End If


    End Sub


    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        btnGenerar.Enabled = False
        DetallePedidoE.idPedidoSucursal = idPedidoSucursal
        Me.Hide()
        DetallePedidoE.cargarDatos()
        DetallePedidoE.Show()
    End Sub

    Private Sub btnVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalle.Click
        Me.Hide()
        DetallePedidoE.idPedidoSucursal = idPedidoSucursal
        DetallePedidoE.cargarDatos()
        DetallePedidoE.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        sql = "update pedidossucursales set estado = 'Finalizado' where idpedsucu = " & idPedidoSucursal & ""
        Funciones.consulta(sql)
        cargarPedidos()
    End Sub

    Private Sub btnVolverE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        MenuElaboracion.Show()
    End Sub
End Class