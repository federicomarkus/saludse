<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cursoAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cursoAlta))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGenerarAlta = New System.Windows.Forms.Button()
        Me.cboIdCapacitacion = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblIdCapacitacion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(517, 100)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(428, 76)
        Me.lblTitulo.TabIndex = 53
        Me.lblTitulo.Text = "Alta de cursos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(7, 709)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(155, 49)
        Me.btnVolver.TabIndex = 57
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnGenerarAlta
        '
        Me.btnGenerarAlta.BackColor = System.Drawing.Color.Peru
        Me.btnGenerarAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarAlta.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarAlta.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnGenerarAlta.Location = New System.Drawing.Point(380, 560)
        Me.btnGenerarAlta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenerarAlta.Name = "btnGenerarAlta"
        Me.btnGenerarAlta.Size = New System.Drawing.Size(304, 100)
        Me.btnGenerarAlta.TabIndex = 56
        Me.btnGenerarAlta.Text = "Generar alta"
        Me.btnGenerarAlta.UseVisualStyleBackColor = False
        '
        'cboIdCapacitacion
        '
        Me.cboIdCapacitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdCapacitacion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIdCapacitacion.FormattingEnabled = True
        Me.cboIdCapacitacion.Items.AddRange(New Object() {"Opción 1", "Opción 2", "Opción 3"})
        Me.cboIdCapacitacion.Location = New System.Drawing.Point(481, 270)
        Me.cboIdCapacitacion.Name = "cboIdCapacitacion"
        Me.cboIdCapacitacion.Size = New System.Drawing.Size(212, 34)
        Me.cboIdCapacitacion.TabIndex = 58
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(380, 519)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(457, 22)
        Me.dtpFecha.TabIndex = 59
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescripcion.Location = New System.Drawing.Point(380, 350)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(457, 31)
        Me.txtDescripcion.TabIndex = 60
        '
        'txtDuracion
        '
        Me.txtDuracion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuracion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDuracion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDuracion.Location = New System.Drawing.Point(380, 391)
        Me.txtDuracion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDuracion.MaxLength = 100
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(457, 31)
        Me.txtDuracion.TabIndex = 61
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.SystemColors.Window
        Me.txtHora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHora.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtHora.Location = New System.Drawing.Point(380, 430)
        Me.txtHora.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHora.MaxLength = 100
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(457, 31)
        Me.txtHora.TabIndex = 62
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTipo.Location = New System.Drawing.Point(380, 480)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipo.MaxLength = 100
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(457, 31)
        Me.txtTipo.TabIndex = 63
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNombre.Location = New System.Drawing.Point(380, 311)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(457, 31)
        Me.txtNombre.TabIndex = 64
        '
        'lblIdCapacitacion
        '
        Me.lblIdCapacitacion.AutoSize = True
        Me.lblIdCapacitacion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCapacitacion.ForeColor = System.Drawing.Color.Peru
        Me.lblIdCapacitacion.Location = New System.Drawing.Point(205, 273)
        Me.lblIdCapacitacion.Name = "lblIdCapacitacion"
        Me.lblIdCapacitacion.Size = New System.Drawing.Size(221, 26)
        Me.lblIdCapacitacion.TabIndex = 65
        Me.lblIdCapacitacion.Text = "ID de la  capacitación:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Peru
        Me.lblNombre.Location = New System.Drawing.Point(205, 311)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(93, 26)
        Me.lblNombre.TabIndex = 66
        Me.lblNombre.Text = "Nombre:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Peru
        Me.lblFecha.Location = New System.Drawing.Point(211, 519)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(76, 26)
        Me.lblFecha.TabIndex = 67
        Me.lblFecha.Text = "Fecha:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Peru
        Me.lblTipo.Location = New System.Drawing.Point(211, 480)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(60, 26)
        Me.lblTipo.TabIndex = 68
        Me.lblTipo.Text = "Tipo:"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Peru
        Me.lblHora.Location = New System.Drawing.Point(211, 435)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(64, 26)
        Me.lblHora.TabIndex = 69
        Me.lblHora.Text = "Hora:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.ForeColor = System.Drawing.Color.Peru
        Me.lblDuracion.Location = New System.Drawing.Point(205, 394)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(103, 26)
        Me.lblDuracion.TabIndex = 70
        Me.lblDuracion.Text = "Duración:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Peru
        Me.lblDescripcion.Location = New System.Drawing.Point(205, 350)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(129, 26)
        Me.lblDescripcion.TabIndex = 71
        Me.lblDescripcion.Text = "Descripción:"
        '
        'cursoAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1161, 748)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblIdCapacitacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cboIdCapacitacion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGenerarAlta)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cursoAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de curso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnGenerarAlta As System.Windows.Forms.Button
    Friend WithEvents cboIdCapacitacion As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblIdCapacitacion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
End Class
