Public Class Form_Editar_Cliente
    Private Sub Form_Editar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Try
            Dim funciones As New FMostrarClientes
            Dim logica As New VClientes

            If txt_Nombre.Text = "" Or txt_Identificacion.Text = "" Then
                MsgBox("¡DEBE RELLENAR LOS CAMPOS!")
            Else
                logica.gId = txt_Id.Text
                logica.gNombre = txt_Nombre.Text
                logica.gDireccion = txt_Direccion.Text
                logica.gTelefono = txt_Telefono.Text
                logica.gIdentificacion = txt_Identificacion.Text
                logica.gFecha_Registro = box_Fecha_Registro.Value.ToString
            End If

            If funciones.FNuevoCliente(logica) Then
                MsgBox("¡CLIENTE ACTUALIZADO!")
                Me.Close()
                Form_Registro_Cliente.Mostrar()
            End If
        Catch ex As Exception
            MsgBox("NO SE REALIZO LA ACTUALIZACION")
        End Try
    End Sub

End Class