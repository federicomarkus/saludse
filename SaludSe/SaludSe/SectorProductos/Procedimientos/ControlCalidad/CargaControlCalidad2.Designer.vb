<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaControlCalidad2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaControlCalidad2))
        Me.lblProveedores = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.ListaOrdenProd = New System.Windows.Forms.DataGridView()
        Me.lblNumeroOrden = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.gbVencimiento = New System.Windows.Forms.GroupBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lblAdvertencia = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaOrdenProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVencimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProveedores
        '
        Me.lblProveedores.AutoSize = True
        Me.lblProveedores.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedores.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblProveedores.Location = New System.Drawing.Point(238, 44)
        Me.lblProveedores.Name = "lblProveedores"
        Me.lblProveedores.Size = New System.Drawing.Size(358, 35)
        Me.lblProveedores.TabIndex = 24
        Me.lblProveedores.Text = "Control de calidad: Cargas."
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(12, 12)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(212, 93)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 23
        Me.imgLogo.TabStop = False
        '
        'ListaOrdenProd
        '
        Me.ListaOrdenProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaOrdenProd.Location = New System.Drawing.Point(12, 153)
        Me.ListaOrdenProd.Name = "ListaOrdenProd"
        Me.ListaOrdenProd.Size = New System.Drawing.Size(584, 208)
        Me.ListaOrdenProd.TabIndex = 25
        '
        'lblNumeroOrden
        '
        Me.lblNumeroOrden.AutoSize = True
        Me.lblNumeroOrden.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroOrden.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblNumeroOrden.Location = New System.Drawing.Point(12, 108)
        Me.lblNumeroOrden.Name = "lblNumeroOrden"
        Me.lblNumeroOrden.Size = New System.Drawing.Size(349, 35)
        Me.lblNumeroOrden.TabIndex = 26
        Me.lblNumeroOrden.Text = "Productos de la orden nº: "
        '
        'txtDia
        '
        Me.txtDia.AccessibleDescription = ""
        Me.txtDia.Location = New System.Drawing.Point(57, 29)
        Me.txtDia.MaxLength = 2
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(91, 30)
        Me.txtDia.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Gray
        Me.lbl1.Location = New System.Drawing.Point(6, 34)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(45, 22)
        Me.lbl1.TabIndex = 28
        Me.lbl1.Text = "Dia :"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Gray
        Me.lbl3.Location = New System.Drawing.Point(426, 34)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(51, 22)
        Me.lbl3.TabIndex = 30
        Me.lbl3.Text = "Año :"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(483, 29)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(95, 30)
        Me.txtAño.TabIndex = 3
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Gray
        Me.lbl2.Location = New System.Drawing.Point(216, 34)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(49, 22)
        Me.lbl2.TabIndex = 32
        Me.lbl2.Text = "Mes :"
        '
        'gbVencimiento
        '
        Me.gbVencimiento.Controls.Add(Me.txtMes)
        Me.gbVencimiento.Controls.Add(Me.lbl1)
        Me.gbVencimiento.Controls.Add(Me.lbl2)
        Me.gbVencimiento.Controls.Add(Me.txtDia)
        Me.gbVencimiento.Controls.Add(Me.txtAño)
        Me.gbVencimiento.Controls.Add(Me.lbl3)
        Me.gbVencimiento.Enabled = False
        Me.gbVencimiento.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVencimiento.ForeColor = System.Drawing.Color.Gray
        Me.gbVencimiento.Location = New System.Drawing.Point(18, 432)
        Me.gbVencimiento.Name = "gbVencimiento"
        Me.gbVencimiento.Size = New System.Drawing.Size(584, 65)
        Me.gbVencimiento.TabIndex = 33
        Me.gbVencimiento.TabStop = False
        Me.gbVencimiento.Text = "Fecha vencimiento"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(254, 29)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(95, 30)
        Me.txtMes.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(20, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 22)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Id del producto :"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Peru
        Me.lblId.Location = New System.Drawing.Point(161, 398)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(24, 22)
        Me.lblId.TabIndex = 35
        Me.lblId.Text = "ID"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Peru
        Me.lblNombre.Location = New System.Drawing.Point(445, 398)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(70, 22)
        Me.lblNombre.TabIndex = 37
        Me.lblNombre.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Peru
        Me.Label7.Location = New System.Drawing.Point(268, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 22)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Nombre del producto :"
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Peru
        Me.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCargar.Location = New System.Drawing.Point(448, 503)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(148, 50)
        Me.btnCargar.TabIndex = 4
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'lblAdvertencia
        '
        Me.lblAdvertencia.AutoSize = True
        Me.lblAdvertencia.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertencia.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblAdvertencia.Location = New System.Drawing.Point(203, 364)
        Me.lblAdvertencia.Name = "lblAdvertencia"
        Me.lblAdvertencia.Size = New System.Drawing.Size(187, 22)
        Me.lblAdvertencia.TabIndex = 38
        Me.lblAdvertencia.Text = "SELECCIONE PRODUCTO"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 503)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(148, 50)
        Me.btnVolver.TabIndex = 39
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'CargaControlCalidad2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(608, 565)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblAdvertencia)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbVencimiento)
        Me.Controls.Add(Me.lblNumeroOrden)
        Me.Controls.Add(Me.ListaOrdenProd)
        Me.Controls.Add(Me.lblProveedores)
        Me.Controls.Add(Me.imgLogo)
        Me.Name = "CargaControlCalidad2"
        Me.Text = "CargaCC"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaOrdenProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVencimiento.ResumeLayout(False)
        Me.gbVencimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProveedores As System.Windows.Forms.Label
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ListaOrdenProd As System.Windows.Forms.DataGridView
    Friend WithEvents lblNumeroOrden As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents gbVencimiento As System.Windows.Forms.GroupBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents lblAdvertencia As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
