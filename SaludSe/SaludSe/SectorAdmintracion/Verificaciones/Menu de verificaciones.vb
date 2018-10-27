Option Explicit On
Imports System.Data.Odbc

Public Class MenuDeVerificaciones



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.Conexion()
    End Sub


    Private Sub btnVeriPagaRega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeriPagaRega.Click
        Me.Hide()
        VPagaderegalia.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnVeriSumiServi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeriSumiServi.Click
        Me.Hide()
        VSuministroS.Show()

    End Sub

  
  
    Private Sub btnControlIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlIngreso.Click
        Me.Hide()
        CIngresos.Show()


    End Sub

    Private Sub btnVerifUtiMar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifUtiMar.Click
        Me.Hide()
        VUtiMarca.Show()

    End Sub

    Private Sub btnVeriDifeSucu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeriDifeSucu.Click
        Me.Hide()
        VDifSucu.Show()

    End Sub

    Private Sub btnControlEgresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlEgresos.Click
        Me.Hide()
        CEgresos.Show()
    End Sub

    Private Sub abmpedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        abmPed.Show()

    End Sub

    Private Sub abmPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        abmPag.Show()
    End Sub

    Private Sub abmServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        abmServi.Show()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        MenuAdministrador.Show()

    End Sub
End Class
