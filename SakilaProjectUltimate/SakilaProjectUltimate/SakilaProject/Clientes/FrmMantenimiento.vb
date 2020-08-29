Public Class FrmMantenimiento

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' En esta funcion [frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()]
    '''  se manda a llamar desde el formulario principal la funcion "ABRIR FORM DENTRO DEL PANEL"
    '''  para que en los demas formularios se muestren dentro del form Principal
    ''' </summary>
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles BtnConfigUsuario.Click
        frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()
    End Sub

    Private Sub BtnConfigLibro_Click(sender As Object, e As EventArgs) Handles BtnConfigLibro.Click
        frmMenu.AbrirFormEnPanel(Of GestionLibros)()
    End Sub

    Private Sub BtnConfigBibliotecario_Click(sender As Object, e As EventArgs) Handles BtnConfigBibliotecario.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
    End Sub

    Private Sub BtnConfigEjemplares_Click(sender As Object, e As EventArgs) Handles BtnConfigEjemplares.Click
        frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
    End Sub
End Class