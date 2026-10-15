Imports System.Data.OleDb

Public Class frm_paineldobarbeiro
    Public Property Usuario As String

    Private Sub frm_paineldobarbeiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        lbl_usuario.Text = Usuario ' Atualiza o lbl_usuario com o nome do usuário
        lbl_usuario.Font = New Font(lbl_usuario.Font, FontStyle.Bold) ' Define o texto como negrito
        CarregarAgendamentos() ' Carrega todos os agendamentos no DataGridView
    End Sub

    Private Sub pcb_logout_Click(sender As Object, e As EventArgs)
        lbl_usuario.Text = "" ' Reseta o lbl_usuario
        frm_login.Show() ' Mostra o formulário de login
        Me.Close() ' Fecha o formulário de painel
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit() ' Encerra a aplicação por completo
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        lbl_usuario.Text = "" ' Reseta o lbl_usuario
        frm_login.Show() ' Mostra o formulário de login
        Me.Close() ' Fecha o formulário de painel
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
                dv.RowFilter = "nomebarbeiro = '" & lbl_usuario.Text & "'"
                dgv_barbeiro.DataSource = dv ' Define a fonte de dados do DataGridView
            End Using
        Catch ex As Exception
            MsgBox("Erro ao carregar agendamentos: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
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
                dv.RowFilter = "nomebarbeiro = '" & lbl_usuario.Text & "' AND dia = #" & dtp_data.Value.ToString("MM/dd/yyyy") & "#"
                dgv_barbeiro.DataSource = dv ' Define a fonte de dados do DataGridView
            End Using
        Catch ex As Exception
            MsgBox("Erro ao carregar agendamentos: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

End Class



