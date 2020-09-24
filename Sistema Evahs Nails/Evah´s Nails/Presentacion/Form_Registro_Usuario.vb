Public Class Form_Registro_Usuario
    Dim conexion As New FConexion
    Dim UsuarioExistente As Boolean = False


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        comprobarNombreUsuario()
        If UsuarioExistente Then
            MsgBox("Usuario Existente")
        ElseIf UsuarioExistente = False Then
            InsertarUsuario()
        End If
    End Sub

    Private Sub InsertarUsuario()
        Dim nombreUsuario As String = txtUsuario.Text.Trim
        Dim contrasena As String = txtContrasena.Text.Trim
        Dim identidad As String = txtIdentidad.Text.Trim
        Dim nombreCompleto As String = txtNombreCompleto.Text.Trim
        Dim telefono As String = txtTelefono.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim
        Dim tipoUsuario As Integer = CBTipoUsuario.SelectedIndex
        If nombreUsuario <> "" And contrasena <> "" And nombreCompleto <> "" Then
            Dim sql As String
            sql = "exec InsertarUsuarios '" & nombreUsuario & "','" & contrasena & "','" & identidad & "','" & nombreCompleto & "','" & telefono & "','" & direccion & "','" & tipoUsuario & "','" & Date.Now.ToString("yyyy-MM-dd") & "'"
            conexion.Modificaciones(sql)
            MsgBox("Usuario Ingresado correctamente")
            Me.Dispose()
        Else
            MsgBox("Debe llenar todos los datos")
        End If

    End Sub

    Private Sub comprobarNombreUsuario()
        Try
            Dim sql As String
            sql = "SELECT * FROM Usuarios WHERE Nombre_Usuario='" & txtUsuario.Text.Trim & "'"
            Dim ds As New DataSet
            ds = conexion.Consultas(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                UsuarioExistente = True
            Else
                UsuarioExistente = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Form_Registro_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBTipoUsuario.SelectedIndex = 0
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class