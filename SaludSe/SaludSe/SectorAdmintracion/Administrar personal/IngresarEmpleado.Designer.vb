<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresarEmpleado))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboIdSector = New System.Windows.Forms.ComboBox()
        Me.lblIdSector = New System.Windows.Forms.Label()
        Me.btnGenerarEmpleado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(491, 74)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(551, 76)
        Me.lblTitulo.TabIndex = 14
        Me.lblTitulo.Text = "Ingresar empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cboIdSector
        '
        Me.cboIdSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdSector.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIdSector.FormattingEnabled = True
        Me.cboIdSector.Items.AddRange(New Object() {"Opción 1", "Opción 2", "Opción 3"})
        Me.cboIdSector.Location = New System.Drawing.Point(505, 298)
        Me.cboIdSector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboIdSector.Name = "cboIdSector"
        Me.cboIdSector.Size = New System.Drawing.Size(281, 34)
        Me.cboIdSector.TabIndex = 27
        '
        'lblIdSector
        '
        Me.lblIdSector.AutoSize = True
        Me.lblIdSector.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdSector.ForeColor = System.Drawing.Color.Peru
        Me.lblIdSector.Location = New System.Drawing.Point(336, 308)
        Me.lblIdSector.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdSector.Name = "lblIdSector"
        Me.lblIdSector.Size = New System.Drawing.Size(139, 26)
        Me.lblIdSector.TabIndex = 26
        Me.lblIdSector.Text = "ID del sector:"
        '
        'btnGenerarEmpleado
        '
        Me.btnGenerarEmpleado.BackColor = System.Drawing.Color.Peru
        Me.btnGenerarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarEmpleado.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnGenerarEmpleado.Location = New System.Drawing.Point(482, 355)
        Me.btnGenerarEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenerarEmpleado.Name = "btnGenerarEmpleado"
        Me.btnGenerarEmpleado.Size = New System.Drawing.Size(304, 100)
        Me.btnGenerarEmpleado.TabIndex = 28
        Me.btnGenerarEmpleado.Text = "Registrar nuevo empleado"
        Me.btnGenerarEmpleado.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Peru
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancelar.Location = New System.Drawing.Point(54, 495)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(144, 43)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'IngresarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1161, 568)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGenerarEmpleado)
        Me.Controls.Add(Me.cboIdSector)
        Me.Controls.Add(Me.lblIdSector)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "IngresarEmpleado"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresarEmpleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboIdSector As ComboBox
    Friend WithEvents lblIdSector As Label
    Friend WithEvents btnGenerarEmpleado As Button
    Friend WithEvents btnCancelar As Button
End Class
