Public Class frm_paineldocliente
    Public Property Usuario As String

    Private Sub frm_paineldocliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco() ' Conecta ao banco de dados
        limpar_camposlogin() ' Limpa os campos de login
        lbl_usuario.Text = Usuario ' Atualiza o lbl_usuario com o nome do usuário
        txt_nome.Text = lbl_usuario.Text ' Puxa o nome do lbl_usuario para o txt_nome
        carregar_barbeiros() ' Carrega a lista de barbeiros
        carregar_servicos() ' Carrega a lista de serviços
        configurarIntervaloDeTempo() ' Configura o intervalo de tempo para o agendamento
        lbl_preco.Text = "VALOR: " ' Define o texto inicial do lbl_preco
    End Sub

    Private Sub pcb_logout_Click(sender As Object, e As EventArgs)
        lbl_usuario.Text = "" ' Reseta o lbl_usuario
        frm_login.Show() ' Mostra o formulário de login
        Me.Close() ' Fecha o formulário de painel
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit() ' Encerra a aplicação por completo
    End Sub

    Private Sub carregar_barbeiros()
        Try
            Dim sql As String = "SELECT nome FROM tb_barbeiros" ' Monta a string SQL para selecionar os nomes dos barbeiros
            Dim rs As Object = db.Execute(sql) ' Executa a instrução SQL
            cmb_barbeiros.Items.Clear() ' Limpa os itens do combobox de barbeiros
            Do While Not rs.EOF
                cmb_barbeiros.Items.Add(rs.Fields("nome").Value) ' Adiciona o nome do barbeiro ao combobox
                rs.MoveNext() ' Move para o próximo registro
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar barbeiros: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub carregar_servicos()
        Try
            Dim sql As String = "SELECT servico, preco FROM tb_servicos" ' Monta a string SQL para selecionar os serviços e preços
            Dim rs As Object = db.Execute(sql) ' Executa a instrução SQL
            cmb_servico.Items.Clear() ' Limpa os itens do combobox de serviços
            Do While Not rs.EOF
                cmb_servico.Items.Add(rs.Fields("servico").Value) ' Adiciona o serviço ao combobox
                rs.MoveNext() ' Move para o próximo registro
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar serviços: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub configurarIntervaloDeTempo()
        Try
            txt_hora.Format = DateTimePickerFormat.Time ' Define o formato do DateTimePicker para hora
            txt_hora.ShowUpDown = True ' Mostra os botões de incremento/decremento
            txt_hora.Value = DateTime.Today.AddHours(6) ' Inicia às 06:00 AM
            txt_hora.MinDate = DateTime.Today.AddHours(6) ' Define a hora mínima para 06:00 AM
            txt_hora.MaxDate = DateTime.Today.AddHours(20) ' Define a hora máxima para 08:00 PM
        Catch ex As Exception
            MsgBox("Erro ao configurar intervalo de tempo: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub txt_hora_ValueChanged(sender As Object, e As EventArgs) Handles txt_hora.ValueChanged
        Try
            Dim selectedTime As DateTime = txt_hora.Value ' Obtém o valor selecionado no DateTimePicker
            Dim minutes As Integer = selectedTime.Minute ' Obtém os minutos do valor selecionado

            ' Arredonda para o intervalo de 1 hora mais próximo
            If minutes <> 0 Then
                txt_hora.Value = New DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, selectedTime.Hour, 0, 0) ' Arredonda para a hora cheia
            End If

            ' Verifica se o horário está dentro do intervalo permitido
            If txt_hora.Value.TimeOfDay < TimeSpan.FromHours(6) OrElse txt_hora.Value.TimeOfDay > TimeSpan.FromHours(20) Then
                MsgBox("Por favor, selecione um horário entre 06:00 AM e 08:00 PM.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso") ' Exibe uma mensagem de aviso
                txt_hora.Value = DateTime.Today.AddHours(6) ' Reseta o valor para 06:00 AM
            End If
        Catch ex As Exception
            MsgBox("Erro ao selecionar a hora: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub txt_data_ValueChanged(sender As Object, e As EventArgs) Handles txt_data.ValueChanged
        Try
            ' Verifica se a data é uma segunda-feira, está no passado ou mais de um ano no futuro
            If txt_data.Value.DayOfWeek = DayOfWeek.Monday OrElse txt_data.Value < DateTime.Now OrElse txt_data.Value > DateTime.Today.AddYears(1) Then
                MsgBox("Por favor, selecione uma data válida (entre terça-feira e domingo, não no passado e dentro de um ano).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso") ' Exibe uma mensagem de aviso
                txt_data.Value = DateTime.Today ' Reseta o valor para a data atual
            End If
        Catch ex As Exception
            MsgBox("Erro ao selecionar a data: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub txt_data_DropDown(sender As Object, e As EventArgs) Handles txt_data.DropDown
        Try
            ' Incrementa a data até que não seja segunda-feira
            While txt_data.Value.DayOfWeek = DayOfWeek.Monday
                txt_data.Value = txt_data.Value.AddDays(1)
            End While
        Catch ex As Exception
            MsgBox("Erro ao abrir o seletor de data: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub cmb_servico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_servico.SelectedIndexChanged
        Try
            If cmb_servico.SelectedItem IsNot Nothing Then
                ' Obtém o preço do serviço selecionado
                Dim sql As String = "SELECT preco FROM tb_servicos WHERE servico = '" & cmb_servico.SelectedItem.ToString() & "'"
                Dim rs As Object = db.Execute(sql) ' Executa a instrução SQL
                If Not rs.EOF Then
                    Dim preco As Decimal = rs.Fields("preco").Value ' Obtém o preço do serviço
                    lbl_preco.Text = "VALOR: R$ " & preco.ToString("F2") ' Atualiza o lbl_preco com o preço do serviço formatado
                End If
            Else
                lbl_preco.Text = "VALOR: " ' Reseta o lbl_preco se nenhum serviço estiver selecionado
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar o preço do serviço: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            ' Verifica se o termo foi aceito
            If Not ckb_termo.Checked Then
                MsgBox("Você deve aceitar os termos para agendar um atendimento.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            Dim nomeCliente As String = txt_nome.Text.ToUpper() ' Obtém o nome do cliente e converte para maiúsculas
            Dim nomeBarbeiro As String = cmb_barbeiros.SelectedItem.ToString() ' Obtém o nome do barbeiro selecionado
            Dim data As DateTime = txt_data.Value ' Obtém a data selecionada
            Dim hora As DateTime = txt_hora.Value ' Obtém a hora selecionada
            Dim tipoServico As String = cmb_servico.SelectedItem.ToString() ' Obtém o serviço selecionado

            ' Verifica se já existe um agendamento para o barbeiro no mesmo dia e horário
            Dim sqlVerifica As String = "SELECT COUNT(*) AS count FROM tb_agendamentos WHERE nomebarbeiro = '" & nomeBarbeiro & "' AND dia = '" & data.ToString("yyyy-MM-dd") & "' AND hora = '" & hora.ToString("HH:mm") & "'"
            Dim rsVerifica As Object = db.Execute(sqlVerifica) ' Executa a instrução SQL
            Dim count As Integer = rsVerifica.Fields("count").Value ' Obtém o número de agendamentos

            If count > 0 Then
                MsgBox("Já existe um agendamento para este barbeiro no mesmo dia e horário.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso") ' Exibe uma mensagem de aviso
                Exit Sub ' Interrompe o processo de agendamento
            End If

            ' Insere o novo agendamento
            Dim sql As String = "INSERT INTO tb_agendamentos (nomecliente, nomebarbeiro, dia, hora, tiposervico) VALUES ('" & nomeCliente & "', '" & nomeBarbeiro & "', '" & data.ToString("yyyy-MM-dd") & "', '" & hora.ToString("HH:mm") & "', '" & tipoServico & "')"
            db.Execute(sql) ' Executa a instrução SQL

            ' Recupera o ID do agendamento recém-criado
            Dim rs As Object = db.Execute("SELECT @@IDENTITY AS id") ' Executa a instrução SQL para obter o ID
            Dim id As Integer = rs.Fields("id").Value ' Obtém o ID do agendamento

            MsgBox("Agendamento realizado com sucesso! Número da ordem de serviço: " & id, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso") ' Exibe uma mensagem de sucesso
        Catch ex As Exception
            MsgBox("Erro ao realizar agendamento: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro") ' Exibe uma mensagem de erro
        End Try
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        ' Limpa todos os campos
        txt_data.Value = DateTime.Today ' Volta para a data atual
        cmb_barbeiros.SelectedIndex = -1 ' Define como nenhum selecionado
        cmb_servico.SelectedIndex = -1 ' Define como nenhum selecionado
        ckb_termo.Checked = False ' Desmarca o checkbox
        lbl_preco.Text = "VALOR: " ' Limpa o lbl_preco
    End Sub

    Private Sub btn_alterarcadastrocliente_Click(sender As Object, e As EventArgs) Handles btn_alterarcadastrocliente.Click
        Dim frmAlterarCadastro As New frm_alterarcadastro()
        frmAlterarCadastro.Usuario = Usuario ' Passa o nome do usuário para o formulário de alteração de cadastro
        Me.Hide() ' Esconde o formulário de painel do cliente
        frmAlterarCadastro.ShowDialog() ' Mostra o formulário de alteração de cadastro
        Me.Show() ' Mostra novamente o formulário de painel do cliente após fechar o formulário de alteração de cadastro
    End Sub

    Private Sub btn_atendimento_Click(sender As Object, e As EventArgs) Handles btn_atendimento.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit() ' Encerra a aplicação por completo
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        lbl_usuario.Text = "" ' Reseta o lbl_usuario
        frm_login.Show() ' Mostra o formulário de login
        Me.Close() ' Fecha o formulário de painel
    End Sub
End Class

