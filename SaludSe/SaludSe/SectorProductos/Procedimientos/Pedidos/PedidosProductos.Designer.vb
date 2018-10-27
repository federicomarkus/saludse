<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidosProductos))
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.lblPedidos = New System.Windows.Forms.Label()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.btnSolicitarP = New System.Windows.Forms.Button()
        Me.gbInfoInsumo = New System.Windows.Forms.GroupBox()
        Me.btnVaciarC = New System.Windows.Forms.Button()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        Me.txtPrecioT = New System.Windows.Forms.TextBox()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.txtStockC = New System.Windows.Forms.TextBox()
        Me.txtStockD = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblPrecioT = New System.Windows.Forms.Label()
        Me.lblPrecioU = New System.Windows.Forms.Label()
        Me.lblStockComp = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.gbxDatosOrden = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.txtNroOrden = New System.Windows.Forms.TextBox()
        Me.txtProveedor2 = New System.Windows.Forms.TextBox()
        Me.lblproductosS = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.lblProveedor2 = New System.Windows.Forms.Label()
        Me.lstProductosSolicitados = New System.Windows.Forms.ListBox()
        Me.lblNroOrden = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.pbSaludSe = New System.Windows.Forms.PictureBox()
        Me.btnVerPedidosP = New System.Windows.Forms.Button()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfoInsumo.SuspendLayout()
        Me.gbxDatosOrden.SuspendLayout()
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPedidos.ColumnHeadersHeight = 28
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPedidos.EnableHeadersVisualStyles = False
        Me.dgvPedidos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvPedidos.Location = New System.Drawing.Point(12, 201)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvPedidos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvPedidos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidos.Size = New System.Drawing.Size(581, 308)
        Me.dgvPedidos.TabIndex = 33
        '
        'lblPedidos
        '
        Me.lblPedidos.AutoSize = True
        Me.lblPedidos.Font = New System.Drawing.Font("Trebuchet MS", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedidos.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblPedidos.Location = New System.Drawing.Point(382, 47)
        Me.lblPedidos.Name = "lblPedidos"
        Me.lblPedidos.Size = New System.Drawing.Size(192, 57)
        Me.lblPedidos.TabIndex = 35
        Me.lblPedidos.Text = "Pedidos"
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(173, 165)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(420, 20)
        Me.txtBuscador.TabIndex = 36
        '
        'btnSolicitarP
        '
        Me.btnSolicitarP.BackColor = System.Drawing.Color.Peru
        Me.btnSolicitarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolicitarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitarP.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitarP.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnSolicitarP.Location = New System.Drawing.Point(419, 515)
        Me.btnSolicitarP.Name = "btnSolicitarP"
        Me.btnSolicitarP.Size = New System.Drawing.Size(174, 50)
        Me.btnSolicitarP.TabIndex = 37
        Me.btnSolicitarP.Text = "GENERAR PEDIDO"
        Me.btnSolicitarP.UseVisualStyleBackColor = False
        '
        'gbInfoInsumo
        '
        Me.gbInfoInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbInfoInsumo.BackColor = System.Drawing.Color.Transparent
        Me.gbInfoInsumo.Controls.Add(Me.btnVaciarC)
        Me.gbInfoInsumo.Controls.Add(Me.btnAgregarP)
        Me.gbInfoInsumo.Controls.Add(Me.txtPrecioT)
        Me.gbInfoInsumo.Controls.Add(Me.txtPrecioU)
        Me.gbInfoInsumo.Controls.Add(Me.txtStockC)
        Me.gbInfoInsumo.Controls.Add(Me.txtStockD)
        Me.gbInfoInsumo.Controls.Add(Me.txtProveedor)
        Me.gbInfoInsumo.Controls.Add(Me.txtTipo)
        Me.gbInfoInsumo.Controls.Add(Me.txtCodigo)
        Me.gbInfoInsumo.Controls.Add(Me.txtDescripcion)
        Me.gbInfoInsumo.Controls.Add(Me.lblPrecioT)
        Me.gbInfoInsumo.Controls.Add(Me.lblPrecioU)
        Me.gbInfoInsumo.Controls.Add(Me.lblStockComp)
        Me.gbInfoInsumo.Controls.Add(Me.lblStock)
        Me.gbInfoInsumo.Controls.Add(Me.lblProveedor)
        Me.gbInfoInsumo.Controls.Add(Me.lblTipo)
        Me.gbInfoInsumo.Controls.Add(Me.lblCodigo)
        Me.gbInfoInsumo.Controls.Add(Me.lblDescripcion)
        Me.gbInfoInsumo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInfoInsumo.ForeColor = System.Drawing.Color.Sienna
        Me.gbInfoInsumo.Location = New System.Drawing.Point(605, 12)
        Me.gbInfoInsumo.Name = "gbInfoInsumo"
        Me.gbInfoInsumo.Size = New System.Drawing.Size(376, 307)
        Me.gbInfoInsumo.TabIndex = 38
        Me.gbInfoInsumo.TabStop = False
        Me.gbInfoInsumo.Text = "Informacion Producto"
        '
        'btnVaciarC
        '
        Me.btnVaciarC.BackColor = System.Drawing.Color.Peru
        Me.btnVaciarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVaciarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVaciarC.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVaciarC.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVaciarC.Location = New System.Drawing.Point(229, 251)
        Me.btnVaciarC.Name = "btnVaciarC"
        Me.btnVaciarC.Size = New System.Drawing.Size(84, 50)
        Me.btnVaciarC.TabIndex = 51
        Me.btnVaciarC.Text = "Vaciar Campos"
        Me.btnVaciarC.UseVisualStyleBackColor = False
        '
        'btnAgregarP
        '
        Me.btnAgregarP.BackColor = System.Drawing.Color.Peru
        Me.btnAgregarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarP.Enabled = False
        Me.btnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarP.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarP.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnAgregarP.Location = New System.Drawing.Point(75, 251)
        Me.btnAgregarP.Name = "btnAgregarP"
        Me.btnAgregarP.Size = New System.Drawing.Size(84, 50)
        Me.btnAgregarP.TabIndex = 42
        Me.btnAgregarP.Text = "Agregar al pedido"
        Me.btnAgregarP.UseVisualStyleBackColor = False
        '
        'txtPrecioT
        '
        Me.txtPrecioT.Enabled = False
        Me.txtPrecioT.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioT.Location = New System.Drawing.Point(292, 210)
        Me.txtPrecioT.Name = "txtPrecioT"
        Me.txtPrecioT.Size = New System.Drawing.Size(75, 23)
        Me.txtPrecioT.TabIndex = 49
        '
        'txtPrecioU
        '
        Me.txtPrecioU.Enabled = False
        Me.txtPrecioU.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioU.Location = New System.Drawing.Point(116, 212)
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Size = New System.Drawing.Size(65, 23)
        Me.txtPrecioU.TabIndex = 48
        '
        'txtStockC
        '
        Me.txtStockC.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockC.Location = New System.Drawing.Point(305, 166)
        Me.txtStockC.Name = "txtStockC"
        Me.txtStockC.Size = New System.Drawing.Size(62, 23)
        Me.txtStockC.TabIndex = 47
        '
        'txtStockD
        '
        Me.txtStockD.Enabled = False
        Me.txtStockD.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockD.Location = New System.Drawing.Point(109, 166)
        Me.txtStockD.Name = "txtStockD"
        Me.txtStockD.Size = New System.Drawing.Size(65, 23)
        Me.txtStockD.TabIndex = 46
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(109, 119)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(258, 23)
        Me.txtProveedor.TabIndex = 45
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(202, 77)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(165, 23)
        Me.txtTipo.TabIndex = 44
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(84, 77)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 23)
        Me.txtCodigo.TabIndex = 43
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 35)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(247, 23)
        Me.txtDescripcion.TabIndex = 42
        '
        'lblPrecioT
        '
        Me.lblPrecioT.AutoSize = True
        Me.lblPrecioT.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioT.ForeColor = System.Drawing.Color.Peru
        Me.lblPrecioT.Location = New System.Drawing.Point(187, 211)
        Me.lblPrecioT.Name = "lblPrecioT"
        Me.lblPrecioT.Size = New System.Drawing.Size(103, 22)
        Me.lblPrecioT.TabIndex = 22
        Me.lblPrecioT.Text = "Precio Total"
        '
        'lblPrecioU
        '
        Me.lblPrecioU.AutoSize = True
        Me.lblPrecioU.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioU.ForeColor = System.Drawing.Color.Peru
        Me.lblPrecioU.Location = New System.Drawing.Point(15, 212)
        Me.lblPrecioU.Name = "lblPrecioU"
        Me.lblPrecioU.Size = New System.Drawing.Size(95, 22)
        Me.lblPrecioU.TabIndex = 21
        Me.lblPrecioU.Text = "Precio Unit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblStockComp
        '
        Me.lblStockComp.AutoSize = True
        Me.lblStockComp.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockComp.ForeColor = System.Drawing.Color.Peru
        Me.lblStockComp.Location = New System.Drawing.Point(183, 166)
        Me.lblStockComp.Name = "lblStockComp"
        Me.lblStockComp.Size = New System.Drawing.Size(116, 22)
        Me.lblStockComp.TabIndex = 20
        Me.lblStockComp.Text = "Stock Compra"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.Peru
        Me.lblStock.Location = New System.Drawing.Point(15, 166)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(88, 22)
        Me.lblStock.TabIndex = 19
        Me.lblStock.Text = "Stock Disp"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.Peru
        Me.lblProveedor.Location = New System.Drawing.Point(15, 119)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(88, 22)
        Me.lblProveedor.TabIndex = 18
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Peru
        Me.lblTipo.Location = New System.Drawing.Point(152, 77)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(44, 22)
        Me.lblTipo.TabIndex = 17
        Me.lblTipo.Text = "Tipo"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Peru
        Me.lblCodigo.Location = New System.Drawing.Point(15, 77)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(63, 22)
        Me.lblCodigo.TabIndex = 16
        Me.lblCodigo.Text = "Codigo"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Peru
        Me.lblDescripcion.Location = New System.Drawing.Point(15, 35)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(99, 22)
        Me.lblDescripcion.TabIndex = 15
        Me.lblDescripcion.Text = "Descripcion"
        '
        'gbxDatosOrden
        '
        Me.gbxDatosOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbxDatosOrden.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatosOrden.Controls.Add(Me.btnConfirmar)
        Me.gbxDatosOrden.Controls.Add(Me.btnCancelar)
        Me.gbxDatosOrden.Controls.Add(Me.txtImporteTotal)
        Me.gbxDatosOrden.Controls.Add(Me.txtNroOrden)
        Me.gbxDatosOrden.Controls.Add(Me.txtProveedor2)
        Me.gbxDatosOrden.Controls.Add(Me.lblproductosS)
        Me.gbxDatosOrden.Controls.Add(Me.lblImporteTotal)
        Me.gbxDatosOrden.Controls.Add(Me.lblProveedor2)
        Me.gbxDatosOrden.Controls.Add(Me.lstProductosSolicitados)
        Me.gbxDatosOrden.Controls.Add(Me.lblNroOrden)
        Me.gbxDatosOrden.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosOrden.ForeColor = System.Drawing.Color.Sienna
        Me.gbxDatosOrden.Location = New System.Drawing.Point(605, 325)
        Me.gbxDatosOrden.Name = "gbxDatosOrden"
        Me.gbxDatosOrden.Size = New System.Drawing.Size(376, 279)
        Me.gbxDatosOrden.TabIndex = 39
        Me.gbxDatosOrden.TabStop = False
        Me.gbxDatosOrden.Text = "Informacion Orden"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.Peru
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnConfirmar.Location = New System.Drawing.Point(19, 208)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(84, 50)
        Me.btnConfirmar.TabIndex = 51
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Peru
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancelar.Location = New System.Drawing.Point(116, 208)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 50)
        Me.btnCancelar.TabIndex = 50
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Enabled = False
        Me.txtImporteTotal.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteTotal.Location = New System.Drawing.Point(19, 160)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(181, 23)
        Me.txtImporteTotal.TabIndex = 49
        '
        'txtNroOrden
        '
        Me.txtNroOrden.Enabled = False
        Me.txtNroOrden.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrden.Location = New System.Drawing.Point(19, 59)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(181, 23)
        Me.txtNroOrden.TabIndex = 48
        '
        'txtProveedor2
        '
        Me.txtProveedor2.Enabled = False
        Me.txtProveedor2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor2.Location = New System.Drawing.Point(19, 109)
        Me.txtProveedor2.Name = "txtProveedor2"
        Me.txtProveedor2.Size = New System.Drawing.Size(181, 23)
        Me.txtProveedor2.TabIndex = 47
        '
        'lblproductosS
        '
        Me.lblproductosS.AutoSize = True
        Me.lblproductosS.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductosS.ForeColor = System.Drawing.Color.Peru
        Me.lblproductosS.Location = New System.Drawing.Point(242, 26)
        Me.lblproductosS.Name = "lblproductosS"
        Me.lblproductosS.Size = New System.Drawing.Size(97, 44)
        Me.lblproductosS.TabIndex = 20
        Me.lblproductosS.Text = "Productos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Solicitados "
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteTotal.ForeColor = System.Drawing.Color.Peru
        Me.lblImporteTotal.Location = New System.Drawing.Point(15, 135)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(113, 22)
        Me.lblImporteTotal.TabIndex = 19
        Me.lblImporteTotal.Text = "Importe Total"
        '
        'lblProveedor2
        '
        Me.lblProveedor2.AutoSize = True
        Me.lblProveedor2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor2.ForeColor = System.Drawing.Color.Peru
        Me.lblProveedor2.Location = New System.Drawing.Point(15, 85)
        Me.lblProveedor2.Name = "lblProveedor2"
        Me.lblProveedor2.Size = New System.Drawing.Size(88, 22)
        Me.lblProveedor2.TabIndex = 18
        Me.lblProveedor2.Text = "Proveedor"
        '
        'lstProductosSolicitados
        '
        Me.lstProductosSolicitados.FormattingEnabled = True
        Me.lstProductosSolicitados.ItemHeight = 24
        Me.lstProductosSolicitados.Location = New System.Drawing.Point(219, 77)
        Me.lstProductosSolicitados.Name = "lstProductosSolicitados"
        Me.lstProductosSolicitados.Size = New System.Drawing.Size(148, 196)
        Me.lstProductosSolicitados.TabIndex = 17
        '
        'lblNroOrden
        '
        Me.lblNroOrden.AutoSize = True
        Me.lblNroOrden.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroOrden.ForeColor = System.Drawing.Color.Peru
        Me.lblNroOrden.Location = New System.Drawing.Point(15, 36)
        Me.lblNroOrden.Name = "lblNroOrden"
        Me.lblNroOrden.Size = New System.Drawing.Size(144, 22)
        Me.lblNroOrden.TabIndex = 16
        Me.lblNroOrden.Text = "Nro Orden Pedido"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 575)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(90, 30)
        Me.btnVolver.TabIndex = 40
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(24, 533)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 41
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.Peru
        Me.lblBuscar.Location = New System.Drawing.Point(12, 165)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(155, 22)
        Me.lblBuscar.TabIndex = 42
        Me.lblBuscar.Text = "Buscar por nombre"
        '
        'pbSaludSe
        '
        Me.pbSaludSe.Image = CType(resources.GetObject("pbSaludSe.Image"), System.Drawing.Image)
        Me.pbSaludSe.Location = New System.Drawing.Point(0, 0)
        Me.pbSaludSe.Name = "pbSaludSe"
        Me.pbSaludSe.Size = New System.Drawing.Size(341, 135)
        Me.pbSaludSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSaludSe.TabIndex = 34
        Me.pbSaludSe.TabStop = False
        '
        'btnVerPedidosP
        '
        Me.btnVerPedidosP.BackColor = System.Drawing.Color.Peru
        Me.btnVerPedidosP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerPedidosP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerPedidosP.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPedidosP.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVerPedidosP.Location = New System.Drawing.Point(186, 515)
        Me.btnVerPedidosP.Name = "btnVerPedidosP"
        Me.btnVerPedidosP.Size = New System.Drawing.Size(227, 50)
        Me.btnVerPedidosP.TabIndex = 43
        Me.btnVerPedidosP.Text = "VER PEDIDOS PENDIENTES"
        Me.btnVerPedidosP.UseVisualStyleBackColor = False
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(993, 617)
        Me.Controls.Add(Me.btnVerPedidosP)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.gbxDatosOrden)
        Me.Controls.Add(Me.gbInfoInsumo)
        Me.Controls.Add(Me.btnSolicitarP)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.lblPedidos)
        Me.Controls.Add(Me.pbSaludSe)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfoInsumo.ResumeLayout(False)
        Me.gbInfoInsumo.PerformLayout()
        Me.gbxDatosOrden.ResumeLayout(False)
        Me.gbxDatosOrden.PerformLayout()
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents lblPedidos As System.Windows.Forms.Label
    Friend WithEvents pbSaludSe As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents btnSolicitarP As System.Windows.Forms.Button
    Friend WithEvents gbInfoInsumo As System.Windows.Forms.GroupBox
    Friend WithEvents gbxDatosOrden As System.Windows.Forms.GroupBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioT As System.Windows.Forms.Label
    Friend WithEvents lblPrecioU As System.Windows.Forms.Label
    Friend WithEvents lblStockComp As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents btnVaciarC As System.Windows.Forms.Button
    Friend WithEvents btnAgregarP As System.Windows.Forms.Button
    Friend WithEvents txtPrecioT As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioU As System.Windows.Forms.TextBox
    Friend WithEvents txtStockC As System.Windows.Forms.TextBox
    Friend WithEvents txtStockD As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor2 As System.Windows.Forms.TextBox
    Friend WithEvents lblproductosS As System.Windows.Forms.Label
    Friend WithEvents lblImporteTotal As System.Windows.Forms.Label
    Friend WithEvents lblProveedor2 As System.Windows.Forms.Label
    Friend WithEvents lstProductosSolicitados As System.Windows.Forms.ListBox
    Friend WithEvents lblNroOrden As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnVerPedidosP As System.Windows.Forms.Button
End Class
