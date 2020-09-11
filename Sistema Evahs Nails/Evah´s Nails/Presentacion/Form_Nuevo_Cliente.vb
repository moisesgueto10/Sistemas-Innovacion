Public Class Form_Nuevo_Cliente
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Try
            Dim funciones As New FMostrarClientes
            Dim logica As New VClientes

            If txt_Nombre.Text = "" Or txt_Identificacion.Text = "" Then
                MsgBox("¡DEBE RELLENAR LOS CAMPOS!")
            Else
                logica.gNombre = txt_Nombre.Text
                logica.gDireccion = txt_Direccion.Text
                logica.gTelefono = txt_Telefono.Text
                logica.gIdentificacion = txt_Identificacion.Text
                logica.gFecha_Registro = box_Fecha_Registro.Value.ToString
            End If

            If funciones.FNuevoCliente(logica) Then
                MsgBox("¡AGREGADO CORRECTAMENTE!")
                Me.Close()
                Form_Registro_Cliente.Mostrar()
            End If
        Catch ex As Exception
            MsgBox("NO SE REALIZO EL REGISTRO")
        End Try
    End Sub
End Class