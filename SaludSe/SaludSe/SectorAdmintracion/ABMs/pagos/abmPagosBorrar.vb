Option Explicit On
Imports System.Data.Odbc
Public Class abmPagosBorrar
    Dim codPago As Integer
    Dim opc As Integer
    Private Sub abmPagosBorrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        DataGridView1.DataSource = llenarGrilla("select * from pagos")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        codPago = DataGridView1.Item(0, e.RowIndex).Value
        opc = MsgBox("Esta seguro que quiere eliminar el pago numero  " & codPago & "", vbYesNo)
        If (opc = 6) Then
            sql = "delete from pagossucursal where idpagos='" & codPago & "'"
            consulta(sql)
            sql = "delete from pagos where idpagos='" & codPago & "'"
            consulta(sql)
            MsgBox("El pago numero " & codPago & " se elimino con exito", vbInformation)
            DataGridView1.DataSource = llenarGrilla("select * from pagos")
        Else
            MsgBox("Se cancelo el borrado del pedido numero " & codPago & "", vbInformation)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmPag.Show()
    End Sub
End Class