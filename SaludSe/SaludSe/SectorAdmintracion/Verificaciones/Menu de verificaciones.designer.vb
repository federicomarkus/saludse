<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuDeVerificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuDeVerificaciones))
        Me.btnVerifUtiMar = New System.Windows.Forms.Button()
        Me.btnVeriSumiServi = New System.Windows.Forms.Button()
        Me.btnVeriPagaRega = New System.Windows.Forms.Button()
        Me.btnControlEgresos = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnVeriDifeSucu = New System.Windows.Forms.Button()
        Me.btnControlIngreso = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVerifUtiMar
        '
        Me.btnVerifUtiMar.BackColor = System.Drawing.Color.Peru
        Me.btnVerifUtiMar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerifUtiMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifUtiMar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifUtiMar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVerifUtiMar.Location = New System.Drawing.Point(178, 207)
        Me.btnVerifUtiMar.Name = "btnVerifUtiMar"
        Me.btnVerifUtiMar.Size = New System.Drawing.Size(245, 100)
        Me.btnVerifUtiMar.TabIndex = 9
        Me.btnVerifUtiMar.Text = "Verificar la utilización de la marca"
        Me.btnVerifUtiMar.UseVisualStyleBackColor = False
        '
        'btnVeriSumiServi
        '
        Me.btnVeriSumiServi.BackColor = System.Drawing.Color.Peru
        Me.btnVeriSumiServi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVeriSumiServi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVeriSumiServi.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeriSumiServi.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVeriSumiServi.Location = New System.Drawing.Point(178, 324)
        Me.btnVeriSumiServi.Name = "btnVeriSumiServi"
        Me.btnVeriSumiServi.Size = New System.Drawing.Size(245, 100)
        Me.btnVeriSumiServi.TabIndex = 10
        Me.btnVeriSumiServi.Text = "Verificar los suministros de servicios"
        Me.btnVeriSumiServi.UseVisualStyleBackColor = False
        '
        'btnVeriPagaRega
        '
        Me.btnVeriPagaRega.BackColor = System.Drawing.Color.Peru
        Me.btnVeriPagaRega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVeriPagaRega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVeriPagaRega.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeriPagaRega.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVeriPagaRega.Location = New System.Drawing.Point(488, 207)
        Me.btnVeriPagaRega.Name = "btnVeriPagaRega"
        Me.btnVeriPagaRega.Size = New System.Drawing.Size(243, 100)
        Me.btnVeriPagaRega.TabIndex = 11
        Me.btnVeriPagaRega.Text = "Verificar la paga de regalía"
        Me.btnVeriPagaRega.UseVisualStyleBackColor = False
        '
        'btnControlEgresos
        '
        Me.btnControlEgresos.BackColor = System.Drawing.Color.Peru
        Me.btnControlEgresos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControlEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlEgresos.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlEgresos.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnControlEgresos.Location = New System.Drawing.Point(488, 446)
        Me.btnControlEgresos.Name = "btnControlEgresos"
        Me.btnControlEgresos.Size = New System.Drawing.Size(243, 100)
        Me.btnControlEgresos.TabIndex = 13
        Me.btnControlEgresos.Text = "Controlar los egresos"
        Me.btnControlEgresos.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 584)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(144, 37)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnVeriDifeSucu
        '
        Me.btnVeriDifeSucu.BackColor = System.Drawing.Color.Peru
        Me.btnVeriDifeSucu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVeriDifeSucu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVeriDifeSucu.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeriDifeSucu.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVeriDifeSucu.Location = New System.Drawing.Point(488, 324)
        Me.btnVeriDifeSucu.Name = "btnVeriDifeSucu"
        Me.btnVeriDifeSucu.Size = New System.Drawing.Size(243, 100)
        Me.btnVeriDifeSucu.TabIndex = 16
        Me.btnVeriDifeSucu.Text = "Verificar la diferencia entre sucursales "
        Me.btnVeriDifeSucu.UseVisualStyleBackColor = False
        '
        'btnControlIngreso
        '
        Me.btnControlIngreso.BackColor = System.Drawing.Color.Peru
        Me.btnControlIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControlIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlIngreso.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlIngreso.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnControlIngreso.Location = New System.Drawing.Point(180, 446)
        Me.btnControlIngreso.Name = "btnControlIngreso"
        Me.btnControlIngreso.Size = New System.Drawing.Size(243, 100)
        Me.btnControlIngreso.TabIndex = 17
        Me.btnControlIngreso.Text = "Controlar los ingresos"
        Me.btnControlIngreso.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(61, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(408, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(545, 61)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Menú de verificaciones"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(61, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(341, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'MenuDeVerificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(969, 633)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnControlIngreso)
        Me.Controls.Add(Me.btnVeriDifeSucu)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnControlEgresos)
        Me.Controls.Add(Me.btnVeriPagaRega)
        Me.Controls.Add(Me.btnVeriSumiServi)
        Me.Controls.Add(Me.btnVerifUtiMar)
        Me.Name = "MenuDeVerificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuDeVerificaciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerifUtiMar As System.Windows.Forms.Button
    Friend WithEvents btnVeriSumiServi As System.Windows.Forms.Button
    Friend WithEvents btnVeriPagaRega As System.Windows.Forms.Button
    Friend WithEvents btnControlEgresos As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnVeriDifeSucu As System.Windows.Forms.Button
    Friend WithEvents btnControlIngreso As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
