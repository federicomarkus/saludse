Imports System.Data.Odbc
Public Class ModificarProveedores

    Dim sql, dir, tel, mail, cont As String
    Dim cal As Integer
    Dim rta As OdbcDataReader


    Private Sub ModificarProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtDireccion.Text = "" Or txtTelefono.Text = "" Or txtMail.Text = "" Or txtContacto.Text = "" Or txtCalificacion.Text = "" Then

            lblError.Text = "Error. Completar campos"

        Else

            lblError.Text = ""

            dir = txtDireccion.Text
            tel = txtTelefono.Text
            mail = txtMail.Text
            cont = txtContacto.Text
            cal = txtCalificacion.Text

            sql = "update proveedores set nombre = '" & txtNombreP.Text & "', direccion='" & dir & "',telefono='" & tel & "',mail='" & mail & "',contacto='" & cont & "',calificacion=" & cal & " where idProveedor=" & Proveedores.numero
            consulta(sql)

            MsgBox("Se han modificado los datos del proveedor correctamente")
            Proveedores.actualizarGrilla()
            Proveedores.numero = 0

            Me.Hide()


        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Proveedores.actualizarGrilla()
        Proveedores.numero = 0
        Me.Hide()
    End Sub

    Private Sub txtCalificacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalificacion.KeyPress
        OnlyNum(e)
    End Sub
End Class