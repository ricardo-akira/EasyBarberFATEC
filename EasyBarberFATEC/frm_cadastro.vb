Public Class frm_cadastro
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        ' Verifica se todos os campos estão preenchidos
        If txt_cpf.Text = "" Or txt_nome.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub ' Interrompe o processo de salvamento
        End If

        ' Verifica se o CPF já está cadastrado
        sql = "SELECT * FROM tb_clientes WHERE cpf = '" & txt_cpf.Text & "'" ' Monta a string SQL para verificar se o CPF já existe
        rs = db.Execute(sql) ' Executa a instrução SQL
        If Not rs.EOF Then
            MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub ' Interrompe o processo de salvamento
        End If

        Try
            ' Monta a string SQL para inserir os dados na tabela tb_clientes
            sql = "INSERT INTO tb_clientes (cpf, nome, email, senha) VALUES ('" & txt_cpf.Text & "','" &
                                                                                  txt_nome.Text & "','" &
                                                                                  txt_email.Text & "','" &
                                                                                  txt_senha.Text & "')"

            ' Executa a instrução SQL
            rs = db.Execute(UCase(sql))

            limpar_camposlogin() ' Limpa os campos do formulário de login
            ' Exibe uma mensagem de sucesso
            MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            ' Limpa os campos do formulário
            limpar_camposcliente()
        Catch ex As Exception
            ' Exibe uma mensagem de erro
            MsgBox("Erro ao gravar os dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco() ' Conecta ao banco de dados
        txt_nome.TextAlign = HorizontalAlignment.Center ' Centraliza o texto no TextBox
        txt_email.TextAlign = HorizontalAlignment.Center ' Centraliza o texto no TextBox
        txt_senha.TextAlign = HorizontalAlignment.Center ' Centraliza o texto no TextBox
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit() ' Encerra a aplicação por completo
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close() ' Fecha o formulário de cadastro
        frm_login.Show() ' Mostra o formulário de login
    End Sub
End Class