<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Dim lblTitulo As System.Windows.Forms.Label
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado))
        Me.btnRegistrarEmpleado = New System.Windows.Forms.Button()
        Me.btnGestionarAusencias = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCapa = New System.Windows.Forms.Button()
        lblTitulo = New System.Windows.Forms.Label()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        lblTitulo.AutoSize = True
        lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        lblTitulo.Location = New System.Drawing.Point(362, 61)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(246, 61)
        lblTitulo.TabIndex = 23
        lblTitulo.Text = "Empleado"
        '
        'PictureBox1
        '
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(12, 13)
        PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(341, 166)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        '
        'btnRegistrarEmpleado
        '
        Me.btnRegistrarEmpleado.BackColor = System.Drawing.Color.Peru
        Me.btnRegistrarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEmpleado.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnRegistrarEmpleado.Location = New System.Drawing.Point(87, 272)
        Me.btnRegistrarEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado"
        Me.btnRegistrarEmpleado.Size = New System.Drawing.Size(305, 90)
        Me.btnRegistrarEmpleado.TabIndex = 19
        Me.btnRegistrarEmpleado.Text = "Registrar nuevo empleado"
        Me.btnRegistrarEmpleado.UseVisualStyleBackColor = False
        '
        'btnGestionarAusencias
        '
        Me.btnGestionarAusencias.BackColor = System.Drawing.Color.Peru
        Me.btnGestionarAusencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionarAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionarAusencias.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionarAusencias.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnGestionarAusencias.Location = New System.Drawing.Point(459, 272)
        Me.btnGestionarAusencias.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGestionarAusencias.Name = "btnGestionarAusencias"
        Me.btnGestionarAusencias.Size = New System.Drawing.Size(305, 90)
        Me.btnGestionarAusencias.TabIndex = 20
        Me.btnGestionarAusencias.Text = "Gestionar ausencias, licencias y enfermedades"
        Me.btnGestionarAusencias.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 570)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(103, 38)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnCapa
        '
        Me.btnCapa.BackColor = System.Drawing.Color.Peru
        Me.btnCapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapa.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapa.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCapa.Location = New System.Drawing.Point(263, 413)
        Me.btnCapa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCapa.Name = "btnCapa"
        Me.btnCapa.Size = New System.Drawing.Size(305, 90)
        Me.btnCapa.TabIndex = 24
        Me.btnCapa.Text = "Capacitacion de empleados"
        Me.btnCapa.UseVisualStyleBackColor = False
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(871, 621)
        Me.Controls.Add(Me.btnCapa)
        Me.Controls.Add(lblTitulo)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGestionarAusencias)
        Me.Controls.Add(Me.btnRegistrarEmpleado)
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegistrarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnGestionarAusencias As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnCapa As System.Windows.Forms.Button
End Class
