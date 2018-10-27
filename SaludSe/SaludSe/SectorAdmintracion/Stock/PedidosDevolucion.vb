Imports System.Data.Odbc



Public Class PedidosDevolucion
    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection
    Dim sql As String
    Dim pedido, cantidad, cantidad2 As OdbcDataReader
    Dim ds As New DataSet
    Dim adp As New OdbcDataAdapter

    Private Sub txt1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress


        OnlyNum(e)
    End Sub

    Private Sub txt2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress


        OnlyNum(e)
    End Sub

    Private Sub txt3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress


        OnlyNum(e)
    End Sub


    Private Sub PedidosDevolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try


        DataGridView1.DataSource = llenarGrilla("select idPedido,idMenu,cantidad  from PedidosDetalle")
    


    End Sub

    Private Sub btnVeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeri.Click

        If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Then

            MsgBox("Complete todos los campos")

        Else


            sql = "select count(*) from PedidosDetalle where idPedido='" & txt1.Text & "' and idMenu='" & txt3.Text & "'"
            pedido = consulta(sql)

            While pedido.Read = True


                If (pedido(0) = 1) Then



                    sql = "select count(*) from PedidosDetalle where idPedido='" & txt1.Text & "' and cantidad='" & txt2.Text & "'"
                    cantidad = consulta(sql)


                    While cantidad.Read = True


                        If cantidad(0) = 1 Then


                            MsgBox("La cantidad solicitada es igual a la cantidad pedida")
                            txt1.Text = ""
                            txt2.Text = ""
                            txt3.Text = ""


                        Else
                            sql = "select cantidad from PedidosDetalle where idPedido='" & txt1.Text & "'"

                            cantidad2 = consulta(sql)
                            While cantidad2.Read = True



                                MsgBox("La cantidad del pedido elegido es de " & cantidad2(0))

                                txt1.Text = ""
                                txt2.Text = ""
                                txt3.Text = ""
                            End While
                        End If

                    End While


                Else
                    MsgBox("Los datos ingresados no son los correctos")

                    txt1.Text = ""
                    txt2.Text = ""
                    txt3.Text = ""
                End If

            End While







        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuStock.Show()
        Me.Hide()

    End Sub
End Class