Imports MySql.Data.MySqlClient
Public Class FrmPrestamoNuevo
    Private datos As MySqlDataReader
    Private id_libro, id_ejemplar As Integer
    Private cambiolibro, cambioisbn As Integer
    Private variable As String
    Private comienzo As Integer
    Dim codigoisbn As String = ""
    Private Sub FrmPrestamoNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbISBN.Enabled = False
        cargarlibro()
        misfunciones.seleccionCb(CBLibro, id_libro)

        CBRecibido.SelectedIndex = 1
        CBRetraso.SelectedIndex = 1
        comienzo = 1
    End Sub






    Private Sub cargarlibro()
        CBLibro.Items.Clear()
        Dim sql As String = "select * from libro ORDER BY Titulo ASC;"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                CBLibro.Items.Add(New Elementos(datos("Titulo"), datos("id_libro")))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub BtnGuardarNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        Dim id_editorial As Integer
        Dim comando As String = "", registros As MySqlDataReader = Nothing, id_prestamo_libro As Integer = 0
        If Trim(txtidentidad.Text) <> "" And Trim(txtentrega.Text) <> "" And Trim(txtprestamo.Text) <> "" And Trim(cbISBN.Text) <> "" And IsNumeric(txtidentidad.Text) And Trim(CBRecibido.Text) <> "" And Trim(CBRetraso.Text) <> "" And cbISBN.Enabled = True And TxtNombre.Text <> "" Then

            comando = "SELECT MAX(id_prestamo_libro) as id FROM prestamo_libro;"
            registros = mibd.consulta(comando)
            If registros.HasRows Then
                While registros.Read
                    id_prestamo_libro = registros("id")
                End While
            End If
            registros.Close()

            comando = "SELECT * FROM ejemplar WHERE CodigoISBN='" & cbISBN.Text & "';"
            registros = mibd.consulta(comando)
            If registros.HasRows Then
                While registros.Read
                    id_editorial = registros("id_ejemplar")
                End While
            End If
            registros.Close()
            If cbdevolucion.Text = "" Then
                comando = "INSERT INTO `biblioteca`.`prestamo_libro` (`id_prestamo_libro`, `id_ejemplar`, `identidad`, `fecha_prestamo`, `fecha_entrega`, `recibido`, `retraso`) VALUES ('" & id_prestamo_libro + 1 & "', '" & id_editorial & "', '" & txtidentidad.Text & "', '" & Convert.ToDateTime(txtprestamo.Text).ToString("yyyy-MM-dd hh:mm:ss") & "', '" & Convert.ToDateTime(txtentrega.Text).ToString("yyyy-MM-dd hh:mm:ss") & "', '" & CBRecibido.Text & "', '" & CBRetraso.Text & "');"
            Else
                comando = "INSERT INTO `biblioteca`.`prestamo_libro` (`id_prestamo_libro`, `id_ejemplar`, `identidad`, `fecha_prestamo`, `fecha_entrega`, `fecha_devolucion`, `recibido`, `retraso`) VALUES ('" & id_prestamo_libro + 1 & "', '" & id_editorial & "', '" & txtidentidad.Text & "', '" & Convert.ToDateTime(txtprestamo.Text).ToString("yyyy-MM-dd hh:mm:ss") & "', '" & Convert.ToDateTime(txtentrega.Text).ToString("yyyy-MM-dd hh:mm:ss") & "', '" & Convert.ToDateTime(cbdevolucion.Text).ToString("yyyy-MM-dd hh:mm:ss") & "', '" & CBRecibido.Text & "', '" & CBRetraso.Text & "');"
            End If
            mibd.sentencias(comando)

            If CBRecibido.SelectedIndex = 1 Then
                comando = "UPDATE `biblioteca`.`ejemplar` SET `Disponibilidad`='Prestado' WHERE `CodigoISBN`='" & cbISBN.Text & "';"
                mibd.sentencias(comando)
            End If

            Me.Dispose()
        Else
            MsgBox("Ingrese los datos de forma correcta, identidad sin espacios ni guiones, un libro que este disponible y demas", MsgBoxStyle.Exclamation, "READER SYSTEM")
        End If
        frmMenu.contador()
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub cbISBN_TextChanged(sender As Object, e As EventArgs)

        If cbISBN.Text.Length <> 17 Then
            cbISBN.Text = variable
        End If
    End Sub

    Private Sub txtidentidad_TextChanged(sender As Object, e As EventArgs)
        TxtNombre.Text = ""
        cargarnombre()
    End Sub

    Sub cargarnombre()
        Dim sql2 As String = ""
        If misfunciones.getIdusuario <> "root" Then
            sql2 = "select * from alumnos WHERE identidad='" & txtidentidad.Text & "' AND id_campus='" & misfunciones.getcampus & "';"
        Else
            sql2 = "select * from alumnos WHERE identidad='" & txtidentidad.Text & "';"
        End If

        datos = mibd.consulta(sql2)
        If datos.HasRows Then
            While datos.Read
                TxtNombre.Text = datos("Nombre") & " " & datos("Apellido")
            End While
        End If
        datos.Close()
    End Sub

    Private Sub cbISBN_SelectedIndexChanged(sender As Object, e As EventArgs)
        variable = cbISBN.Text
    End Sub

    Private Sub CBLibro_SelectedIndexChanged(sender As Object, e As EventArgs)
        cbISBN.Enabled = True
        cargarejemplar()
        misfunciones.seleccionCb(cbISBN, id_ejemplar)
        Dim sql1 As String = "select * from libro WHERE id_libro='" & CBLibro.SelectedItem.value & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                txtedicion.Text = datos("Edicion")
            End While
        End If
        datos.Close()
        If cbISBN.Items.Count > 0 Then
            cbISBN.SelectedIndex = 0
        Else
            cbISBN.Text = ""
            cbISBN.Items.Clear()
            cbISBN.Enabled = False
            MsgBox("No hay ejemplares disponibles de este libro, porfavor seleccione otro libro", MsgBoxStyle.Critical, "READER SYSTEM")

        End If
    End Sub

    Private Sub cargarejemplar()
        cbISBN.Items.Clear()
        Dim sql As String = "select * from ejemplar WHERE id_libro='" & CBLibro.SelectedItem.value & "' AND Disponibilidad='Disponible' AND id_campus='" & misfunciones.getcampus & "';"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbISBN.Items.Add(New Elementos(datos("CodigoISBN"), datos("id_ejemplar")))
            End While
        End If
        datos.Close()
    End Sub

