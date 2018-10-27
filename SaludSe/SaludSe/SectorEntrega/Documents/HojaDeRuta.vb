Public Class HojaDeRuta

    Private Sub HojaDeRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        lbP_HRCodigoEnvio.Items.Clear()
        lbP_HRDireccion.Items.Clear()
        Me.Close()
    End Sub
End Class