Imports MySql.Data.MySqlClient
Public Class LoginInicio
    Private nombre_de_usuario As String
    Private datos As MySqlDataReader
    Private usuario, contrasena As String
    Private id_de_campus As Integer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim validadorcontra As String = ""
        Dim sql As String = "SELECT * FROM bibliotecario WHERE nombre_de_usuario='" & usuario & "';"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                validadorcontra = datos("contrasena")
                id_de_campus = datos("id_campus")
            End While
        End If
        datos.Close()
        contrasena = TxtClave.Text

        If TxtClave.Text = "" And cbusuario.Text = "" Then
            MsgBox("Espacios Vacios")
        Else
            If contrasena = validadorcontra Then
                misfunciones.setIdusuario(usuario)
                misfunciones.setIdcampus(id_de_campus)
                frmMenu.SetBibliotecario(cbusuario.Text) 'Para colocar en el timer
                frmMenu.Show()
                Me.Dispose()
                FrmInicioSoftware.Dispose()

            Else
                LblDatoIncorrecto.Text = "Usuario o clave incorrecta"
                TxtClave.Text = ""
            End If
        End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Dispose()
        frmMenu.Dispose()
    End Sub

    Private Sub LoginInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarusuario()
        misfunciones.seleccionCb(cbusuario, nombre_de_usuario)
    End Sub

    Private Sub cbusuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbusuario.SelectedIndexChanged
        usuario = cbusuario.Text
    End Sub

    Private Sub cargarusuario()
        cbusuario.Items.Clear()
        Dim sql As String = "select * from bibliotecario"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbusuario.Items.Add(New Elementos(datos("nombre_de_usuario"), datos("identidad")))
            End While
        End If
        datos.Close()
    End Sub
End Class
