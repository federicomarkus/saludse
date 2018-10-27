Imports System.Data.Odbc

Public Class AgregarMenu

    Dim sql As String
    Dim rs As OdbcDataReader
    Public idMenu As Integer
    Public desde As String
    Public editar As Boolean


    Private Sub AgregarMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboTipoElemento.Text = "Producto"
    End Sub

    Public Sub cargarDatos()
        lblActual.Text = ""
        cargarEmpaquetamientos()
        cargarElementos()
        If editar Then
            btnAgregar.Visible = False
            btnEditar.Visible = True
            gbxElementos.Enabled = True

            Dim idEmpaquetamiento As Integer

            sql = "select * from menu where idMenu = " & idMenu & ""
            rs = Funciones.consulta(sql)

            If rs.Read Then
                txtNombre.Text = rs(1)
                idEmpaquetamiento = rs(2)
                txtCaducidad.Text = rs(3)
            End If

            sql = "select nombre from productos where idproducto = " & idEmpaquetamiento & ""
            rs = Funciones.consulta(sql)
            If rs.Read Then
                lblActual.Text = "Actual: " & rs(0)
            End If

            sql = "select r.nombre, cantidad from menu m, menuproductos mp, recetas r where m.idmenu = mp.idmenu and mp.idelemento = r.idreceta and tipo='Receta' and m.idMenu = " & idMenu & ""
            rs = Funciones.consulta(sql)

            Do While rs.Read
                lstElementos.Items.Add(rs(0) & " - " & rs(1) & " - Receta")
            Loop


            sql = "select p.nombre, cantidad from menu m, menuproductos mp, productos p where m.idmenu = mp.idmenu and mp.idelemento = p.idproducto and tipo='Producto' and m.idMenu = " & idMenu & ""
            rs = Funciones.consulta(sql)

            Do While rs.Read
                lstElementos.Items.Add(rs(0) & " - " & rs(1) & " - Producto")
            Loop


        Else
            btnAgregar.Visible = True
            btnEditar.Visible = False
            gbxElementos.Enabled = False
        End If
    End Sub

    Public Sub cargarEmpaquetamientos()
        cboEmpaquetamiento.Items.Clear()
        sql = "select * from productos p, tipoproducto t where t.idTipoProducto = p.idTipoProducto and t.descripcion = 'Empaquetamiento'"
        rs = Funciones.consulta(sql)

        Do While rs.Read
            cboEmpaquetamiento.Items.Add(rs(1))
        Loop


    End Sub

    Private Sub cboTipoElemento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoElemento.SelectedIndexChanged
        lblRemover.Visible = False
        lblAgregar.Visible = False
        cargarElementos()
    End Sub

    Private Sub btnAgregarElemento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarElemento.Click
        If cboElementos.Text <> "" And txtCantidad.Text <> "" Then


            If cboTipoElemento.Text = "Producto" Then


                sql = "select idproducto from productos where nombre = '" & cboElementos.Text & "'"
                rs = Funciones.consulta(sql)

                If rs.Read Then

                    sql = "insert into menuproductos values ('', " & idMenu & ", " & rs(0) & ", " & txtCantidad.Text & ", 'Producto')"
                    Funciones.consulta(sql)

                    
                End If

                lstElementos.Items.Add(cboElementos.Text & " - " & txtCantidad.Text & " - Producto")

                cboElementos.Items.RemoveAt(cboElementos.SelectedIndex)

                txtCantidad.Text = Nothing


            Else

                sql = "select idreceta from recetas where nombre = '" & cboElementos.Text & "'"
                rs = Funciones.consulta(sql)

                If rs.Read Then

                    sql = "insert into menuproductos values ('', " & idMenu & ", " & rs(0) & ", " & txtCantidad.Text & ", 'Receta')"
                    Funciones.consulta(sql)

                End If

                lstElementos.Items.Add(cboElementos.Text & " - " & txtCantidad.Text & " - Receta")

                cboElementos.Items.RemoveAt(cboElementos.SelectedIndex)

                txtCantidad.Text = Nothing


            End If

            lblAgregar.Visible = True
        Else

            MsgBox("Hay campos vacios. Completar campos.")

        End If


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCaducidad.Text = "" Or cboEmpaquetamiento.Text = "" Or txtNombre.Text = "" Then
            MsgBox("Hay campos vacios. Completar campos.")
        Else

            sql = "select idproducto from productos where nombre = '" & cboEmpaquetamiento.Text & "'"
            rs = Funciones.consulta(sql)

            If rs.Read Then

                sql = "insert into menu values ('', '" & txtNombre.Text & "', " & rs(0) & ", " & txtCaducidad.Text & ", 'Activo')"
                Funciones.consulta(sql)

                sql = "select max(idmenu) from menu"
                rs = Funciones.consulta(sql)

                If rs.Read Then
                    idMenu = rs(0)
                End If

                gbxElementos.Enabled = True

            End If


        End If
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If lstElementos.SelectedItem = Nothing Then
            MsgBox("Seleccione un elemento")
        Else

            Dim elementoSeleccionado As String
            elementoSeleccionado = lstElementos.SelectedItem.ToString.Split("-")(0).Trim

            Dim tipo As String
            tipo = lstElementos.SelectedItem.ToString.Split("-")(2).Trim

            If tipo = "Producto" Then

                sql = "select idProducto from productos where nombre = '" & elementoSeleccionado & "'  "
                rs = Funciones.consulta(sql)

            Else

                sql = "select idReceta from recetas where nombre = '" & elementoSeleccionado & "'  "
                rs = Funciones.consulta(sql)

            End If

            If rs.Read Then
                lstElementos.Items.RemoveAt(lstElementos.SelectedIndex)
                sql = "delete from menuproductos where idMenu = " & idMenu & " and idElemento = " & rs(0) & " and tipo = '" & tipo & "'"
                Funciones.consulta(sql)
                lblRemover.Visible = True
            End If

            cargarElementos()

        End If
    End Sub

    Public Sub cargarElementos()
        cboElementos.Items.Clear()

        If cboTipoElemento.Text = "Producto" Then
            sql = "select nombre from productos p where estado = 1 and idproducto not in (select idelemento from menuproductos where idMenu = " & idMenu & " and tipo = 'Producto') and idtipoproducto not in (select idtipoproducto from tipoproducto where descripcion='Empaquetamiento')"
            rs = Funciones.consulta(sql)

            Do While rs.Read
                cboElementos.Items.Add(rs(0))
            Loop
        Else

            sql = "select nombre from recetas p where idreceta not in (select idelemento from menuproductos where idMenu = " & idMenu & " and tipo = 'Receta') "
            rs = Funciones.consulta(sql)

            Do While rs.Read
                cboElementos.Items.Add(rs(0))
            Loop

        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        If desde = "Informe" Then
            GenerarInformeCapacitacion.Show()
        Else
            Menus.cargarMenus()
            Menus.Show()
        End If
        
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If txtCaducidad.Text = "" Or cboEmpaquetamiento.Text = "" Or txtNombre.Text = "" Then
            MsgBox("Hay campos vacios. Completar campos.")
        Else
            Dim idEmpaq As Integer

            sql = "select idproducto from productos where nombre = '" & cboEmpaquetamiento.Text & "'"
            rs = Funciones.consulta(sql)

            If rs.Read Then
                idEmpaq = rs(0)
            End If

            sql = "update menu set nombre = '" & txtNombre.Text & "', empaquetamiento = " & idEmpaq & ", caducidad = " & txtCaducidad.Text & " where idMenu = " & idMenu & ""
            Funciones.consulta(sql)
        End If

    End Sub
End Class