Public Class Form_Editar_Usuario
    Dim conexion As New FConexion
    Private Sub Form_Editar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLenarTodosLosUsuarios()
    End Sub

    Private Sub AgregarHeaders()
        DGUsuarios.Columns(0).HeaderText = "Usuario"
        DGUsuarios.Columns(1).HeaderText = "Contrasena"
        DGUsuarios.Columns(2).HeaderText = "Identificacion"
        DGUsuarios.Columns(3).HeaderText = "Nombre completo"
        DGUsuarios.Columns(4).HeaderText = "Telefono"
        DGUsuarios.Columns(5).HeaderText = "Direccion"
        DGUsuarios.Columns(6).HeaderText = "Privilegios"
        DGUsuarios.Columns(7).HeaderText = "Fecha registro"
    End Sub
    Private Sub LLenarTodosLosUsuarios()
        Dim sql As String
        sql = "select * from Usuarios"
        Dim ds As New DataSet
        ds = conexion.Consultas(sql)
        If ds.Tables(0).Rows.Count > 0 Then
            DGUsuarios.DataSource = ds.Tables(0).DefaultView
            AgregarHeaders()
            DGUsuarios.Visible = True
        Else
            MsgBox("Aun no ha ingresado ningun Usuario")
            DGUsuarios.Visible = False
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellContentClick
        llenarDatos()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DGUsuarios.DoubleClick
        llenarDatos()
    End Sub

    Private Sub llenarDatos()
        If DGUsuarios.SelectedRows.Count > -1 Then
            Dim i As Integer
            i = DGUsuarios.CurrentRow.Index
            txtUsuario.Text = DGUsuarios.Item(0, i).Value().ToString
            txtContrasena.Text = DGUsuarios.Item(1, i).Value().ToString
            txtIdentidad.Text = DGUsuarios.Item(2, i).Value().ToString
            txtNombreCompleto.Text = DGUsuarios.Item(3, i).Value().ToString
            txtTelefono.Text = DGUsuarios.Item(4, i).Value().ToString
            txtDireccion.Text = DGUsuarios.Item(5, i).Value().ToString
            Dim tipo As Boolean = DGUsuarios.Item(6, i).Value()
            If tipo Then
                CBTipoUsuario.SelectedIndex = 1
            Else
                CBTipoUsuario.SelectedIndex = 0
            End If
        Else
            MsgBox("Debe seleccionar un proveedor")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        llenarDatos()
    End Sub

    Private Sub DGUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellClick
        llenarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarDatos()
    End Sub

    Private Sub EditarDatos()
        Dim nombreUsuario As String = txtUsuario.Text.Trim
        Dim contrasena As String = txtContrasena.Text.Trim
        Dim identidad As String = txtIdentidad.Text.Trim
        Dim nombreCompleto As String = txtNombreCompleto.Text.Trim
        Dim telefono As String = txtTelefono.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim
        Dim tipoUsuario As Integer = CBTipoUsuario.SelectedIndex
        If nombreUsuario <> "" And contrasena <> "" And nombreCompleto <> "" Then
            Dim sql As String
            sql = "exec ModificarUsuarios '" & nombreUsuario & "','" & contrasena & "','" & identidad & "','" & nombreCompleto & "','" & telefono & "','" & direccion & "','" & tipoUsuario & "'"
            conexion.Modificaciones(sql)
            MsgBox("Usuario Actualizado correctamente")
            LLenarTodosLosUsuarios()
        Else
            MsgBox("Debe llenar todos los datos")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Registro_Usuario.ShowDialog()
        LLenarTodosLosUsuarios()
    End Sub
End Class