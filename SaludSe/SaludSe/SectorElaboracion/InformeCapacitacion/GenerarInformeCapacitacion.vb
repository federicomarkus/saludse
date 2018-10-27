Imports System.Data.Odbc

Public Class GenerarInformeCapacitacion

    Dim rs As OdbcDataReader
    Dim sql As String
    Dim menusSeleccionados As ArrayList = New ArrayList

    Public Sub cargarDatos()
        sql = "select * from menu where estado = 'Activo'"
        rs = Funciones.consulta(sql)
        Do While rs.Read
            If Not lstMenus.Items.Contains(rs(1)) Then
                cboMenus.Items.Add(rs(1))
            End If
        Loop
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuElaboracion.Show()
    End Sub

    Private Sub btnAgregarMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMenu.Click
        If cboMenus.SelectedItem = Nothing Then
            MsgBox("Seleccione un menu", MsgBoxStyle.Critical)
        Else
            If lstMenus.Items.Count = 20 Then
                MsgBox("No se pueden poner mas menus en el informe (Max 20)", MsgBoxStyle.Critical)
            Else
                lstMenus.Items.Add(cboMenus.Text)
                cboMenus.Items.RemoveAt(cboMenus.SelectedIndex)
            End If
   
        End If
    End Sub

    Private Sub btnRemoverMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverMenu.Click
        If lstMenus.SelectedItem = Nothing Then
            MsgBox("Seleccione un menu", MsgBoxStyle.Critical)
        Else
            cboMenus.Items.Add(lstMenus.SelectedItem)
            lstMenus.Items.RemoveAt(lstMenus.SelectedIndex)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cboMenus.SelectedItem = Nothing Then
            MsgBox("Seleccione un menu", MsgBoxStyle.Critical)
        Else

            Me.Hide()
        sql = "select idMenu from menu where nombre = '" & cboMenus.SelectedItem & "'"
        rs = Funciones.consulta(sql)
            If rs.Read Then
                AgregarMenu.idMenu = rs(0)
                AgregarMenu.editar = True
                AgregarMenu.desde = "Informe"
                AgregarMenu.btnAgregar.Visible = False
                AgregarMenu.btnRemover.Visible = False
                AgregarMenu.btnAgregarElemento.Visible = False
                AgregarMenu.btnEditar.Visible = False
                AgregarMenu.txtCaducidad.Enabled = False
                AgregarMenu.txtCantidad.Enabled = False
                AgregarMenu.txtNombre.Enabled = False
                AgregarMenu.cboEmpaquetamiento.Enabled = False
                AgregarMenu.cboTipoElemento.Enabled = False
                AgregarMenu.cboElementos.Enabled = False
                AgregarMenu.cargarDatos()
                AgregarMenu.btnEditar.Visible = False
                Me.Hide()
                AgregarMenu.Show()
            End If
        End If

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        If lstMenus.Items.Count = 0 Then
            MsgBox("No se ha seleccionado ninguna menu")
        Else
            InformeCapacitacion.lblfecha.Text = Date.Now.ToShortDateString


            If txtObservaciones.Text.Length > 50 Then
                InformeCapacitacion.lblObs.Text = ""
                InformeCapacitacion.lblObs2.Text = ""
                InformeCapacitacion.lblObs3.Text = ""

                For index As Integer = 0 To txtObservaciones.Text.Length - 1

                    If index < 60 Then
                        InformeCapacitacion.lblObs.Text = InformeCapacitacion.lblObs.Text & txtObservaciones.Text.Chars(index)

                    ElseIf index < 120 And index >= 60 Then

                        InformeCapacitacion.lblObs2.Text = InformeCapacitacion.lblObs2.Text & txtObservaciones.Text.Chars(index)
                    Else
                        InformeCapacitacion.lblObs3.Text = InformeCapacitacion.lblObs3.Text & txtObservaciones.Text.Chars(index)

                    End If


                Next

            Else

                InformeCapacitacion.lblObs.Text = txtObservaciones.Text

            End If

            Dim cont As Integer = 0

            For Each item As String In lstMenus.Items
                cont = cont + 1
                If cont = 1 Then
                    InformeCapacitacion.lblmenu1.Text = item
                ElseIf cont = 2 Then
                    InformeCapacitacion.lblmenu2.Text = item
                ElseIf cont = 3 Then
                    InformeCapacitacion.lblmenu3.Text = item
                ElseIf cont = 4 Then
                    InformeCapacitacion.lblmenu4.Text = item
                ElseIf cont = 5 Then
                    InformeCapacitacion.lblmenu5.Text = item
                ElseIf cont = 6 Then
                    InformeCapacitacion.lblmenu6.Text = item
                ElseIf cont = 7 Then
                    InformeCapacitacion.lblmenu7.Text = item
                ElseIf cont = 8 Then
                    InformeCapacitacion.lblmenu8.Text = item
                ElseIf cont = 9 Then
                    InformeCapacitacion.lblmenu9.Text = item
                ElseIf cont = 10 Then
                    InformeCapacitacion.lblmenu10.Text = item
                ElseIf cont = 11 Then
                    InformeCapacitacion.lblmenu11.Text = item
                ElseIf cont = 12 Then
                    InformeCapacitacion.lblmenu12.Text = item
                ElseIf cont = 13 Then
                    InformeCapacitacion.lblmenu13.Text = item
                ElseIf cont = 14 Then
                    InformeCapacitacion.lblmenu14.Text = item
                ElseIf cont = 15 Then
                    InformeCapacitacion.lblmenu15.Text = item
                ElseIf cont = 16 Then
                    InformeCapacitacion.lblmenu16.Text = item
                ElseIf cont = 17 Then
                    InformeCapacitacion.lblmenu17.Text = item
                ElseIf cont = 18 Then
                    InformeCapacitacion.lblmenu18.Text = item
                ElseIf cont = 19 Then
                    InformeCapacitacion.lblmenu19.Text = item
                ElseIf cont = 20 Then
                    InformeCapacitacion.lblmenu20.Text = item
                End If

            Next

            Me.Close()
            InformeCapacitacion.Show()
        End If



    End Sub

End Class