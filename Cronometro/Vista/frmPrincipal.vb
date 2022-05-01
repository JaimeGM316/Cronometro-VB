Public Class frmPrincipal
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000

        If nudContador.Value = 59 Then
            Timer1.Stop()
        Else
            nudContador.Value += 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 1000

        If nudContador.Value = 0 Then
            Timer2.Stop()
        Else
            nudContador.Value -= 1
        End If
    End Sub
    'Empezar
    Private Sub btEmpezar_Click(sender As Object, e As EventArgs) Handles btEmpezar.Click
        Timer1.Start()
        Timer2.Stop()
    End Sub
    Private Sub EmpezarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpezarToolStripMenuItem.Click
        Timer1.Start()
        Timer2.Stop()
    End Sub

    'Parar
    Private Sub btParar_Click(sender As Object, e As EventArgs) Handles btParar.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub
    Private Sub PararToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PararToolStripMenuItem.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    'Cuenta atras
    Private Sub btCuentaAtras_Click(sender As Object, e As EventArgs) Handles btCuentaAtras.Click
        Timer1.Stop()
        Timer2.Start()
    End Sub
    Private Sub CuentaAtrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaAtrasToolStripMenuItem.Click
        Timer1.Stop()
        Timer2.Start()
    End Sub

    'Reset
    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        nudContador.Value = 0
    End Sub
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        nudContador.Value = 0
    End Sub

    'Finalizar
    Private Sub FinalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizarToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class