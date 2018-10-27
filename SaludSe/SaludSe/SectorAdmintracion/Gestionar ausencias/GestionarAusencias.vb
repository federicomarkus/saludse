Option Explicit On
Imports System.Data.Odbc

Public Class GestionarAusencias
    Dim sql As String
    Dim rsEmpleado As OdbcDataReader
    Dim rsExiste As OdbcDataReader
    Dim rsfecha As OdbcDataReader
    Dim rsfechamax As OdbcDataReader
    Public registrarAusencia As Boolean



    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Empleado.Show()

    End Sub

    Private Sub GestionarAusencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "select idEmpleado from Empleados"

        rsEmpleado = consulta(sql)
        cboIdEmpleado.Items.Clear()
        While rsEmpleado.Read = True



            cboIdEmpleado.Items.Add(rsEmpleado(0))

        End While
        cboIdEmpleado.Items.Add("")
    End Sub

    Private Sub btnRegistrarAusencia_Click(sender As Object, e As EventArgs) Handles btnRegistrarAusencia.Click



        If (txtDescripcion.Text = "" Or txtDurecion.Text = "" Or cboIdEmpleado.Text = "") Then
            MsgBox("Debe rellenar todos los espacios")
        Else
            If (txtDurecion.Text > 0) Then
                If (txtDurecion.Text < 90) Then


                    sql = "select count(*) from Ausencia where idEmpleado=" + cboIdEmpleado.Text
                    rsExiste = consulta(sql)

                    While rsExiste.Read = True
                        If rsExiste(0) = 1 Then


                            sql = "select fecha from Ausencia where idEmpleado=" + cboIdEmpleado.Text
                            rsfecha = consulta(sql)

                            While rsfecha.Read = True




                                If Date.Today <= (DateAdd(DateInterval.Day, CInt(txtDurecion.Text), rsfecha(0))) Then
                                    MsgBox("Ya se ha registrado la asuencia de este empleado")

                                    cboIdEmpleado.Text = ""
                                    txtDescripcion.Text = ""
                                    txtDurecion.Text = ""

                                Else

                                    sql = "insert into Ausencia values(''," + cboIdEmpleado.Text + ",'" + Format(Date.Today, "yyyy/MM/dd") + "','" + txtDescripcion.Text + "'," + txtDurecion.Text + ")"

                                    consulta(sql)



                                    MsgBox("Se ha ingresado la ausencia, a continuacion se generará el registro de ausencia correspondiente")
                                    registrarAusencia = True

                                    Me.Hide()


                                    RegistroAusenciavb.Show()




                                End If






                            End While
                        ElseIf rsExiste(0) = 2 Then

                            sql = "select max(fecha) from Ausencia where idEmpleado=" + cboIdEmpleado.Text
                            rsfechamax = consulta(sql)
                            While rsfechamax.Read = True

                                If Date.Today <= (DateAdd(DateInterval.Day, CInt(txtDurecion.Text), rsfechamax(0))) Then
                                    MsgBox("Ya se ha registrado la ausencia de este empleado")

                                    cboIdEmpleado.Text = ""
                                    txtDescripcion.Text = ""
                                    txtDurecion.Text = ""

                                Else

                                    sql = "insert into Ausencia values(''," + cboIdEmpleado.Text + ",'" + Format(Date.Today, "yyyy/MM/dd") + "','" + txtDescripcion.Text + "'," + txtDurecion.Text + ")"

                                    consulta(sql)



                                    MsgBox("Se ha ingresado la ausencia, a continuacion se generará el registro de ausencia correspondiente")
                                    registrarAusencia = True

                                    Me.Hide()

                                    RegistroAusenciavb.Show()


                                End If
                            End While

                        Else

                            sql = "insert into Ausencia values(''," + cboIdEmpleado.Text + ",'" + Format(Date.Today, "yyyy/MM/dd") + "','" + txtDescripcion.Text + "'," + txtDurecion.Text + ")"

                            consulta(sql)



                            MsgBox("Se ha ingresado la ausencia, a continuacion se generará el registro de ausencia correspondiente")
                            registrarAusencia = True
                            Me.Hide()

                            RegistroAusenciavb.Show()

                        End If


                    End While
                Else

                    MsgBox("El empleado no puede tener mas de 90 días de ausencia")

                End If


            Else
                MsgBox("La ausencia debe ser mayor a 0")
            End If





            End If




    End Sub

    Private Sub txtDurecion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDurecion.KeyPress
        OnlyNum(e)
    End Sub


End Class