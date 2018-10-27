Option Explicit On
Imports System.Data.Odbc
Public Class BorradoProducto
    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection

    Dim borrado, tipo, prod, combo, update1 As OdbcDataReader
    Dim adp As New OdbcDataAdapter
    Dim ds As New DataSet
    Dim sql, nuevo As String
    Private Sub BorradoProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try

        sql = "select descripcion from TipoProducto"
        combo = Consulta(sql)

        While combo.Read = True


            ComboBox1.Items.Add(combo(0))


        End While
        ComboBox1.Items.Add("")

        DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If ComboBox1.Text = "" Then

            MsgBox("Seleccione una opcion")


        Else



            sql = "update TipoProducto set estado=0 where descripcion='" & ComboBox1.Text & "'"
            borrado = Consulta(sql)

            sql = "select idTipoProducto from TipoProducto where  descripcion='" & ComboBox1.Text & "'"
            tipo = Consulta(sql)

            While tipo.Read = True


                sql = "select count(*),idProducto from Productos where idTipoProducto=" & tipo(0) & ""
                prod = Consulta(sql)

                While prod.Read = True


                    If prod(0) = 1 Then


                        sql = "update Productos set estado=0 where idProducto=" & prod(1) & ""
                        update1 = Consulta(sql)




                    End If



                End While
            End While


            MsgBox("Se cambio el estado a inhabilitado!")

            ComboBox1.Text = ""



            DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")


        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        ABMProducto.DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")

        ABMProducto.Show()

        Me.Hide()

    End Sub

   
End Class