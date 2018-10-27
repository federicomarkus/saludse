Option Explicit On
Imports System.Data.Odbc
Public Class CIngresos
    Dim rsNS As OdbcDataReader
    Dim rsSuma As OdbcDataReader
    Dim rsTicket As OdbcDataReader
    Dim rsFechaHoy As OdbcDataReader
    Dim rsSucursal As OdbcDataReader
    Dim sumar As Integer
    Dim entro As Boolean



    Private Sub CIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        cmbSeleSucu.Items.Clear()

        sql = "select nombre from sucursales where disponible=1"
        rsNS = consulta(sql)
        While rsNS.Read = True

            cmbSeleSucu.Items.Add(rsNS(0))
        End While
        cmbSeleSucu.Items.Add(" ")

        lstMontos.Visible = False
        btnControlar.Visible = False

    End Sub

    Private Sub btnControlar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlar.Click
        lstMontos.Items.Clear()
        entro = False
        

            sql = "select idsucursal from sucursales where nombre='" & cmbSeleSucu.Text & "'"
            rsSucursal = consulta(sql)
            While rsSucursal.Read = True
            sql = "select idticket,fechapago,monto from ticket t, empleados e, sucursales s,usuarios u where u.idempleado=e.idempleado and t.estado=1 and s.disponible=1 and t.idEmpleado=e.idEmpleado and u.idsucursal= " & rsSucursal(0) & " group by t.idTicket"
                rsTicket = consulta(sql)

                While rsTicket.Read = True
                    entro = True
                    sumar = sumar + rsTicket(2)
                    lstMontos.Items.Add("Numero de ticket: " & rsTicket(0) & " ||| Fecha de pago: " & rsTicket(1) & " ||| Monto: " & rsTicket(2))
                End While
                If (entro = True) Then
                    lstMontos.Items.Add("-----------------------------------------")
                    lstMontos.Items.Add("Monto total: " & sumar)
                    sumar = 0
                Else



                    lstMontos.Items.Add("Esta sucursal no tuvo ingresos")
                End If
            End While

    End Sub

    

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Close()
        MenuDeVerificaciones.Show()

    End Sub

    Private Sub cmbSeleSucu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSeleSucu.SelectedIndexChanged
        If (cmbSeleSucu.Text = " ") Then
            btnControlar.Visible = False
            lstMontos.Visible = False
            MsgBox("No selecciono ninguna sucursal", vbCritical)


        Else
            lstMontos.Visible = True
            btnControlar.Visible = True
            lstMontos.Items.Clear()
        End If

    End Sub


End Class