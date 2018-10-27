Option Explicit On
Imports System.Data.Odbc
Public Class abmPedidoBorrar
    Dim codPedido As Integer
    Dim opc As Integer
    Dim codMenu As String
    Dim idMenu As OdbcDataReader
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub abmPedidoBorrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        DataGridView1.DataSource = llenarGrilla("select pd.idpedido,s.nombre,p.fecha,p.pedidof,m.nombre,cantidad from  pedido p,  pedidosdetalle pd,  menu m,  sucursales s where p.idpedido=pd.idpedido and s.idsucursal=p.idsucursal and pd.idmenu=m.idmenu")
        


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        codPedido = DataGridView1.Item(0, e.RowIndex).Value
        codMenu = DataGridView1.Item(4, e.RowIndex).Value
        opc = MsgBox("Esta seguro que quiere eliminar el pedido numero  " & codPedido & " cuyo pedido fue es: '" & codmenu & "'", vbYesNo)
        If (opc = 6) Then
            sql = "select idmenu from menu where nombre='" & codMenu & "'"
            idMenu = consulta(sql)
            While idMenu.read = True
                sql = "delete from pedidosdetalle where idpedido='" & codPedido & "' and idMenu='" & idMenu(0) & "'"
                consulta(sql)
                
                MsgBox("El pedido numero " & codPedido & " se elimino con exito", vbInformation)
            End While
           

            DataGridView1.DataSource = llenarGrilla("select pd.idpedido,s.nombre,p.fecha,p.pedidof,m.nombre,cantidad from  pedido p,  pedidosdetalle pd,  menu m,  sucursales s where p.idpedido=pd.idpedido and s.idsucursal=p.idsucursal and pd.idmenu=m.idmenu")
        Else
            MsgBox("Se cancelo el borrado del pedido numero " & codPedido & "", vbInformation)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmPed.Show()

    End Sub
End Class