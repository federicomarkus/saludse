Option Explicit On
Imports System.Data.Odbc


Public Class Capacitacion

    Dim cmd As OdbcCommand
    Dim cnn As OdbcConnection
    Dim sql As String
    Dim adp As New OdbcDataAdapter
    Dim ds As New DataSet
    Dim emp As String
    Dim empleados, capacitado, finaliza, finaliza1, existe, existe2 As OdbcDataReader
    Public codempleado As Integer



    Private Sub Capacitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Funciones.conexion()



        Catch ex As Exception

            MsgBox("ERROR")

        End Try

 


        DataGridView1.DataSource = llenarGrilla("select *  from empleados")



    End Sub
   
    Private Sub btnVeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeri.Click

        If emp = "" Then

            MsgBox("Debe seleccionar un empleado!")


        Else
            sql = "select capacitado from empleados where idEmpleado=" & codempleado & ""
            capacitado = Consulta(sql)


            While capacitado.Read = True


                Form1.lblempleado.Text = codempleado

                If capacitado(0) = 1 Then

                    Form1.lblcapa.Text = "SI"


                    sql = "select count(*) from CursoEmpleados where idEmpleado=" & codempleado & ""
                    existe = Consulta(sql)


                    While existe.Read = True

                        If existe(0) >= 1 Then


                            sql = "select count(*),finalizado,c.nombre from CursoEmpleados cu,curso c where  cu.idCurso=c.idCurso and cu.idEmpleado=" & codempleado & " and cu.finalizado=0"
                            finaliza = Consulta(sql)

                            While finaliza.Read = True




                                If finaliza(0) >= 1 Then

                                    Form1.DataGridView1.DataSource = llenarGrilla("select c.idCurso,nombre from curso c,CursoEmpleados cu where cu.idCurso=c.idCurso and idEmpleado=" & codempleado & " and finalizado=0")

                                

                                    Form1.lblcurso.Visible = False


                                    Form1.Show()
                                    


                                End If
                            End While

                            sql = "select count(*),finalizado,c.nombre from CursoEmpleados cu,curso c where  cu.idCurso=c.idCurso and cu.idEmpleado=" & codempleado & " and cu.finalizado=1"
                            finaliza1 = Consulta(sql)

                            While finaliza1.Read = True

                                If finaliza1(0) >= 1 Then

                                    Form1.DataGridView1.DataSource = llenarGrilla("select c.idCurso,nombre from curso c,CursoEmpleados cu where cu.idCurso=c.idCurso and idEmpleado=" & codempleado & " and finalizado=1")

                                    Form1.lblcurso.Visible = False

                                    Form1.Show()



                                End If



                            End While


                        Else


                            Form1.lblcurso.Visible = True
                            Form1.lblcurso.Text = "No realizo ningun curso"

                            Form1.Show()



                        End If
                    End While
                Else
                    sql = "select count(*) from CursoEmpleados where idEmpleado=" & codempleado & ""
                    existe = Consulta(sql)


                    While existe.Read = True

                        If existe(0) >= 1 Then


                            sql = "select count(*),finalizado,c.nombre from CursoEmpleados cu,curso c where  cu.idCurso=c.idCurso and cu.idEmpleado=" & codempleado & " and cu.finalizado=0"
                            finaliza = Consulta(sql)

                            While finaliza.Read = True


                                If finaliza(0) >= 1 Then


                                    Form1.DataGridView1.DataSource = llenarGrilla("select c.idCurso,nombre from curso c,CursoEmpleados cu where cu.idCurso=c.idCurso and idEmpleado=" & codempleado & " and finalizado=0")
                                   

                                    Form1.lblcurso.Visible = False


                                    Form1.Show()




                                End If
                            End While
                        Else
                            Form1.lblcurso.Visible = True
                            Form1.lblcurso.Text = "No realizo ningun curso"

                        End If
                    End While


                    Form1.lblcapa.Text = "NO"






                    Form1.Show()


                End If

            End While
        End If
    End Sub

   
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Empleado.Show()



        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        emp = DataGridView1.Item(0, e.RowIndex).Value

        sql = "select idEmpleado from empleados where idEmpleado='" & emp & "'"
        empleados = consulta(sql)

        While empleados.Read = True

            codempleado = empleados(0)


            MsgBox("Seleccionado correctamente")





        End While

    End Sub
End Class
