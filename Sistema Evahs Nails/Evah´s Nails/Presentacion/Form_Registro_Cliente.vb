Imports System.Data.SqlClient
Public Class Form_Registro_Cliente
    Dim dt As New DataTable
    Dim bd As New FMostrarClientes
    Dim da As New SqlDataAdapter
    Private Sub Form_Registro_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Sub SubConexionBD()
        Try
            Dim funcion As New FConexion
            funcion.FnConectado()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            Dim func As New FMostrarClientes
            dt = func.FnMostrarClientes

            If dt.Rows.Count <> 0 Then
                data_TablaClientes.DataSource = dt
                data_TablaClientes.DataSource = dt
                data_TablaClientes.Columns(0).HeaderText = "ID"
                data_TablaClientes.Columns(1).HeaderText = "NOMBRE COMPLETO"
                data_TablaClientes.Columns(2).HeaderText = "DIRECCION"
                data_TablaClientes.Columns(3).HeaderText = "TELEFONO"
                data_TablaClientes.Columns(4).HeaderText = "IDENTIFICACION"
                data_TablaClientes.Columns(5).HeaderText = "FECHA DE REGISTRO"
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
End Class