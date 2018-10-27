Option Explicit On
Imports System.Data.Odbc
Public Class abmServiModificar
    Dim rsNombreSucu As OdbcDataReader
    Dim rsIdSucursals As OdbcDataReader
    Dim rsIdSucursal As OdbcDataReader
    Dim idServicio As Integer
    Dim codSucu As String
    Dim opc As Integer

    Private Sub abmServiModificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        DataGridView1.DataSource = llenarGrilla("select ss.idservicio,s.nombre Nombre_Servicio,su.nombre Nombre_Sucursal,serviciosCumplidos Servicio_Cumplido from servicios s, sucuservicio ss, sucursales su where  su.idSucursal=ss.idSucursal and s.idservicio=ss.idservicio group by ss.idservicio")
    End Sub

    Private Sub CkSucu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkSucu.CheckedChanged
        If (CkSucu.Checked = True) Then
            cmbSucu.Visible = True
        Else
            cmbSucu.Text = ""
            cmbSucu.Visible = False

        End If
        cmbSucu.Items.Clear()

        sql = "select nombre from sucursales where nombre!='" & codSucu & "' and disponible=1"
        rsNombreSucu = consulta(sql)
        While rsNombreSucu.Read = True
            cmbSucu.Items.Add(rsNombreSucu(0))

        End While
        cmbSucu.Items.Add("")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        idServicio = DataGridView1.Item(0, e.RowIndex).Value
        codSucu = DataGridView1.Item(2, e.RowIndex).Value
        opc = MsgBox("Esta seguro que quiere modificar el servicio numero  " & idServicio & " cuya sucursal  es: '" & codSucu & "'", vbYesNo)
        If (opc = 6) Then
            Label4.Visible = True
            CkSucu.Visible = True
            CkSucu.Checked = False
            CkCumplido.Visible = True
            CkCumplido.Checked = False
            CkServicio.Visible = True
            CkServicio.Checked = False
            btnModificar.Visible = True
        Else
            Label4.Visible = False
            CkSucu.Visible = False
            CkSucu.Checked = False
            CkCumplido.Visible = False
            CkCumplido.Checked = False
            CkServicio.Visible = False
            CkServicio.Checked = False
            btnModificar.Visible = False
        End If
    End Sub

   
    Private Sub CkServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkServicio.CheckedChanged
        If (CkServicio.Checked = True) Then
            TextBox1.Visible = True
            TextBox1.Text = ""
        Else
            TextBox1.Visible = False
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub CkCumplido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkCumplido.CheckedChanged
        If (CkCumplido.Checked = True) Then
            ckSi.Visible = True
            CkNo.Visible = True

        Else

            ckSi.Visible = False
            CkNo.Visible = False
        End If
    End Sub

    Private Sub ckSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckSi.CheckedChanged
        If (CkCumplido.Checked = True) Then

            If (ckSi.Checked = True) Then
                CkNo.Checked = False
            Else
                CkNo.Checked = True

            End If
        Else
            ckSi.Checked = False
        End If
    End Sub

    Private Sub CkNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkNo.CheckedChanged
        If (CkCumplido.Checked = True) Then
            If (CkNo.Checked = True) Then
                ckSi.Checked = False
            Else
                ckSi.Checked = True

            End If
        Else
            CkNo.Checked = False
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim fatal As Boolean
        If (CkCumplido.Checked = True Or CkServicio.Checked = True Or CkSucu.Checked = True) Then
            If (CkSucu.Checked = True And cmbSucu.Text <> "") Then
                sql = "select idsucursal from sucursales where nombre='" & cmbSucu.Text & "'"
                rsIdSucursal = consulta(sql)
                While rsIdSucursal.Read = True
                    sql = "update sucuservicio set idsucursal='" & rsIdSucursal(0) & "' where idServicio='" & idServicio & "'"
                    consulta(sql)

                    CkSucu.Checked = False
                    MsgBox("Sucursal actualizada", vbInformation)
                End While

            ElseIf (CkSucu.Checked = True And cmbSucu.Text = "") Then
                MsgBox("No elijio una sucursal", vbCritical)
                fatal = True
            End If


            If (CkServicio.Checked = True And TextBox1.Text <> "") Then

                sql = "update servicios set nombre='" & TextBox1.Text & "' where idServicio='" & idServicio & "'"
                consulta(sql)

                CkServicio.Checked = False
                MsgBox("Servicio actualizado", vbInformation)


            ElseIf (CkServicio.Checked = True And TextBox1.Text = "") Then
                MsgBox("No escribio ningun servicio", vbCritical)
                fatal = True
            End If

            If (CkCumplido.Checked = True And ckSi.Checked = True) Then
                sql = "select idsucursal from sucursales where nombre='" & codSucu & "'"
                rsIdSucursals = consulta(sql)
                While rsIdSucursals.Read = True
                    sql = "update sucuservicio set servicioscumplidos=1 where idServicio='" & idServicio & "' and idsucursal='" & rsIdSucursals(0) & "'"
                    consulta(sql)
                    ckSi.Checked = False
                    CkCumplido.Checked = False
                    MsgBox("Servicio cumplido actualizado", vbInformation)
                End While
                

            ElseIf (CkCumplido.Checked = True And CkNo.Checked = True) Then

                sql = "select idsucursal from sucursales where nombre='" & codSucu & "'"
                rsIdSucursals = consulta(sql)
                While rsIdSucursals.Read = True
                    sql = "update sucuservicio set servicioscumplidos=0 where idServicio='" & idServicio & "' and idsucursal='" & rsIdSucursals(0) & "'"
                    consulta(sql)
                    CkNo.Checked = False
                    CkCumplido.Checked = False
                    MsgBox("Servicio cumplido actualizado", vbInformation)
                End While
            ElseIf (CkCumplido.Checked = True And CkNo.Checked = False And ckSi.Checked = False) Then
                MsgBox("Error en el servicio cumplido , elija una opcion", vbCritical)
                fatal = True
            End If
            DataGridView1.DataSource = llenarGrilla("select ss.idservicio,s.nombre Nombre_Servicio,su.nombre Nombre_Sucursal,serviciosCumplidos Servicio_Cumplido from servicios s, sucuservicio ss, sucursales su where  su.idSucursal=ss.idSucursal and s.idservicio=ss.idservicio group by ss.idservicio")
            If (fatal = False) Then
                Label4.Visible = False
                CkSucu.Visible = False
                CkCumplido.Visible = False
                CkServicio.Visible = False
                btnModificar.Visible = False
                TextBox1.Visible = False
            End If
        Else
            MsgBox("No selecciono ningun campo para actualizar", vbCritical)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmServi.Show()
    End Sub
End Class