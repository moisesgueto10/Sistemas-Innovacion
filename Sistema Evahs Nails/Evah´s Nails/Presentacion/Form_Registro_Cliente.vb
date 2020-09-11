Imports System.Data.SqlClient
Public Class Form_Registro_Cliente
    Dim dt As New DataTable
    Dim bd As New FMostrarClientes
    Dim da As New SqlDataAdapter
    Private Sub Form_Registro_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Public Sub Mostrar()
        Try
            Dim func As New FMostrarClientes
            dt = func.FnMostrarClientes

            If dt.Rows.Count <> 0 Then
                data_TablaClientes.DataSource = dt
                data_TablaClientes.Columns(0).HeaderText = "ID"
                data_TablaClientes.Columns(1).HeaderText = "NOMBRE COMPLETO"
                data_TablaClientes.Columns(2).HeaderText = "DIRECCION"
                data_TablaClientes.Columns(3).HeaderText = "TELEFONO"
                data_TablaClientes.Columns(4).HeaderText = "IDENTIFICACION"
                data_TablaClientes.Columns(5).HeaderText = "FECHA DE REGISTRO"
                Dim registros As String = data_TablaClientes.Rows.Count.ToString
                lbl_TotalRegistros.Text = "Total Registros: " + registros
            Else
                data_TablaClientes.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_Buscar.TextChanged
        bd.BusquedaDinamica(txt_Buscar.Text, data_TablaClientes)
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Form_Nuevo_Cliente.Show()
    End Sub


    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If data_TablaClientes.SelectedRows.Count <> 0 Then
            Form_Editar_Cliente.Show()
            data_TablaClientes_CellContentClick()
        Else
            Form_Editar_Cliente.Close()
            MsgBox("DEBE SELECCIONAR UN CLIENTE")
        End If
    End Sub

    Private Sub data_TablaClientes_CellContentClick() Handles data_TablaClientes.CellContentClick
        Dim i As Integer
        i = data_TablaClientes.CurrentRow.Index

        Form_Editar_Cliente.txt_Id.Text = data_TablaClientes.Item(0, i).Value().ToString
        Form_Editar_Cliente.txt_Nombre.Text = data_TablaClientes.Item(1, i).Value().ToString
        Form_Editar_Cliente.txt_Direccion.Text = data_TablaClientes.Item(2, i).Value().ToString
        Form_Editar_Cliente.txt_Telefono.Text = data_TablaClientes.Item(3, i).Value().ToString
        Form_Editar_Cliente.txt_Identificacion.Text = data_TablaClientes.Item(4, i).Value().ToString
        Form_Editar_Cliente.box_Fecha_Registro.Value() = data_TablaClientes.Item(5, i).Value().ToString

    End Sub
End Class