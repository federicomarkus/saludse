Option Explicit On
Imports System.Data.Odbc
Public Class abmServiBorrar
    Dim idServicio As Integer
    Dim opc As Integer
    Dim codSucu As String
    Dim idSucu As OdbcDataReader
    Private Sub abmServiBorrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        DataGridView1.DataSource = llenarGrilla("select ss.idservicio,s.nombre Nombre_Servicio,su.nombre Nombre_Sucursal,serviciosCumplidos Servicio_Cumplido from servicios s, sucuservicio ss, sucursales su where  su.idSucursal=ss.idSucursal and s.idservicio=ss.idservicio group by ss.idservicio")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        idServicio = DataGridView1.Item(0, e.RowIndex).Value
        codSucu = DataGridView1.Item(2, e.RowIndex).Value
        opc = MsgBox("Esta seguro que quiere eliminar el servicio numero  " & idServicio & " cuya sucursal es: '" & codSucu & "'", vbYesNo)
        If (opc = 6) Then
            sql = "select idSucursal from sucursales where nombre='" & codSucu & "'"
            idSucu = consulta(sql)
            While idSucu.read = True
                sql = "delete from sucuservicio where idservicio='" & idServicio & "' and idSucursal= '" & idSucu(0) & "'"
                consulta(sql)
            End While
            
            MsgBox("El servicio numero " & idServicio & " cuya sucursal es: '" & codSucu & "' se elimino con exito", vbInformation)
            DataGridView1.DataSource = llenarGrilla("select ss.idservicio,s.nombre Nombre_Servicio,su.nombre Nombre_Sucursal,serviciosCumplidos Servicio_Cumplido from servicios s, sucuservicio ss, sucursales su where  su.idSucursal=ss.idSucursal and s.idservicio=ss.idservicio group by ss.idservicio")
        Else
            MsgBox("Se cancelo el borrado del pedido numero " & idServicio & "", vbInformation)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmServi.Show()

    End Sub
End Class