Imports System.Data.SqlClient
Public Class FMostrarClientes
    Inherits FConexion
    Dim cmd As New SqlCommand
    Public Function FnMostrarClientes() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarClientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            FnDesconectado()
        End Try
    End Function

    Sub BusquedaDinamica(ByVal busqueda As String, ByVal dgv As DataGridView)
        Try
            FnConectado()
            Dim da As New SqlDataAdapter("Select * from Clientes where (Id_Cliente like '" & busqueda + "%" & "') Or (Nombre_Completo like '" & "%" + busqueda + "%" & "')", cnn)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns(0).HeaderText = "ID"
            dgv.Columns(1).HeaderText = "NOMBRE COMPLETO"
            dgv.Columns(2).HeaderText = "DIRECCION"
            dgv.Columns(3).HeaderText = "TELEFONO"
            dgv.Columns(4).HeaderText = "IDENTIFICACION"
            dgv.Columns(5).HeaderText = "FECHA DE REGISTRO"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function FNuevoCliente(ByRef dts As VClientes) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("ModificarClientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Id_Cliente", dts.gId)
            cmd.Parameters.AddWithValue("@Nombre_Completo", dts.gNombre)
            cmd.Parameters.AddWithValue("@Direccion", dts.gDireccion)
            cmd.Parameters.AddWithValue("@Telefono", dts.gTelefono)
            cmd.Parameters.AddWithValue("@Identificacion", dts.gIdentificacion)
            cmd.Parameters.AddWithValue("@Fecha_Registro", dts.gFecha_Registro)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()
        End Try

    End Function
End Class