#Region "EVENTO DE LOS CALENDARIOS"

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario1.DateChanged
        txtprestamo.Text = Calendario1.SelectionEnd.Date.ToString("yyyy-MM-dd") & " " & TimeOfDay
        If txtentrega.Text <> "" And txtprestamo.Text <> "" Then
            If (DateTime.Compare(Convert.ToDateTime(txtprestamo.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(txtentrega.Text).ToString("yyyy-MM-dd HH:MM:ss")) >= 0) Then
                MsgBox("La fecha de prestamo no puede ser mayor a la de entrega", MsgBoxStyle.Critical, "READER SYSTEM")
                txtprestamo.Text = ""
            Else

            End If
        End If
        If cbdevolucion.Text <> "" And txtprestamo.Text <> "" Then
            If (DateTime.Compare(Convert.ToDateTime(txtprestamo.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(cbdevolucion.Text).ToString("yyyy-MM-dd HH:MM:ss")) >= 0) Then
                MsgBox("La fecha de devolucion no puede ser menor a la de el prestamo", MsgBoxStyle.Critical, "READER SYSTEM")
                txtprestamo.Text = ""
            End If

        End If

        If txtentrega.Text <> "" And cbdevolucion.Text <> "" Then
            If (DateTime.Compare(Convert.ToDateTime(txtentrega.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(cbdevolucion.Text).ToString("yyyy-MM-dd HH:MM:ss")) >= 0) Then 'La fecha actual es mayor que la fecha insertada.
                CBRetraso.SelectedIndex = 1 ' NO
            Else
                CBRetraso.SelectedIndex = 0 'SI
            End If
        End If
        If txtprestamo.Text <> "" And cbdevolucion.Text <> "" Then
            If (DateTime.Compare(Convert.ToDateTime(txtprestamo.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(cbdevolucion.Text).ToString("yyyy-MM-dd HH:MM:ss")) <= 0) Then
                CBRecibido.SelectedIndex = 0

            Else
                MsgBox("La fecha de cuando se realizo el prestamos no puede ser menor a cuando se devolvio", MsgBoxStyle.Critical, "READER SYSTEM")
                cbdevolucion.Text = ""
            End If
        End If
    End Sub

    Private Sub Calendario2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario2.DateChanged
        txtentrega.Text = Calendario2.SelectionEnd.Date.ToString("yyyy-MM-dd") & " " & TimeOfDay
        If txtprestamo.Text <> "" Then
            If (DateTime.Compare(Convert.ToDateTime(txtprestamo.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(txtentrega.Text).ToString("yyyy-MM-dd HH:MM:ss")) < 0) Then

            Else
                MsgBox("LA fecha de entrega no puede ser menor a la fecha que se realizo el prestamo", MsgBoxStyle.Critical, "READER SYSTEM")
                txtentrega.Text = ""
            End If
        End If

        If cbdevolucion.Text <> "" And txtentrega.Text <> "" Then
            If (DateTime.Compare(Convert.ToDateTime(txtentrega.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(cbdevolucion.Text).ToString("yyyy-MM-dd HH:MM:ss")) >= 0) Then 'La fecha actual es mayor que la fecha insertada.
                CBRetraso.SelectedIndex = 1 ' NO
            Else
                CBRetraso.SelectedIndex = 0 'SI
            End If
        End If
    End Sub

    Private Sub Calendario3_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendario3.DateSelected
        cbdevolucion.Text = Calendario3.SelectionEnd.Date.ToString("yyyy-MM-dd") & " " & TimeOfDay
        If txtprestamo.Text <> "" Then
            cbdevolucion.Text = Calendario3.SelectionEnd.Date.ToString("yyyy-MM-dd") & " " & TimeOfDay
            If (DateTime.Compare(Convert.ToDateTime(txtprestamo.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(cbdevolucion.Text).ToString("yyyy-MM-dd HH:MM:ss")) <= 0) Then
                CBRecibido.SelectedIndex = 0
                CBRecibido.Enabled = False

            Else
                cbdevolucion.Text = ""
                MsgBox("La fecha de cuando se realizo el prestamo no puede ser menor a cuando se devolvio", MsgBoxStyle.Exclamation, "READER SYSTEM")
                Calendario1.Enabled = False
            End If
        End If

        If txtentrega.Text <> "" And cbdevolucion.Text <> "" Then
            If (DateTime.Compare(Convert.ToDateTime(txtentrega.Text).ToString("yyyy-MM-dd HH:MM:ss"), Convert.ToDateTime(cbdevolucion.Text).ToString("yyyy-MM-dd HH:MM:ss")) >= 0) Then 'La fecha actual es mayor que la fecha insertada.
                CBRetraso.SelectedIndex = 1 ' NO
            Else
                CBRetraso.SelectedIndex = 0 'SI
            End If
        End If
        If cbdevolucion.Text = "" Then
            CBRecibido.SelectedIndex = 1
            CBRetraso.SelectedIndex = 1
        End If

    End Sub
#End Region

#Region "ACCION DE LOS BOTONES DE CALENDARIO"

    Private Sub BtnCalPrestamo_Click(sender As Object, e As EventArgs) Handles BtnCalPrestamo.Click
        If Calendario1.Visible = True Then
            Calendario1.Visible = False
        Else
            Calendario1.Visible = True
            Calendario2.Visible = False
            Calendario3.Visible = False
        End If
    End Sub

    Private Sub CBLibro_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBLibro.SelectedIndexChanged
        cbISBN.Enabled = True
        codigoisbn = cbISBN.Text


        cargarejemplar()
        misfunciones.seleccionCb(cbISBN, id_ejemplar)

        Dim sql1 As String = "select * from libro WHERE id_libro='" & CBLibro.SelectedItem.value & "';"
        datos = mibd.consulta(sql1)
        If datos.HasRows Then
            While datos.Read
                txtedicion.Text = datos("Edicion")
            End While
        End If
        datos.Close()

        If cbISBN.Items.Count > 0 Then
            cbISBN.SelectedIndex = 0
        Else

            cbISBN.Text = ""
            cbISBN.Enabled = False
            MsgBox("No hay ejemplares disponibles de este libro, porfavor seleccione otro libro", MsgBoxStyle.Critical, "READER SYSTEM")
            cbISBN.Text = ""
        End If

    End Sub

    Private Sub txtidentidad_TextChanged_1(sender As Object, e As EventArgs) Handles txtidentidad.TextChanged
        If comienzo = 1 Then
            TxtNombre.Text = ""
            cargarnombre()
        End If
    End Sub

    Private Sub cbISBN_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbISBN.SelectedIndexChanged
        variable = cbISBN.Text
    End Sub

    Private Sub cbISBN_TextChanged_1(sender As Object, e As EventArgs) Handles cbISBN.TextChanged
        If cbISBN.Text.Length <> 17 Then
            cbISBN.Text = variable
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        cbdevolucion.Text = ""
        CBRecibido.SelectedIndex = 1
        CBRetraso.SelectedIndex = 1
    End Sub

    Private Sub BtnCalEntrega_Click(sender As Object, e As EventArgs) Handles BtnCalEntrega.Click

        If Calendario2.Visible = True Then
            Calendario2.Visible = False
        Else
            Calendario2.Visible = True
            Calendario1.Visible = False
            Calendario3.Visible = False
        End If
    End Sub

    Private Sub BtnCalDevolucion_Click(sender As Object, e As EventArgs) Handles BtnCalDevolucion.Click
        If Calendario3.Visible = True Then
            Calendario3.Visible = False
        Else
            Calendario3.Visible = True
            Calendario1.Visible = False
            Calendario2.Visible = False
        End If
    End Sub
#End Region

End Class