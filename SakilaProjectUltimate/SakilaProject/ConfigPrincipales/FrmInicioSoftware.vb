Public Class FrmInicioSoftware
    Private Sub FrmInicioSoftware_Load(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BarraProgreso.Increment(1)
        If BarraProgreso.Value = 30 Then
            LblProceso.Text = "Iniciando..."
        End If
        If BarraProgreso.Value = 60 Then
            LblProceso.Text = "Cargando base de datos..."
        End If
        If BarraProgreso.Value = 80 Then
            LblProceso.Text = "Verificando Bibliotecario..."
        End If
        If BarraProgreso.Value = 100 Then
            LoginInicio.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class