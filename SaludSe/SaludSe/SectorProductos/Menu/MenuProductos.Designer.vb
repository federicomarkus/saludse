<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuProductos))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblMenuP = New System.Windows.Forms.Label()
        Me.pbSaludSe = New System.Windows.Forms.PictureBox()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.gbProcedimientos = New System.Windows.Forms.GroupBox()
        Me.btnControlC = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.btnRecepcionarM = New System.Windows.Forms.Button()
        Me.gbABM = New System.Windows.Forms.GroupBox()
        Me.btnTipoP = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProcedimientos.SuspendLayout()
        Me.gbABM.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 440)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(90, 30)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblMenuP
        '
        Me.lblMenuP.AutoSize = True
        Me.lblMenuP.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuP.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblMenuP.Location = New System.Drawing.Point(342, 39)
        Me.lblMenuP.Name = "lblMenuP"
        Me.lblMenuP.Size = New System.Drawing.Size(504, 61)
        Me.lblMenuP.TabIndex = 4
        Me.lblMenuP.Text = "Gestion de Productos"
        '
        'pbSaludSe
        '
        Me.pbSaludSe.Image = CType(resources.GetObject("pbSaludSe.Image"), System.Drawing.Image)
        Me.pbSaludSe.Location = New System.Drawing.Point(-5, -5)
        Me.pbSaludSe.Name = "pbSaludSe"
        Me.pbSaludSe.Size = New System.Drawing.Size(341, 135)
        Me.pbSaludSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSaludSe.TabIndex = 5
        Me.pbSaludSe.TabStop = False
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.Peru
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnProveedores.Location = New System.Drawing.Point(26, 41)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(166, 65)
        Me.btnProveedores.TabIndex = 8
        Me.btnProveedores.Text = "PROVEEDORES"
        Me.btnProveedores.UseVisualStyleBackColor = False
        '
        'gbProcedimientos
        '
        Me.gbProcedimientos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbProcedimientos.BackColor = System.Drawing.Color.Transparent
        Me.gbProcedimientos.Controls.Add(Me.btnControlC)
        Me.gbProcedimientos.Controls.Add(Me.btnPedidos)
        Me.gbProcedimientos.Controls.Add(Me.btnRecepcionarM)
        Me.gbProcedimientos.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProcedimientos.ForeColor = System.Drawing.Color.Sienna
        Me.gbProcedimientos.Location = New System.Drawing.Point(155, 157)
        Me.gbProcedimientos.Name = "gbProcedimientos"
        Me.gbProcedimientos.Size = New System.Drawing.Size(536, 112)
        Me.gbProcedimientos.TabIndex = 9
        Me.gbProcedimientos.TabStop = False
        Me.gbProcedimientos.Text = "Procedimientos"
        '
        'btnControlC
        '
        Me.btnControlC.BackColor = System.Drawing.Color.Peru
        Me.btnControlC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControlC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlC.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlC.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnControlC.Location = New System.Drawing.Point(373, 31)
        Me.btnControlC.Name = "btnControlC"
        Me.btnControlC.Size = New System.Drawing.Size(153, 60)
        Me.btnControlC.TabIndex = 14
        Me.btnControlC.Text = "CONTROL DE CALIDAD"
        Me.btnControlC.UseVisualStyleBackColor = True
        '
        'btnPedidos
        '
        Me.btnPedidos.BackColor = System.Drawing.Color.Peru
        Me.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidos.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidos.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnPedidos.Location = New System.Drawing.Point(201, 31)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(166, 60)
        Me.btnPedidos.TabIndex = 13
        Me.btnPedidos.Text = "PEDIDOS"
        Me.btnPedidos.UseVisualStyleBackColor = False
        '
        'btnRecepcionarM
        '
        Me.btnRecepcionarM.BackColor = System.Drawing.Color.Peru
        Me.btnRecepcionarM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecepcionarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecepcionarM.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecepcionarM.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnRecepcionarM.Location = New System.Drawing.Point(29, 31)
        Me.btnRecepcionarM.Name = "btnRecepcionarM"
        Me.btnRecepcionarM.Size = New System.Drawing.Size(153, 60)
        Me.btnRecepcionarM.TabIndex = 12
        Me.btnRecepcionarM.Text = "RECEPCIONAR MERCADERIA"
        Me.btnRecepcionarM.UseVisualStyleBackColor = False
        '
        'gbABM
        '
        Me.gbABM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbABM.BackColor = System.Drawing.Color.Transparent
        Me.gbABM.Controls.Add(Me.btnTipoP)
        Me.gbABM.Controls.Add(Me.btnProductos)
        Me.gbABM.Controls.Add(Me.btnProveedores)
        Me.gbABM.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbABM.ForeColor = System.Drawing.Color.Sienna
        Me.gbABM.Location = New System.Drawing.Point(155, 294)
        Me.gbABM.Name = "gbABM"
        Me.gbABM.Size = New System.Drawing.Size(545, 112)
        Me.gbABM.TabIndex = 10
        Me.gbABM.TabStop = False
        Me.gbABM.Text = "Altas - Bajas - Modificaiones"
        '
        'btnTipoP
        '
        Me.btnTipoP.BackColor = System.Drawing.Color.Peru
        Me.btnTipoP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTipoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoP.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoP.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnTipoP.Location = New System.Drawing.Point(370, 41)
        Me.btnTipoP.Name = "btnTipoP"
        Me.btnTipoP.Size = New System.Drawing.Size(166, 65)
        Me.btnTipoP.TabIndex = 10
        Me.btnTipoP.Text = "TIPO PRODUCTO"
        Me.btnTipoP.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.Peru
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnProductos.Location = New System.Drawing.Point(198, 41)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(166, 65)
        Me.btnProductos.TabIndex = 9
        Me.btnProductos.Text = "PRODUCTOS"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(854, 494)
        Me.Controls.Add(Me.gbProcedimientos)
        Me.Controls.Add(Me.gbABM)
        Me.Controls.Add(Me.pbSaludSe)
        Me.Controls.Add(Me.lblMenuP)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "MenuPrincipal"
        Me.Text = "Form1"
        CType(Me.pbSaludSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProcedimientos.ResumeLayout(False)
        Me.gbABM.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblMenuP As System.Windows.Forms.Label
    Friend WithEvents pbSaludSe As System.Windows.Forms.PictureBox
    Friend WithEvents btnProveedores As System.Windows.Forms.Button
    Friend WithEvents gbProcedimientos As System.Windows.Forms.GroupBox
    Friend WithEvents btnControlC As System.Windows.Forms.Button
    Friend WithEvents btnPedidos As System.Windows.Forms.Button
    Friend WithEvents btnRecepcionarM As System.Windows.Forms.Button
    Friend WithEvents gbABM As System.Windows.Forms.GroupBox
    Friend WithEvents btnTipoP As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button

End Class
