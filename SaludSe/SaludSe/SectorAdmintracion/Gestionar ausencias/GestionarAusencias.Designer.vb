<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarAusencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionarAusencias))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboIdEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblIdEmpleado = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistrarAusencia = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDurecion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(385, 71)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(474, 61)
        Me.lblTitulo.TabIndex = 14
        Me.lblTitulo.Text = "Gestionar ausencias"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cboIdEmpleado
        '
        Me.cboIdEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIdEmpleado.FormattingEnabled = True
        Me.cboIdEmpleado.Items.AddRange(New Object() {"Opción 1", "Opción 2", "Opción 3"})
        Me.cboIdEmpleado.Location = New System.Drawing.Point(463, 217)
        Me.cboIdEmpleado.Name = "cboIdEmpleado"
        Me.cboIdEmpleado.Size = New System.Drawing.Size(212, 30)
        Me.cboIdEmpleado.TabIndex = 16
        '
        'lblIdEmpleado
        '
        Me.lblIdEmpleado.AutoSize = True
        Me.lblIdEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdEmpleado.ForeColor = System.Drawing.Color.Peru
        Me.lblIdEmpleado.Location = New System.Drawing.Point(264, 225)
        Me.lblIdEmpleado.Name = "lblIdEmpleado"
        Me.lblIdEmpleado.Size = New System.Drawing.Size(192, 22)
        Me.lblIdEmpleado.TabIndex = 15
        Me.lblIdEmpleado.Text = "ID del empleado ausente"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 562)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(161, 46)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnRegistrarAusencia
        '
        Me.btnRegistrarAusencia.BackColor = System.Drawing.Color.Peru
        Me.btnRegistrarAusencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarAusencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarAusencia.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarAusencia.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnRegistrarAusencia.Location = New System.Drawing.Point(298, 422)
        Me.btnRegistrarAusencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrarAusencia.Name = "btnRegistrarAusencia"
        Me.btnRegistrarAusencia.Size = New System.Drawing.Size(305, 90)
        Me.btnRegistrarAusencia.TabIndex = 18
        Me.btnRegistrarAusencia.Text = "Registrar ausencia"
        Me.btnRegistrarAusencia.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Peru
        Me.Label2.Location = New System.Drawing.Point(75, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Duración de la ausencia (en dias):"
        '
        'txtDurecion
        '
        Me.txtDurecion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDurecion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDurecion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDurecion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDurecion.Location = New System.Drawing.Point(341, 362)
        Me.txtDurecion.MaxLength = 100
        Me.txtDurecion.Name = "txtDurecion"
        Me.txtDurecion.Size = New System.Drawing.Size(344, 26)
        Me.txtDurecion.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Peru
        Me.Label1.Location = New System.Drawing.Point(226, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescripcion.Location = New System.Drawing.Point(341, 283)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(344, 26)
        Me.txtDescripcion.TabIndex = 22
        '
        'GestionarAusencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 621)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDurecion)
        Me.Controls.Add(Me.btnRegistrarAusencia)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.cboIdEmpleado)
        Me.Controls.Add(Me.lblIdEmpleado)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GestionarAusencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar ausencias"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboIdEmpleado As ComboBox
    Friend WithEvents lblIdEmpleado As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnRegistrarAusencia As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDurecion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
End Class
