Imports MySql.Data.MySqlClient
Public Class FrmUsuarioEditar
    Private datos As MySqlDataReader
    Private id_campus, id_carrera As Integer
    Private cambioscampus, cambioscarrera As Integer

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()
        Me.Dispose()
    End Sub

    Private Sub FrmUsuarioEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarcarrera()
        cargarcampus()
        misfunciones.seleccionCb(Cbcarrera, id_carrera)
        misfunciones.seleccionCb(CBcampus, id_campus)
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM usuario INNER JOIN campus ON campus.id_campus=usuario.id_campus INNER JOIN carrera ON carrera.id_carrera=usuario.id_carrera WHERE id_usuario=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtNombre.Text = datos("Nombre")
                Cbcarrera.Text = datos("nombre_carrera")
                TxtApellido.Text = datos("Apellido")
                TxtTelefono.Text = datos("Telefono")
                CBcampus.Text = datos("nombre_campus")
                TxtEdad.Text = datos("edad")
                TxtDireccion.Text = datos("Direccion")
                TxtIdentidad.Text = datos("Num_identidad")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub cargarcarrera()
        Cbcarrera.Items.Clear()
        Dim sql As String = "select * from carrera"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcarrera.Items.Add(New Elementos(datos("nombre_carrera"), datos("id_carrera")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub Cbcarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbcarrera.SelectedIndexChanged
        cambioscarrera = 1
    End Sub

    Private Sub CBcampus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBcampus.SelectedIndexChanged
        cambioscampus = 1
    End Sub

    Private Sub cargarcampus()
        CBcampus.Items.Clear()
        Dim sql As String = "select * from campus"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBcampus.Items.Add(New Elementos(datos("nombre_campus"), datos("id_campus")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_usuario As Integer = 0
        'Update() `biblioteca`.`usuario` Set `id_carrera` = '3', `id_campus` = '2', `Nombre` = 'Marcias', `Apellido` = 'Anaa', `Telefono` = '98568033', `edad` = '21', `Direccion` = 'La Rivieras', `Num_Identidad` = '0101-1999-345872' WHERE (`id_usuario` = '10');
        'cambios carerra es igual a autor
        'cambios campus es igual a editorial
        If Trim(TxtNombre.Text) <> "" And Trim(TxtApellido.Text) <> "" And Trim(TxtEdad.Text) <> "" And Trim(TxtDireccion.Text) <> "" Then
            If cambioscarrera = 1 And cambioscampus = 0 Then
                sql = "Update `biblioteca`.`usuario` Set `id_carrera` = '" & Cbcarrera.SelectedItem.value & "', `id_campus` = '" & misfunciones.getId2 &
                               "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text &
                               "', `edad` = '" & TxtEdad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `Num_Identidad` = '" & TxtIdentidad.Text & "' WHERE `id_usuario`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
            ElseIf cambioscampus = 1 And cambioscarrera = 0 Then
                sql = "Update `biblioteca`.`usuario` Set `id_carrera` = '" & misfunciones.getId1 & "', `id_campus` = '" & CBcampus.SelectedItem.value &
                               "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text &
                               "', `edad` = '" & TxtEdad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `Num_Identidad` = '" & TxtIdentidad.Text & "' WHERE `id_usuario`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
            ElseIf cambioscampus = 1 And cambioscarrera = 1 Then
                sql = "Update `biblioteca`.`usuario` Set `id_carrera` = '" & Cbcarrera.SelectedItem.value & "', `id_campus` = '" & CBcampus.SelectedItem.value &
                               "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text &
                               "', `edad` = '" & TxtEdad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `Num_Identidad` = '" & TxtIdentidad.Text & "' WHERE `id_usuario`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)

            ElseIf cambioscampus = 0 And cambioscarrera = 0 Then
                sql = "Update `biblioteca`.`usuario` Set `id_carrera` = '" & misfunciones.getId1 & "', `id_campus` = '" & misfunciones.getId2 & "', `Nombre` = '" & TxtNombre.Text & "', `Apellido` = '" & TxtApellido.Text & "', `Telefono` = '" & TxtTelefono.Text & "', `edad` = '" & TxtEdad.Text & "', `Direccion` = '" & TxtDireccion.Text & "', `Num_Identidad` = '" & TxtIdentidad.Text & "' WHERE `id_usuario`='" & misfunciones.getId & "';"
                mibd.sentencias(sql)
            End If
            frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()

            Me.Dispose()
        Else
            MsgBox("Ingrese todos los campos")
        End If

    End Sub
End Class