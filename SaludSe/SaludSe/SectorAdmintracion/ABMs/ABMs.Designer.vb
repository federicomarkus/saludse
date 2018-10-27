<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMs))
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSec = New System.Windows.Forms.Button()
        Me.btnPro = New System.Windows.Forms.Button()
        Me.abmServicios = New System.Windows.Forms.Button()
        Me.abmPagos = New System.Windows.Forms.Button()
        Me.abmpedido = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCursos
        '
        Me.btnCursos.BackColor = System.Drawing.Color.Peru
        Me.btnCursos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCursos.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCursos.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCursos.Location = New System.Drawing.Point(168, 229)
        Me.btnCursos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(228, 81)
        Me.btnCursos.TabIndex = 44
        Me.btnCursos.Text = "cursos"
        Me.btnCursos.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(427, 79)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(143, 61)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "ABMs"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
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
        Me.btnVolver.Size = New System.Drawing.Size(92, 38)
        Me.btnVolver.TabIndex = 47
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnSec
        '
        Me.btnSec.BackColor = System.Drawing.Color.Peru
        Me.btnSec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSec.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSec.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnSec.Location = New System.Drawing.Point(456, 229)
        Me.btnSec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.Size = New System.Drawing.Size(228, 81)
        Me.btnSec.TabIndex = 48
        Me.btnSec.Text = "Sectores"
        Me.btnSec.UseVisualStyleBackColor = False
        '
        'btnPro
        '
        Me.btnPro.BackColor = System.Drawing.Color.Peru
        Me.btnPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPro.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPro.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnPro.Location = New System.Drawing.Point(168, 342)
        Me.btnPro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.Size = New System.Drawing.Size(228, 81)
        Me.btnPro.TabIndex = 49
        Me.btnPro.Text = "Productos"
        Me.btnPro.UseVisualStyleBackColor = False
        '
        'abmServicios
        '
        Me.abmServicios.BackColor = System.Drawing.Color.Peru
        Me.abmServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abmServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmServicios.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmServicios.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.abmServicios.Location = New System.Drawing.Point(456, 451)
        Me.abmServicios.Name = "abmServicios"
        Me.abmServicios.Size = New System.Drawing.Size(228, 81)
        Me.abmServicios.TabIndex = 52
        Me.abmServicios.Text = "servicios"
        Me.abmServicios.UseVisualStyleBackColor = False
        '
        'abmPagos
        '
        Me.abmPagos.BackColor = System.Drawing.Color.Peru
        Me.abmPagos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abmPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmPagos.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmPagos.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.abmPagos.Location = New System.Drawing.Point(168, 451)
        Me.abmPagos.Name = "abmPagos"
        Me.abmPagos.Size = New System.Drawing.Size(228, 81)
        Me.abmPagos.TabIndex = 51
        Me.abmPagos.Text = "pagos"
        Me.abmPagos.UseVisualStyleBackColor = False
        '
        'abmpedido
        '
        Me.abmpedido.BackColor = System.Drawing.Color.Peru
        Me.abmpedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abmpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmpedido.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmpedido.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.abmpedido.Location = New System.Drawing.Point(456, 342)
        Me.abmpedido.Name = "abmpedido"
        Me.abmpedido.Size = New System.Drawing.Size(228, 81)
        Me.abmpedido.TabIndex = 50
        Me.abmpedido.Text = "pedido"
        Me.abmpedido.UseVisualStyleBackColor = False
        '
        'ABMs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 608)
        Me.Controls.Add(Me.abmServicios)
        Me.Controls.Add(Me.abmPagos)
        Me.Controls.Add(Me.abmpedido)
        Me.Controls.Add(Me.btnPro)
        Me.Controls.Add(Me.btnSec)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCursos)
        Me.Name = "ABMs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABMs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCursos As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSec As System.Windows.Forms.Button
    Friend WithEvents btnPro As System.Windows.Forms.Button
    Friend WithEvents abmServicios As System.Windows.Forms.Button
    Friend WithEvents abmPagos As System.Windows.Forms.Button
    Friend WithEvents abmpedido As System.Windows.Forms.Button
End Class
