Public Class Form_Registro_Servicios
    Dim dt As New DataTable
    Dim bd As New FMostrarServicios
    Private Sub Form_Registro_Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Public Sub Mostrar()
        Try
            Dim func As New FMostrarServicios
            dt = func.FnMostrarServicios

            If dt.Rows.Count <> 0 Then
                dgv_Tabla_Servicios.DataSource = dt
                dgv_Tabla_Servicios.Columns(0).HeaderText = "ID"
                dgv_Tabla_Servicios.Columns(1).HeaderText = "NOMBRE SERVICIO"
                dgv_Tabla_Servicios.Columns(2).HeaderText = "DESCRIPCIÓN"
                Dim registros As String = dgv_Tabla_Servicios.Rows.Count.ToString
                lbl_Total_Servicios.Text = "Total Registros: " + registros
            Else
                dgv_Tabla_Servicios.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Buscar_Servicio_TextChanged(sender As Object, e As EventArgs) Handles txt_Buscar_Servicio.TextChanged
        bd.BusquedaDinamica(txt_Buscar_Servicio.Text, dgv_Tabla_Servicios)
    End Sub

    Private Sub dgv_Tabla_Servicios_CellContentClick() Handles dgv_Tabla_Servicios.CellContentClick
        Dim i As Integer
        i = dgv_Tabla_Servicios.CurrentRow.Index

        txt_Id.Text = dgv_Tabla_Servicios.Item(0, i).Value().ToString
        txt_Nombre.Text = dgv_Tabla_Servicios.Item(1, i).Value().ToString
        txt_Descripcion.Text = dgv_Tabla_Servicios.Item(2, i).Value().ToString
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_Tabla_Servicios.SelectedRows.Count <> 0 Then
            dgv_Tabla_Servicios_CellContentClick()
        Else
            Form_Editar_Cliente.Close()
            MsgBox("DEBE SELECCIONAR UN SERVICIO")
        End If
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Try
            Dim funciones As New FMostrarServicios
            Dim logica As New VServicios

            If txt_Nombre.Text = "" Or txt_Id.Text = "" Then
                MsgBox("¡DEBE RELLENAR LOS CAMPOS!")
            Else
                logica.gId = txt_Id.Text
                logica.gNombre = txt_Nombre.Text
                logica.gDescripcion = txt_Descripcion.Text
            End If

            If funciones.FNuevoServicio(logica) Then
                MsgBox("¡AGREGADO CORRECTAMENTE!")
                Mostrar()
                txt_Id.Text = ""
                txt_Nombre.Text = ""
                txt_Descripcion.Text = ""
            End If
        Catch ex As Exception
            MsgBox("NO SE REALIZO EL REGISTRO")
        End Try
    End Sub
End Class