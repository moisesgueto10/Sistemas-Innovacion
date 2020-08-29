Imports MySql.Data.MySqlClient
Public Class FrmUsuarioEliminar
    Private datos As MySqlDataReader
    Private id_campus, id_carrera As Integer

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()
        Me.Dispose()
    End Sub

    Private Sub FrmUsuarioEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarcarrera()
        cargarcampus()
        misfunciones.seleccionCb(Cbcarrera, id_carrera)
        misfunciones.seleccionCb(CBcampus, id_campus)
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
                TxtEdad.Text = datos("fecha_de_nacimiento")
                TxtDireccion.Text = datos("Direccion")
                TxtIdentidad.Text = datos("Num_identidad")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_usuario As Integer = 0

        sql = "DELETE FROM `biblioteca`.`usuario` WHERE (`id_usuario` = '" & misfunciones.getId & "');"

        mibd.sentencias(sql)

        frmMenu.AbrirFormEnPanel(Of GestionUsuarios)()
        Me.Dispose()
    End Sub
End Class