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

    Private Sub box_Fecha_Registro_ValueChanged(sender As Object, e As EventArgs) Handles box_Fecha_Registro.ValueChanged

    End Sub

    Private Sub txt_Direccion_TextChanged(sender As Object, e As EventArgs) Handles txt_Direccion.TextChanged

    End Sub

    Private Sub txt_Identificacion_TextChanged(sender As Object, e As EventArgs) Handles txt_Identificacion.TextChanged

    End Sub

    Private Sub txt_Telefono_TextChanged(sender As Object, e As EventArgs) Handles txt_Telefono.TextChanged

    End Sub

    Private Sub txt_Nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_Nombre.TextChanged

    End Sub

    Private Sub lbl_Fecha_Registro_Click(sender As Object, e As EventArgs) Handles lbl_Fecha_Registro.Click

    End Sub

    Private Sub lbl_Direccion_Click(sender As Object, e As EventArgs) Handles lbl_Direccion.Click

    End Sub

    Private Sub lbl_Identificacion_Click(sender As Object, e As EventArgs) Handles lbl_Identificacion.Click

    End Sub

    Private Sub lbl_Telefono_Click(sender As Object, e As EventArgs) Handles lbl_Telefono.Click

    End Sub

    Private Sub lbl_Nombre_Click(sender As Object, e As EventArgs) Handles lbl_Nombre.Click

    End Sub
End Class