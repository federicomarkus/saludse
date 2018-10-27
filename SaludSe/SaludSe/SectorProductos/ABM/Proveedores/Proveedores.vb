Imports System.Data.Odbc

Public Class Proveedores

    Dim sql As String
    Public numero As Integer
    Dim rta As OdbcDataReader

    Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        actualizarGrilla()
        
    End Sub

    Private Sub btnCargarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarProv.Click

        Me.Hide()
        CargarProveedor.Show()

    End Sub

    Private Sub btnModificarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProv.Click

        If numero = 0 Then
            MsgBox("No se ha seleccionado ningun proveedor")
        Else
            ModificarProveedores.Show()

            sql = "select nombre,direccion,telefono,mail,contacto,calificacion from proveedores where idProveedor=" & numero & ""
            rta = consulta(sql)

            If rta.Read = True Then
                ModificarProveedores.txtNombreP.Text = rta(0)
                ModificarProveedores.txtDireccion.Text = rta(1)
                ModificarProveedores.txtTelefono.Text = rta(2)
                ModificarProveedores.txtMail.Text = rta(3)
                ModificarProveedores.txtContacto.Text = rta(4)
                ModificarProveedores.txtCalificacion.Text = rta(5)

            End If

        End If


    End Sub

    Private Sub ListaProveedores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaProveedores.CellClick

        Try
            numero = ListaProveedores.Rows(e.RowIndex).Cells("idProveedor").Value.ToString
        Catch ex As Exception

        End Try

    End Sub

    Public Sub actualizarGrilla()

        sql = "select * from proveedores where estado=1"
        ListaProveedores.DataSource = llenarGrilla(sql)
        ListaProveedores.AutoResizeColumns()
    End Sub

    Private Sub btnEliminarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.Click
        Dim eliminar As Integer

        If numero = 0 Then

            MsgBox("No se ha seleccionado ningun proveedor")

        Else

            sql = "select nombre from proveedores where idProveedor=" & numero & ""
            rta = consulta(sql)

            If rta.Read = True Then

                eliminar = MsgBox("Esta seguro que quiere eliminar el proveedor '' " & rta(0) & "''?", MsgBoxStyle.YesNo)
                If eliminar = 6 Then

                    sql = "update proveedores set estado=0 where idProveedor=" & numero & ""
                    consulta(sql)

                    actualizarGrilla()
                    numero = 0
                Else
                    numero = 0

                End If

            End If
        End If
    End Sub

    Private Sub VolverABM_Click(sender As System.Object, e As System.EventArgs) Handles VolverABM.Click
        Me.Hide()
        MenuProductos.Show()
    End Sub
End Class
