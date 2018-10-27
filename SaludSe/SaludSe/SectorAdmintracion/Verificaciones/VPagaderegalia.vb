Option Explicit On
Imports System.Data.Odbc
Public Class VPagaderegalia
    Dim rsNS As OdbcDataReader
    Dim rsNombreSucursal As OdbcDataReader
    Dim rsMaximaFecha As OdbcDataReader
    Dim rsFechaHoy As OdbcDataReader

   

    Private Sub VPagaderegalia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        lblrespuesta.Text = ""
        cmbSeleSucu.Text = " "
        cmbSeleSucu.Items.Clear()
        sql = "select nombre from sucursales where disponible=1"
        rsNS = consulta(sql)
        While rsNS.Read = True

            cmbSeleSucu.Items.Add(rsNS(0))
        End While
        cmbSeleSucu.Items.Add(" ")

    End Sub


    
    Private Sub cmbSeleSucu_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSeleSucu.SelectedIndexChanged
        If (cmbSeleSucu.Text = " ") Then

            MsgBox("No selecciono ninguna sucursal", vbCritical)
            lblrespuesta.Text = " "
        Else
          

            sql = "select idsucursal from sucursales where nombre= '" & cmbSeleSucu.Text & "'"
            rsNombreSucursal = consulta(sql)
            While rsNombreSucursal.Read = True
                sql = "select max(YEAR(fecha)),max(MONTH(fecha)),max(DAY(fecha)) from pagossucursal ps, pagos p, Sucursales s where p.idpagos=ps.idpagos and s.disponible=1 and ps.idsucursal=s.idsucursal and ps.idsucursal= '" & rsNombreSucursal(0) & "' and descripcion= 'Pago por regalia'"
                rsMaximaFecha = consulta(sql)
                While rsMaximaFecha.Read = True

                    sql = "select YEAR(NOW()),MONTH (NOW()),DAY(NOW())"
                    rsFechaHoy = consulta(sql)
                    While rsFechaHoy.Read = True
                        Try
                            If (rsMaximaFecha(0) = rsFechaHoy(0)) Then
                                If (rsMaximaFecha(1) = rsFechaHoy(1)) Then
                                    lblrespuesta.Text = "REGALIA PAGA"
                                Else
                                    lblrespuesta.Text = "REGALIA IMPAGA"
                                End If
                            Else
                                lblrespuesta.Text = "REGALIA IMPAGA"
                            End If
                        Catch ex As Exception
                            MsgBox("Esta sucursal nunca ha pagado una regalía ", vbCritical)
                            lblrespuesta.Text = " "

                        End Try

                    End While
                End While
            End While
        End If
    End Sub

  

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
      
        Me.Close()
        MenuDeVerificaciones.Show()
    End Sub
End Class