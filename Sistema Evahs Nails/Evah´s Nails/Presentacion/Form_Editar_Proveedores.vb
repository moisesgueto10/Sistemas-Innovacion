Public Class Form_Editar_Proveedores
    Dim conexion As New FConexion
    Private Sub Form_Editar_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProveedores()

    End Sub

    Private Sub AgregarHeaders()
        DGProveedores.Columns(0).HeaderText = "Codigo"
        DGProveedores.Columns(1).HeaderText = "Nombre"
        DGProveedores.Columns(2).HeaderText = "Correo"
        DGProveedores.Columns(3).HeaderText = "Telefono"
        DGProveedores.Columns(4).HeaderText = "Direccion"
    End Sub
    Private Sub llenarProveedores()
        Dim sql As String
        sql = "select * from Proveedores"
        Dim ds As New DataSet
        ds = conexion.Consultas(sql)
        If ds.Tables(0).Rows.Count > 0 Then
            DGProveedores.DataSource = ds.Tables(0).DefaultView
            AgregarHeaders()
            DGProveedores.Visible = True
        Else
            DGProveedores.Visible = False
            MsgBox("Aun no ha ingresado ningun proveedor")
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        llenarDatos()
    End Sub

    Private Sub llenarDatos()
        If DGProveedores.SelectedRows.Count Then
            Dim i As Integer
            i = DGProveedores.CurrentRow.Index
            txtCodigo.Text = DGProveedores.Item(0, i).Value().ToString
            txtUsuario.Text = DGProveedores.Item(1, i).Value().ToString
            txtCorreo.Text = DGProveedores.Item(2, i).Value().ToString
            txtTelefono.Text = DGProveedores.Item(3, i).Value().ToString
            txtDireccion.Text = DGProveedores.Item(4, i).Value().ToString
        Else
            MsgBox("Debe seleccionar un proveedor")
        End If


    End Sub

    Private Sub DGProveedores_DoubleClick(sender As Object, e As EventArgs) Handles DGProveedores.DoubleClick
        llenarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarProveedor()
    End Sub

    Private Sub EditarProveedor()

        Dim codigoProveedor As String = txtCodigo.Text.Trim
        If codigoProveedor <> "" Then
            Dim nombreProveedor As String = txtUsuario.Text.Trim
            Dim correo As String = txtCorreo.Text.Trim
            Dim telefono As String = txtTelefono.Text.Trim
            Dim direccion As String = txtDireccion.Text.Trim
            If nombreProveedor <> "" Then
                Dim sql As String
                sql = "exec ModificarProveedores '" & codigoProveedor & "','" & nombreProveedor & "','" & correo & "','" & telefono & "','" & direccion & "'"
                conexion.Modificaciones(sql)
                borrarTextBox()
                MsgBox("Proveedor actualizado correctamente")
                llenarProveedores()
            Else
                MsgBox("Debe ingresar el nombre del proveedor")
            End If
        Else
            MsgBox("Debe seleccionar un proveedor primero para editarlo")
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarProveedor()
    End Sub

    Private Sub eliminarProveedor()
        Dim codigoProveedor As String = txtCodigo.Text.Trim
        If codigoProveedor <> "" Then
            Dim sql As String = "Delete from Proveedores WHERE Id_Proveedor=" & codigoProveedor
            conexion.Modificaciones(sql)
            MsgBox("Proveedor eliminado")
            borrarTextBox()
            llenarProveedores()
        Else
            MsgBox("Debe seleccionar un proveedor primero para eliminarlo")
        End If

    End Sub

    Private Sub borrarTextBox()
        txtCodigo.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtUsuario.Text = ""
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Form_Registro_Proveedores.ShowDialog()
        llenarProveedores()
    End Sub

    Private Sub Form_Editar_Proveedores_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        llenarProveedores()
    End Sub
End Class