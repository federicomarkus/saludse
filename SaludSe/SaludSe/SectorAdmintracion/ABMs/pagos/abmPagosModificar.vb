Option Explicit On
Imports System.Data.Odbc
Public Class abmPagosModificar
    Dim rsIdPago As OdbcDataReader
    Dim rsNombreSucu As OdbcDataReader
    Dim rsNombreMenu As OdbcDataReader
    Dim rsIdSucursal As OdbcDataReader
    Dim fatal As Boolean
    Private Sub abmPagosModificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()


        DataGridView1.DataSource = llenarGrilla("select * from pagos")
        cmbPago.Items.Clear()
        sql = "select p.idpagos from pagos p"
        rsIdPago = consulta(sql)
        While rsIdPago.Read = True
            cmbPago.Items.Add(rsIdPago(0))
        End While


        cmbPago.Items.Add("")
    End Sub

    Private Sub cmbPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPago.SelectedIndexChanged
        If (cmbPago.Text = " " Or cmbPago.Text = "") Then
            Label4.Visible = False

            CkDescripcion.Visible = False
            CkDestinatario.Visible = False
            CkMonto.Visible = False
        Else
            Label4.Visible = True
            CkDescripcion.Visible = True
            CkDescripcion.Checked = False
            CkMonto.Visible = True
            CkMonto.Checked = False
            CkDestinatario.Visible = True
            CkDestinatario.Checked = False
            btnModificar.Visible = True
        End If
    End Sub

   

    Private Sub CkMonto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkMonto.CheckedChanged
        If (CkMonto.Checked = True) Then
            txtMonto.Visible = True
            txtMonto.Text = ""
        Else
            txtMonto.Text = ""
            txtMonto.Visible = False
        End If
    End Sub

    Private Sub CkDestinatario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkDestinatario.CheckedChanged
        If (CkDestinatario.Checked = True) Then
            txtDestinatario.Visible = True
            txtDestinatario.Text = ""
        Else
            txtDestinatario.Visible = False
            txtDestinatario.Text = ""
        End If
    End Sub

    Private Sub CkDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkDescripcion.CheckedChanged
        If (CkDescripcion.Checked = True) Then
            txtDescripcion.Visible = True
            txtDescripcion.Text = ""
        Else
            txtDescripcion.Visible = False
            txtDescripcion.Text = ""
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If (CkMonto.Checked = False And CkDescripcion.Checked = False And CkDestinatario.Checked = False) Then
            MsgBox("No selecciono ninguna opcion para actualizar", vbCritical)
            CkDescripcion.Visible = False
            CkDestinatario.Visible = False
            CkMonto.Visible = False
            txtDestinatario.Visible = False
            txtDescripcion.Visible = False
            txtMonto.Visible = False
            cmbPago.Text = " "
        Else

            If (CkMonto.Checked = True And txtMonto.Text <> "" And txtMonto.Text <> " ") Then
                sql = "update pagos set monto='" & txtMonto.Text & "' where idpagos='" & cmbPago.Text & "'"
                consulta(sql)
                CkMonto.Checked = False

                MsgBox("Monto actualizado correctamente", vbInformation)
            ElseIf (CkMonto.Checked = True) And (txtMonto.Text = "") Or (txtMonto.Text = " ") Then
                MsgBox("No ingreso un monto", vbCritical)
                fatal = True
            End If

            If (CkDescripcion.Checked = True And (txtDescripcion.Text <> "" Or txtDescripcion.Text <> " ")) Then
                sql = "update pagos set descripcion='" & txtDescripcion.Text & "' where idpagos='" & cmbPago.Text & "'"
                consulta(sql)
                CkDescripcion.Checked = False
                MsgBox("Descripcion actualizada correctamente", vbInformation)
            ElseIf (CkDescripcion.Checked = True And (CkDescripcion.Text = "" Or CkDescripcion.Text = " ")) Then
                MsgBox("No ingreso una descripcion", vbCritical)
                fatal = True
            End If

            If (CkDestinatario.Checked = True And (txtDestinatario.Text <> "" Or txtDestinatario.Text <> " ")) Then
                sql = "update pagos set destinatario='" & txtDestinatario.Text & "' where idpagos='" & cmbPago.Text & "'"
                consulta(sql)
                CkDestinatario.Checked = False
                MsgBox("Destinatario actualizado correctamente", vbInformation)
            ElseIf (CkDestinatario.Checked = True And (txtDestinatario.Text = "" Or txtDestinatario.Text = " ")) Then
                MsgBox("No ingreso un destinatario", vbCritical)
                fatal = True

            End If
            DataGridView1.DataSource = llenarGrilla("select * from pagos")
            If (fatal = False) Then
                cmbPago.Items.Clear()
                sql = "select p.idpagos from pagos p"
                rsIdPago = consulta(sql)
                While rsIdPago.Read = True
                    cmbPago.Items.Add(rsIdPago(0))
                End While


                cmbPago.Items.Add("")


                Label4.Visible = False

                CkMonto.Visible = False
                CkDescripcion.Visible = False
                CkDestinatario.Visible = False
                btnModificar.Visible = False
            End If
        End If
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmPag.Show()
    End Sub

   
End Class