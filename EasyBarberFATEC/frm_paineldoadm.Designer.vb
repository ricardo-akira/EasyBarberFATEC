<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_paineldoadm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_paineldoadm))
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.pnl_funcionalidades = New System.Windows.Forms.Panel()
        Me.btn_aumentar = New System.Windows.Forms.PictureBox()
        Me.btn_diminuir = New System.Windows.Forms.PictureBox()
        Me.btn_sair = New System.Windows.Forms.PictureBox()
        Me.pnl_funcionalidades2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_todosatendimentos = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_adm = New System.Windows.Forms.DataGridView()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.btn_deletar = New System.Windows.Forms.Button()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_funcionalidades.SuspendLayout()
        CType(Me.btn_aumentar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_diminuir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_funcionalidades2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_usuario.Location = New System.Drawing.Point(5, 139)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(287, 48)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Nome do Usuario"
        Me.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnl_funcionalidades
        '
        Me.pnl_funcionalidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnl_funcionalidades.Controls.Add(Me.btn_aumentar)
        Me.pnl_funcionalidades.Controls.Add(Me.btn_diminuir)
        Me.pnl_funcionalidades.Controls.Add(Me.btn_sair)
        Me.pnl_funcionalidades.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_funcionalidades.Location = New System.Drawing.Point(0, 0)
        Me.pnl_funcionalidades.Name = "pnl_funcionalidades"
        Me.pnl_funcionalidades.Size = New System.Drawing.Size(1280, 32)
        Me.pnl_funcionalidades.TabIndex = 6
        '
        'btn_aumentar
        '
        Me.btn_aumentar.Cursor = System.Windows.Forms.Cursors.No
        Me.btn_aumentar.Image = CType(resources.GetObject("btn_aumentar.Image"), System.Drawing.Image)
        Me.btn_aumentar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_aumentar.Location = New System.Drawing.Point(49, 9)
        Me.btn_aumentar.Name = "btn_aumentar"
        Me.btn_aumentar.Size = New System.Drawing.Size(14, 14)
        Me.btn_aumentar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_aumentar.TabIndex = 1
        Me.btn_aumentar.TabStop = False
        '
        'btn_diminuir
        '
        Me.btn_diminuir.Cursor = System.Windows.Forms.Cursors.No
        Me.btn_diminuir.Image = CType(resources.GetObject("btn_diminuir.Image"), System.Drawing.Image)
        Me.btn_diminuir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_diminuir.Location = New System.Drawing.Point(29, 9)
        Me.btn_diminuir.Name = "btn_diminuir"
        Me.btn_diminuir.Size = New System.Drawing.Size(14, 14)
        Me.btn_diminuir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_diminuir.TabIndex = 2
        Me.btn_diminuir.TabStop = False
        '
        'btn_sair
        '
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_sair.Location = New System.Drawing.Point(9, 9)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(14, 14)
        Me.btn_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_sair.TabIndex = 0
        Me.btn_sair.TabStop = False
        '
        'pnl_funcionalidades2
        '
        Me.pnl_funcionalidades2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnl_funcionalidades2.Controls.Add(Me.Label1)
        Me.pnl_funcionalidades2.Controls.Add(Me.Button4)
        Me.pnl_funcionalidades2.Controls.Add(Me.Button1)
        Me.pnl_funcionalidades2.Controls.Add(Me.btn_todosatendimentos)
        Me.pnl_funcionalidades2.Controls.Add(Me.btn_logout)
        Me.pnl_funcionalidades2.Controls.Add(Me.Button2)
        Me.pnl_funcionalidades2.Controls.Add(Me.Label2)
        Me.pnl_funcionalidades2.Controls.Add(Me.lbl_usuario)
        Me.pnl_funcionalidades2.Controls.Add(Me.PictureBox1)
        Me.pnl_funcionalidades2.Controls.Add(Me.lbl_titulo)
        Me.pnl_funcionalidades2.Controls.Add(Me.Label3)
        Me.pnl_funcionalidades2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_funcionalidades2.Location = New System.Drawing.Point(0, 32)
        Me.pnl_funcionalidades2.Name = "pnl_funcionalidades2"
        Me.pnl_funcionalidades2.Size = New System.Drawing.Size(297, 688)
        Me.pnl_funcionalidades2.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(29, 374)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(237, 37)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Gerenciar barbeiros"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(30, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 37)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Gerar relatórios"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_todosatendimentos
        '
        Me.btn_todosatendimentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_todosatendimentos.FlatAppearance.BorderSize = 0
        Me.btn_todosatendimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_todosatendimentos.Location = New System.Drawing.Point(30, 288)
        Me.btn_todosatendimentos.Name = "btn_todosatendimentos"
        Me.btn_todosatendimentos.Size = New System.Drawing.Size(237, 37)
        Me.btn_todosatendimentos.TabIndex = 19
        Me.btn_todosatendimentos.Text = "Todos atendimentos"
        Me.btn_todosatendimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_todosatendimentos.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Location = New System.Drawing.Point(13, 596)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(263, 37)
        Me.btn_logout.TabIndex = 18
        Me.btn_logout.Text = "Logout do app"
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(13, 639)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(263, 37)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Sair do app"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SF Pro Text", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(71, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Simplifique a gestão da sua barbearia."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("SF Pro Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(66, 28)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(201, 44)
        Me.lbl_titulo.TabIndex = 14
        Me.lbl_titulo.Text = "EasyBarber"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SF Pro Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(70, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Seja bem-vindo(a):"
        '
        'dgv_adm
        '
        Me.dgv_adm.AllowUserToAddRows = False
        Me.dgv_adm.AllowUserToDeleteRows = False
        Me.dgv_adm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_adm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_adm.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.dgv_adm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_adm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_adm.Location = New System.Drawing.Point(318, 144)
        Me.dgv_adm.Name = "dgv_adm"
        Me.dgv_adm.ReadOnly = True
        Me.dgv_adm.Size = New System.Drawing.Size(942, 454)
        Me.dgv_adm.TabIndex = 20
        '
        'btn_criar
        '
        Me.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_criar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_criar.Location = New System.Drawing.Point(1117, 620)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(143, 45)
        Me.btn_criar.TabIndex = 26
        Me.btn_criar.Text = "criar"
        Me.btn_criar.UseVisualStyleBackColor = True
        '
        'btn_deletar
        '
        Me.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_deletar.Location = New System.Drawing.Point(819, 620)
        Me.btn_deletar.Name = "btn_deletar"
        Me.btn_deletar.Size = New System.Drawing.Size(143, 45)
        Me.btn_deletar.TabIndex = 27
        Me.btn_deletar.Text = "delete"
        Me.btn_deletar.UseVisualStyleBackColor = True
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_atualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_atualizar.Location = New System.Drawing.Point(968, 620)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(143, 45)
        Me.btn_atualizar.TabIndex = 28
        Me.btn_atualizar.Text = "atualizar"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SF Pro Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 22)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ADMINISTRADOR"
        '
        'frm_paineldoadm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.btn_deletar)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.dgv_adm)
        Me.Controls.Add(Me.pnl_funcionalidades2)
        Me.Controls.Add(Me.pnl_funcionalidades)
        Me.Font = New System.Drawing.Font("SF Pro Text", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "frm_paineldoadm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EASYBARBER"
        Me.pnl_funcionalidades.ResumeLayout(False)
        CType(Me.btn_aumentar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_diminuir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_funcionalidades2.ResumeLayout(False)
        Me.pnl_funcionalidades2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_adm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_usuario As Label
    Friend WithEvents pnl_funcionalidades As Panel
    Friend WithEvents btn_aumentar As PictureBox
    Friend WithEvents btn_diminuir As PictureBox
    Friend WithEvents btn_sair As PictureBox
    Friend WithEvents pnl_funcionalidades2 As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_todosatendimentos As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgv_adm As DataGridView
    Friend WithEvents btn_criar As Button
    Friend WithEvents btn_deletar As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents Label1 As Label
End Class
