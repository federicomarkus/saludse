Public Class ComprobantePe

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        btnVolver.Visible = False

        PrintForm1.Print()
        btnImprimir.Visible = True
        btnVolver.Visible = True

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Reposicion.Show()
        Me.Close()
        Reposicion.ComboBox1.Text = ""
        Reposicion.ComboBox2.Text = ""
    End Sub

    Private Sub ComprobantePe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class