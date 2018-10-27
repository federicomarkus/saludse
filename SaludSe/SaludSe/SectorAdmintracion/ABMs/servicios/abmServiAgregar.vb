Option Explicit On
Imports System.Data.Odbc
Public Class abmServiAgregar
    Dim rsIdSucursal As OdbcDataReader
    Dim rsNombreSucursal As OdbcDataReader
    Dim rsIdServicioMax As OdbcDataReader
    Private Sub abmServiAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
        cmbSeleSucu.Items.Clear()
        sql = "select nombre,idSucursal from sucursales where disponible=1"
        rsNombreSucursal = consulta(sql)
        While rsNombreSucursal.Read = True

            cmbSeleSucu.Items.Add(rsNombreSucursal(0))

        End While
        cmbSeleSucu.Items.Add(" ")
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If (cmbSeleSucu.Text = " " Or txtServicio.Text = "" Or CheckBox1.Checked = False And CheckBox2.Checked = False) Then
            MsgBox("Asegurese de que todos los campos esten completos", vbCritical)
        Else
            sql = "insert into servicios values('','" & txtServicio.Text & "')"
            consulta(sql)
            sql = "select max(idServicio) from servicios"
            rsIdServicioMax = consulta(sql)
            While rsIdServicioMax.Read = True
                sql = "select idSucursal from sucursales where nombre='" & cmbSeleSucu.Text & "'"
                rsIdSucursal = consulta(sql)
                While rsIdSucursal.Read = True
                    If (CheckBox1.Checked = True) Then
                        sql = "insert into sucuservicio values('" & rsIdSucursal(0) & "','" & rsIdServicioMax(0) & "',1)"
                        consulta(sql)
                    Else
                        sql = "insert into sucuservicio values('" & rsIdSucursal(0) & "','" & rsIdServicioMax(0) & "',0)"
                        consulta(sql)
                    End If
                    MsgBox("El servicio fue insertado correctamente", vbInformation)
                    cmbSeleSucu.Text = " "
                    txtServicio.Text = " "
                    CheckBox1.Checked = False
                    CheckBox2.Checked = False

                End While
               
            End While

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If (CheckBox1.Checked = False) Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If (CheckBox2.Checked = False) Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmServi.Show()

    End Sub
End Class