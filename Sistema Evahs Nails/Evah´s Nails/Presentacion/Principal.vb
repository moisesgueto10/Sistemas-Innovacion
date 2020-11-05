Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'METODO DE ABRIR FORMULARIO'
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = panelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() ' Busca el formulario en la coleccion

        'Si el form no fue encontrado/ no existe

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            panelFormularios.Controls.Add(Formulario)
            panelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()

        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)

        'CONDICION PARA SABER SI ESTA ABIERTO
        If (Application.OpenForms("FrmUsuarios") Is Nothing) Then
            btnUsuarios.BackColor = Color.FromArgb(64, 0, 64)
        End If

        If (Application.OpenForms("FrmClientes") Is Nothing) Then
            btnClientes.BackColor = Color.FromArgb(64, 0, 64)
        End If

        If (Application.OpenForms("FrmServicios") Is Nothing) Then
            btnServicios.BackColor = Color.FromArgb(64, 0, 64)
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TimerHorayFecha_Tick(sender As Object, e As EventArgs) Handles TimerHorayFecha.Tick
        lblHora.Text = Format(Now, "hh:mm:ss")
        lblFecha.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        AbrirFormEnPanel(Of FrmUsuarios)()
        btnUsuarios.BackColor = Color.FromArgb(80, 94, 129)

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormEnPanel(Of FrmClientes)()
        btnClientes.BackColor = Color.FromArgb(80, 94, 129)

    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        AbrirFormEnPanel(Of FrmServicios)()
        btnServicios.BackColor = Color.FromArgb(80, 94, 129)
    End Sub
End Class
