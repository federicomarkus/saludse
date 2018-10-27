Option Explicit On
Imports System.Data.Odbc

Public Class ABMSector
    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection
    Dim sql As String
    Dim nombre, insert1 As OdbcDataReader
    Dim adp As New OdbcDataAdapter
    Dim ds As New DataSet


  
    Private Sub ABMSector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try

        DataGridView1.DataSource = llenarGrilla("select *  from sectores")
     

        txt1.Focus()

    End Sub
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



                sql = "select count(*) from sectores where sector='" & txt1.Text & "'"
                nombre = consulta(sql)

                While nombre.Read = True


                    If nombre(0) = 0 Then


                        sql = "insert into sectores values('','" & txt1.Text & "')"
                        insert1 = consulta(sql)

                        MsgBox("Se agrego correctamente")


                        DataGridView1.DataSource = llenarGrilla("select *  from sectores")

                        txt1.Text = ""
                        txt1.Focus()


                    Else


                        MsgBox("Este sector ya existe")
                        txt1.Text = ""
                        txt1.Focus()

                    End If


                End While

            End If
        End If


    End Sub

  
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        ModiSector.Show()
        Me.Hide()


    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        BorradoSector.Show()
        Me.Hide()

    End Sub

   
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        ABMs.Show()
        Me.Hide()

    End Sub
End Class