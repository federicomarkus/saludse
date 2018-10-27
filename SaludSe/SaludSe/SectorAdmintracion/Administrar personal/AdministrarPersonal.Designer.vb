<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrarPersonal))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGenerarSolicitud = New System.Windows.Forms.Button()
        Me.cboIdPersonal = New System.Windows.Forms.ComboBox()
        Me.lblIdPersonal = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(376, 93)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(621, 76)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Administrar personal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(79, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
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
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnGenerarSolicitud
        '
        Me.btnGenerarSolicitud.BackColor = System.Drawing.Color.Peru
        Me.btnGenerarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarSolicitud.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarSolicitud.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnGenerarSolicitud.Location = New System.Drawing.Point(335, 404)
        Me.btnGenerarSolicitud.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerarSolicitud.Name = "btnGenerarSolicitud"
        Me.btnGenerarSolicitud.Size = New System.Drawing.Size(228, 81)
        Me.btnGenerarSolicitud.TabIndex = 26
        Me.btnGenerarSolicitud.Text = "Generar solicitud de asignación de sector "
        Me.btnGenerarSolicitud.UseVisualStyleBackColor = False
        '
        'cboIdPersonal
        '
        Me.cboIdPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdPersonal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIdPersonal.FormattingEnabled = True
        Me.cboIdPersonal.Items.AddRange(New Object() {"Opción 1", "Opción 2", "Opción 3"})
        Me.cboIdPersonal.Location = New System.Drawing.Point(406, 226)
        Me.cboIdPersonal.Name = "cboIdPersonal"
        Me.cboIdPersonal.Size = New System.Drawing.Size(212, 34)
        Me.cboIdPersonal.TabIndex = 25
        '
        'lblIdPersonal
        '
        Me.lblIdPersonal.AutoSize = True
        Me.lblIdPersonal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdPersonal.ForeColor = System.Drawing.Color.Peru
        Me.lblIdPersonal.Location = New System.Drawing.Point(280, 234)
        Me.lblIdPersonal.Name = "lblIdPersonal"
        Me.lblIdPersonal.Size = New System.Drawing.Size(162, 26)
        Me.lblIdPersonal.TabIndex = 24
        Me.lblIdPersonal.Text = "ID del personal:"
        '
        'AdministrarPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 621)
        Me.Controls.Add(Me.btnGenerarSolicitud)
        Me.Controls.Add(Me.cboIdPersonal)
        Me.Controls.Add(Me.lblIdPersonal)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AdministrarPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaludSe - Administrar personal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnGenerarSolicitud As Button
    Friend WithEvents cboIdPersonal As ComboBox
    Friend WithEvents lblIdPersonal As Label
End Class
