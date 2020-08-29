Imports MySql.Data.MySqlClient
Public Class FrmCarPorCampNuevo

    Private datos As MySqlDataReader
    Private id_campus, id_carrera As Integer

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionCarreraPorCampus)()
        Me.Dispose()
    End Sub

    Private Sub FrmCarPorCampNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcarrera()
        cargarcampus()
        misfunciones.seleccionCb(CBCarrera, id_carrera)
        misfunciones.seleccionCb(CBcampus, id_campus)
        If misfunciones.getIdusuario <> "root" Then
            CBcampus.SelectedIndex = misfunciones.getcampus - 1
            CBcampus.Enabled = False
        End If
    End Sub


    Private Sub cargarcarrera()
        CBCarrera.Items.Clear()
        Dim sql As String = "select * from carrera"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBCarrera.Items.Add(New Elementos(datos("nombre_carrera"), datos("id_carrera")))
            End While
        End If
        datos.Close()
        CBCarrera.SelectedIndex = 0
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = ""
        Dim validadorcampus As Integer
        Dim validadorcarrera As Integer
        Dim repetido As String = "SELECT * FROM carreras_por_campus WHERE id_campus='" & CBcampus.SelectedItem.value & "' AND id_carrera='" & CBCarrera.SelectedItem.value & "';"
        datos = mibd.consulta(repetido)
        If datos.HasRows Then
            While datos.Read
                validadorcampus = datos("id_campus")
                validadorcarrera = datos("id_carrera")
            End While
        End If
        datos.Close()

        If validadorcampus = CBcampus.SelectedItem.value And validadorcarrera = CBCarrera.SelectedItem.value Then
            MsgBox("La carrera " & CBCarrera.Text & " en el campus " & CBcampus.Text & " ya existe")
        Else
            Try
                sql = "INSERT INTO `biblioteca`.`carreras_por_campus` (`id_campus`, `id_carrera`) VALUES ('" & CBcampus.SelectedItem.value & "', '" & CBCarrera.SelectedItem.value & "');"
                mibd.sentencias(sql)
                Me.Dispose()
            Catch

            End Try
        End If
    End Sub

    Private Sub cargarcampus()
        CBcampus.Items.Clear()
        Dim sql As String = "select * from campus"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBcampus.Items.Add(New Elementos(datos("nombre_campus"), datos("id_campus")))
            End While
        End If
        datos.Close()
        CBcampus.SelectedIndex = 0
    End Sub

End Class