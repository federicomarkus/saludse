Public Class TipoProducto
    Dim sql As String
    Public carga As Boolean
    Dim desc As String
    Public id As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        cargarTipoProductos()
    End Sub

    Public Sub cargarTipoProductos()
        sql = "select idTipoProducto ID_TipoProducto, descripcion Descripcion from TipoProducto where estado=1"
        listaTipoProductos.DataSource = Funciones.llenarGrilla(sql)

    End Sub

    Private Sub btnCargarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarProv.Click
        Me.Hide()
        TipoProductoABM.Show()
        carga = True
        TipoProductoABM.btnCargarProducto.Text = "Cargar"
    End Sub

    Private Sub VolverABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverABM.Click
        Me.Hide()
        MenuProductos.Show()
    End Sub

    Private Sub btnModificarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProv.Click
        carga = False
        TipoProductoABM.btnCargarProducto.Text = "Modificar"

        If id = 0 Then
            MsgBox("Ningun tipo de producto seleccionado")
        Else
            Me.Hide()
            TipoProductoABM.Show()
            TipoProductoABM.txtDescripcion.Text = desc
        End If

    End Sub

    Private Sub listaTipoProductos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles listaTipoProductos.CellClick
        desc = listaTipoProductos.Rows(e.RowIndex).Cells("Descripcion").Value.ToString()
        id = listaTipoProductos.Rows(e.RowIndex).Cells(0).Value.ToString()

    End Sub

    Private Sub btnEliminarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.Click
        If id = 0 Then
            MsgBox("Ningun tipo de producto seleccionado")
        Else
            sql = "update TipoProducto set estado=0 where idTipoProducto =" & id
            consulta(sql)
            cargarTipoProductos()
            id = 0
        End If
    End Sub
End Class
