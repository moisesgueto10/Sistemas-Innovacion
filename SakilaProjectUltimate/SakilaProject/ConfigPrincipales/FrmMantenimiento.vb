Public Class FrmMantenimiento

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

#Region "PANTALLAS DE MANTENIMIENTO"

    ''' <summary>
    ''' En esta funcion [frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()]
    '''  se manda a llamar desde el formulario principal la funcion "ABRIR FORM DENTRO DEL PANEL"
    '''  para que en los demas formularios se muestren dentro del form Principal
    ''' </summary>
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles BtnConfigUsuario.Click
        frmMenu.AbrirFormEnPanel(Of GestionAlumnos)()
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

    Private Sub BtnConfigCarrera_Click(sender As Object, e As EventArgs) Handles BtnConfigCarrera.Click
        If misfunciones.getIdusuario <> "root" Then
            MsgBox("Solo el usuario root puede modificar este apartado")
        Else
            frmMenu.AbrirFormEnPanel(Of GestionCarrera)()
        End If

    End Sub

    Private Sub BtnConfigAutor_Click(sender As Object, e As EventArgs) Handles BtnConfigAutor.Click
        frmMenu.AbrirFormEnPanel(Of GestionAutor)()
    End Sub

    Private Sub BtnConfigCampus_Click(sender As Object, e As EventArgs) Handles BtnConfigCampus.Click
        If misfunciones.getIdusuario <> "root" Then
            MsgBox("Solo el usuario root puede modificar este apartado")
        Else
            frmMenu.AbrirFormEnPanel(Of GestionCampus)()
        End If

    End Sub

    Private Sub BtnConfigEditorial_Click(sender As Object, e As EventArgs) Handles BtnConfigEditorial.Click
        frmMenu.AbrirFormEnPanel(Of GestionEditorial)()
    End Sub

    Private Sub BtnConfigCarreraPorCampus_Click(sender As Object, e As EventArgs) Handles BtnConfigCarreraPorCampus.Click
        frmMenu.AbrirFormEnPanel(Of GestionCarreraPorCampus)()
    End Sub

    Private Sub BtnConfigCiudades_Click(sender As Object, e As EventArgs) Handles BtnConfigCiudades.Click
        If misfunciones.getIdusuario <> "root" Then
            MsgBox("Solo el usuario root puede modificar este apartado")
        Else
            frmMenu.AbrirFormEnPanel(Of GestionCiudades)()
        End If

    End Sub

    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

End Class