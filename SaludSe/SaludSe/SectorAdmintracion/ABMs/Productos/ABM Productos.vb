Option Explicit On
Imports System.Data.Odbc
Public Class ABMProducto





    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection

    Dim nombre, insert1 As OdbcDataReader
    Dim adp As New OdbcDataAdapter
    Dim ds As New DataSet
    Dim sql As String







    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click


        txt1.Focus()

        If txt1.Text = "" Then


            MsgBox("Complete todos los datos")

        Else

            If (IsNumeric(txt1.Text)) Then


                MsgBox("No se permiten ingresar numeros")


                txt1.Text = ""
                txt1.Focus()


            Else


                sql = "select count(*) from TipoProducto where descripcion='" & txt1.Text & "'"
                nombre = consulta(sql)

                While nombre.Read = True


                    If nombre(0) = 0 Then


                        sql = "insert into TipoProducto values('','" & txt1.Text & "',1)"
                        insert1 = consulta(sql)

                        MsgBox("Se agrego correctamente")


                        DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")

                        txt1.Text = ""
                        txt1.Focus()


                    Else


                        MsgBox("Este Producto ya existe")
                        txt1.Text = ""
                        txt1.Focus()

                    End If


                End While

            End If
        End If
    End Sub








    Private Sub ABMPro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try


        ds.Tables.Clear()

        DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")



    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        ModiProducto.Show()
        Me.Hide()


    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        BorradoProducto.Show()
        Me.Hide()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        ABMs.Show()
        Me.Hide()

    End Sub
End Class