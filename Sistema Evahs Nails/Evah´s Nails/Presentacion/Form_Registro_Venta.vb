Imports System.Data
Public Class Form_Registro_Venta
    Dim codigoFactura As Integer
    Dim conexion As FConexion = New FConexion()
    Dim signoStock As String
    Private Sub Form_Registro_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Evahs_NailsDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        ' Me.ServiciosTableAdapter.Fill(Me.Evahs_NailsDataSet.Servicios)
        Llenardatagrid()
        CodVentas()
        llenarComboBoxServicios()
    End Sub

    Private Sub llenarComboBoxServicios()

        Dim sql As String
        sql = "select Id_Servicio, Nombre_Servicio from Servicios"
        Dim ds As New DataSet
        ds = conexion.Consultas(sql)

        CBNombreServicio.DataSource = ds.Tables(0)
        CBNombreServicio.ValueMember = "Id_Servicio"
        CBNombreServicio.DisplayMember = "Nombre_Servicio"

    End Sub
    Private Sub CodVentas()
        Dim dsa As New DataSet
        Dim sql As String = "select MAX(Id_Ventas) from Ventas"
        dsa = conexion.Consultas(sql)
        If IsDBNull(dsa.Tables(0).Rows(0)(0)) Then
            codigoFactura = 1
        Else
            codigoFactura = Integer.Parse(dsa.Tables(0).Rows(0)(0)) + 1
        End If
        lblFacturaNumero.Text = codigoFactura
    End Sub

    Private Sub Llenardatagrid()
        DGFactura.Columns.Add("Id_Venta", "N° Factura")
        DGFactura.Columns.Add("tipo", "Tipo")
        DGFactura.Columns.Add("codigo", "Codigo")
        DGFactura.Columns.Add("descripcion", "Descripcion")
        DGFactura.Columns.Add("Cantidad", "Cantidad")
        DGFactura.Columns.Add("Precio Individual", "Precio Individual")
        DGFactura.Columns.Add("Precio_Total", "Precio Total")
        DGFactura.Columns.Add("Estado", "Estado")
        CBEstadoProducto.SelectedIndex = 1
        CBEstadoServicio.SelectedIndex = 1
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        ingresarProducto()
    End Sub

    Private Sub VarciarProductos()
        txtCodigoProducto.Text = ""
        txtPrecioProducto.Text = ""
        txtDescripcionProducto.Text = ""
        txtCantidadProducto.Value = 0
        txtStockProducto.Value = 0
        CBEstadoProducto.SelectedIndex = 1
    End Sub

    Private Sub ingresarProducto()
        Dim codigoProducto As String = txtCodigoProducto.Text.Trim
        Dim descripcionProducto As String = txtDescripcionProducto.Text.Trim
        Dim precioProducto As String = txtPrecioProducto.Text.Trim
        Dim cantidadProducto As Integer = txtCantidadProducto.Value
        Dim estadoProducto As String = CBEstadoProducto.Text

        If codigoProducto <> "" And descripcionProducto <> "" And precioProducto <> "" And cantidadProducto <> 0 Then
            DGFactura.Rows.Add(codigoFactura, "Producto", codigoProducto, descripcionProducto, cantidadProducto, precioProducto, Convert.ToDecimal(precioProducto) * cantidadProducto, estadoProducto)
            signoStock = "-"
            modificarStock2()
            VarciarProductos()
        Else
            MsgBox("Campos vacios")
        End If
    End Sub
    Private Sub ingresarServicio()
        Dim codigoServicio As String = CBNombreServicio.SelectedValue
        Dim descripcionServicio As String = CBNombreServicio.Text
        Dim precioServicio As String = txtPrecioServicio.Text.Trim
        Dim cantidadServicio As Integer = txtCantidadServicio.Value
        Dim estadoServicio As String = CBEstadoServicio.Text

        If descripcionServicio <> "" And precioServicio <> "" And cantidadServicio <> 0 Then
            DGFactura.Rows.Add(codigoFactura, "Servicio", codigoServicio, descripcionServicio, cantidadServicio, precioServicio, Convert.ToDecimal(precioServicio) * cantidadServicio, estadoServicio)
        Else
            MsgBox("Informacion incompleta (Campos vacios, cantidad igual a 0, etc.")
        End If
    End Sub

    Private Sub VaciarServicios()
        txtPrecioServicio.Text = ""
        txtCantidadServicio.Value = 1
        CBEstadoServicio.SelectedIndex = 1
    End Sub

    Private Sub vaciarProductos()
        txtPrecioProducto.Text = ""
        txtDescripcionProducto.Text = ""
        txtCantidadProducto.Value = 0
        txtStockProducto.Value = 0
        btnAgregarProducto.Enabled = False
    End Sub
    Private Sub btnAgregarServicio_Click(sender As Object, e As EventArgs) Handles btnAgregarServicio.Click
        ingresarServicio()
        VaciarServicios()
    End Sub

    Private Sub CBEstadoProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEstadoProducto.SelectedIndexChanged

    End Sub

    Private Sub txtCantidadProducto_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidadProducto.ValueChanged
        If txtCantidadProducto.Value > txtStockProducto.Value Then
            txtCantidadProducto.Value = txtStockProducto.Value
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarVentaYDetallesDeVenta()
    End Sub

    Private Sub btnGuardarEImprimir_Click(sender As Object, e As EventArgs) Handles btnGuardarEImprimir.Click
        GuardarVentaYDetallesDeVenta()
        ImprimirFactura()
    End Sub

    Private Sub GuardarVentaYDetallesDeVenta()
        Try
            Dim sql As String = "exec ModificarVentas " & codigoFactura & ",'Hugo_Sanabria',3,'" & Date.Now.ToString("yyyy-MM-dd") & "'"
            conexion.Modificaciones(sql)
            For x = 0 To DGFactura.Rows.Count - 1
                Dim tipo As String = Convert.ToString(DGFactura.Rows.Item(x).Cells(1).Value)
                If tipo = "Producto" Then
                    Dim codigoProducto As String = DGFactura.Rows.Item(x).Cells(2).Value
                    Dim precioProducto As String = DGFactura.Rows.Item(x).Cells(5).Value
                    Dim cantidadProducto As String = DGFactura.Rows.Item(x).Cells(4).Value
                    Dim estadoProducto As String = DGFactura.Rows.Item(x).Cells(7).Value
                    Dim sqlProducto As String = "exec InsertarVentaDetalleProductos " & codigoFactura & ",'"
                    conexion.Modificaciones(sqlProducto)
                ElseIf tipo = "Servicio" Then
                    Dim sqlServicio As String = "exec "
                    conexion.Modificaciones(sqlServicio)
                End If
            Next
        Catch ex As Exception

        End Try



    End Sub

    Private Sub ImprimirFactura()

    End Sub

    Private Sub txtCodigoProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoProducto.TextChanged
        Dim dt As New DataSet

        If txtCodigoProducto.TextLength >= 0 Then
            Try
                Dim sql As String = "Select * from Productos where Id_Producto='" & txtCodigoProducto.Text & "' and Tipo_Producto='VENTA'"
                dt = conexion.Consultas(sql)
                If dt.Tables(0).Rows.Count > 0 Then
                    txtDescripcionProducto.Text = dt.Tables(0).Rows(0)(1)
                    txtPrecioProducto.Text = dt.Tables(0).Rows(0)(3)
                    txtStockProducto.Text = dt.Tables(0).Rows(0)(4)
                    txtCantidadProducto.Maximum = dt.Tables(0).Rows(0)(4)
                    If dt.Tables(0).Rows(0)(4) >= 1 Then
                        txtCantidadProducto.Value = 1
                    End If
                    btnAgregarProducto.Enabled = True
                Else
                    btnAgregarProducto.Enabled = False
                    vaciarProductos()
                End If

            Catch
                MessageBox.Show("Producto no encontrado", "Error de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        If txtDescripcionProducto.Text.Trim = "" Then
            vaciarProductos()
        End If
    End Sub

    Private Sub DGFactura_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DGFactura.UserDeletedRow

    End Sub

    Private Sub modificarStock()
        Dim i As Integer
        i = DGFactura.CurrentRow.Index
        Dim codigoProducto As String = DGFactura.Item(2, i).Value().ToString
        Dim cantidadProducto As String = DGFactura.Item(4, i).Value().ToString
        Dim sql As String = "exec ModificarStockProductoVenta '" & codigoProducto & "'," & signoStock & cantidadProducto & ""
        conexion.Modificaciones(sql)
    End Sub
    Private Sub modificarStock2()
        Dim i As Integer
        i = DGFactura.CurrentRow.Index
        Dim codigoProducto As String = txtCodigoProducto.Text
        Dim cantidadProducto As Integer = txtCantidadProducto.Value
        Dim sql As String = "exec ModificarStockProductoVenta '" & codigoProducto & "'," & signoStock & cantidadProducto & ""
        conexion.Modificaciones(sql)
    End Sub

    Private Sub DGFactura_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DGFactura.UserDeletingRow
        signoStock = ""
        modificarStock()
        vaciarProductos()
        txtCodigoProducto.Text = ""
    End Sub
End Class