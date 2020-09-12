Imports System.Data.SqlClient
Public Class FMostrar_Productos
    Inherits FConexion
    Dim cmd As New SqlCommand
    Public Function FnMostrarProductos() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarProductos")
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
            Dim da As New SqlDataAdapter("Select * from Productos where (Id_Producto like '" & busqueda + "%" & "') Or (Nombre_Producto like '" & "%" + busqueda + "%" & "') Or (Tipo_Producto like '" & busqueda + "%" & "')", cnn)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            dgv.Columns(0).HeaderText = "ID"
            dgv.Columns(1).HeaderText = "NOMBRE PRODUCTO"
            dgv.Columns(2).HeaderText = "COMPRA"
            dgv.Columns(3).HeaderText = "VENTA"
            dgv.Columns(4).HeaderText = "CANTIDAD"
            dgv.Columns(5).HeaderText = "TIPO PRODUCTO"
            dgv.Columns(6).HeaderText = "FECHA REGISTRO"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function FNuevoProducto(ByRef dts As VProductos) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("ModificarProductos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId)
            cmd.Parameters.AddWithValue("@Nombre_Producto", dts.gNombre)
            cmd.Parameters.AddWithValue("@Precio_Compra", dts.gPrecio_Compra)
            cmd.Parameters.AddWithValue("@Precio_Venta", dts.gPrecio_Venta)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)
            cmd.Parameters.AddWithValue("@Tipo_Producto", dts.gTipo_Prod)
            cmd.Parameters.AddWithValue("@Fecha_Registro", dts.gFecha_Registro)

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

    Public Sub FormatoMoneda(ByRef txBox As TextBox)
        If txBox.Text = String.Empty Then
            Return
        Else
            Dim valor As Decimal
            valor = Convert.ToDecimal(txBox.Text)
            txBox.Text = valor.ToString("#,##0.00")
        End If
    End Sub

    Public Sub FormatoDecimal(ByRef txBox As TextBox)
        If txBox.Text = String.Empty Then
            Return
        Else
            Dim valor As Decimal
            valor = Convert.ToDecimal(txBox.Text)
        End If
    End Sub
End Class
