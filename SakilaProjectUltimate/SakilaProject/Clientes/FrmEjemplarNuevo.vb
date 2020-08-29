Imports MySql.Data.MySqlClient
Public Class FrmEjemplarNuevo
    Private datos As MySqlDataReader
    Private id_campus, id_libro As Integer

    Private Sub FrmEjemplarNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcampus()
        misfunciones.seleccionCb(Cbcampus, id_campus)
        cargarlibro()
        misfunciones.seleccionCb(cblibro, id_libro)
        Cbcampus.SelectedIndex = 0
        cbestado.SelectedIndex = 0
        cblibro.SelectedIndex = 0
    End Sub

    Private Sub cargarcampus()
        Cbcampus.Items.Clear()
        Dim sql As String = "select * from campus"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                Cbcampus.Items.Add(New Elementos(datos("nombre_campus"), datos("id_campus")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_ejemplar As Integer = 0
        If txtejemplar.Text <> "" Then
            sql = "SELECT MAX(id_ejemplar) as id FROM ejemplar;"
            registros = mibd.consulta(sql)


            If registros.HasRows Then
                While registros.Read
                    id_ejemplar = registros("id")
                End While
            End If

            registros.Close()
            sql = "INSERT INTO `biblioteca`.`ejemplar` (`id_ejemplar`, `num_ejemplar`, `estado`, `id_libro`, `id_campus`) VALUES ('" &
                    id_ejemplar + 1 & "','" & txtejemplar.Text & "', '" & cbestado.Text & "' , '" & cblibro.SelectedItem.value & "' , '" & Cbcampus.SelectedItem.value & "');"

            mibd.sentencias(sql)

            frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
            Me.Dispose()
        Else
            MsgBox("Ingrese todos los datos")
        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionEjemplares)()
        Me.Dispose()
    End Sub

    Private Sub cargarlibro()
        cblibro.Items.Clear()
        Dim sql As String = "select * from libro"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cblibro.Items.Add(New Elementos(datos("Titulo"), datos("id_libro")))
            End While
        End If
        datos.Close()
    End Sub

End Class