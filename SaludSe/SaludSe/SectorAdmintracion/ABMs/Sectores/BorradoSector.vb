
Option Explicit On
Imports System.Data.Odbc

Public Class BorradoSector


    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection
    Dim sql As String
    Dim borrado, combo As OdbcDataReader
    Dim ds As New DataSet
    Dim adp As New OdbcDataAdapter

    Private Sub BorradoSector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try

        sql = "select sector from sectores"
        combo = consulta(sql)

        While combo.Read = True


            ComboBox1.Items.Add(combo(0))



        End While
        DataGridView1.DataSource = llenarGrilla("select *  from sectores")
        ComboBox1.Items.Add("")


    End Sub


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        If ComboBox1.Text = "" Then

            MsgBox("Seleccione una opcion")


        Else



            sql = "delete from sectores where sector='" & ComboBox1.Text & "'"
            borrado = consulta(sql)

            MsgBox("Borrado correctamente")

            ComboBox1.Text = ""



            DataGridView1.DataSource = llenarGrilla("select *  from sectores")


        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        ABMSector.DataGridView1.DataSource = llenarGrilla("select *  from sectores")
        ABMSector.Show()
        Me.Hide()

    End Sub
End Class