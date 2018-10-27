<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblProveedores = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.ListaProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarProv = New System.Windows.Forms.Button()
        Me.btnModificarProv = New System.Windows.Forms.Button()
        Me.btnCargarProv = New System.Windows.Forms.Button()
        Me.VolverABM = New System.Windows.Forms.Button()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProveedores
        '
        Me.lblProveedores.AutoSize = True
        Me.lblProveedores.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedores.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblProveedores.Location = New System.Drawing.Point(405, 49)
        Me.lblProveedores.Name = "lblProveedores"
        Me.lblProveedores.Size = New System.Drawing.Size(251, 61)
        Me.lblProveedores.TabIndex = 12
        Me.lblProveedores.Text = "Productos"
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(12, 12)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(341, 135)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 11
        Me.imgLogo.TabStop = False
        '
        'ListaProductos
        '
        Me.ListaProductos.AllowUserToAddRows = False
        Me.ListaProductos.AllowUserToDeleteRows = False
        Me.ListaProductos.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ListaProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ListaProductos.ColumnHeadersHeight = 28
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaProductos.DefaultCellStyle = DataGridViewCellStyle3
        Me.ListaProductos.EnableHeadersVisualStyles = False
        Me.ListaProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ListaProductos.Location = New System.Drawing.Point(12, 153)
        Me.ListaProductos.Name = "ListaProductos"
        Me.ListaProductos.ReadOnly = True
        Me.ListaProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ListaProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.ListaProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaProductos.Size = New System.Drawing.Size(853, 265)
        Me.ListaProductos.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnEliminarProv)
        Me.GroupBox1.Controls.Add(Me.btnModificarProv)
        Me.GroupBox1.Controls.Add(Me.btnCargarProv)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBox1.Location = New System.Drawing.Point(324, 435)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 88)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnEliminarProv
        '
        Me.btnEliminarProv.BackColor = System.Drawing.Color.Peru
        Me.btnEliminarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProv.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProv.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnEliminarProv.Location = New System.Drawing.Point(302, 29)
        Me.btnEliminarProv.Name = "btnEliminarProv"
        Me.btnEliminarProv.Size = New System.Drawing.Size(128, 48)
        Me.btnEliminarProv.TabIndex = 1
        Me.btnEliminarProv.Text = "ELIMINAR"
        Me.btnEliminarProv.UseVisualStyleBackColor = False
        '
        'btnModificarProv
        '
        Me.btnModificarProv.BackColor = System.Drawing.Color.Peru
        Me.btnModificarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarProv.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProv.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnModificarProv.Location = New System.Drawing.Point(168, 29)
        Me.btnModificarProv.Name = "btnModificarProv"
        Me.btnModificarProv.Size = New System.Drawing.Size(128, 48)
        Me.btnModificarProv.TabIndex = 2
        Me.btnModificarProv.Text = "MODIFICAR"
        Me.btnModificarProv.UseVisualStyleBackColor = False
        '
        'btnCargarProv
        '
        Me.btnCargarProv.BackColor = System.Drawing.Color.Peru
        Me.btnCargarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarProv.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarProv.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCargarProv.Location = New System.Drawing.Point(34, 29)
        Me.btnCargarProv.Name = "btnCargarProv"
        Me.btnCargarProv.Size = New System.Drawing.Size(128, 48)
        Me.btnCargarProv.TabIndex = 0
        Me.btnCargarProv.Text = "CARGAR"
        Me.btnCargarProv.UseVisualStyleBackColor = False
        '
        'VolverABM
        '
        Me.VolverABM.BackColor = System.Drawing.Color.Peru
        Me.VolverABM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VolverABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VolverABM.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverABM.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.VolverABM.Location = New System.Drawing.Point(12, 491)
        Me.VolverABM.Name = "VolverABM"
        Me.VolverABM.Size = New System.Drawing.Size(98, 32)
        Me.VolverABM.TabIndex = 15
        Me.VolverABM.Text = "VOLVER"
        Me.VolverABM.UseVisualStyleBackColor = False
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(877, 556)
        Me.Controls.Add(Me.VolverABM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListaProductos)
        Me.Controls.Add(Me.lblProveedores)
        Me.Controls.Add(Me.imgLogo)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProveedores As System.Windows.Forms.Label
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ListaProductos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarProv As System.Windows.Forms.Button
    Friend WithEvents btnModificarProv As System.Windows.Forms.Button
    Friend WithEvents btnCargarProv As System.Windows.Forms.Button
    Friend WithEvents VolverABM As System.Windows.Forms.Button
End Class
