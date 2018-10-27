<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuStock
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
        Dim lblTitulo As System.Windows.Forms.Label
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuStock))
        Me.btnRepos = New System.Windows.Forms.Button()
        Me.btnDevo = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        lblTitulo = New System.Windows.Forms.Label()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRepos
        '
        Me.btnRepos.BackColor = System.Drawing.Color.Peru
        Me.btnRepos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepos.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepos.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnRepos.Location = New System.Drawing.Point(115, 265)
        Me.btnRepos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRepos.Name = "btnRepos"
        Me.btnRepos.Size = New System.Drawing.Size(305, 90)
        Me.btnRepos.TabIndex = 21
        Me.btnRepos.Text = "Reposicion de Stock"
        Me.btnRepos.UseVisualStyleBackColor = False
        '
        'btnDevo
        '
        Me.btnDevo.BackColor = System.Drawing.Color.Peru
        Me.btnDevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevo.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnDevo.Location = New System.Drawing.Point(496, 265)
        Me.btnDevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDevo.Name = "btnDevo"
        Me.btnDevo.Size = New System.Drawing.Size(305, 90)
        Me.btnDevo.TabIndex = 22
        Me.btnDevo.Text = "Devolucion de stock"
        Me.btnDevo.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Peru
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnVolver.Location = New System.Drawing.Point(12, 489)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(180, 66)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        lblTitulo.AutoSize = True
        lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        lblTitulo.Location = New System.Drawing.Point(440, 80)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(149, 61)
        lblTitulo.TabIndex = 24
        lblTitulo.Text = "Stock"
        '
        'PictureBox1
        '
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(12, 13)
        PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(341, 166)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        '
        'MenuStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(934, 568)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(lblTitulo)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnDevo)
        Me.Controls.Add(Me.btnRepos)
        Me.Name = "MenuStock"
        Me.Text = "MenuStock"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRepos As System.Windows.Forms.Button
    Friend WithEvents btnDevo As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
