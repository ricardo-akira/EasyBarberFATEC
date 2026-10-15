Public Class frm_login
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit() ' Encerra a aplicação por completo
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco() ' Conecta ao banco de dados
        frm_carregamento.ShowDialog() ' Mostra o formulário de carregamento
        txt_senha.UseSystemPasswordChar = True ' Configura o txt_senha para usar caracteres de senha inicialmente
        txt_senha.TextAlign = HorizontalAlignment.Center ' Centraliza o texto no TextBox
    End Sub

    Private Sub ckb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_mostrarSenha.CheckedChanged
        If ckb_mostrarSenha.Checked Then
            txt_senha.UseSystemPasswordChar = False ' Mostra a senha
        Else
            txt_senha.UseSystemPasswordChar = True ' Esconde a senha
        End If
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_cpf.Text <> "" And txt_senha.Text <> "" Then
                Dim nomeUsuario As String = ""

                ' Verificar na tabela tb_adms
                sql = "SELECT * FROM tb_adms WHERE cpf = '" & txt_cpf.Text & "' AND senha = '" & txt_senha.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    nomeUsuario = rs.Fields("nome").Value
                    Dim frmPainelAdm As New frm_paineldoadm()
                    frmPainelAdm.Usuario = nomeUsuario ' Define a propriedade Usuario no formulário frm_paineldoadm
                    frmPainelAdm.Show()
                    Me.Hide()
                    Exit Sub
                End If

                ' Verificar na tabela tb_clientes
                sql = "SELECT * FROM tb_clientes WHERE cpf = '" & txt_cpf.Text & "' AND senha = '" & txt_senha.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    nomeUsuario = rs.Fields("nome").Value
                    Dim frmPainelCliente As New frm_paineldocliente()
                    frmPainelCliente.Usuario = nomeUsuario ' Define a propriedade Usuario no formulário frm_paineldocliente
                    frmPainelCliente.Show()
                    Me.Hide()
                    Exit Sub
                End If

                ' Verificar na tabela tb_barbeiros
                sql = "SELECT * FROM tb_barbeiros WHERE cpf = '" & txt_cpf.Text & "' AND senha = '" & txt_senha.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    nomeUsuario = rs.Fields("nome").Value
                    Dim frmPainelBarbeiro As New frm_paineldobarbeiro()
                    frmPainelBarbeiro.Usuario = nomeUsuario ' Define a propriedade Usuario no formulário frm_paineldobarbeiro
                    frmPainelBarbeiro.Show()
                    Me.Hide()
                    Exit Sub
                End If

                ' Se não encontrar em nenhuma tabela
                MsgBox("CPF ou senha inválidos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                MsgBox("Por favor, preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_redirecionarCadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_redirecionarCadastro.LinkClicked
        frm_cadastro.Show()
    End Sub
End Class