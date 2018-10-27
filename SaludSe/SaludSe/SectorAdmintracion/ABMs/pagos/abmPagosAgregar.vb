Option Explicit On
Imports System.Data.Odbc
Public Class abmPagosAgregar
    Dim rsIdSucursal As OdbcDataReader
    Dim rsNombreSucursal As OdbcDataReader
    Dim rsIdPagosMax As OdbcDataReader
    Private Sub abmPagosAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
       
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If ((txtMonto.Text <> "")) Then
            
                sql = "insert into pagos values('','" & txtMonto.Text & "','" & txtDestinatario.Text & "','" & Format(Date.Today, "yyyy/MM/dd") & "','" & txtDescripcion.Text & "')"
                consulta(sql)
                
                    MsgBox("Pago ingresado correctamente", vbInformation)
                    txtDescripcion.Text = ""
                    txtDestinatario.Text = ""
            txtMonto.Text = ""


        Else
            MsgBox("Asegurese de tener el campo del monto con un valor ", vbCritical)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmPag.Show()

    End Sub
End Class