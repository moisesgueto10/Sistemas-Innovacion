Public Class Form_Registro_Proveedores
    Dim conexion As New FConexion
    Dim codigoProveedor As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        InsertarProveedor()
    End Sub

    Private Sub InsertarProveedor()
        Dim nombreProveedor As String = txtUsuario.Text.Trim
        Dim correo As String = txtCorreo.Text.Trim
        Dim telefono As String = txtTelefono.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim
        If nombreProveedor <> "" Then
            Dim sql As String
            sql = "exec ModificarProveedores '" & codigoProveedor & "','" & nombreProveedor & "','" & correo & "','" & telefono & "','" & direccion & "'"
            conexion.Modificaciones(sql)
            MsgBox("Proveedor Ingresado correctamente")
            Me.Dispose()
        Else
            MsgBox("Debe ingresar el nombre del proveedor")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub CodProveedor()
        Dim dsa As New DataSet
        Dim sql As String = "select MAX(Id_Proveedor) from Proveedores"
        dsa = conexion.Consultas(sql)
        If IsDBNull(dsa.Tables(0).Rows(0)(0)) Then
            codigoProveedor = 1
        Else
            codigoProveedor = Integer.Parse(dsa.Tables(0).Rows(0)(0)) + 1
        End If
    End Sub

    Private Sub Form_Registro_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CodProveedor()
    End Sub
End Class