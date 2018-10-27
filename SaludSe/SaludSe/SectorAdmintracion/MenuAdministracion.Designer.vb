<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdministrador))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVerificacionesYControles = New System.Windows.Forms.Button()
        Me.btnPersonalYEmpleados = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(147, 156)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(571, 61)
        Me.lblTitulo.TabIndex = 20
        Me.lblTitulo.Text = "Administracion contable"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(261, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btnVerificacionesYControles
        '
        Me.btnVerificacionesYControles.BackColor = System.Drawing.Color.Peru
        Me.btnVerificacionesYControles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerificacionesYControles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerificacionesYControles.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificacionesYControles.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVerificacionesYControles.Location = New System.Drawing.Point(55, 317)
        Me.btnVerificacionesYControles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerificacionesYControles.Name = "btnVerificacionesYControles"
        Me.btnVerificacionesYControles.Size = New System.Drawing.Size(228, 81)
        Me.btnVerificacionesYControles.TabIndex = 39
        Me.btnVerificacionesYControles.Text = "Verificaciones y  controles"
        Me.btnVerificacionesYControles.UseVisualStyleBackColor = False
        '
        'btnPersonalYEmpleados
        '
        Me.btnPersonalYEmpleados.BackColor = System.Drawing.Color.Peru
        Me.btnPersonalYEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonalYEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonalYEmpleados.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonalYEmpleados.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnPersonalYEmpleados.Location = New System.Drawing.Point(315, 317)
        Me.btnPersonalYEmpleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPersonalYEmpleados.Name = "btnPersonalYEmpleados"
        Me.btnPersonalYEmpleados.Size = New System.Drawing.Size(228, 81)
        Me.btnPersonalYEmpleados.TabIndex = 40
        Me.btnPersonalYEmpleados.Text = "Personal y empleados"
        Me.btnPersonalYEmpleados.UseVisualStyleBackColor = False
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.Peru
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnStock.Location = New System.Drawing.Point(576, 317)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(228, 81)
        Me.btnStock.TabIndex = 41
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Peru
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancelar.Location = New System.Drawing.Point(12, 570)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 38)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Peru
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Button1.Location = New System.Drawing.Point(315, 431)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 81)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "ABMs"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 608)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnPersonalYEmpleados)
        Me.Controls.Add(Me.btnVerificacionesYControles)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdministracionContablevb"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVerificacionesYControles As System.Windows.Forms.Button
    Friend WithEvents btnPersonalYEmpleados As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
