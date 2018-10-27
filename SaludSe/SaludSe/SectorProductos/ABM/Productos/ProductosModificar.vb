Imports System.Data.Odbc
Public Class ProductosModificar
    Dim sql As String
    Dim rta, rta2, rs, provs As OdbcDataReader
    Dim idProducto, idTipo As Integer
    Dim array As ArrayList = New ArrayList()
    Private Sub ProductosModificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()

        sql = "select descripcion from TipoProducto"
        rta = consulta(sql)

        While rta.Read = True
            cmbTipo.Items.Add(rta(0))
        End While

        cmbTipo.Items.Add("")

        actualizarListaD()
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtCant.Text = "" Or txtPuntoP.Text = "" Or txtMarca.Text = "" Or txtNombreProd.Text = "" Or cmbTipo.Text = "" Or cmbUnidad.Text = "" Or txtCalif.Text = "" Or txtStock.Text = "" Or lbCargado.Items.Count = 0 Then

            MsgBox("Faltan completar datos")

        Else

            sql = "delete from provprod where idproducto=" & Productos.idProducto & ""
            consulta(sql)

            For Each item As String In array
                Dim precio As String
                Do
                    precio = InputBox("Ingrese precio para el proveedor " + item, )
                Loop Until IsNumeric(precio)
                sql = "select idProveedor from proveedores where nombre='" & item & "'"
                provs = consulta(sql)
                If provs.Read = True Then
                    sql = "insert into provprod values(" & provs(0) & "," & Productos.idProducto & "," & precio & ")"
                    consulta(sql)
                End If

            Next

            sql = "update productos set nombre = '" & txtNombreProd.Text & "', marca = '" & txtMarca.Text & "', tipoMedida= '" & cmbUnidad.Text & "', idTipoProducto = " & idTipo & ",   cantMedida='" & txtCant.Text & "', puntoPedido='" & txtPuntoP.Text & "', stock='" & txtStock.Text & "', calificacion='" & txtCalif.Text & "' where idProducto=" & Productos.idProducto
            consulta(sql)

            MsgBox("Se han modificado los datos")
            Productos.actualizarGrilla()

            Me.Hide()
            Productos.idProducto = 0
            array.Clear()
            lbCargado.Items.Clear()

        End If


    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub txtPuntoP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPuntoP.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub lbDisponible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDisponible.SelectedIndexChanged
        If Not (array.Contains(lbDisponible.Text)) Then
            array.Add(lbDisponible.Text)
            lbCargado.Items.Add(lbDisponible.Text)
        End If
    End Sub

    Private Sub lbCargado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCargado.SelectedIndexChanged
        If (array.Contains(lbCargado.Text)) Then
            array.Remove(lbCargado.Text)
            lbCargado.Items.RemoveAt(lbCargado.SelectedIndex)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        Productos.Show()
        Productos.idProducto = 0
        lbCargado.Items.Clear()
        array.Clear()

    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        sql = "select idTipoProducto from tipoProducto where descripcion='" & cmbTipo.Text & "'"
        rta = consulta(sql)

        If rta.Read = True Then
            idTipo = rta(0)
        End If
    End Sub

    Public Sub actualizarListaC()
        sql = "select prov.nombre from provprod pp, proveedores prov, productos prod where prod.idproducto=pp.idproducto and pp.idproveedor=prov.idproveedor and pp.idproducto=" & Productos.idProducto & ""
        rs = consulta(sql)
        While rs.Read = True
            lbCargado.Items.Add(rs(0))
            array.Add(rs(0))
        End While
    End Sub
    Public Sub actualizarListaD()
        sql = "select nombre from proveedores"
        rs = consulta(sql)
        While rs.Read = True
            lbDisponible.Items.Add(rs(0))
        End While
    End Sub
End Class