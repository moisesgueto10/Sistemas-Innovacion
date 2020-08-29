Public Class FrmAcercade
    Private Sub FrmAcercade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRestricciones_Click(sender As Object, e As EventArgs) Handles BtnRestricciones.Click
        Dim informacion As String = "El Usuario root tiene acceso a todas las pantallas de mantenimiento.

Los bibliotecarios tienen acceso a la informacion del campus que les corresponde.

Los bibliotecarios solo pueden administrar las siguientes pantallas de mantenimiento:

1. Prestamos
2. Alumnos
3. Libros
4. Su perfil de bibliotecario
5. Carrera por campus
6. Ejemplares
7. Autor
8. Editorial"

        AutoEscritura(informacion, 40)

    End Sub

    Private Sub BtnExtras_Click(sender As Object, e As EventArgs) Handles BtnExtras.Click
        Dim extras As String = "Copyright © 2019

Software creado por Grupo numero 2 Desarrollo de Software

Todos los derechos reservados

Todos los iconos fueron obtenidos de www.flaticon.com"

        AutoEscritura(extras, 50)

    End Sub

    Private Sub AutoEscritura(Info As String, tiempo As Integer)

        LblContenido.Text = ""

        For Each espacio As Char In Info
            LblContenido.Text &= espacio
            Application.DoEvents()
            System.Threading.Thread.Sleep(tiempo)
        Next
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Dispose()
    End Sub
End Class