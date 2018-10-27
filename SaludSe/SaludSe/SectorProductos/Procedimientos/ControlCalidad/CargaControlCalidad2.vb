Imports System.Data.Odbc
Public Class CargaControlCalidad2
    Dim sql, dir, tel, mail, cont, nombre As String
    Dim idProv As String
    Dim cal, idProd, cantidad, dia, mes, año, rtaCargar As Integer
    Dim fechaHoy, ordenCargada, rta As OdbcDataReader
    Dim idOrden As Integer
    Dim fechaCarga As Date


    Private Sub CargaCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        actualizarGrilla()
        lblNumeroOrden.Text = "Productos de la orden nº: " & CargarControlCalidad.numero
    End Sub
    Public Sub actualizarGrilla()
        idOrden = CargarControlCalidad.numero
        sql = " select p.idProducto IdProducto, p.nombre NombreProducto, p.marca Marca, p.TipoMedida Unidad,p.CantMedida Cantidad, precioUnitario Precio, cantidad Unidades from productos p, OrdenProducto op, Orden o where op.idorden=o.idorden and p.idProducto=op.idproducto and o.idorden=" & idOrden & " and op.cargado=0"
        ListaOrdenProd.DataSource = llenarGrilla(sql)
        ListaOrdenProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ListaOrdenProd.ClearSelection()
    End Sub

    Private Sub ListaOrdenProd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaOrdenProd.CellClick
        Try
            idProd = ListaOrdenProd.Rows(e.RowIndex).Cells("idProducto").Value.ToString
            nombre = ListaOrdenProd.Rows(e.RowIndex).Cells("NombreProducto").Value.ToString
            cantidad = ListaOrdenProd.Rows(e.RowIndex).Cells("Cantidad").Value.ToString
            lblId.Text = idProd
            lblNombre.Text = nombre
            lblAdvertencia.Text = ""
            gbVencimiento.Enabled = True
            gbVencimiento.ForeColor = Color.Sienna
            lbl1.ForeColor = Color.Peru
            lbl2.ForeColor = Color.Peru
            lbl3.ForeColor = Color.Peru
        Catch ex As Exception

        End Try


    End Sub


    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click



        If txtDia.Text <> "" And txtMes.Text <> "" And txtAño.Text <> "" Then
            dia = txtDia.Text
            mes = txtMes.Text
            año = txtAño.Text
            If (dia <= 31 And dia >= 1) Or (mes <= 12 And mes >= 1) Or (año >= 2018) Then

                sql = "select day(now()), month(now()), year(now());"
                fechaHoy = consulta(sql)

                If fechaHoy.Read = True Then

                    If (año = fechaHoy(2) And mes = fechaHoy(1) And dia > fechaHoy(0)) Or (año = fechaHoy(2) And mes > fechaHoy(1)) Or (año > fechaHoy(2)) Then

                        rtaCargar = MsgBox("La fecha de vencimiento es el '" & dia & "/" & mes & "/" & año & "' para el producto '" & nombre & "' ?", MsgBoxStyle.YesNo)

                        If rtaCargar = 6 Then

                            sql = "update OrdenProducto set cargado=1 where idProducto=" & idProd & " and idOrden=" & CargarControlCalidad.numero & ""
                            consulta(sql)

                            sql = "insert into comprasP values(" & idProd & "," & CargarControlCalidad.numero & " ,curdate(), '" & año & "/" & mes & "/" & dia & "',1,0," & cantidad & ")"
                            consulta(sql)

                            lblAdvertencia.Text = "SELECCIONE PRODUCTO"
                            txtDia.Text = ""
                            txtMes.Text = ""
                            txtAño.Text = ""
                            gbVencimiento.ForeColor = Color.Gray
                            lbl1.ForeColor = Color.Gray
                            lbl2.ForeColor = Color.Gray
                            lbl3.ForeColor = Color.Gray
                            gbVencimiento.Enabled = False

                            sql = "select count(*) from OrdenProducto where cargado=0 and idOrden=" & CargarControlCalidad.numero & ""
                            ordenCargada = consulta(sql)

                            If ordenCargada.Read = True Then

                                If ordenCargada(0) = 0 Then

                                    sql = "update orden set cargado=1 where idOrden=" & CargarControlCalidad.numero & ""
                                    consulta(sql)

                                    CargarControlCalidad.actualizarGrilla()
                                    Me.Hide()
                                    CargarControlCalidad.Show()

                                Else
                                    actualizarGrilla()
                                End If
                            End If
                        End If
                    Else
                        MsgBox("La fecha ingresada es menor o igual a la actual")
                    End If
                End If
            End If
        Else
            MsgBox("Faltan completar datos")
        End If
    End Sub

    Private Sub txtDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDia.KeyPress
        OnlyNum(e)
    End Sub
    Private Sub txtMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMes.KeyPress
        OnlyNum(e)
    End Sub
    Private Sub txtAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAño.KeyPress
        OnlyNum(e)
    End Sub


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        CargarControlCalidad.Show()

    End Sub

End Class