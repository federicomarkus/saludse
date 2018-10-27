Imports System.Data.Odbc

Public Class AgregarReceta

    Dim rs As OdbcDataReader
    Dim sql As String
    Public editar As Boolean
    Public idReceta As Integer
    Dim productos As ArrayList = New ArrayList
    Dim cantidades As ArrayList = New ArrayList
    Dim idProductos As ArrayList = New ArrayList


    Private Sub AgregarReceta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
    End Sub

    Public Sub cargarDatos()
        lstProductos.Items.Clear()
        If editar Then
            btnAgregar.Visible = False
            btnEditar.Visible = True
            btnRemover.Visible = True

            sql = "select * from recetas where idReceta = " & idReceta & ""
            rs = Funciones.consulta(sql)

            If rs.Read Then
                txtNombre.Text = rs(1)
                txtDescripcion.Text = rs(2)
            End If

            sql = "select nombre, cantidad from productos p, recetasproductos r where r.idproducto = p.idproducto and r.idreceta = " & idReceta & ""
            rs = Funciones.consulta(sql)

            Do While rs.Read
                lstProductos.Items.Add(rs(0) & " - " & rs(1))
            Loop


        Else
            btnAgregar.Visible = True
            btnEditar.Visible = False
            btnRemover.Visible = False
        End If
        cargarProductos()

    End Sub


    Private Sub btnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click
        If editar Then

            If Not String.IsNullOrEmpty(cboProductos.Text) And txtCantidad.Text <> "" Then


                sql = "select idProducto from productos where nombre = '" & cboProductos.Text & "'"
                rs = Funciones.consulta(sql)

                If rs.Read Then
                    lstProductos.Items.Add(cboProductos.Text & " - " & txtCantidad.Text)
                    sql = "insert into RecetasProductos values ('', " & idReceta & ", " & rs(0) & ", " & txtCantidad.Text & "  ) "
                    Funciones.consulta(sql)
                End If
                txtCantidad.Clear()
                cboProductos.Items.Clear()
                cargarProductos()
            Else
                MsgBox("Hay campos vacios. Completar campos.")

            End If

        Else
            If Not String.IsNullOrEmpty(cboProductos.Text) And txtCantidad.Text <> "" Then


                lstProductos.Items.Add(cboProductos.Text & " - " & txtCantidad.Text)
                productos.Add(cboProductos.Text)
                cantidades.Add(txtCantidad.Text)



                idProductos.Add(Funciones.consultaCampo("select idProducto from productos where nombre = '" & cboProductos.Text & "'")(0))

                cboProductos.Items.RemoveAt(cboProductos.SelectedIndex)

                txtCantidad.Text = Nothing

            Else

                MsgBox("Hay campos vacios. Completar campos.")

            End If

        End If

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If txtNombre.Text <> "" And txtDescripcion.Text <> "" Then

            If productos.Count > 1 Then

                sql = "insert into recetas values('', '" & txtNombre.Text & "', '" & txtDescripcion.Text & "', 'Activo')"
                Funciones.consulta(sql)

                sql = "select max(idReceta) from recetas"
                rs = Funciones.consulta(sql)

                If rs.Read Then

                    Dim idReceta As Integer = rs(0)

                    For i = 0 To productos.Count - 1

                        sql = "insert into RecetasProductos values ('', " & idReceta & ", " & idProductos.Item(i) & ", " & cantidades.Item(i) & ") "
                        Funciones.consulta(sql)


                    Next

                End If

                vaciar()
                MsgBox("Se cargo la receta correctamente")

            Else
                MsgBox("Tiene que tener por lo menos 2 productos")


            End If

        Else
            MsgBox("Hay campos vacios. Completar campos.")


        End If

    End Sub

    Private Sub cargarProductos()
        cboProductos.Items.Clear()

        sql = "select nombre from productos where estado=1 and idproducto not in (select idproducto from recetasproductos where idReceta = " & idReceta & ") and idtipoproducto != (select idtipoproducto from tipoproducto where descripcion='Empaquetamiento')"
            rs = Funciones.consulta(sql)
            Do While rs.Read

                cboProductos.Items.Add(rs(0))

            Loop

    End Sub

    Private Sub vaciar()

        productos.Clear()
        idProductos.Clear()
        cantidades.Clear()
        cboProductos.Items.Clear()
        txtNombre.Clear()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        lstProductos.Items.Clear()

        cargarProductos()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        Recetas.cargarRecetas()
        Recetas.Show()
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Funciones.OnlyNum(e)
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If lstProductos.SelectedItem = Nothing Then
            MsgBox("Seleccione un producto")
        Else

            If lstProductos.Items.Count = 2 Then
                MsgBox("Tiene que haber por lo menos 2 productos")
            Else

                Dim productoSeleccionado As String
                productoSeleccionado = lstProductos.SelectedItem.ToString.Split("-")(0).Trim

                sql = "select idProducto from productos where nombre = '" & productoSeleccionado & "'  "
                rs = Funciones.consulta(sql)

                If rs.Read Then
                    lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
                    sql = "delete from recetasproductos where idReceta = " & idReceta & " and idProducto = " & rs(0) & ""
                    Funciones.consulta(sql)
                End If

                cboProductos.Items.Clear()
                cargarProductos()

            End If

        End If
        
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        If txtNombre.Text <> "" And txtDescripcion.Text <> "" Then

            sql = "update recetas set nombre = '" & txtNombre.Text & "', descripcion = '" & txtDescripcion.Text & "' where idReceta = " & idReceta & ""
            Funciones.consulta(sql)

            For i = 0 To productos.Count - 1

                sql = "insert into RecetasProductos values ('', " & idReceta & ", " & idProductos.Item(i) & ", " & cantidades.Item(i) & "  ) "
                Funciones.consulta(sql)

            Next
        Else
            MsgBox("Hay campos vacios. Completar campos.")
        End If
    End Sub
End Class