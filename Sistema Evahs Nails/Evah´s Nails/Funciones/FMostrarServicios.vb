Imports System.Data.SqlClient
Public Class FMostrarServicios
    Inherits FConexion
    Dim cmd As New SqlCommand
    Public Function FnMostrarServicios() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarServicios")
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
            Dim da As New SqlDataAdapter("Select * from Servicios where (Id_Servicio like '" & busqueda + "%" & "') Or (Nombre_Servicio like '" & "%" + busqueda + "%" & "')", cnn)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns(0).HeaderText = "ID"
            dgv.Columns(1).HeaderText = "NOMBRE SERVICIO"
            dgv.Columns(2).HeaderText = "DESCRIPCION"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function FNuevoServicio(ByRef dts As VServicios) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("ModificarServicios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Id_Servicio", dts.gId)
            cmd.Parameters.AddWithValue("@Nombre_Servicio", dts.gNombre)
            cmd.Parameters.AddWithValue("@Descripcion_Servicio", dts.gDescripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR AL INTENTAR REGISTRAR")
            Return False
        Finally
            FnDesconectado()
        End Try

    End Function
End Class
