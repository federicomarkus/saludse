<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarContratoEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarContratoEmpleado))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblFechaVigencia = New System.Windows.Forms.Label()
        Me.dtpVigencia = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerarContrato = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(99, 146)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(897, 76)
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "Generar contrato de empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(372, -12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.Peru
        Me.lblMonto.Location = New System.Drawing.Point(315, 318)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(76, 26)
        Me.lblMonto.TabIndex = 35
        Me.lblMonto.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonto.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMonto.Location = New System.Drawing.Point(417, 314)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMonto.MaxLength = 100
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(457, 31)
        Me.txtMonto.TabIndex = 34
        '
        'lblFechaVigencia
        '
        Me.lblFechaVigencia.AutoSize = True
        Me.lblFechaVigencia.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVigencia.ForeColor = System.Drawing.Color.Peru
        Me.lblFechaVigencia.Location = New System.Drawing.Point(207, 471)
        Me.lblFechaVigencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaVigencia.Name = "lblFechaVigencia"
        Me.lblFechaVigencia.Size = New System.Drawing.Size(190, 26)
        Me.lblFechaVigencia.TabIndex = 36
        Me.lblFechaVigencia.Text = "Fecha de vigencia:"
        '
        'dtpVigencia
        '
        Me.dtpVigencia.Location = New System.Drawing.Point(417, 474)
        Me.dtpVigencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpVigencia.Name = "dtpVigencia"
        Me.dtpVigencia.Size = New System.Drawing.Size(457, 22)
        Me.dtpVigencia.TabIndex = 37
        '
        'btnGenerarContrato
        '
        Me.btnGenerarContrato.BackColor = System.Drawing.Color.Peru
        Me.btnGenerarContrato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarContrato.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarContrato.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnGenerarContrato.Location = New System.Drawing.Point(449, 549)
        Me.btnGenerarContrato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenerarContrato.Name = "btnGenerarContrato"
        Me.btnGenerarContrato.Size = New System.Drawing.Size(304, 100)
        Me.btnGenerarContrato.TabIndex = 38
        Me.btnGenerarContrato.Text = "Generar contrato"
        Me.btnGenerarContrato.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Peru
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancelar.Location = New System.Drawing.Point(13, 673)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(164, 46)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'GenerarContratoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1161, 748)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGenerarContrato)
        Me.Controls.Add(Me.dtpVigencia)
        Me.Controls.Add(Me.lblFechaVigencia)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "GenerarContratoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenerarContratoEmpleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMonto As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblFechaVigencia As Label
    Friend WithEvents dtpVigencia As DateTimePicker
    Friend WithEvents btnGenerarContrato As Button
    Friend WithEvents btnCancelar As Button
End Class
