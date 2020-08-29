Module Inicio
    ''' <summary>
    ''' Variable global para facilitar el uso de la base de datos
    ''' </summary>
    Public mibd As BD
    Public misfunciones As Funciones
    Public Sub main()
        mibd = New BD
        misfunciones = New Funciones
        Try
            mibd.conectar()
            If mibd.estado Then
                Date.Now.ToString("yyyy-MM-dd hh:mm:ss]")
                Application.Run(frmMenu)
                Date.Now.ToString("yyyy-MM-dd hh:mm:ss]")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
