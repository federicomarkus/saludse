Imports System.Data.Odbc
Public Class ControlCalidad

    Dim sql As String
    Dim fecha As OdbcDataReader

    Private Sub ControlCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        fechaV()
    End Sub

    Public Sub fechaV()
        sql = "select fecha from verificacion"
        fecha = consulta(sql)
        If fecha.Read = True Then

            lblUltimaVerificacion.Text = "Ultima verificacion: " & Format(fecha(0), "dd/MM/yyyy").ToString

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CargarControlCalidad.Show()
        CargarControlCalidad.actualizarGrilla()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ModificarControlCalidad.Show()
        ModificarControlCalidad.actualizarGrilla()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        VerificarControlCalidad.Show()
        Me.Hide()

        sql = "select p.idProducto IdProducto,p.nombre, o.idOrden, fechaVencimiento FechaVencimiento,p.marca Marca,p.CantMedida Cantidad, p.TipoMedida Unidad, c.cantidad stock from productos p, orden o, ComprasP c where c.idOrden = o.idOrden and c.idProducto=p.idProducto and fechavencimiento<curdate() and c.chequeado=0"
        VerificarControlCalidad.ListaOrdenProd.DataSource = llenarGrilla(sql)
        VerificarControlCalidad.ListaOrdenProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        VerificarControlCalidad.ListaOrdenProd.ClearSelection()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuProductos.Show()
    End Sub
End Class