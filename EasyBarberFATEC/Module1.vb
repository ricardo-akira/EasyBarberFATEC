Module Module1
    Public db As ADODB.Connection 'variavel do banco de dados
    Public rs As ADODB.Recordset 'variavel de tabela
    Public sql, diretorio, aux_cpf, resp As String 'variavel de querys (gravar, excluir, alterar e consultar)
    Public cont As Integer 'variavel de contagem
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-A9FESKN\SQLEXPRESS;initial catalog=clientesDb;trusted_connection=yes")
            'MsgBox("Conectado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro na conexão com o banco de dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_camposcliente()
        With frm_cadastro
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_senha.Clear()
            .txt_cpf.Focus()
        End With
    End Sub

    Sub limpar_camposlogin()
        With frm_login
            .txt_cpf.Clear()
            .txt_senha.Clear()
            .txt_cpf.Focus()
        End With
    End Sub

End Module


