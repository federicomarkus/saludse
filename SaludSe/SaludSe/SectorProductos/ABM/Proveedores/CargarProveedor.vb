Imports System.Data.Odbc

Public Class CargarProveedor

    Dim sql, nom, dir, tel, mail, cont As String
    Dim rta As OdbcDataReader


    Private Sub CargarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conexion()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If txtNombre.Text = "" Or txtDireccion.Text = "" Or txtTelefono.Text = "" Or txtMail.Text = "" Or txtContacto.Text = "" Then

            lblError.Text = "Error. Completar campos"

        Else

            lblError.Text = ""

            sql = "select count(*) from proveedores where nombre='" & txtNombre.Text & "'"
            rta = consulta(sql)

            If rta.Read = True Then

                If rta(0) = 0 Then

                    nom = txtNombre.Text
                    dir = txtDireccion.Text
                    tel = txtTelefono.Text
                    mail = txtMail.Text
                    cont = txtContacto.Text

                    sql = "insert into proveedores values('','" & nom & "','" & dir & "','" & tel & "','" & mail & "','" & cont & "',0,0,1)"
                    consulta(sql)

                    MsgBox("Se ha cargado un nuevo proveedor correctamente")

                    txtNombre.Text = ""
                    txtDireccion.Text = ""
                    txtTelefono.Text = ""
                    txtMail.Text = ""
                    txtContacto.Text = ""
                    lblError.Text = ""

                Else

                    MsgBox("Ya existe un proveedor con este nombre")

                End If

            End If


        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Proveedores.Show()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
        txtContacto.Text = ""
        lblError.Text = ""
        Proveedores.actualizarGrilla()

    End Sub
    Private Sub txtTelefono_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        OnlyNum(e)
    End Sub
End Class