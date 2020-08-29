Imports MySql.Data.MySqlClient
Public Class FrmEjemplarNuevo
    Private datos As MySqlDataReader
    Private id_campus, id_libro As Integer

    Private Sub FrmEjemplarNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcampus()
        misfunciones.seleccionCb(Cbcampus, id_campus)
        cargarlibro()
        misfunciones.seleccionCb(cblibro, id_libro)
        If misfunciones.getIdusuario <> "root" Then
            Cbcampus.SelectedIndex = misfunciones.getcampus - 1
            Cbcampus.Enabled = False
        Else
            Cbcampus.SelectedIndex = 0
        End If
        cbestado.SelectedIndex = 0
        cblibro.SelectedIndex = 0
        CBDisponibilidad.SelectedIndex = 0
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
        Dim validadorcodigoISBN As String = ""
        Dim sql1 As String = "SELECT * FROM ejemplar WHERE codigoISBN='" & txtejemplar.Text & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                validadorcodigoISBN = datos("CodigoISBN")
            End While
        End If
        datos.Close()

        If validadorcodigoISBN <> txtejemplar.Text Then
            If txtejemplar.Text <> "" Then
                sql = "SELECT MAX(id_ejemplar) as id FROM ejemplar;"
                registros = mibd.consulta(sql)


                If registros.HasRows Then
                    While registros.Read
                        id_ejemplar = registros("id")
                    End While
                End If

                registros.Close()
                sql = "INSERT INTO `biblioteca`.`ejemplar` (`id_ejemplar`, `CodigoISBN`, `estado`, `Disponibilidad`, `id_libro`, `id_campus`) VALUES ('" &
                        id_ejemplar + 1 & "','" & txtejemplar.Text & "', '" & cbestado.Text & "' , '" & CBDisponibilidad.Text & "' , '" & cblibro.SelectedItem.value & "' , '" & Cbcampus.SelectedItem.value & "');"

                mibd.sentencias(sql)
                Me.Dispose()
            Else
                MsgBox("Ingrese todos los datos", MsgBoxStyle.Exclamation, "READER SYSTEM")
            End If
        Else
            MsgBox("El codigo ISBN ya existe", MsgBoxStyle.Critical, "READER SYSTEM")
        End If



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub cblibro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblibro.SelectedIndexChanged

        Dim sql As String = "select * from libro WHERE id_libro='" & cblibro.SelectedItem.value & "';"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtedicion.Text = datos("Edicion")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FrmLibrosNuevo.ShowDialog()
        cargarlibro()
        misfunciones.seleccionCb(cblibro, id_libro)
    End Sub

    Private Sub cargarlibro()
        cblibro.Items.Clear()
        Dim sql As String = "select * from libro ORDER BY Titulo ASC"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cblibro.Items.Add(New Elementos(datos("Titulo"), datos("id_libro")))
            End While
        End If
        datos.Close()
    End Sub

End Class