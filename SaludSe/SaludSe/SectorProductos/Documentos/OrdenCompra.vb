Public Class OrdenCompra
    Dim contador As Integer
    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        PrintForm1.Print()
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        PedidosProductos.Show()
        PedidosProductos.totalImporte = 0
        Button1.Visible = True
        Label1.Text = ""
        btnVolver.Visible = False
        ProgressBar1.Value = 0.0
        Timer1.Interval = 50
        Timer1.Enabled = True
        ProgressBar1.Maximum = 100
        contador = 0
        PedidosProductos.cargarProductos()
        limpiar()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Visible = True
    End Sub

    Private Sub OrdenCompra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 50
        Timer1.Enabled = True
        ProgressBar1.Visible = False
        btnVolver.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Visible = True Then
            contador = contador + 4
            ProgressBar1.Value = contador
            If contador = 100 Then
                Timer1.Enabled = False
                MsgBox("Orden de Compra enviada a Sector Monetario")
                ProgressBar1.Visible = False
                Button1.Visible = False
                Label1.Text = "Orden enviada a sector monetario"
                btnVolver.Visible = True
            End If
        End If
    End Sub

    Private Sub limpiar()


        lblCantidad1.Text = ""
        lblDescripcion1.Text = ""
        lblCostoUnitario1.Text = ""
        lblImporte1.Text = ""

        lblCantidad2.Text = ""
        lblDescripcion2.Text = ""
        lblCostoUnitario2.Text = ""
        lblImporte2.Text = ""
        
        lblCantidad3.Text = ""
        lblDescripcion3.Text = ""
        lblCostoUnitario3.Text = ""
        lblImporte3.Text = ""
       
        lblCantidad4.Text = ""
        lblDescripcion4.Text = ""
        lblCostoUnitario4.Text = ""
        lblImporte4.Text = ""
        
        lblCantidad5.Text = ""
        lblDescripcion5.Text = ""
        lblCostoUnitario5.Text = ""
        lblImporte5.Text = ""
       
        lblCantidad6.Text = ""
        lblDescripcion6.Text = ""
        lblCostoUnitario6.Text = ""
        lblImporte6.Text = ""
      
        lblCantidad7.Text = ""
        lblDescripcion7.Text = ""
        lblCostoUnitario7.Text = ""
        lblImporte7.Text = ""
       
        lblCantidad8.Text = ""
        lblDescripcion8.Text = ""
        lblCostoUnitario8.Text = ""
        lblImporte8.Text = ""


        lblCantidad9.Text = ""
        lblDescripcion9.Text = ""
        lblCostoUnitario9.Text = ""
        lblImporte9.Text = ""

        lblCantidad10.Text = ""
        lblDescripcion10.Text = ""
        lblCostoUnitario10.Text = ""
        lblImporte10.Text = ""

    End Sub
End Class