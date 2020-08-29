Imports MySql.Data.MySqlClient
Public Class FrmCarPorCampEliminar
    Private datos As MySqlDataReader

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCarreraPorCampus)()
        Me.Dispose()
    End Sub

    Private Sub FrmCarPorCampEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM carreras_por_campus INNER JOIN campus ON campus.id_campus=carreras_por_campus.id_campus INNER JOIN carrera ON carrera.id_carrera=carreras_por_campus.id_carrera WHERE carreras_por_campus.id_campus='" & misfunciones.getId & "' AND carreras_por_campus.id_carrera='" & misfunciones.getId1 & "';"

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBCarrera.Text = datos("nombre_carrera")
                CBcampus.Text = datos("nombre_campus")
            End While
        End If
        datos.Close()

    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = ""
        sql = "DELETE FROM `biblioteca`.`carreras_por_campus` WHERE (`id_campus` = '" & misfunciones.getId & "') and (`id_carrera` = '" & misfunciones.getId1 & "');"
        mibd.sentencias(sql)
        frmMenu.AbrirFormEnPanel(Of GestionCarreraPorCampus)()
        Me.Dispose()
    End Sub
End Class