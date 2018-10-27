<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VDifSucu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VDifSucu))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.cmbSeleSucu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.btnControl = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 740)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(144, 37)
        Me.btnVolver.TabIndex = 35
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Font = New System.Drawing.Font("Trebuchet MS", 32.0!, System.Drawing.FontStyle.Bold)
        Me.lblrespuesta.ForeColor = System.Drawing.Color.Sienna
        Me.lblrespuesta.Location = New System.Drawing.Point(-123, 278)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(0, 54)
        Me.lblrespuesta.TabIndex = 34
        '
        'cmbSeleSucu
        '
        Me.cmbSeleSucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeleSucu.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeleSucu.FormattingEnabled = True
        Me.cmbSeleSucu.Items.AddRange(New Object() {"Opción 1", "Opción 2", "Opción 3"})
        Me.cmbSeleSucu.Location = New System.Drawing.Point(267, 243)
        Me.cmbSeleSucu.Name = "cmbSeleSucu"
        Me.cmbSeleSucu.Size = New System.Drawing.Size(212, 30)
        Me.cmbSeleSucu.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(32, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Seleccione su sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(12, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(879, 61)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Verificar la difrencia entre sucursales"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(341, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Location = New System.Drawing.Point(298, 335)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(457, 290)
        Me.lst1.TabIndex = 37
        '
        'btnControl
        '
        Me.btnControl.BackColor = System.Drawing.Color.Peru
        Me.btnControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControl.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControl.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnControl.Location = New System.Drawing.Point(455, 663)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(144, 37)
        Me.btnControl.TabIndex = 36
        Me.btnControl.Text = "Controlar"
        Me.btnControl.UseVisualStyleBackColor = False
        '
        'VDifSucu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1013, 789)
        Me.Controls.Add(Me.lst1)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.cmbSeleSucu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "VDifSucu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VDifSucu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblrespuesta As System.Windows.Forms.Label
    Friend WithEvents cmbSeleSucu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lst1 As System.Windows.Forms.ListBox
    Friend WithEvents btnControl As System.Windows.Forms.Button
End Class
