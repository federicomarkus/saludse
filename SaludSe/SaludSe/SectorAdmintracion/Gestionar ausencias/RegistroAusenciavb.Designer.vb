<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAusenciavb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroAusenciavb))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblIdAusencia = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblTextoIdAusencia = New System.Windows.Forms.Label()
        Me.lblTextoEmpleado = New System.Windows.Forms.Label()
        Me.lblTextoFecha = New System.Windows.Forms.Label()
        Me.lblTextoDescripcion = New System.Windows.Forms.Label()
        Me.lblTextoDuracion = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(367, 61)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(490, 61)
        Me.lblTitulo.TabIndex = 16
        Me.lblTitulo.Text = "Registro de ausencia"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lblIdAusencia
        '
        Me.lblIdAusencia.AutoSize = True
        Me.lblIdAusencia.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdAusencia.ForeColor = System.Drawing.Color.Peru
        Me.lblIdAusencia.Location = New System.Drawing.Point(97, 228)
        Me.lblIdAusencia.Name = "lblIdAusencia"
        Me.lblIdAusencia.Size = New System.Drawing.Size(288, 27)
        Me.lblIdAusencia.TabIndex = 17
        Me.lblIdAusencia.Text = "Identificador de la ausencia:"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.ForeColor = System.Drawing.Color.Peru
        Me.lblEmpleado.Location = New System.Drawing.Point(97, 308)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(115, 27)
        Me.lblEmpleado.TabIndex = 18
        Me.lblEmpleado.Text = "Empleado:"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.Peru
        Me.lblfecha.Location = New System.Drawing.Point(97, 394)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(78, 27)
        Me.lblfecha.TabIndex = 19
        Me.lblfecha.Text = "Fecha:"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.ForeColor = System.Drawing.Color.Peru
        Me.lbldescripcion.Location = New System.Drawing.Point(97, 474)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(134, 27)
        Me.lbldescripcion.TabIndex = 20
        Me.lbldescripcion.Text = "Descripción:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.ForeColor = System.Drawing.Color.Peru
        Me.lblDuracion.Location = New System.Drawing.Point(97, 558)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(107, 27)
        Me.lblDuracion.TabIndex = 21
        Me.lblDuracion.Text = "Duración:"
        '
        'lblTextoIdAusencia
        '
        Me.lblTextoIdAusencia.AutoSize = True
        Me.lblTextoIdAusencia.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoIdAusencia.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoIdAusencia.Location = New System.Drawing.Point(391, 228)
        Me.lblTextoIdAusencia.Name = "lblTextoIdAusencia"
        Me.lblTextoIdAusencia.Size = New System.Drawing.Size(0, 27)
        Me.lblTextoIdAusencia.TabIndex = 22
        '
        'lblTextoEmpleado
        '
        Me.lblTextoEmpleado.AutoSize = True
        Me.lblTextoEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoEmpleado.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoEmpleado.Location = New System.Drawing.Point(218, 308)
        Me.lblTextoEmpleado.Name = "lblTextoEmpleado"
        Me.lblTextoEmpleado.Size = New System.Drawing.Size(0, 27)
        Me.lblTextoEmpleado.TabIndex = 23
        '
        'lblTextoFecha
        '
        Me.lblTextoFecha.AutoSize = True
        Me.lblTextoFecha.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoFecha.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoFecha.Location = New System.Drawing.Point(181, 394)
        Me.lblTextoFecha.Name = "lblTextoFecha"
        Me.lblTextoFecha.Size = New System.Drawing.Size(0, 27)
        Me.lblTextoFecha.TabIndex = 24
        '
        'lblTextoDescripcion
        '
        Me.lblTextoDescripcion.AutoSize = True
        Me.lblTextoDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoDescripcion.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoDescripcion.Location = New System.Drawing.Point(237, 474)
        Me.lblTextoDescripcion.Name = "lblTextoDescripcion"
        Me.lblTextoDescripcion.Size = New System.Drawing.Size(0, 27)
        Me.lblTextoDescripcion.TabIndex = 25
        '
        'lblTextoDuracion
        '
        Me.lblTextoDuracion.AutoSize = True
        Me.lblTextoDuracion.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoDuracion.ForeColor = System.Drawing.Color.Peru
        Me.lblTextoDuracion.Location = New System.Drawing.Point(210, 558)
        Me.lblTextoDuracion.Name = "lblTextoDuracion"
        Me.lblTextoDuracion.Size = New System.Drawing.Size(0, 27)
        Me.lblTextoDuracion.TabIndex = 26
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Peru
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnImprimir.Location = New System.Drawing.Point(727, 555)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 53)
        Me.btnImprimir.TabIndex = 48
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(725, 474)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(132, 53)
        Me.btnVolver.TabIndex = 49
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'RegistroAusenciavb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 621)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTextoDuracion)
        Me.Controls.Add(Me.lblTextoDescripcion)
        Me.Controls.Add(Me.lblTextoFecha)
        Me.Controls.Add(Me.lblTextoEmpleado)
        Me.Controls.Add(Me.lblTextoIdAusencia)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.lblIdAusencia)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RegistroAusenciavb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroAusenciavb"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblIdAusencia As Label
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblTextoIdAusencia As Label
    Friend WithEvents lblTextoEmpleado As Label
    Friend WithEvents lblTextoFecha As Label
    Friend WithEvents lblTextoDescripcion As Label
    Friend WithEvents lblTextoDuracion As Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
