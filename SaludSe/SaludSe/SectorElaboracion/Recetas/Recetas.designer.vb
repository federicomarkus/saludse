﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recetas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxRecetas = New System.Windows.Forms.GroupBox()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRecetas.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(425, 43)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(203, 61)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Recetas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'gbxRecetas
        '
        Me.gbxRecetas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbxRecetas.BackColor = System.Drawing.Color.Transparent
        Me.gbxRecetas.Controls.Add(Me.dgvGrilla)
        Me.gbxRecetas.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRecetas.ForeColor = System.Drawing.Color.Sienna
        Me.gbxRecetas.Location = New System.Drawing.Point(12, 122)
        Me.gbxRecetas.Name = "gbxRecetas"
        Me.gbxRecetas.Size = New System.Drawing.Size(770, 356)
        Me.gbxRecetas.TabIndex = 5
        Me.gbxRecetas.TabStop = False
        Me.gbxRecetas.Text = "Recetas"
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGrilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvGrilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrilla.ColumnHeadersHeight = 28
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrilla.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrilla.EnableHeadersVisualStyles = False
        Me.dgvGrilla.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvGrilla.Location = New System.Drawing.Point(19, 29)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGrilla.Size = New System.Drawing.Size(728, 308)
        Me.dgvGrilla.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBox2.Location = New System.Drawing.Point(345, 502)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 84)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Peru
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnEliminar.Location = New System.Drawing.Point(299, 29)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 39)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Peru
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnEditar.Location = New System.Drawing.Point(156, 30)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(127, 39)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Peru
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnAgregar.Location = New System.Drawing.Point(14, 30)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(127, 39)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 561)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 39)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Recetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(804, 612)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxRecetas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Recetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recetas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRecetas.ResumeLayout(False)
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbxRecetas As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView

End Class
