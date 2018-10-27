Public Class TipoProductoABM
    Dim sql As String
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        TipoProducto.Show()
        lblError.Text = ""
        txtDescripcion.Text = ""
        TipoProducto.cargarTipoProductos()
        TipoProducto.id = 0
    End Sub

    Private Sub btnCargarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarProducto.Click
        If btnCargarProducto.Text = "Cargar" Then


            If txtDescripcion.Text = "" Then
                lblError.Text = "Completar todos los campos"
            Else
                sql = "insert into TipoProducto values('', '" & txtDescripcion.Text & "', 1)"
                consulta(sql)
                MsgBox("Se cargo correctamente")
                lblError.Text = ""
                txtDescripcion.Text = ""

                Me.Hide()
                TipoProducto.Show()
                TipoProducto.cargarTipoProductos()
                TipoProducto.id = 0

            End If

        Else

            If txtDescripcion.Text = "" Then
                lblError.Text = "Completar todos los campos"
            Else
                sql = "update TipoProducto set descripcion = '" & txtDescripcion.Text & "' where idTipoProducto = " & TipoProducto.id
                consulta(sql)
                MsgBox("Modificado correctamente")
                lblError.Text = ""
                txtDescripcion.Text = ""

                Me.Hide()
                TipoProducto.Show()
                TipoProducto.cargarTipoProductos()
                TipoProducto.id = 0

            End If


        End If
    End Sub
End Class