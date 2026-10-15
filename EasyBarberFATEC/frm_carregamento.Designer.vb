<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_carregamento
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_carregamento))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.link_creditos2 = New System.Windows.Forms.LinkLabel()
        Me.link_creditos1 = New System.Windows.Forms.LinkLabel()
        Me.lbl_creditos = New System.Windows.Forms.Label()
        Me.lbl_copyrights = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("SF Pro Text", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(285, 190)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(293, 66)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "EasyBarber"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(222, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(73, 301)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(659, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(69, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Carregando..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'link_creditos2
        '
        Me.link_creditos2.ActiveLinkColor = System.Drawing.Color.White
        Me.link_creditos2.AutoSize = True
        Me.link_creditos2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_creditos2.Font = New System.Drawing.Font("SF Pro Text", 8.25!, System.Drawing.FontStyle.Underline)
        Me.link_creditos2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.link_creditos2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.link_creditos2.Location = New System.Drawing.Point(356, 540)
        Me.link_creditos2.Name = "link_creditos2"
        Me.link_creditos2.Size = New System.Drawing.Size(75, 15)
        Me.link_creditos2.TabIndex = 12
        Me.link_creditos2.TabStop = True
        Me.link_creditos2.Text = "Ricardo Akira"
        '
        'link_creditos1
        '
        Me.link_creditos1.ActiveLinkColor = System.Drawing.Color.White
        Me.link_creditos1.AutoSize = True
        Me.link_creditos1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_creditos1.Font = New System.Drawing.Font("SF Pro Text", 8.25!, System.Drawing.FontStyle.Underline)
        Me.link_creditos1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.link_creditos1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.link_creditos1.Location = New System.Drawing.Point(255, 540)
        Me.link_creditos1.Name = "link_creditos1"
        Me.link_creditos1.Size = New System.Drawing.Size(96, 15)
        Me.link_creditos1.TabIndex = 11
        Me.link_creditos1.TabStop = True
        Me.link_creditos1.Text = "Gustavo Tarcitani"
        '
        'lbl_creditos
        '
        Me.lbl_creditos.AutoSize = True
        Me.lbl_creditos.Font = New System.Drawing.Font("SF Pro Text", 8.0!)
        Me.lbl_creditos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_creditos.Location = New System.Drawing.Point(212, 540)
        Me.lbl_creditos.Name = "lbl_creditos"
        Me.lbl_creditos.Size = New System.Drawing.Size(376, 15)
        Me.lbl_creditos.TabIndex = 10
        Me.lbl_creditos.Text = "© 2024 Gustavo Tarcitani e Ricardo Akira. Todos os direitos reservados."
        Me.lbl_creditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_copyrights
        '
        Me.lbl_copyrights.Font = New System.Drawing.Font("SF Pro Text", 8.0!)
        Me.lbl_copyrights.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_copyrights.Location = New System.Drawing.Point(37, 547)
        Me.lbl_copyrights.Name = "lbl_copyrights"
        Me.lbl_copyrights.Size = New System.Drawing.Size(726, 51)
        Me.lbl_copyrights.TabIndex = 9
        Me.lbl_copyrights.Text = "Este software foi criado com dedicação e é protegido por leis de direitos autorai" &
    "s. Qualquer uso, reprodução ou distribuição sem autorização prévia é proibido."
        Me.lbl_copyrights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SF Pro Text", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(292, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Simplifique a gestão da sua barbearia."
        '
        'frm_carregamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.link_creditos2)
        Me.Controls.Add(Me.link_creditos1)
        Me.Controls.Add(Me.lbl_creditos)
        Me.Controls.Add(Me.lbl_copyrights)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Font = New System.Drawing.Font("SF Pro Text", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_carregamento"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EASYBARBER - ""Simplifique a gestão da sua barbearia."""
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents link_creditos2 As LinkLabel
    Friend WithEvents link_creditos1 As LinkLabel
    Friend WithEvents lbl_creditos As Label
    Friend WithEvents lbl_copyrights As Label
    Friend WithEvents Label2 As Label
End Class
