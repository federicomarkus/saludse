Imports System.Data.Odbc

Public Class Recetas

    Dim rs As OdbcDataReader
    Dim sql As String
    Dim idReceta As Integer = 0


    Private Sub Recetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        cargarRecetas()
    End Sub

    Public Sub cargarRecetas()
        sql = "select * from recetas where estado = 'Activo'"
        dgvGrilla.DataSource = Funciones.llenarGrilla(sql)
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuElaboracion.Show()
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.Hide()
        AgregarReceta.editar = False
        AgregarReceta.cargarDatos()
        AgregarReceta.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If idReceta = 0 Then
            MsgBox("Seleccione una receta", MsgBoxStyle.Critical, "Error")
        Else

            sql = "select count(*) from PedidosDetalle P, PedidosSucursales Ps, MenuProductos mp where p.idpedido = ps.idpedido and mp.idmenu = p.idmenu and ps.estado = 'En Proceso' and mp.tipo = 'Receta' and mp.idElemento = " & idReceta & ""
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If Not rs(0) = 0 Then
                    MsgBox("La receta forma parte de un pedido por lo que no se puede editar.", MsgBoxStyle.Critical, "Error")
                Else
                    Me.Hide()
                    AgregarReceta.editar = True
                    AgregarReceta.idReceta = idReceta
                    AgregarReceta.cargarDatos()
                    AgregarReceta.Show()
                End If

            End If

        End If
        idReceta = 0

    End Sub

    Private Sub dgvGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
        Try
            idReceta = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If idReceta = 0 Then
            MsgBox("Seleccione una receta", MsgBoxStyle.Critical, "Error")
        Else

            sql = "select count(*) from PedidosDetalle P, PedidosSucursal Ps, MenuProductos mp where p.idpedido = ps.idpedido and mp.idmenu = p.idmenu and p.estado = 'En Proceso' and mp.tipo = 'Receta' and mp.idElemento = " & idReceta & ""
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If Not rs(0) = 0 Then
                    MsgBox("La receta forma parte de un pedido que esta EN PROCESO por lo que no se puede editar.", MsgBoxStyle.Critical, "Error")
                Else

                    sql = "update recetas set estado = 'Inactivo' where idReceta = " & idReceta & ""
                    Funciones.consulta(sql)

                End If

            End If

        End If
        idReceta = 0
    End Sub
End Class
