Option Explicit On
Imports System.Data.Odbc
Public Class abmPedidoModificar
    Dim rsIdPedido As OdbcDataReader
    Dim rsNombreSucu As OdbcDataReader
    Dim rsNombreMenu As OdbcDataReader
    Dim rsIdSucursal As OdbcDataReader
    Dim idPedido As Integer
    Dim codMenu As String
    Dim codSucu As String
    Dim opc As Integer
    Dim rsIdMenum As OdbcDataReader

    

    Private Sub abmPedidoModificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Funciones.conexion()
       

        DataGridView1.DataSource = llenarGrilla("select pd.idpedido,s.nombre,p.fecha,p.pedidof,m.nombre,cantidad from  pedido p,  pedidosdetalle pd,  menu m,  sucursales s where p.idpedido=pd.idpedido and s.idsucursal=p.idsucursal and pd.idmenu=m.idmenu")


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

    Private Sub CkMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkMenu.CheckedChanged
        If (CkMenu.Checked = True) Then
            cmbMenu.Visible = True
        Else
            cmbMenu.Text = ""
            cmbMenu.Visible = False
        End If
        cmbMenu.Items.Clear()
        sql = "select nombre from menu where nombre!='" & codMenu & "'"
        rsNombreMenu = consulta(sql)
        While rsNombreMenu.Read = True
            cmbMenu.Items.Add(rsNombreMenu(0))

        End While

        cmbMenu.Items.Add("")
    End Sub

    Private Sub CkCantidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkCantidad.CheckedChanged
        If (CkCantidad.Checked = True) Then
            TextBox1.Visible = True
        Else
            TextBox1.Text = ""
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub CkPedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkPedido.CheckedChanged
        If (CkPedido.Checked = True) Then
            ckSi.Visible = True
            CkNo.Visible = True
            
        Else
            
            ckSi.Visible = False
            CkNo.Visible = False
        End If
      
    End Sub

    Private Sub ckSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckSi.CheckedChanged
        If (CkPedido.Checked = True) Then

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
        If (CkPedido.Checked = True) Then
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
        Dim rsIdMenu As OdbcDataReader
        If (CkCantidad.Checked = True Or CkMenu.Checked = True Or CkPedido.Checked = True Or CkSucu.Checked = True) Then


            If (CkSucu.Checked = True And cmbSucu.Text <> "") Then
                sql = "select idsucursal from sucursales where nombre='" & cmbSucu.Text & "'"
                rsIdSucursal = consulta(sql)
                While rsIdSucursal.Read = True
                    sql = "update pedido set idsucursal='" & rsIdSucursal(0) & "' where idPedido='" & idPedido & "'"
                    consulta(sql)

                    CkSucu.Checked = False
                    MsgBox("Sucursal actualizada", vbInformation)
                End While

            ElseIf (CkSucu.Checked = True And cmbSucu.Text = "") Then
                MsgBox("No elijio una sucursal", vbCritical)
                fatal = True
            End If


            If (CkMenu.Checked = True And cmbMenu.Text <> "") Then
                sql = "select idmenu from menu where nombre='" & cmbMenu.Text & "'"
                rsIdMenu = consulta(sql)
                While rsIdMenu.Read = True
                    sql = "select idmenu from menu where nombre='" & codMenu & "'"
                    rsIdMenum = consulta(sql)
                    While rsIdMenum.read = True
                        sql = "update pedidosDetalle set idmenu='" & rsIdMenu(0) & "' where idPedido='" & idPedido & "' and idMenu='" & rsIdMenum(0) & "'"
                        consulta(sql)

                        CkMenu.Checked = False
                        MsgBox("Menu actualizado", vbInformation)
                    End While
                    
                End While
            ElseIf (CkMenu.Checked = True And cmbSucu.Text = "") Then
                MsgBox("No elijio un menu", vbCritical)
                fatal = True
            End If


            If (CkCantidad.Checked = True And TextBox1.Text <> " " And TextBox1.Text <> "" And TextBox1.Text <> "0") Then
                sql = "select idmenu from menu where nombre='" & codMenu & "'"
                rsIdMenum = consulta(sql)
                While rsIdMenum.Read = True
                    sql = "update pedidosdetalle set cantidad='" & TextBox1.Text & "' where idPedido='" & idPedido & "' and idMenu='" & rsIdMenum(0) & "'"
                    consulta(sql)
                    CkCantidad.Checked = False
                    MsgBox("Cantidad actualizada", vbInformation)
                End While
            ElseIf (CkCantidad.Checked = True And (TextBox1.Text = "0" Or TextBox1.Text = "" Or TextBox1.Text = " ")) Then
                MsgBox("Error en la cantidad ingresada, ingrese nuevamente un valor valido", vbCritical)
                fatal = True
            End If

            If (CkPedido.Checked = True And ckSi.Checked = True) Then

                sql = "update pedido set pedidof=1 where idPedido='" & idPedido & "'"
                consulta(sql)
                ckSi.Checked = False
                CkPedido.Checked = False
                MsgBox("Pedido finalizado actualizado", vbInformation)
            ElseIf (CkPedido.Checked = True And CkNo.Checked = True) Then

                sql = "update pedido set pedidof=0 where idPedido='" & idPedido & "'"
                consulta(sql)
                CkNo.Checked = False
                CkPedido.Checked = False
                MsgBox("Pedido finalizado actualizado", vbInformation)
            ElseIf (CkPedido.Checked = True And CkNo.Checked = False And ckSi.Checked = False) Then
                MsgBox("Error en el pedido finalizado, elija una opcion", vbCritical)
                fatal = True
            End If


            DataGridView1.DataSource = llenarGrilla("select pd.idpedido,s.nombre,p.fecha,p.pedidof,m.nombre,cantidad from  pedido p,  pedidosdetalle pd,  menu m,  sucursales s where p.idpedido=pd.idpedido and s.idsucursal=p.idsucursal and pd.idmenu=m.idmenu")
            If (fatal = False) Then
                Label4.Visible = False
                CkSucu.Visible = False
                CkCantidad.Visible = False
                CkMenu.Visible = False
                CkPedido.Visible = False
                btnModificar.Visible = False
            End If
        Else
            MsgBox("No selecciono ningun campo para actualizar", vbCritical)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        abmPed.Show()

    End Sub
Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        idPedido = DataGridView1.Item(0, e.RowIndex).Value
        codSucu = DataGridView1.Item(1, e.RowIndex).Value
        codMenu = DataGridView1.Item(4, e.RowIndex).Value
        opc = MsgBox("Esta seguro que quiere eliminar el pedido numero  " & idPedido & " cuyo pedido  es: '" & codMenu & "'", vbYesNo)
        If (opc = 6) Then
            Label4.Visible = True
            CkSucu.Visible = True
            CkSucu.Checked = False
            CkCantidad.Visible = True
            CkCantidad.Checked = False
            CkMenu.Visible = True
            CkMenu.Checked = False
            CkPedido.Visible = True
            CkPedido.Checked = False
            btnModificar.Visible = True
        Else
            Label4.Visible = False
            CkSucu.Visible = False
            CkCantidad.Visible = False
            CkMenu.Visible = False
            CkPedido.Visible = False
            btnModificar.Visible = False
        End If
       
    End Sub
End Class