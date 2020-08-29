Public Class frmContraseñaBibliotecario
    Public contraseñavolatil As String
    Public id, id1 As Integer
    Private Sub BtnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtnGuardarNuevo.Click
        contraseñavolatil = txtcontraseña.Text
        If Trim(txtcontraseña.Text) <> "" Then
            If contraseñavolatil = misfunciones.getId2 Then
                MsgBox("Hola funciono")
                MsgBox(GestionBibliotecario.id)
                frmBibliotecarioEditar.Show()
                Me.Dispose()
            Else
                MsgBox("contraseña incorrecta")
            End If
        Else
            MsgBox("Ingrese algo que nosea un espacio en blanco")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        frmMenu.AbrirFormEnPanel(Of GestionBibliotecario)()
        Me.Dispose()
    End Sub
End Class