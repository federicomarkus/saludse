<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cursoBaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cursoBaja))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGenerarBaja = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblIdCurso = New System.Windows.Forms.Label()
        Me.cboIdCurso = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(432, 84)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(438, 76)
        Me.lblTitulo.TabIndex = 53
        Me.lblTitulo.Text = "Baja de cursos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'btnGenerarBaja
        '
        Me.btnGenerarBaja.BackColor = System.Drawing.Color.Peru
        Me.btnGenerarBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarBaja.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarBaja.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnGenerarBaja.Location = New System.Drawing.Point(389, 550)
        Me.btnGenerarBaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenerarBaja.Name = "btnGenerarBaja"
        Me.btnGenerarBaja.Size = New System.Drawing.Size(304, 100)
        Me.btnGenerarBaja.TabIndex = 54
        Me.btnGenerarBaja.Text = "Generar baja"
        Me.btnGenerarBaja.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(16, 699)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(155, 49)
        Me.btnVolver.TabIndex = 55
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblIdCurso
        '
        Me.lblIdCurso.AutoSize = True
        Me.lblIdCurso.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCurso.ForeColor = System.Drawing.Color.Peru
        Me.lblIdCurso.Location = New System.Drawing.Point(315, 286)
        Me.lblIdCurso.Name = "lblIdCurso"
        Me.lblIdCurso.Size = New System.Drawing.Size(221, 26)
        Me.lblIdCurso.TabIndex = 67
        Me.lblIdCurso.Text = "ID de la  capacitación:"
        '
        'cboIdCurso
        '
        Me.cboIdCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdCurso.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIdCurso.FormattingEnabled = True
        Me.cboIdCurso.Items.AddRange(New Object() {"Opción 1", "Opción 2", "Opción 3"})
        Me.cboIdCurso.Location = New System.Drawing.Point(591, 283)
        Me.cboIdCurso.Name = "cboIdCurso"
        Me.cboIdCurso.Size = New System.Drawing.Size(212, 34)
        Me.cboIdCurso.TabIndex = 66
        '
        'cursoBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1161, 748)
        Me.Controls.Add(Me.lblIdCurso)
        Me.Controls.Add(Me.cboIdCurso)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGenerarBaja)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cursoBaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de cursos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGenerarBaja As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblIdCurso As System.Windows.Forms.Label
    Friend WithEvents cboIdCurso As System.Windows.Forms.ComboBox
End Class
