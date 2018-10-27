<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarMenu))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbxElementos = New System.Windows.Forms.GroupBox()
        Me.lblAgregar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRemover = New System.Windows.Forms.Label()
        Me.lstElementos = New System.Windows.Forms.ListBox()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.cboTipoElemento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregarElemento = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cboElementos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCaducidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEmpaquetamiento = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxDatos.SuspendLayout()
        Me.gbxElementos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(10, 619)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 39)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'gbxDatos
        '
        Me.gbxDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.Controls.Add(Me.lblActual)
        Me.gbxDatos.Controls.Add(Me.btnEditar)
        Me.gbxDatos.Controls.Add(Me.btnAgregar)
        Me.gbxDatos.Controls.Add(Me.gbxElementos)
        Me.gbxDatos.Controls.Add(Me.txtCaducidad)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.cboEmpaquetamiento)
        Me.gbxDatos.Controls.Add(Me.lblDescripcion)
        Me.gbxDatos.Controls.Add(Me.lblNombre)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.ForeColor = System.Drawing.Color.Sienna
        Me.gbxDatos.Location = New System.Drawing.Point(23, 136)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(943, 477)
        Me.gbxDatos.TabIndex = 13
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos Generales"
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.ForeColor = System.Drawing.Color.Peru
        Me.lblActual.Location = New System.Drawing.Point(410, 16)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(0, 22)
        Me.lblActual.TabIndex = 17
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Peru
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnEditar.Location = New System.Drawing.Point(366, 95)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(191, 44)
        Me.btnEditar.TabIndex = 16
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
        Me.btnAgregar.Location = New System.Drawing.Point(366, 95)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(191, 44)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'gbxElementos
        '
        Me.gbxElementos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbxElementos.BackColor = System.Drawing.Color.Transparent
        Me.gbxElementos.Controls.Add(Me.lblAgregar)
        Me.gbxElementos.Controls.Add(Me.GroupBox1)
        Me.gbxElementos.Controls.Add(Me.cboTipoElemento)
        Me.gbxElementos.Controls.Add(Me.Label4)
        Me.gbxElementos.Controls.Add(Me.btnAgregarElemento)
        Me.gbxElementos.Controls.Add(Me.Label2)
        Me.gbxElementos.Controls.Add(Me.txtCantidad)
        Me.gbxElementos.Controls.Add(Me.cboElementos)
        Me.gbxElementos.Controls.Add(Me.Label3)
        Me.gbxElementos.Enabled = False
        Me.gbxElementos.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbxElementos.ForeColor = System.Drawing.Color.Sienna
        Me.gbxElementos.Location = New System.Drawing.Point(22, 154)
        Me.gbxElementos.Name = "gbxElementos"
        Me.gbxElementos.Size = New System.Drawing.Size(892, 306)
        Me.gbxElementos.TabIndex = 11
        Me.gbxElementos.TabStop = False
        Me.gbxElementos.Text = "Elementos del Menu"
        '
        'lblAgregar
        '
        Me.lblAgregar.AutoSize = True
        Me.lblAgregar.Location = New System.Drawing.Point(120, 271)
        Me.lblAgregar.Name = "lblAgregar"
        Me.lblAgregar.Size = New System.Drawing.Size(178, 22)
        Me.lblAgregar.TabIndex = 17
        Me.lblAgregar.Text = "Se agrego el elemento"
        Me.lblAgregar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblRemover)
        Me.GroupBox1.Controls.Add(Me.lstElementos)
        Me.GroupBox1.Controls.Add(Me.btnRemover)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Sienna
        Me.GroupBox1.Location = New System.Drawing.Point(462, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 268)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementos Agregados"
        '
        'lblRemover
        '
        Me.lblRemover.AutoSize = True
        Me.lblRemover.Location = New System.Drawing.Point(117, 241)
        Me.lblRemover.Name = "lblRemover"
        Me.lblRemover.Size = New System.Drawing.Size(188, 22)
        Me.lblRemover.TabIndex = 13
        Me.lblRemover.Text = "Se removio el elemento"
        Me.lblRemover.Visible = False
        '
        'lstElementos
        '
        Me.lstElementos.FormattingEnabled = True
        Me.lstElementos.ItemHeight = 22
        Me.lstElementos.Location = New System.Drawing.Point(52, 42)
        Me.lstElementos.Name = "lstElementos"
        Me.lstElementos.Size = New System.Drawing.Size(304, 136)
        Me.lstElementos.TabIndex = 10
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.Color.Peru
        Me.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnRemover.Location = New System.Drawing.Point(102, 202)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(213, 36)
        Me.btnRemover.TabIndex = 12
        Me.btnRemover.Text = "Remover Elemento"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'cboTipoElemento
        '
        Me.cboTipoElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoElemento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoElemento.FormattingEnabled = True
        Me.cboTipoElemento.Items.AddRange(New Object() {"Receta", "Producto"})
        Me.cboTipoElemento.Location = New System.Drawing.Point(166, 67)
        Me.cboTipoElemento.Name = "cboTipoElemento"
        Me.cboTipoElemento.Size = New System.Drawing.Size(212, 30)
        Me.cboTipoElemento.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(107, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tipo"
        '
        'btnAgregarElemento
        '
        Me.btnAgregarElemento.BackColor = System.Drawing.Color.Peru
        Me.btnAgregarElemento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarElemento.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarElemento.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnAgregarElemento.Location = New System.Drawing.Point(98, 227)
        Me.btnAgregarElemento.Name = "btnAgregarElemento"
        Me.btnAgregarElemento.Size = New System.Drawing.Size(223, 36)
        Me.btnAgregarElemento.TabIndex = 11
        Me.btnAgregarElemento.Text = "Agregar Elemento"
        Me.btnAgregarElemento.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Peru
        Me.Label2.Location = New System.Drawing.Point(69, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantidad.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantidad.Location = New System.Drawing.Point(171, 177)
        Me.txtCantidad.MaxLength = 100
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(111, 26)
        Me.txtCantidad.TabIndex = 8
        '
        'cboElementos
        '
        Me.cboElementos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboElementos.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboElementos.FormattingEnabled = True
        Me.cboElementos.Location = New System.Drawing.Point(166, 124)
        Me.cboElementos.Name = "cboElementos"
        Me.cboElementos.Size = New System.Drawing.Size(212, 30)
        Me.cboElementos.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Peru
        Me.Label3.Location = New System.Drawing.Point(5, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Agregar Elemento"
        '
        'txtCaducidad
        '
        Me.txtCaducidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCaducidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCaducidad.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaducidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCaducidad.Location = New System.Drawing.Point(760, 45)
        Me.txtCaducidad.MaxLength = 100
        Me.txtCaducidad.Name = "txtCaducidad"
        Me.txtCaducidad.Size = New System.Drawing.Size(154, 26)
        Me.txtCaducidad.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Peru
        Me.Label1.Location = New System.Drawing.Point(660, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Caducidad:"
        '
        'cboEmpaquetamiento
        '
        Me.cboEmpaquetamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpaquetamiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpaquetamiento.FormattingEnabled = True
        Me.cboEmpaquetamiento.Location = New System.Drawing.Point(444, 41)
        Me.cboEmpaquetamiento.Name = "cboEmpaquetamiento"
        Me.cboEmpaquetamiento.Size = New System.Drawing.Size(187, 30)
        Me.cboEmpaquetamiento.TabIndex = 8
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Peru
        Me.lblDescripcion.Location = New System.Drawing.Point(286, 48)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(152, 22)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "Empaquetamiento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Peru
        Me.lblNombre.Location = New System.Drawing.Point(18, 49)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(76, 22)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNombre.Location = New System.Drawing.Point(108, 46)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 26)
        Me.txtNombre.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(437, 34)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(168, 61)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Menus"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'AgregarMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(993, 670)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AgregarMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarMenu"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.gbxElementos.ResumeLayout(False)
        Me.gbxElementos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboEmpaquetamiento As System.Windows.Forms.ComboBox
    Friend WithEvents txtCaducidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxElementos As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoElemento As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarElemento As System.Windows.Forms.Button
    Friend WithEvents lstElementos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cboElementos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents lblAgregar As System.Windows.Forms.Label
    Friend WithEvents lblRemover As System.Windows.Forms.Label
    Friend WithEvents lblActual As System.Windows.Forms.Label
End Class
