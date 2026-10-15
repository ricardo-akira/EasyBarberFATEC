<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.btn_sair = New System.Windows.Forms.PictureBox()
        Me.btn_aumentar = New System.Windows.Forms.PictureBox()
        Me.btn_diminuir = New System.Windows.Forms.PictureBox()
        Me.pnl_funcionalidades = New System.Windows.Forms.Panel()
        Me.lbl_statusBanco = New System.Windows.Forms.Label()
        Me.pcb_icon2 = New System.Windows.Forms.PictureBox()
        Me.lbl_copyrights = New System.Windows.Forms.Label()
        Me.lbl_creditos = New System.Windows.Forms.Label()
        Me.link_creditos1 = New System.Windows.Forms.LinkLabel()
        Me.link_creditos2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcb_icon1 = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_redirecionarCadastro = New System.Windows.Forms.LinkLabel()
        Me.ckb_mostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.btn_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_aumentar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_diminuir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_funcionalidades.SuspendLayout()
        CType(Me.pcb_icon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_entrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sair
        '
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btn_sair, "btn_sair")
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.TabStop = False
        '
        'btn_aumentar
        '
        Me.btn_aumentar.Cursor = System.Windows.Forms.Cursors.No
        resources.ApplyResources(Me.btn_aumentar, "btn_aumentar")
        Me.btn_aumentar.Name = "btn_aumentar"
        Me.btn_aumentar.TabStop = False
        '
        'btn_diminuir
        '
        Me.btn_diminuir.Cursor = System.Windows.Forms.Cursors.No
        resources.ApplyResources(Me.btn_diminuir, "btn_diminuir")
        Me.btn_diminuir.Name = "btn_diminuir"
        Me.btn_diminuir.TabStop = False
        '
        'pnl_funcionalidades
        '
        Me.pnl_funcionalidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnl_funcionalidades.Controls.Add(Me.lbl_statusBanco)
        Me.pnl_funcionalidades.Controls.Add(Me.pcb_icon2)
        Me.pnl_funcionalidades.Controls.Add(Me.btn_aumentar)
        Me.pnl_funcionalidades.Controls.Add(Me.btn_diminuir)
        Me.pnl_funcionalidades.Controls.Add(Me.btn_sair)
        resources.ApplyResources(Me.pnl_funcionalidades, "pnl_funcionalidades")
        Me.pnl_funcionalidades.Name = "pnl_funcionalidades"
        '
        'lbl_statusBanco
        '
        resources.ApplyResources(Me.lbl_statusBanco, "lbl_statusBanco")
        Me.lbl_statusBanco.Name = "lbl_statusBanco"
        '
        'pcb_icon2
        '
        resources.ApplyResources(Me.pcb_icon2, "pcb_icon2")
        Me.pcb_icon2.Name = "pcb_icon2"
        Me.pcb_icon2.TabStop = False
        '
        'lbl_copyrights
        '
        resources.ApplyResources(Me.lbl_copyrights, "lbl_copyrights")
        Me.lbl_copyrights.Name = "lbl_copyrights"
        '
        'lbl_creditos
        '
        resources.ApplyResources(Me.lbl_creditos, "lbl_creditos")
        Me.lbl_creditos.Name = "lbl_creditos"
        '
        'link_creditos1
        '
        Me.link_creditos1.ActiveLinkColor = System.Drawing.Color.White
        resources.ApplyResources(Me.link_creditos1, "link_creditos1")
        Me.link_creditos1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_creditos1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.link_creditos1.Name = "link_creditos1"
        Me.link_creditos1.TabStop = True
        '
        'link_creditos2
        '
        Me.link_creditos2.ActiveLinkColor = System.Drawing.Color.White
        resources.ApplyResources(Me.link_creditos2, "link_creditos2")
        Me.link_creditos2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_creditos2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.link_creditos2.Name = "link_creditos2"
        Me.link_creditos2.TabStop = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'pcb_icon1
        '
        resources.ApplyResources(Me.pcb_icon1, "pcb_icon1")
        Me.pcb_icon1.Name = "pcb_icon1"
        Me.pcb_icon1.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txt_cpf, "txt_cpf")
        Me.txt_cpf.ForeColor = System.Drawing.Color.White
        Me.txt_cpf.Name = "txt_cpf"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txt_senha, "txt_senha")
        Me.txt_senha.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'btn_entrar
        '
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btn_entrar, "btn_entrar")
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btn_redirecionarCadastro
        '
        Me.btn_redirecionarCadastro.ActiveLinkColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btn_redirecionarCadastro, "btn_redirecionarCadastro")
        Me.btn_redirecionarCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_redirecionarCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.btn_redirecionarCadastro.LinkColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_redirecionarCadastro.Name = "btn_redirecionarCadastro"
        Me.btn_redirecionarCadastro.TabStop = True
        '
        'ckb_mostrarSenha
        '
        resources.ApplyResources(Me.ckb_mostrarSenha, "ckb_mostrarSenha")
        Me.ckb_mostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckb_mostrarSenha.Name = "ckb_mostrarSenha"
        Me.ckb_mostrarSenha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'frm_login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ckb_mostrarSenha)
        Me.Controls.Add(Me.btn_redirecionarCadastro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.pcb_icon1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.link_creditos2)
        Me.Controls.Add(Me.link_creditos1)
        Me.Controls.Add(Me.lbl_creditos)
        Me.Controls.Add(Me.lbl_copyrights)
        Me.Controls.Add(Me.pnl_funcionalidades)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.btn_sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_aumentar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_diminuir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_funcionalidades.ResumeLayout(False)
        Me.pnl_funcionalidades.PerformLayout()
        CType(Me.pcb_icon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb_icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_entrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_sair As PictureBox
    Friend WithEvents btn_aumentar As PictureBox
    Friend WithEvents btn_diminuir As PictureBox
    Friend WithEvents pnl_funcionalidades As Panel
    Friend WithEvents lbl_copyrights As Label
    Friend WithEvents lbl_creditos As Label
    Friend WithEvents link_creditos1 As LinkLabel
    Friend WithEvents link_creditos2 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents pcb_icon1 As PictureBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_entrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_redirecionarCadastro As LinkLabel
    Friend WithEvents ckb_mostrarSenha As CheckBox
    Friend WithEvents pcb_icon2 As PictureBox
    Friend WithEvents lbl_statusBanco As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
