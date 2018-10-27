<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecepcionarM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecepcionarM))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.pbSaludSe = New System.Windows.Forms.PictureBox()
        Me.lblMenuP = New System.Windows.Forms.Label()
        Me.dgvRecepcionarM = New System.Windows.Forms.DataGridView()
        Me.gbInfoOrden = New System.Windows.Forms.GroupBox()
        Me.lblOrden2 = New System.Windows.Forms.Label()
        Me.lblNroOrden = New System.Windows.Forms.Label()
        Me.lblInporteT2 = New System.Windows.Forms.Label()
        Me.lblImporteT = New System.Windows.Forms.Label()
        Me.lblProveedor2 = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.btnRecepcionarM = New System.Windows.Forms.Button()
        Me.btnVolverOrdenes = New System.Windows.Forms.Button()
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecepcionarM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfoOrden.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 561)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(90, 30)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(12, 500)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 29
        '
        'pbSaludSe
        '
        Me.pbSaludSe.Image = CType(resources.GetObject("pbSaludSe.Image"), System.Drawing.Image)
        Me.pbSaludSe.Location = New System.Drawing.Point(15, 4)
        Me.pbSaludSe.Name = "pbSaludSe"
        Me.pbSaludSe.Size = New System.Drawing.Size(341, 135)
        Me.pbSaludSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSaludSe.TabIndex = 30
        Me.pbSaludSe.TabStop = False
        '
        'lblMenuP
        '
        Me.lblMenuP.AutoSize = True
        Me.lblMenuP.Font = New System.Drawing.Font("Trebuchet MS", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuP.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblMenuP.Location = New System.Drawing.Point(371, 40)
        Me.lblMenuP.Name = "lblMenuP"
        Me.lblMenuP.Size = New System.Drawing.Size(561, 57)
        Me.lblMenuP.TabIndex = 31
        Me.lblMenuP.Text = "Recepcionar Mercaderia "
        '
        'dgvRecepcionarM
        '
        Me.dgvRecepcionarM.AllowUserToAddRows = False
        Me.dgvRecepcionarM.AllowUserToDeleteRows = False
        Me.dgvRecepcionarM.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRecepcionarM.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRecepcionarM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecepcionarM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRecepcionarM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRecepcionarM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRecepcionarM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecepcionarM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecepcionarM.ColumnHeadersHeight = 28
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecepcionarM.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecepcionarM.EnableHeadersVisualStyles = False
        Me.dgvRecepcionarM.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvRecepcionarM.Location = New System.Drawing.Point(12, 163)
        Me.dgvRecepcionarM.Name = "dgvRecepcionarM"
        Me.dgvRecepcionarM.ReadOnly = True
        Me.dgvRecepcionarM.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRecepcionarM.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvRecepcionarM.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvRecepcionarM.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRecepcionarM.Size = New System.Drawing.Size(527, 294)
        Me.dgvRecepcionarM.TabIndex = 32
        '
        'gbInfoOrden
        '
        Me.gbInfoOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbInfoOrden.BackColor = System.Drawing.Color.Transparent
        Me.gbInfoOrden.Controls.Add(Me.lblOrden2)
        Me.gbInfoOrden.Controls.Add(Me.lblNroOrden)
        Me.gbInfoOrden.Controls.Add(Me.lblInporteT2)
        Me.gbInfoOrden.Controls.Add(Me.lblImporteT)
        Me.gbInfoOrden.Controls.Add(Me.lblProveedor2)
        Me.gbInfoOrden.Controls.Add(Me.lblProveedor)
        Me.gbInfoOrden.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInfoOrden.ForeColor = System.Drawing.Color.Sienna
        Me.gbInfoOrden.Location = New System.Drawing.Point(545, 163)
        Me.gbInfoOrden.Name = "gbInfoOrden"
        Me.gbInfoOrden.Size = New System.Drawing.Size(363, 229)
        Me.gbInfoOrden.TabIndex = 33
        Me.gbInfoOrden.TabStop = False
        Me.gbInfoOrden.Text = "Informacion Orden"
        '
        'lblOrden2
        '
        Me.lblOrden2.AutoSize = True
        Me.lblOrden2.Location = New System.Drawing.Point(169, 40)
        Me.lblOrden2.Name = "lblOrden2"
        Me.lblOrden2.Size = New System.Drawing.Size(0, 24)
        Me.lblOrden2.TabIndex = 15
        '
        'lblNroOrden
        '
        Me.lblNroOrden.AutoSize = True
        Me.lblNroOrden.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroOrden.ForeColor = System.Drawing.Color.Peru
        Me.lblNroOrden.Location = New System.Drawing.Point(28, 42)
        Me.lblNroOrden.Name = "lblNroOrden"
        Me.lblNroOrden.Size = New System.Drawing.Size(99, 22)
        Me.lblNroOrden.TabIndex = 14
        Me.lblNroOrden.Text = "Nro Orden: "
        '
        'lblInporteT2
        '
        Me.lblInporteT2.AutoSize = True
        Me.lblInporteT2.Location = New System.Drawing.Point(169, 182)
        Me.lblInporteT2.Name = "lblInporteT2"
        Me.lblInporteT2.Size = New System.Drawing.Size(0, 24)
        Me.lblInporteT2.TabIndex = 13
        '
        'lblImporteT
        '
        Me.lblImporteT.AutoSize = True
        Me.lblImporteT.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteT.ForeColor = System.Drawing.Color.Peru
        Me.lblImporteT.Location = New System.Drawing.Point(28, 184)
        Me.lblImporteT.Name = "lblImporteT"
        Me.lblImporteT.Size = New System.Drawing.Size(119, 22)
        Me.lblImporteT.TabIndex = 12
        Me.lblImporteT.Text = "Importe Total:"
        '
        'lblProveedor2
        '
        Me.lblProveedor2.AutoSize = True
        Me.lblProveedor2.Location = New System.Drawing.Point(169, 112)
        Me.lblProveedor2.Name = "lblProveedor2"
        Me.lblProveedor2.Size = New System.Drawing.Size(0, 24)
        Me.lblProveedor2.TabIndex = 10
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.Peru
        Me.lblProveedor.Location = New System.Drawing.Point(28, 114)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(94, 22)
        Me.lblProveedor.TabIndex = 5
        Me.lblProveedor.Text = "Proveedor:"
        '
        'btnRecepcionarM
        '
        Me.btnRecepcionarM.BackColor = System.Drawing.Color.Peru
        Me.btnRecepcionarM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecepcionarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecepcionarM.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecepcionarM.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnRecepcionarM.Location = New System.Drawing.Point(619, 407)
        Me.btnRecepcionarM.Name = "btnRecepcionarM"
        Me.btnRecepcionarM.Size = New System.Drawing.Size(237, 50)
        Me.btnRecepcionarM.TabIndex = 34
        Me.btnRecepcionarM.Text = "RECEPCIONAR MERCADERIA"
        Me.btnRecepcionarM.UseVisualStyleBackColor = False
        '
        'btnVolverOrdenes
        '
        Me.btnVolverOrdenes.BackColor = System.Drawing.Color.Peru
        Me.btnVolverOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolverOrdenes.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverOrdenes.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolverOrdenes.Location = New System.Drawing.Point(404, 463)
        Me.btnVolverOrdenes.Name = "btnVolverOrdenes"
        Me.btnVolverOrdenes.Size = New System.Drawing.Size(135, 34)
        Me.btnVolverOrdenes.TabIndex = 35
        Me.btnVolverOrdenes.Text = "VER ORDENES"
        Me.btnVolverOrdenes.UseVisualStyleBackColor = False
        '
        'RecepcionarM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(920, 603)
        Me.Controls.Add(Me.btnVolverOrdenes)
        Me.Controls.Add(Me.btnRecepcionarM)
        Me.Controls.Add(Me.gbInfoOrden)
        Me.Controls.Add(Me.dgvRecepcionarM)
        Me.Controls.Add(Me.lblMenuP)
        Me.Controls.Add(Me.pbSaludSe)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "RecepcionarM"
        Me.Text = "RecepcionarM"
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecepcionarM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfoOrden.ResumeLayout(False)
        Me.gbInfoOrden.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents pbSaludSe As System.Windows.Forms.PictureBox
    Friend WithEvents lblMenuP As System.Windows.Forms.Label
    Friend WithEvents dgvRecepcionarM As System.Windows.Forms.DataGridView
    Friend WithEvents gbInfoOrden As System.Windows.Forms.GroupBox
    Friend WithEvents lblImporteT As System.Windows.Forms.Label
    Friend WithEvents lblProveedor2 As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents lblInporteT2 As System.Windows.Forms.Label
    Friend WithEvents btnRecepcionarM As System.Windows.Forms.Button
    Friend WithEvents lblOrden2 As System.Windows.Forms.Label
    Friend WithEvents lblNroOrden As System.Windows.Forms.Label
    Friend WithEvents btnVolverOrdenes As System.Windows.Forms.Button
End Class
