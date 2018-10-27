<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIngresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIngresos))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnControlar = New System.Windows.Forms.Button()
        Me.lstMontos = New System.Windows.Forms.ListBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.cmbSeleSucu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(341, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(359, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 61)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Control de ingresos"
        '
        'btnControlar
        '
        Me.btnControlar.BackColor = System.Drawing.Color.Peru
        Me.btnControlar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnControlar.Location = New System.Drawing.Point(316, 322)
        Me.btnControlar.Name = "btnControlar"
        Me.btnControlar.Size = New System.Drawing.Size(158, 39)
        Me.btnControlar.TabIndex = 24
        Me.btnControlar.Text = "CONTROLAR"
        Me.btnControlar.UseVisualStyleBackColor = False
        '
        'lstMontos
        '
        Me.lstMontos.FormattingEnabled = True
        Me.lstMontos.Location = New System.Drawing.Point(16, 393)
        Me.lstMontos.Name = "lstMontos"
        Me.lstMontos.Size = New System.Drawing.Size(802, 303)
        Me.lstMontos.TabIndex = 25
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.Peru
        Me.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnvolver.Location = New System.Drawing.Point(16, 746)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(119, 41)
        Me.btnvolver.TabIndex = 26
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'cmbSeleSucu
        '
        Me.cmbSeleSucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeleSucu.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeleSucu.FormattingEnabled = True
        Me.cmbSeleSucu.Items.AddRange(New Object() {"Opción 1", "Opción 2", "Opción 3"})
        Me.cmbSeleSucu.Location = New System.Drawing.Point(259, 204)
        Me.cmbSeleSucu.Name = "cmbSeleSucu"
        Me.cmbSeleSucu.Size = New System.Drawing.Size(212, 30)
        Me.cmbSeleSucu.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(24, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Seleccione su sucursal"
        '
        'CIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(830, 802)
        Me.Controls.Add(Me.cmbSeleSucu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.lstMontos)
        Me.Controls.Add(Me.btnControlar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "CIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CIngresos"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnControlar As System.Windows.Forms.Button
    Friend WithEvents lstMontos As System.Windows.Forms.ListBox
    Friend WithEvents btnvolver As System.Windows.Forms.Button
    Friend WithEvents cmbSeleSucu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
