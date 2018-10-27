Imports System.Data.Odbc

Public Class InicioSesion

    Public usuarionombre As String
    Public idusuario As Integer
    Dim conec As OdbcConnection
    Dim cmd As OdbcCommand
    Dim rs As OdbcDataReader
    Dim sql As String
    Public usuario As String
    Dim pass As String
    Dim var As String

    Public Sub ConnectionTest()

        Try
            Funciones.conexion()


        Catch ex As Exception

            ConnectionFailed()

        End Try

    End Sub

    Public Sub direccionamiento(ByVal sql)

    End Sub

    Public Sub ConnectionFailed()

        MsgBox("ERROR", MsgBoxStyle.Critical, "Conexion")
        MyBase.Close()

    End Sub


    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click

        If txtcontraseña.PasswordChar = "•" Then
            txtcontraseña.PasswordChar = ""
        Else
            txtcontraseña.PasswordChar = "•"
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        If txtusuario.Text = "" Or txtcontraseña.Text = "" Then
            MsgBox("Hay un campo vacio")
        Else

            usuario = txtusuario.Text
            sql = ("select count(*) from usuarios where usuario = '" & usuario & "' ")
            var = Funciones.consultaExiste(sql)

            If var = True Then

                pass = txtcontraseña.Text
                sql = ("select count(*) from usuarios where usuario = '" & usuario & "' and contraseña = '" & pass & "' ")
                var = Funciones.consultaExiste(sql)

                If var = True Then

                    MsgBox("Inició sesion de forma correcta")
                    txtusuario.Text = ""
                    txtcontraseña.Text = ""


                    sql = ("select s.sector, u.administrador, e.idEmpleado, u.idUsuario from usuarios u, empleados e, sectores s where usuario = '" & usuario & "' and u.idEmpleado = e.idEmpleado and s.idSector = e.idSector")
                    rs = Funciones.consulta(sql)

                    If rs.Read = True Then

                        Funciones.idEmpleado = rs(2)
                        Funciones.idUsuario = rs(3)

                        If rs(1) = True Then

                        Else

                            If rs(0).Equals("Entrega") Then

                                MenuEntregas.Show()

                            ElseIf rs(0).Equals("Productos") Then

                                MenuProductos.Show()


                            ElseIf rs(0).Equals("Elaboracion") Then

                                MenuElaboracion.Show()



                            ElseIf rs(0).Equals("Administracion") Then

                                MenuAdministrador.Show()
                            Else

                                MenuAdmin.Show()

                            End If

                    End If

                    End If

                    Me.Visible = False

                Else
                    MsgBox("La contraseña es erronea")
                    txtcontraseña.Text = ""
                End If

            Else

                MsgBox("El usuario no existe")
                txtusuario.Text = ""
                txtcontraseña.Text = ""

            End If

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConnectionTest()

    End Sub

End Class
