Imports MySql.Data.MySqlClient
Public Class FrmCiudadesEliminar
    Private datos As MySqlDataReader

    Private Sub FrmCiudadesEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM ciudad WHERE id_ciudad=" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                TxtCiudad.Text = datos("nombre_ciudad")
            End While
        End If
        datos.Close()
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCiudades)()
        Me.Dispose()
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "DELETE FROM `biblioteca`.`ciudad` WHERE (`id_ciudad` = '" & misfunciones.getId & "');"
        mibd.sentencias(sql)
        frmMenu.AbrirFormEnPanel(Of GestionCiudades)()
        Me.Dispose()

    End Sub

End Class