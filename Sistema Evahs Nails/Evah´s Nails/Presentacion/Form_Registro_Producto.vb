Public Class Form_Registro_Producto
    Dim dt As New DataTable
    Dim bd As New FMostrar_Productos

    Private Sub Form_Registro_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Public Sub Mostrar()
        Try
            Dim func As New FMostrar_Productos
            dt = func.FnMostrarProductos

            If dt.Rows.Count <> 0 Then
                dgv_Tabla_Producto.DataSource = dt
                dgv_Tabla_Producto.Columns(0).HeaderText = "ID"
                dgv_Tabla_Producto.Columns(1).HeaderText = "NOMBRE PRODUCTO"
                dgv_Tabla_Producto.Columns(2).HeaderText = "COMPRA"
                dgv_Tabla_Producto.Columns(3).HeaderText = "VENTA"
                dgv_Tabla_Producto.Columns(4).HeaderText = "CANTIDAD"
                dgv_Tabla_Producto.Columns(5).HeaderText = "TIPO PRODUCTO"
                dgv_Tabla_Producto.Columns(6).HeaderText = "FECHA REGISTRO"

                Dim registros As String = dgv_Tabla_Producto.Rows.Count.ToString
                lbl_Total_Productos.Text = "Total Productos: " + registros
            Else
                dgv_Tabla_Producto.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_Buscar.TextChanged
        bd.BusquedaDinamica(txt_Buscar.Text, dgv_Tabla_Producto)
    End Sub

    Private Sub dgv_Tabla_Producto_CellContentClick() Handles dgv_Tabla_Producto.CellContentClick
        Dim i As Integer
        i = dgv_Tabla_Producto.CurrentRow.Index

        txt_Id.Text = dgv_Tabla_Producto.Item(0, i).Value().ToString
        txt_Nombre.Text = dgv_Tabla_Producto.Item(1, i).Value().ToString
        txt_Compra.Text = dgv_Tabla_Producto.Item(2, i).Value().ToString
        txt_Venta.Text = dgv_Tabla_Producto.Item(3, i).Value().ToString
        txt_Cantidad.Text = dgv_Tabla_Producto.Item(4, i).Value().ToString
        cBox_Tipo.Text = dgv_Tabla_Producto.Item(5, i).Value().ToString
        dtp_Fecha.Value = dgv_Tabla_Producto.Item(6, i).Value().ToString
    End Sub

    Public Sub FormatoMoneda(ByVal txBox As TextBox)
        bd.FormatoMoneda(txBox)
    End Sub

    Public Sub FormatoDecimal(ByRef txBox As TextBox)
        bd.FormatoDecimal(txBox)
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Try
            Dim funciones As New FMostrar_Productos
            Dim logica As New VProductos

            logica.gId = txt_Id.Text
            logica.gNombre = txt_Nombre.Text
            logica.gCantidad = txt_Cantidad.Text
            logica.gPrecio_Compra = txt_Compra.Text
            logica.gPrecio_Venta = txt_Venta.Text
            logica.gTipo_Prod = cBox_Tipo.SelectedItem.ToString
            logica.gFecha_Registro = dtp_Fecha.Value.ToString

            If funciones.FNuevoProducto(logica) Then
                MsgBox("¡AGREGADO CORRECTAMENTE!")
                Mostrar()
                txt_Id.Text = ""
                txt_Nombre.Text = ""
                txt_Cantidad.Text = ""
                txt_Compra.Text = ""
                txt_Venta.Text = ""
                cBox_Tipo.SelectedItem = ""
            End If
        Catch ex As Exception
            MsgBox("DEBE RELLENAR TODOS LOS CAMPOS")
        End Try
    End Sub

    Private Sub txt_Compra_Leave(sender As Object, e As EventArgs) Handles txt_Compra.Leave
        FormatoMoneda(txt_Compra)
    End Sub

    Private Sub txt_Venta_Leave(sender As Object, e As EventArgs) Handles txt_Venta.Leave
        FormatoMoneda(txt_Venta)
    End Sub

    Private Sub txt_Cantidad_Leave(sender As Object, e As EventArgs) Handles txt_Cantidad.Leave
        FormatoDecimal(txt_Cantidad)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_Tabla_Producto.SelectedRows.Count <> 0 Then
            dgv_Tabla_Producto_CellContentClick()
        Else
            Form_Editar_Cliente.Close()
            MsgBox("DEBE SELECCIONAR UN PRODUCTO")
        End If
    End Sub
End Class