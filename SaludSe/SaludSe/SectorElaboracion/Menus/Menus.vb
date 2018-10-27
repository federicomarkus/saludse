Imports System.Data.Odbc

Public Class Menus

    Dim sql As String
    Dim rs As OdbcDataReader
    Dim idMenu As Integer

    Private Sub Menus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        cargarMenus()
    End Sub

    Public Sub cargarMenus()
        'sql = "select * from menus where estado = 'Activo'"
        sql = "select idmenu, m.nombre Nombre, p.nombre Empaquetamiento from menu m, productos p where m.empaquetamiento = p.idproducto"
        dgvGrilla.DataSource = Funciones.llenarGrilla(sql)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.Hide()
        AgregarMenu.editar = False
        AgregarMenu.btnAgregar.Visible = True
        AgregarMenu.btnRemover.Visible = True
        AgregarMenu.btnAgregarElemento.Visible = True
        AgregarMenu.btnEditar.Visible = True
        AgregarMenu.txtCaducidad.Enabled = True
        AgregarMenu.txtCantidad.Enabled = True
        AgregarMenu.txtNombre.Enabled = True
        AgregarMenu.cboEmpaquetamiento.Enabled = True
        AgregarMenu.cboTipoElemento.Enabled = True
        AgregarMenu.cargarDatos()
        AgregarMenu.Show()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuElaboracion.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Recetas.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If idMenu = 0 Then
            MsgBox("Seleccione un menu", MsgBoxStyle.Critical, "Error")
        Else

            sql = "select count(*) from PedidosDetalle P, PedidosSucursales Ps, MenuProductos mp where p.idpedido = ps.idpedido and mp.idmenu = p.idmenu and ps.estado = 'En Proceso' and mp.tipo = 'Menu' and mp.idElemento = " & idMenu & ""
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If Not rs(0) = 0 Then
                    MsgBox("El menu forma parte de un pedido por lo que no se puede editar.", MsgBoxStyle.Critical, "Error")
                Else
                    Me.Hide()
                    AgregarMenu.editar = True
                    AgregarMenu.idMenu = idMenu
                    AgregarMenu.btnAgregar.Visible = True
                    AgregarMenu.btnRemover.Visible = True
                    AgregarMenu.btnAgregarElemento.Visible = True
                    AgregarMenu.btnEditar.Visible = True
                    AgregarMenu.txtCaducidad.Enabled = True
                    AgregarMenu.txtCantidad.Enabled = True
                    AgregarMenu.txtNombre.Enabled = True
                    AgregarMenu.cboElementos.Enabled = True
                    AgregarMenu.cboEmpaquetamiento.Enabled = True
                    AgregarMenu.cboTipoElemento.Enabled = True
                    AgregarMenu.btnEditar.Visible = True
                    AgregarMenu.cargarDatos()
                    AgregarMenu.Show()
                End If

            End If

        End If
        idMenu = 0

    End Sub

    Private Sub dgvGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
        Try
            idMenu = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If idMenu = 0 Then
            MsgBox("Seleccione un menu", MsgBoxStyle.Critical, "Error")
        Else

            sql = "select count(*) from PedidosDetalle P, PedidosSucursales Ps where p.idPedido = ps.idPedido and ps.estado = 'En Proceso' and p.idMenu = " & idMenu & ""
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If Not rs(0) = 0 Then
                    MsgBox("El menu forma parte de un pedido que se encuentra EN PROCESO por lo que no se puede editar.", MsgBoxStyle.Critical, "Error")
                Else

                    sql = "update menu set estado = 'Inactivo' where idMenu = " & idMenu & ""
                    Funciones.consulta(sql)

                End If

            End If

        End If
        idMenu = 0
    End Sub
End Class