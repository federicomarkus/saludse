Option Explicit On
Imports System.Data.Odbc
Public Class VDifSucu
    Dim rsControlCorrecto As OdbcDataReader
    Dim rsNombreSucursal As OdbcDataReader
    Dim verificar As Boolean
    Dim entro As Boolean
    Private Sub VDifSucu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        lblrespuesta.Text = " "
        cmbSeleSucu.Text = " "
        cmbSeleSucu.Items.Clear()
        sql = "select nombre,idSucursal from sucursales where disponible=1"
        rsNombreSucursal = consulta(sql)
        While rsNombreSucursal.Read = True

            cmbSeleSucu.Items.Add(rsNombreSucursal(0))
        End While
        cmbSeleSucu.Items.Add(" ")
    End Sub

    Private Sub cmbSeleSucu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSeleSucu.SelectedIndexChanged
        If (cmbSeleSucu.Text = " ") Then
            btnControl.Visible = False
            lst1.Visible = False
            MsgBox("No selecciono ninguna sucursal", vbCritical)

        Else
            lst1.Visible = True
            btnControl.Visible = True
            lst1.Items.Clear()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

     
        Me.Close()
        MenuDeVerificaciones.Show()
    End Sub

    Private Sub btnControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControl.Click
        entro = False
        sql = "select s.nombre,c.descripcion from sucursales s, control_marca c where s.idsucursal=c.idsucursal and s.disponible=1 and cumplida=1 and control_marca=0 and s.nombre='" & cmbSeleSucu.Text & "'"
        rsControlCorrecto = consulta(sql)

        While rsControlCorrecto.Read = True
            lst1.Items.Add("La " & rsControlCorrecto(0) & ": tiene el " & rsControlCorrecto(1) & " correctamente realizado")
            entro = True
        End While
        If (entro = True) Then
            lst1.Items.Add("-------------------------------------------------------------------------------------------")
        End If

        sql = "select s.nombre,c.descripcion from sucursales s, control_marca c where s.idsucursal=c.idsucursal and s.disponible=1 and cumplida=0 and control_marca=0 and s.nombre='" & cmbSeleSucu.Text & "'"
        rsControlCorrecto = consulta(sql)
        While rsControlCorrecto.Read = True
            lst1.Items.Add("La " & rsControlCorrecto(0) & ": tiene el " & rsControlCorrecto(1) & " sin realizar")
            entro = True
        End While

        If entro = False Then
            lst1.Items.Add("LA " & cmbSeleSucu.Text & " NO TIENE CONTROLES HECHOS")
            entro = True
        End If
    End Sub
End Class