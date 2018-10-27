Public Class OrdenDeEntrega

    Private Sub OrdenDeEntrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        lblOE_Fecha.Text = ""
        lblOE_Nro.Text = ""
        lblOE_Nombre.Text = ""
        lblOE_Direccion.Text = ""
        lbOE_Nombre.Items.Clear()
        lbOE_Cantidad.Items.Clear()
        lbOE_PrecioU.Items.Clear()
        lbOE_Total.Items.Clear()
        txtOE_Total.Text = ""
        Me.Close()
    End Sub
End Class