Imports System.Data.OleDb

Public Class frm_alterarcadastro
    Public Property Usuario As String

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit() ' Encerra a aplicação por completo
    End Sub

    Private Sub btn_atendimento_Click(sender As Object, e As EventArgs) Handles btn_atendimento.Click
        Dim frmPainelCliente As New frm_paineldocliente()
        frmPainelCliente.Usuario = Usuario ' Passa o nome do usuário para o formulário de atendimento
        frmPainelCliente.Show()
        Me.Hide() ' Esconde o formulário atual
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit() ' Encerra a aplicação por completo
    End Sub

    Private Sub frm_alterarcadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        lbl_usuario.Text = Usuario ' Atualiza o lbl_usuario com o nome do usuário
        CarregarAgendamentos() ' Carrega todos os agendamentos no DataGridView
    End Sub

    Private Sub CarregarAgendamentos()
        Try
            Dim sql As String = "SELECT * FROM tb_agendamentos"
            Dim connString As String = "Provider=SQLOLEDB;Data Source=DESKTOP-A9FESKN\SQLEXPRESS;Initial Catalog=clientesDb;trusted_connection=yes;" ' Substitua pelos valores corretos
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable
                da.Fill(dt)

                ' Aplicar o filtro usando DataView
                Dim dv As New DataView(dt)
                dv.RowFilter = "nomecliente = '" & lbl_usuario.Text & "'"
                dgv_seusatendimentos.DataSource = dv ' Define a fonte de dados do DataGridView
            End Using
        Catch ex As Exception
            MsgBox("Erro ao carregar agendamentos: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_seusatendimentos.CellContentClick
        ' Código para manipular o clique na célula, se necessário
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        lbl_usuario.Text = "" ' Reseta o lbl_usuario
        frm_login.Show() ' Mostra o formulário de login
        Me.Close() ' Fecha o formulário de painel
    End Sub
End Class
