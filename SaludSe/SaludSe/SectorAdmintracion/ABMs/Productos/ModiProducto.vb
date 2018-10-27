Option Explicit On
Imports System.Data.Odbc
Public Class ModiProducto

    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection

    Dim nombre, insert1, producto, update1, combo As OdbcDataReader
    Dim adp As New OdbcDataAdapter
    Dim ds As New DataSet
    Dim sql, nuevo As String

    Private Sub ModiProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try

        sql = "select descripcion from TipoProducto"
        combo = consulta(sql)

        While combo.Read = True


            ComboBox1.Items.Add(combo(0))


        End While
        ComboBox1.Items.Add("")

        DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")




    End Sub


    Private Sub btnModi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModi.Click


        If ComboBox1.Text = "" Then

            MsgBox("Seleccione una opcion")


        Else

            sql = "select idTipoProducto from TipoProducto where descripcion='" & ComboBox1.Text & "'"
            producto = consulta(sql)

            While producto.Read = True


                nuevo = InputBox("Ingrese la nueva descripcion del producto")


                sql = "update TipoProducto set descripcion='" & nuevo & "'  where idTipoProducto='" & producto(0) & "'"
                update1 = consulta(sql)

                MsgBox("Modificado correctamente!")

                ComboBox1.Text = ""



                DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")


            End While

        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click


        ABMProducto.DataGridView1.DataSource = llenarGrilla("select *  from TipoProducto")
        ABMProducto.Show()
        Me.Hide()


    End Sub
End Class