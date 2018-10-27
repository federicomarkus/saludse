Public Class InformeCapacitacion

    Private Sub Buttok(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Try
            PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)

        Catch ex As Exception

            MsgBox("error")

        End Try

        Me.Close()
        GenerarInformeCapacitacion.Visible = True

    End Sub

    Private Sub Informe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class