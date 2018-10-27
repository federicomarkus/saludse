<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratoEmpleado
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContratoEmpleado))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblIdContrato = New System.Windows.Forms.Label()
        Me.lblVigencia = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblTextoIdContrato = New System.Windows.Forms.Label()
        Me.lblTextoEmpleado = New System.Windows.Forms.Label()
        Me.lblTextoFecha = New System.Windows.Forms.Label()
        Me.lblTextoMonto = New System.Windows.Forms.Label()
        Me.lblTextoVigencia = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(332, 121)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(527, 61)
        Me.lblTitulo.TabIndex = 20
        Me.lblTitulo.Text = "Contrato de empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 73)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lblIdContrato
        '
        Me.lblIdContrato.AutoSize = True
        Me.lblIdContrato.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdContrato.ForeColor = System.Drawing.Color.Peru
        Me.lblIdContrato.Location = New System.Drawing.Point(253, 284)
        Me.lblIdContrato.Name = "lblIdContrato"
        Me.lblIdContrato.Size = New System.Drawing.Size(151, 24)
        Me.lblIdContrato.TabIndex = 36
        Me.lblIdContrato.Text = "ID del contrato:"
        '
        'lblVigencia
        '
        Me.lblVigencia.AutoSize = True
        Me.lblVigencia.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigencia.ForeColor = System.Drawing.Color.Peru
        Me.lblVigencia.Location = New System.Drawing.Point(253, 489)
        Me.lblVigencia.Name = "lblVigencia"
        Me.lblVigencia.Size = New System.Drawing.Size(179, 24)
        Me.lblVigencia.TabIndex = 38
        Me.lblVigencia.Text = "Fecha de vigencia:"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.Peru
        Me.lblMonto.Location = New System.Drawing.Point(253, 433)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(72, 24)
        Me.lblMonto.TabIndex = 39
        Me.lblMonto.Text = "Monto:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Peru
        Me.lblFecha.Location = New System.Drawing.Point(253, 381)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(181, 24)
        Me.lblFecha.TabIndex = 40
        Me.lblFecha.Text = "Fecha de creación:"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.ForeColor = System.Drawing.Color.Peru
        Me.lblEmpleado.Location = New System.Drawing.Point(253, 333)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(104, 24)
        Me.lblEmpleado.TabIndex = 41
        Me.lblEmpleado.Text = "Empleado:"
        '
        'lblTextoIdContrato
        '
        Me.lblTextoIdContrato.AutoSize = True
        Me.lblTextoIdContrato.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoIdContrato.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoIdContrato.Location = New System.Drawing.Point(410, 284)
        Me.lblTextoIdContrato.Name = "lblTextoIdContrato"
        Me.lblTextoIdContrato.Size = New System.Drawing.Size(0, 24)
        Me.lblTextoIdContrato.TabIndex = 42
        '
        'lblTextoEmpleado
        '
        Me.lblTextoEmpleado.AutoSize = True
        Me.lblTextoEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoEmpleado.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoEmpleado.Location = New System.Drawing.Point(363, 333)
        Me.lblTextoEmpleado.Name = "lblTextoEmpleado"
        Me.lblTextoEmpleado.Size = New System.Drawing.Size(0, 24)
        Me.lblTextoEmpleado.TabIndex = 43
        '
        'lblTextoFecha
        '
        Me.lblTextoFecha.AutoSize = True
        Me.lblTextoFecha.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoFecha.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoFecha.Location = New System.Drawing.Point(440, 381)
        Me.lblTextoFecha.Name = "lblTextoFecha"
        Me.lblTextoFecha.Size = New System.Drawing.Size(0, 24)
        Me.lblTextoFecha.TabIndex = 44
        '
        'lblTextoMonto
        '
        Me.lblTextoMonto.AutoSize = True
        Me.lblTextoMonto.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoMonto.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoMonto.Location = New System.Drawing.Point(331, 433)
        Me.lblTextoMonto.Name = "lblTextoMonto"
        Me.lblTextoMonto.Size = New System.Drawing.Size(0, 24)
        Me.lblTextoMonto.TabIndex = 45
        '
        'lblTextoVigencia
        '
        Me.lblTextoVigencia.AutoSize = True
        Me.lblTextoVigencia.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoVigencia.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoVigencia.Location = New System.Drawing.Point(438, 489)
        Me.lblTextoVigencia.Name = "lblTextoVigencia"
        Me.lblTextoVigencia.Size = New System.Drawing.Size(0, 24)
        Me.lblTextoVigencia.TabIndex = 46
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Peru
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnImprimir.Location = New System.Drawing.Point(427, 555)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 53)
        Me.btnImprimir.TabIndex = 47
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(280, 555)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(132, 53)
        Me.btnVolver.TabIndex = 48
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'ContratoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 621)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTextoVigencia)
        Me.Controls.Add(Me.lblTextoMonto)
        Me.Controls.Add(Me.lblTextoFecha)
        Me.Controls.Add(Me.lblTextoEmpleado)
        Me.Controls.Add(Me.lblTextoIdContrato)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblVigencia)
        Me.Controls.Add(Me.lblIdContrato)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ContratoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContratoEmpleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblIdContrato As Label
    Friend WithEvents lblVigencia As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents lblTextoIdContrato As Label
    Friend WithEvents lblTextoEmpleado As Label
    Friend WithEvents lblTextoFecha As Label
    Friend WithEvents lblTextoMonto As Label
    Friend WithEvents lblTextoVigencia As Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
