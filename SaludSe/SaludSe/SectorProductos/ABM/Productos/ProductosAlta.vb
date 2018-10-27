Imports System.Data.Odbc
Public Class ProductosAlta

    Dim sql As String
    Dim rs, rta, provs, prod As OdbcDataReader
    Dim i As Integer
    Dim array As ArrayList = New ArrayList()

    Private Sub ProductosAlta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conexion()
        actualizarGrilla()
        sql = "select descripcion from TipoProducto"
        rta = consulta(sql)

        While rta.Read = True
            cmbTipo.Items.Add(rta(0))
        End While

        cmbTipo.Items.Add("")

    End Sub
    Public Sub actualizarGrilla()
        sql = "select nombre from proveedores"
        rs = consulta(sql)
        While rs.Read = True
            lbDisponible.Items.Add(rs(0))
        End While
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim nombre, marca, tipoUnidad, tipoProducto As String
        Dim cantidad, puntoP, calif, stockD As Integer

        If txtNombre.Text = "" Or txtMarca.Text = "" Or cmbUnidad.Text = "" Or txtCantidad.Text = "" Or cmbTipo.Text = "" Or txtPuntoP.Text = "" Or txtStock.Text = "" Or txtCalif.Text = "" Or lbCargado.Items.Count = 0 Then

            lblError.Text = "Error. Completar campos"

        Else
            nombre = txtNombre.Text
            marca = txtMarca.Text
            tipoUnidad = cmbUnidad.Text
            cantidad = txtCantidad.Text
            tipoProducto = cmbTipo.Text
            puntoP = txtPuntoP.Text
            stockD = txtStock.Text
            calif = txtCalif.Text




            sql = "select idTipoProducto from tipoProducto where descripcion='" & cmbTipo.Text & "'"
            rta = consulta(sql)

            If rta.Read = True Then

                sql = "insert into productos values('','" & nombre & "','" & marca & "'," & rta(0) & "," & cantidad & ",'" & tipoUnidad & "', " & stockD & "," & puntoP & "," & calif & ",1)"
                consulta(sql)
                sql = "select max(idProducto) from productos"
                prod = consulta(sql)
                If prod.Read = True Then


                    For Each item As String In array
                        Dim precio As String
                        Do
                            precio = InputBox("Ingrese precio para el proveedor " + item, )
                        Loop Until IsNumeric(precio)
                        sql = "select idProveedor from proveedores where nombre='" & item & "'"
                        provs = consulta(sql)
                        If provs.Read = True Then
                            sql = "insert into provprod values(" & provs(0) & "," & prod(0) & "," & precio & ")"
                            consulta(sql)
                        End If

                    Next
                End If
                MsgBox("Se ha cargado un nuevo producto")
                Productos.actualizarGrilla()
                Me.Hide()
                Productos.Show()

            End If

            txtCantidad.Text = ""
            txtMarca.Text = ""
            txtPuntoP.Text = ""
            txtNombre.Text = ""
            cmbTipo.Text = ""
            cmbUnidad.Text = ""
            lblError.Text = ""
            txtCalif.Text = ""
            txtStock.Text = ""
            array.Clear()
            lbCargado.Items.Clear()


        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()

        txtCantidad.Text = ""
        txtMarca.Text = ""
        txtPuntoP.Text = ""
        txtNombre.Text = ""
        cmbTipo.Text = ""
        cmbUnidad.Text = ""
        lblError.Text = ""
        txtCalif.Text = ""
        txtStock.Text = ""

        Productos.Show()
        lbCargado.Items.Clear()
        array.Clear()

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub txtPuntoP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPuntoP.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub lbDisponible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDisponible.SelectedIndexChanged
        If Not (array.Contains(lbDisponible.Text)) Then
            array.Add(lbDisponible.Text)
            lbCargado.Items.Add(lbDisponible.Text)
        End If
    End Sub

    Private Sub lbCargado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCargado.SelectedIndexChanged
        If (array.Contains(lbCargado.Text)) Then
            array.Remove(lbCargado.Text)
            lbCargado.Items.RemoveAt(lbCargado.SelectedIndex)
        End If
    End Sub
End Class