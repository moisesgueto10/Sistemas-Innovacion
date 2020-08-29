Imports System.Runtime.InteropServices
Public Class Form_Login

#Region "Botones Cerrar y Minimizar"

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Ajustar Pantalla"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#End Region

#Region "Editar Componentes"
    Private Sub CustomizeComponents()
        'txt_Usuario
        txt_Usuario.AutoSize = False
        txt_Usuario.Size = New Size(317, 30)
        'txt_Contrasenia
        txt_Contrasenia.AutoSize = False
        txt_Contrasenia.Size = New Size(317, 30)
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles btn_Login.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn_Login.ClientRectangle
        myRectangle.Inflate(0, 35)
        buttonPath.AddEllipse(myRectangle)
        btn_Login.Region = New Region(buttonPath)
    End Sub
#End Region

    Public Sub New()
        InitializeComponent()
        CustomizeComponents()
    End Sub

#Region "Mostrar Contraseña"
    Private Sub cBox_MostrarContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles cBox_MostrarContraseña.CheckedChanged
        If cBox_MostrarContraseña.Checked = True Then
            txt_Contrasenia.UseSystemPasswordChar = False
        Else
            txt_Contrasenia.UseSystemPasswordChar = True
        End If
    End Sub
#End Region
End Class