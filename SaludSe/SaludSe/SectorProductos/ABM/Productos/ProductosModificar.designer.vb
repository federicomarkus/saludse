﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosModificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosModificar))
        Me.pbSaludSe = New System.Windows.Forms.PictureBox()
        Me.lblProveedores = New System.Windows.Forms.Label()
        Me.gbxInfoOrden = New System.Windows.Forms.GroupBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.cmbUnidad = New System.Windows.Forms.ComboBox()
        Me.txtNombreProd = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.txtPuntoP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbCargado = New System.Windows.Forms.ListBox()
        Me.lbDisponible = New System.Windows.Forms.ListBox()
        Me.txtCalif = New System.Windows.Forms.TextBox()
        Me.lblCalificacion = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfoOrden.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbSaludSe
        '
        Me.pbSaludSe.Image = CType(resources.GetObject("pbSaludSe.Image"), System.Drawing.Image)
        Me.pbSaludSe.Location = New System.Drawing.Point(43, 12)
        Me.pbSaludSe.Name = "pbSaludSe"
        Me.pbSaludSe.Size = New System.Drawing.Size(297, 100)
        Me.pbSaludSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSaludSe.TabIndex = 4
        Me.pbSaludSe.TabStop = False
        '
        'lblProveedores
        '
        Me.lblProveedores.AutoSize = True
        Me.lblProveedores.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedores.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblProveedores.Location = New System.Drawing.Point(385, 46)
        Me.lblProveedores.Name = "lblProveedores"
        Me.lblProveedores.Size = New System.Drawing.Size(255, 35)
        Me.lblProveedores.TabIndex = 13
        Me.lblProveedores.Text = "Modificar producto"
        '
        'gbxInfoOrden
        '
        Me.gbxInfoOrden.Controls.Add(Me.txtCalif)
        Me.gbxInfoOrden.Controls.Add(Me.lblCalificacion)
        Me.gbxInfoOrden.Controls.Add(Me.txtStock)
        Me.gbxInfoOrden.Controls.Add(Me.lblStock)
        Me.gbxInfoOrden.Controls.Add(Me.Label4)
        Me.gbxInfoOrden.Controls.Add(Me.cmbTipo)
        Me.gbxInfoOrden.Controls.Add(Me.cmbUnidad)
        Me.gbxInfoOrden.Controls.Add(Me.txtNombreProd)
        Me.gbxInfoOrden.Controls.Add(Me.txtMarca)
        Me.gbxInfoOrden.Controls.Add(Me.txtCant)
        Me.gbxInfoOrden.Controls.Add(Me.txtPuntoP)
        Me.gbxInfoOrden.Controls.Add(Me.Label6)
        Me.gbxInfoOrden.Controls.Add(Me.Label5)
        Me.gbxInfoOrden.Controls.Add(Me.Label3)
        Me.gbxInfoOrden.Controls.Add(Me.Label2)
        Me.gbxInfoOrden.Controls.Add(Me.Label1)
        Me.gbxInfoOrden.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInfoOrden.ForeColor = System.Drawing.Color.Sienna
        Me.gbxInfoOrden.Location = New System.Drawing.Point(30, 118)
        Me.gbxInfoOrden.Name = "gbxInfoOrden"
        Me.gbxInfoOrden.Size = New System.Drawing.Size(329, 336)
        Me.gbxInfoOrden.TabIndex = 14
        Me.gbxInfoOrden.TabStop = False
        Me.gbxInfoOrden.Text = "Datos del producto"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(175, 121)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(148, 32)
        Me.cmbTipo.TabIndex = 20
        '
        'cmbUnidad
        '
        Me.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Items.AddRange(New Object() {"kg", "mg", "ml", "l", "cc"})
        Me.cmbUnidad.Location = New System.Drawing.Point(175, 162)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(148, 32)
        Me.cmbUnidad.TabIndex = 19
        '
        'txtNombreProd
        '
        Me.txtNombreProd.Location = New System.Drawing.Point(125, 36)
        Me.txtNombreProd.Name = "txtNombreProd"
        Me.txtNombreProd.Size = New System.Drawing.Size(198, 30)
        Me.txtNombreProd.TabIndex = 18
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(125, 79)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(198, 30)
        Me.txtMarca.TabIndex = 17
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(177, 248)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(146, 30)
        Me.txtCant.TabIndex = 12
        '
        'txtPuntoP
        '
        Me.txtPuntoP.Location = New System.Drawing.Point(177, 292)
        Me.txtPuntoP.Name = "txtPuntoP"
        Me.txtPuntoP.Size = New System.Drawing.Size(146, 30)
        Me.txtPuntoP.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Peru
        Me.Label6.Location = New System.Drawing.Point(23, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Punto de pedido :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Peru
        Me.Label5.Location = New System.Drawing.Point(17, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de producto :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Peru
        Me.Label3.Location = New System.Drawing.Point(20, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unidad de medida :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Peru
        Me.Label2.Location = New System.Drawing.Point(23, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Peru
        Me.Label1.Location = New System.Drawing.Point(23, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre :"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(30, 460)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(104, 50)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Peru
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnModificar.Location = New System.Drawing.Point(512, 460)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(208, 50)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbCargado)
        Me.GroupBox1.Controls.Add(Me.lbDisponible)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBox1.Location = New System.Drawing.Point(367, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 336)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del proveedor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Peru
        Me.Label8.Location = New System.Drawing.Point(204, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Cargados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Peru
        Me.Label7.Location = New System.Drawing.Point(31, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 22)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Disponibles"
        '
        'lbCargado
        '
        Me.lbCargado.FormattingEnabled = True
        Me.lbCargado.ItemHeight = 24
        Me.lbCargado.Location = New System.Drawing.Point(185, 63)
        Me.lbCargado.Name = "lbCargado"
        Me.lbCargado.Size = New System.Drawing.Size(162, 268)
        Me.lbCargado.TabIndex = 26
        '
        'lbDisponible
        '
        Me.lbDisponible.FormattingEnabled = True
        Me.lbDisponible.ItemHeight = 24
        Me.lbDisponible.Location = New System.Drawing.Point(6, 63)
        Me.lbDisponible.Name = "lbDisponible"
        Me.lbDisponible.Size = New System.Drawing.Size(161, 268)
        Me.lbDisponible.TabIndex = 25
        '
        'txtCalif
        '
        Me.txtCalif.Location = New System.Drawing.Point(264, 203)
        Me.txtCalif.Name = "txtCalif"
        Me.txtCalif.Size = New System.Drawing.Size(55, 30)
        Me.txtCalif.TabIndex = 25
        '
        'lblCalificacion
        '
        Me.lblCalificacion.AutoSize = True
        Me.lblCalificacion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalificacion.ForeColor = System.Drawing.Color.Peru
        Me.lblCalificacion.Location = New System.Drawing.Point(158, 208)
        Me.lblCalificacion.Name = "lblCalificacion"
        Me.lblCalificacion.Size = New System.Drawing.Size(100, 22)
        Me.lblCalificacion.TabIndex = 24
        Me.lblCalificacion.Text = "Calificacion"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(81, 203)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(54, 30)
        Me.txtStock.TabIndex = 23
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.Peru
        Me.lblStock.Location = New System.Drawing.Point(23, 208)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(52, 22)
        Me.lblStock.TabIndex = 22
        Me.lblStock.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(23, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Unidades x Paquete"
        '
        'ProductosModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(748, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gbxInfoOrden)
        Me.Controls.Add(Me.lblProveedores)
        Me.Controls.Add(Me.pbSaludSe)
        Me.Name = "ProductosModificar"
        Me.Text = "Modificar productos"
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfoOrden.ResumeLayout(False)
        Me.gbxInfoOrden.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbSaludSe As System.Windows.Forms.PictureBox
    Friend WithEvents lblProveedores As System.Windows.Forms.Label
    Friend WithEvents gbxInfoOrden As System.Windows.Forms.GroupBox
    Friend WithEvents txtPuntoP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtNombreProd As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbCargado As ListBox
    Friend WithEvents lbDisponible As ListBox
    Friend WithEvents txtCalif As System.Windows.Forms.TextBox
    Friend WithEvents lblCalificacion As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
