<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abmPedidoModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmPedidoModificar))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CkMenu = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CkSucu = New System.Windows.Forms.CheckBox()
        Me.CkCantidad = New System.Windows.Forms.CheckBox()
        Me.CkPedido = New System.Windows.Forms.CheckBox()
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.cmbSucu = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ckSi = New System.Windows.Forms.CheckBox()
        Me.CkNo = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(439, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 61)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Modificar un pedido"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(341, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 28
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(91, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Size = New System.Drawing.Size(890, 239)
        Me.DataGridView1.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(64, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 24)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Seleccione un pedido para modificar:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Peru
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Button1.Location = New System.Drawing.Point(12, 598)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 37)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CkMenu
        '
        Me.CkMenu.AutoSize = True
        Me.CkMenu.Location = New System.Drawing.Point(419, 530)
        Me.CkMenu.Name = "CkMenu"
        Me.CkMenu.Size = New System.Drawing.Size(53, 17)
        Me.CkMenu.TabIndex = 70
        Me.CkMenu.Text = "Menu"
        Me.CkMenu.UseVisualStyleBackColor = True
        Me.CkMenu.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(271, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Modificar:"
        Me.Label4.Visible = False
        '
        'CkSucu
        '
        Me.CkSucu.AutoSize = True
        Me.CkSucu.Location = New System.Drawing.Point(419, 495)
        Me.CkSucu.Name = "CkSucu"
        Me.CkSucu.Size = New System.Drawing.Size(67, 17)
        Me.CkSucu.TabIndex = 72
        Me.CkSucu.Text = "Sucursal"
        Me.CkSucu.UseVisualStyleBackColor = True
        Me.CkSucu.Visible = False
        '
        'CkCantidad
        '
        Me.CkCantidad.AutoSize = True
        Me.CkCantidad.Location = New System.Drawing.Point(419, 565)
        Me.CkCantidad.Name = "CkCantidad"
        Me.CkCantidad.Size = New System.Drawing.Size(68, 17)
        Me.CkCantidad.TabIndex = 73
        Me.CkCantidad.Text = "Cantidad"
        Me.CkCantidad.UseVisualStyleBackColor = True
        Me.CkCantidad.Visible = False
        '
        'CkPedido
        '
        Me.CkPedido.AutoSize = True
        Me.CkPedido.Location = New System.Drawing.Point(419, 599)
        Me.CkPedido.Name = "CkPedido"
        Me.CkPedido.Size = New System.Drawing.Size(109, 17)
        Me.CkPedido.TabIndex = 74
        Me.CkPedido.Text = "Pedido Finalizado"
        Me.CkPedido.UseVisualStyleBackColor = True
        Me.CkPedido.Visible = False
        '
        'cmbMenu
        '
        Me.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Location = New System.Drawing.Point(654, 528)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(258, 21)
        Me.cmbMenu.TabIndex = 75
        Me.cmbMenu.Visible = False
        '
        'cmbSucu
        '
        Me.cmbSucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucu.FormattingEnabled = True
        Me.cmbSucu.Location = New System.Drawing.Point(654, 495)
        Me.cmbSucu.Name = "cmbSucu"
        Me.cmbSucu.Size = New System.Drawing.Size(121, 21)
        Me.cmbSucu.TabIndex = 76
        Me.cmbSucu.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(654, 562)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.Visible = False
        '
        'ckSi
        '
        Me.ckSi.AutoSize = True
        Me.ckSi.Location = New System.Drawing.Point(654, 599)
        Me.ckSi.Name = "ckSi"
        Me.ckSi.Size = New System.Drawing.Size(35, 17)
        Me.ckSi.TabIndex = 78
        Me.ckSi.Text = "Si"
        Me.ckSi.UseVisualStyleBackColor = True
        Me.ckSi.Visible = False
        '
        'CkNo
        '
        Me.CkNo.AutoSize = True
        Me.CkNo.Location = New System.Drawing.Point(740, 599)
        Me.CkNo.Name = "CkNo"
        Me.CkNo.Size = New System.Drawing.Size(40, 17)
        Me.CkNo.TabIndex = 79
        Me.CkNo.Text = "No"
        Me.CkNo.UseVisualStyleBackColor = True
        Me.CkNo.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Peru
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnModificar.Location = New System.Drawing.Point(927, 598)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(144, 37)
        Me.btnModificar.TabIndex = 80
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'abmPedidoModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1101, 647)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.CkNo)
        Me.Controls.Add(Me.ckSi)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmbSucu)
        Me.Controls.Add(Me.cmbMenu)
        Me.Controls.Add(Me.CkPedido)
        Me.Controls.Add(Me.CkCantidad)
        Me.Controls.Add(Me.CkSucu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CkMenu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "abmPedidoModificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abmPedidoModificar"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CkMenu As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CkSucu As System.Windows.Forms.CheckBox
    Friend WithEvents CkCantidad As System.Windows.Forms.CheckBox
    Friend WithEvents CkPedido As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMenu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucu As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ckSi As System.Windows.Forms.CheckBox
    Friend WithEvents CkNo As System.Windows.Forms.CheckBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
