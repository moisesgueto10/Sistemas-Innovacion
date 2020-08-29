Public Class LoginInicio

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Trim(TxtUsuario.Text) = "Moises" And TxtClave.Text = "1234" Or
            Trim(TxtUsuario.Text) = "Hugo" And TxtClave.Text = "0000" Or
            Trim(TxtUsuario.Text) = "Kevin" And TxtClave.Text = "1111" Or
            Trim(TxtUsuario.Text) = "Belkis" And TxtClave.Text = "2222" Or
            Trim(TxtUsuario.Text) = "Jose" And TxtClave.Text = "3333" Then

            frmMenu.SetBibliotecario(TxtUsuario.Text) 'Para colocar en el timer
            frmMenu.Show()
            Me.Dispose()
            FrmInicioSoftware.Dispose()

        ElseIf TxtClave.Text = "" And TxtUsuario.Text = "" Then
            LblDatoIncorrecto.Text = "Espacios vacios"
        Else
            LblDatoIncorrecto.Text = "Usuario o clave incorrecta"
            TxtUsuario.Text = ""
            TxtClave.Text = ""
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Dispose()
        frmMenu.Dispose()
    End Sub

End Class
