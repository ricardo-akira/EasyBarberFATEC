<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_paineldocliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_paineldocliente))
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.pnl_funcionalidades = New System.Windows.Forms.Panel()
        Me.btn_aumentar = New System.Windows.Forms.PictureBox()
        Me.btn_diminuir = New System.Windows.Forms.PictureBox()
        Me.btn_sair = New System.Windows.Forms.PictureBox()
        Me.pnl_funcionalidades2 = New System.Windows.Forms.Panel()
        Me.btn_atendimento = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_alterarcadastrocliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_preco = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_servico = New System.Windows.Forms.ComboBox()
        Me.txt_hora = New System.Windows.Forms.DateTimePicker()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.cmb_barbeiros = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckb_termo = New System.Windows.Forms.CheckBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.pcb_complemento = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.pnl_funcionalidades.SuspendLayout()
        CType(Me.btn_aumentar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_diminuir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_funcionalidades2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pcb_complemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Location = New System.Drawing.Point(9, 134)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(283, 52)
        Me.lbl_usuario.TabIndex = 1
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
        Me.pnl_funcionalidades.TabIndex = 16
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
        Me.pnl_funcionalidades2.Controls.Add(Me.btn_logout)
        Me.pnl_funcionalidades2.Controls.Add(Me.btn_atendimento)
        Me.pnl_funcionalidades2.Controls.Add(Me.Button2)
        Me.pnl_funcionalidades2.Controls.Add(Me.Label2)
        Me.pnl_funcionalidades2.Controls.Add(Me.btn_alterarcadastrocliente)
        Me.pnl_funcionalidades2.Controls.Add(Me.PictureBox1)
        Me.pnl_funcionalidades2.Controls.Add(Me.lbl_titulo)
        Me.pnl_funcionalidades2.Controls.Add(Me.lbl_usuario)
        Me.pnl_funcionalidades2.Controls.Add(Me.Label1)
        Me.pnl_funcionalidades2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_funcionalidades2.Location = New System.Drawing.Point(0, 32)
        Me.pnl_funcionalidades2.Name = "pnl_funcionalidades2"
        Me.pnl_funcionalidades2.Size = New System.Drawing.Size(297, 688)
        Me.pnl_funcionalidades2.TabIndex = 17
        '
        'btn_atendimento
        '
        Me.btn_atendimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_atendimento.FlatAppearance.BorderSize = 0
        Me.btn_atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_atendimento.Image = CType(resources.GetObject("btn_atendimento.Image"), System.Drawing.Image)
        Me.btn_atendimento.Location = New System.Drawing.Point(26, 247)
        Me.btn_atendimento.Name = "btn_atendimento"
        Me.btn_atendimento.Size = New System.Drawing.Size(237, 37)
        Me.btn_atendimento.TabIndex = 19
        Me.btn_atendimento.Text = " Agendar atendimento"
        Me.btn_atendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_atendimento.UseVisualStyleBackColor = True
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
        'btn_alterarcadastrocliente
        '
        Me.btn_alterarcadastrocliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alterarcadastrocliente.FlatAppearance.BorderSize = 0
        Me.btn_alterarcadastrocliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alterarcadastrocliente.Image = CType(resources.GetObject("btn_alterarcadastrocliente.Image"), System.Drawing.Image)
        Me.btn_alterarcadastrocliente.Location = New System.Drawing.Point(26, 290)
        Me.btn_alterarcadastrocliente.Name = "btn_alterarcadastrocliente"
        Me.btn_alterarcadastrocliente.Size = New System.Drawing.Size(237, 37)
        Me.btn_alterarcadastrocliente.TabIndex = 11
        Me.btn_alterarcadastrocliente.Text = "  Seus atendimentos"
        Me.btn_alterarcadastrocliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_alterarcadastrocliente.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SF Pro Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(70, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Seja bem-vindo(a):"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_nome.Location = New System.Drawing.Point(123, 66)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.ReadOnly = True
        Me.txt_nome.Size = New System.Drawing.Size(706, 30)
        Me.txt_nome.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SF Pro Text", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(570, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(483, 51)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Agendar um atendimento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_preco)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmb_servico)
        Me.GroupBox1.Controls.Add(Me.txt_hora)
        Me.GroupBox1.Controls.Add(Me.txt_data)
        Me.GroupBox1.Controls.Add(Me.cmb_barbeiros)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ckb_termo)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 469)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'lbl_preco
        '
        Me.lbl_preco.Font = New System.Drawing.Font("SF Pro Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco.Location = New System.Drawing.Point(619, 404)
        Me.lbl_preco.Name = "lbl_preco"
        Me.lbl_preco.Size = New System.Drawing.Size(234, 36)
        Me.lbl_preco.TabIndex = 29
        Me.lbl_preco.Text = "VALOR:"
        Me.lbl_preco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 22)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Selecione o tipo de serviço:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 22)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Selecione um horário:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Selecione uma data:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 22)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Selecione o profissional:"
        '
        'cmb_servico
        '
        Me.cmb_servico.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmb_servico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmb_servico.FormattingEnabled = True
        Me.cmb_servico.Location = New System.Drawing.Point(252, 298)
        Me.cmb_servico.Name = "cmb_servico"
        Me.cmb_servico.Size = New System.Drawing.Size(577, 30)
        Me.cmb_servico.TabIndex = 24
        '
        'txt_hora
        '
        Me.txt_hora.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_hora.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_hora.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_hora.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_hora.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txt_hora.Location = New System.Drawing.Point(226, 240)
        Me.txt_hora.MaxDate = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.txt_hora.MinDate = New Date(2024, 11, 1, 0, 0, 0, 0)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.ShowUpDown = True
        Me.txt_hora.Size = New System.Drawing.Size(603, 30)
        Me.txt_hora.TabIndex = 23
        '
        'txt_data
        '
        Me.txt_data.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_data.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_data.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_data.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_data.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(226, 182)
        Me.txt_data.MaxDate = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.txt_data.MinDate = New Date(2024, 11, 1, 0, 0, 0, 0)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(603, 30)
        Me.txt_data.TabIndex = 22
        '
        'cmb_barbeiros
        '
        Me.cmb_barbeiros.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmb_barbeiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_barbeiros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmb_barbeiros.FormattingEnabled = True
        Me.cmb_barbeiros.Location = New System.Drawing.Point(226, 124)
        Me.cmb_barbeiros.MaxDropDownItems = 10
        Me.cmb_barbeiros.Name = "cmb_barbeiros"
        Me.cmb_barbeiros.Size = New System.Drawing.Size(603, 30)
        Me.cmb_barbeiros.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Seu nome:"
        '
        'ckb_termo
        '
        Me.ckb_termo.AutoSize = True
        Me.ckb_termo.Font = New System.Drawing.Font("SF Pro Text", 8.0!)
        Me.ckb_termo.Location = New System.Drawing.Point(98, 369)
        Me.ckb_termo.Name = "ckb_termo"
        Me.ckb_termo.Size = New System.Drawing.Size(677, 19)
        Me.ckb_termo.TabIndex = 19
        Me.ckb_termo.Text = "Entendo que não comparecer sem aviso prévio pode resultar em penalidades, incluin" &
    "do restrições temporárias na minha conta."
        Me.ckb_termo.UseVisualStyleBackColor = True
        '
        'btn_salvar
        '
        Me.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_salvar.Location = New System.Drawing.Point(894, 635)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(326, 45)
        Me.btn_salvar.TabIndex = 24
        Me.btn_salvar.Text = "Solicitar Atendimento"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_limpar.Location = New System.Drawing.Point(349, 635)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(143, 45)
        Me.btn_limpar.TabIndex = 25
        Me.btn_limpar.Text = "Limpar campos"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'pcb_complemento
        '
        Me.pcb_complemento.Image = CType(resources.GetObject("pcb_complemento.Image"), System.Drawing.Image)
        Me.pcb_complemento.Location = New System.Drawing.Point(519, 69)
        Me.pcb_complemento.Name = "pcb_complemento"
        Me.pcb_complemento.Size = New System.Drawing.Size(50, 56)
        Me.pcb_complemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_complemento.TabIndex = 26
        Me.pcb_complemento.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Location = New System.Drawing.Point(13, 596)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(263, 37)
        Me.btn_logout.TabIndex = 27
        Me.btn_logout.Text = "Logout do app"
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'frm_paineldocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pcb_complemento)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
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
        Me.Name = "frm_paineldocliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agende um horário - EasyBarber"
        Me.pnl_funcionalidades.ResumeLayout(False)
        CType(Me.btn_aumentar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_diminuir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_funcionalidades2.ResumeLayout(False)
        Me.pnl_funcionalidades2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pcb_complemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_usuario As Label
    Friend WithEvents pnl_funcionalidades As Panel
    Friend WithEvents btn_aumentar As PictureBox
    Friend WithEvents btn_diminuir As PictureBox
    Friend WithEvents btn_sair As PictureBox
    Friend WithEvents pnl_funcionalidades2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_alterarcadastrocliente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ckb_termo As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_servico As ComboBox
    Friend WithEvents txt_hora As DateTimePicker
    Friend WithEvents txt_data As DateTimePicker
    Friend WithEvents cmb_barbeiros As ComboBox
    Friend WithEvents lbl_preco As Label
    Friend WithEvents pcb_complemento As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_atendimento As Button
    Friend WithEvents btn_logout As Button
End Class
