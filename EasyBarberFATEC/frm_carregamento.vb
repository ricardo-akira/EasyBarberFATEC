Public Class frm_carregamento
    Private Sub frm_carregamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura o intervalo do Timer para 1000 milissegundos (1 segundo)
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With ProgressBar1
            Static x = 0
            If .Value + 10 < 100 Then
                .Value += 10
            Else
                .Value = 100
            End If

            ' Incrementa x a cada tick
            x += 1

            If x >= 12 Then
                Timer1.Enabled = False
                Me.Close()
            End If
        End With
    End Sub
End Class