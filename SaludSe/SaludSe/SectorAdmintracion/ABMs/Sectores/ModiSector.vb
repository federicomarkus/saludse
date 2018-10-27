

Option Explicit On
Imports System.Data.Odbc
Public Class ModiSector
    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection
    Dim sql As String
    Dim nuevo As String
    Dim sector, update1, combo As OdbcDataReader
    Dim adp As New OdbcDataAdapter
    Dim ds As New DataSet

    Private Sub btnModi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModi.Click


        If ComboBox1.Text = "" Then

            MsgBox("Seleccione una opcion")


        Else

            sql = "select idSector from sectores where sector='" & ComboBox1.Text & "'"
            sector = Consulta(sql)

            While sector.Read = True


                nuevo = InputBox("Ingrese el nuevo nombre del sector")


                sql = "update sectores set sector='" & nuevo & "'  where idSector='" & sector(0) & "'"
                update1 = Consulta(sql)

                MsgBox("Modificado correctamente!")

                ComboBox1.Text = ""



                DataGridView1.DataSource = llenarGrilla("select *  from sectores")


            End While

        End If
    End Sub

    Private Sub ModiSector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try


        sql = "select sector from sectores"
        combo = Consulta(sql)

        While combo.Read = True


            ComboBox1.Items.Add(combo(0))



        End While
        DataGridView1.DataSource = llenarGrilla("select *  from sectores")
        ComboBox1.Items.Add("")

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        ABMSector.DataGridView1.DataSource = llenarGrilla("select *  from sectores")
        ABMSector.Show()
        Me.Hide()

    End Sub
End Class