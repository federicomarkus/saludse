Option Explicit On
Imports System.Data.Odbc
Public Class VSuministroS
    Dim rsNS As OdbcDataReader
    Dim rsNombreSucursal As OdbcDataReader
    Dim verificar As Boolean

    Private Sub VSuministroS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        lblrespuesta.Text = ""
        cmbSeleSucu.Text = " "
        cmbSeleSucu.Items.Clear()
        sql = "select nombre from sucursales"
        rsNS = consulta(sql)
        While rsNS.Read = True

            cmbSeleSucu.Items.Add(rsNS(0))
        End While
        cmbSeleSucu.Items.Add(" ")
     
    End Sub

    Private Sub cmbSeleSucu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSeleSucu.SelectedIndexChanged
        If (cmbSeleSucu.Text = " ") Then
            lblrespuesta.Text = " "
            cmbSeleSucu.Text = " "
            MsgBox("No selecciono ninguna sucursal", vbCritical)
        Else
            lblrespuesta.Text = " "
            sql = "select idsucursal from sucursales where nombre= '" & cmbSeleSucu.Text & "'"
            rsNombreSucursal = consulta(sql)
            While rsNombreSucursal.Read = True
                verificar = consultaExiste("select count(*) from sucursales s, sucuservicio ss where s.idsucursal=ss.idsucursal and s.disponible=1 and s.idsucursal='" & rsNombreSucursal(0) & "' and ServiciosCumplidos=false")
                If verificar = True Then
                    lblrespuesta.Text = "Esta sucursal tiene faltas de suministros"

                Else
                    lblrespuesta.Text = "Esta sucursal no tiene faltas de suministros"
                End If
            End While
        End If

    End Sub


    Private Sub btnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
    
        Me.Close()
        MenuDeVerificaciones.Show()
    End Sub
End Class