<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosSolicitados
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidosSolicitados))
        Me.dgvPedidosS = New System.Windows.Forms.DataGridView()
        Me.lblPedidos = New System.Windows.Forms.Label()
        Me.pbSaludSe = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnEnviarP = New System.Windows.Forms.Button()
        Me.btnVerSolicitudes = New System.Windows.Forms.Button()
        Me.btnRecepcionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvPedidosS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidosS
        '
        Me.dgvPedidosS.AllowUserToAddRows = False
        Me.dgvPedidosS.AllowUserToDeleteRows = False
        Me.dgvPedidosS.AllowUserToResizeColumns = False
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidosS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPedidosS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidosS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPedidosS.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidosS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPedidosS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidosS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPedidosS.ColumnHeadersHeight = 28
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidosS.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPedidosS.EnableHeadersVisualStyles = False
        Me.dgvPedidosS.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvPedidosS.Location = New System.Drawing.Point(12, 157)
        Me.dgvPedidosS.Name = "dgvPedidosS"
        Me.dgvPedidosS.ReadOnly = True
        Me.dgvPedidosS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidosS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvPedidosS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvPedidosS.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPedidosS.Size = New System.Drawing.Size(628, 285)
        Me.dgvPedidosS.TabIndex = 34
        '
        'lblPedidos
        '
        Me.lblPedidos.AutoSize = True
        Me.lblPedidos.Font = New System.Drawing.Font("Trebuchet MS", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedidos.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblPedidos.Location = New System.Drawing.Point(383, 22)
        Me.lblPedidos.Name = "lblPedidos"
        Me.lblPedidos.Size = New System.Drawing.Size(257, 114)
        Me.lblPedidos.TabIndex = 37
        Me.lblPedidos.Text = "Pedidos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Solicitados"
        '
        'pbSaludSe
        '
        Me.pbSaludSe.Image = CType(resources.GetObject("pbSaludSe.Image"), System.Drawing.Image)
        Me.pbSaludSe.Location = New System.Drawing.Point(2, 1)
        Me.pbSaludSe.Name = "pbSaludSe"
        Me.pbSaludSe.Size = New System.Drawing.Size(341, 135)
        Me.pbSaludSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSaludSe.TabIndex = 36
        Me.pbSaludSe.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 516)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(90, 30)
        Me.btnVolver.TabIndex = 42
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnEnviarP
        '
        Me.btnEnviarP.BackColor = System.Drawing.Color.Peru
        Me.btnEnviarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarP.Enabled = False
        Me.btnEnviarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarP.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarP.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnviarP.Location = New System.Drawing.Point(454, 448)
        Me.btnEnviarP.Name = "btnEnviarP"
        Me.btnEnviarP.Size = New System.Drawing.Size(186, 50)
        Me.btnEnviarP.TabIndex = 41
        Me.btnEnviarP.Text = "ENVIAR PRODUCTOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEnviarP.UseVisualStyleBackColor = False
        '
        'btnVerSolicitudes
        '
        Me.btnVerSolicitudes.BackColor = System.Drawing.Color.Peru
        Me.btnVerSolicitudes.Enabled = False
        Me.btnVerSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerSolicitudes.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerSolicitudes.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVerSolicitudes.Location = New System.Drawing.Point(12, 448)
        Me.btnVerSolicitudes.Name = "btnVerSolicitudes"
        Me.btnVerSolicitudes.Size = New System.Drawing.Size(143, 30)
        Me.btnVerSolicitudes.TabIndex = 43
        Me.btnVerSolicitudes.Text = "Ver Solicitudes"
        Me.btnVerSolicitudes.UseVisualStyleBackColor = False
        '
        'btnRecepcionar
        '
        Me.btnRecepcionar.BackColor = System.Drawing.Color.Peru
        Me.btnRecepcionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecepcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecepcionar.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecepcionar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnRecepcionar.Location = New System.Drawing.Point(225, 448)
        Me.btnRecepcionar.Name = "btnRecepcionar"
        Me.btnRecepcionar.Size = New System.Drawing.Size(198, 50)
        Me.btnRecepcionar.TabIndex = 44
        Me.btnRecepcionar.Text = "RECEPCIONAR PEDIDO"
        Me.btnRecepcionar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 501)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "^^ solo para elaboracion"
        '
        'PedidosSolicitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(652, 558)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRecepcionar)
        Me.Controls.Add(Me.btnVerSolicitudes)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnEnviarP)
        Me.Controls.Add(Me.lblPedidos)
        Me.Controls.Add(Me.pbSaludSe)
        Me.Controls.Add(Me.dgvPedidosS)
        Me.Name = "PedidosSolicitados"
        Me.Text = "PedidosSolicitados"
        CType(Me.dgvPedidosS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPedidosS As System.Windows.Forms.DataGridView
    Friend WithEvents lblPedidos As System.Windows.Forms.Label
    Friend WithEvents pbSaludSe As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnEnviarP As System.Windows.Forms.Button
    Friend WithEvents btnVerSolicitudes As System.Windows.Forms.Button
    Friend WithEvents btnRecepcionar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
