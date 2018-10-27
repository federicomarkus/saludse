Imports System.Data.Odbc


Public Class Reposicion
    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection
    Dim sql As String
    Dim adp As New OdbcDataAdapter
    Dim ds As New DataSet
    Dim menu2, menu3, puntop, stock, insert1, sucursales, maxp, insert2, pedidof As OdbcDataReader
    Dim resta, cantidad As Integer
    Dim agregado As String


    Private Sub Reposicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try

        sql = "select idSucursal from sucursales"
        sucursales = Consulta(sql)

        While sucursales.Read

            ComboBox2.Items.Add(sucursales(0))


        End While

        ComboBox2.Items.Add("")


    End Sub


    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click


        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then

            MsgBox("Complete todos los datos")

        Else


            sql = "select m.idMenu,idSucursal from Menu m,Stock s where  m.idMenu=s.idMenu  and m.nombre='" & ComboBox1.Text & "' and idSucursal='" & ComboBox2.Text & "'"
            menu3 = Consulta(sql)

            While menu3.Read = True

                sql = "select s.PuntoPedido  from Menu m,Stock s  where m.idMenu=s.idMenu and idSucursal=" & menu3(1) & " and m.idMenu=" & menu3(0) & ""
                puntop = Consulta(sql)


                While puntop.Read = True


                    sql = "select cantidad from Stock where idMenu= " & menu3(0) & " and idSucursal=" & menu3(1) & " "
                    stock = Consulta(sql)

                    While stock.Read = True



                        If stock(0) < puntop(0) Then

                            sql = "select count(*) from Pedido p,PedidosDetalle pe,Stock s where p.idPedido=pe.idPedido and pe.idMenu=s.idMenu and pe.idMenu=" & menu3(0) & " and pedidof=1"
                            pedidof = Consulta(sql)

                            While pedidof.Read = True

                                If pedidof(0) >= 1 Then


                                    MsgBox("Este pedido ya se realizo")



                                    ComboBox1.Text = ""


                                    ComboBox2.Text = ""
                                Else


                                    MsgBox("El Stock es menor al Punto de Pedido,Se Generara el Pedido!")

                                    resta = puntop(0) - stock(0)


                                    agregado = InputBox("¿Que cantidad de menus desea?")



                                    If (IsNumeric(agregado)) Then
                                        cantidad = resta + agregado





                                        sql = "insert into  Pedido values(''," & menu3(1) & ",'" & Format(Date.Today, "yyyy/MM/dd") & "',1)"
                                        insert1 = Consulta(sql)



                                        sql = "select max(idPedido)from pedido"
                                        maxp = Consulta(sql)

                                        While maxp.Read = True

                                            ComprobantePe.lblmenu.Text = ComboBox1.Text
                                            ComprobantePe.lblpedido.Text = maxp(0)
                                            ComprobantePe.lblcantidad.Text = cantidad
                                            ComprobantePe.lblsucu.Text = ComboBox2.Text

                                            sql = "insert into PedidosDetalle values (" & maxp(0) & "," & menu3(0) & "," & cantidad & ")"
                                            insert2 = Consulta(sql)

                                            MsgBox("Se Genero el pedido Correctamente!")

                                            ComboBox1.Text = ""


                                            ComboBox2.Text = ""

                                        End While

                                        ComprobantePe.Show()
                                        Me.Hide()





                                    Else


                                        MsgBox("Debe ingresar un numero")



                                    End If

                                End If
                            End While


                        Else

                            MsgBox("El Stock es mayor al Punto de Pedido,Stock Suficiente!")



                            ComboBox1.Text = ""


                            ComboBox2.Text = ""
                        End If

                    End While

                End While

            End While
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()

        sql = "select nombre from Menu m,Stock s where m.idMenu=s.idMenu and idSucursal='" & ComboBox2.Text & "' "
        menu2 = Consulta(sql)



        While menu2.Read = True


            ComboBox1.Items.Add(menu2(0))


        End While
        ComboBox1.Items.Add("")
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuStock.Show()
        Me.Hide()

    End Sub
End Class
