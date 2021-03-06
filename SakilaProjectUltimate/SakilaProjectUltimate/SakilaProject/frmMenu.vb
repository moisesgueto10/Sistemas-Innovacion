﻿Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class frmMenu
    Dim admin As String

    Public Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'El arranque del programa       
        'Timer1.Start()
        'FrmInicioSoftware.ShowDialog()

    End Sub

#Region "FUNCIONALIDEDES DEL FORM"
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelBarraTitulo.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTituo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTituo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        BtnMaximizar.Visible = True
        BtnRestaurar.Visible = False
    End Sub
#End Region

#Region "FUNCION DE ABRIR FORMS DENTRO DEL PANEL"
    'METODO DE ABRIR FORMULARIO
    Public Sub AbrirFormEnPanel(Of Myform As {Form, New})()
        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of Myform)().FirstOrDefault

        If formulario Is Nothing Then 'Funcion que nos ayuda a organizar los formularios dentro de un solo panel
            formulario = New Myform
            formulario.TopLevel = False

            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            AddHandler formulario.FormClosed, AddressOf Me.cerrarFormulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If

    End Sub

    Public Sub cerrarFormEnPanel(Of Myform As {Form, New})()

     

    End Sub

#End Region

#Region "ACCION DE LOS BOTONES EN EL FORM"
    Private Sub BtnLibros_Click(sender As Object, e As EventArgs) Handles BtnLibros.Click
        AbrirFormEnPanel(Of FrmLibrosYCatalogos)()
        BtnLibros.BackColor = Color.FromArgb(12, 61, 92)

        'CERRAR AQUELLOS FORMULARIOS QUE NO SE OCUPAN
        If Application.OpenForms("FrmPrestamos") IsNot Nothing Then
            Application.OpenForms("FrmPrestamos").Close()
        End If
        If Application.OpenForms("FrmMantenimiento") IsNot Nothing Then
            Application.OpenForms("FrmMantenimiento").Close()
        End If
    End Sub

    Private Sub BtnPrestamos_Click(sender As Object, e As EventArgs) Handles BtnPrestamos.Click
        AbrirFormEnPanel(Of FrmPrestamos)()
        BtnPrestamos.BackColor = Color.FromArgb(12, 61, 92)

        If Application.OpenForms("FrmLibrosYCatalogos") IsNot Nothing Then
            Application.OpenForms("FrmLibrosYCatalogos").Close()
        End If
        If Application.OpenForms("FrmMantenimiento") IsNot Nothing Then
            Application.OpenForms("FrmMantenimiento").Close()
        End If
    End Sub

    Private Sub BtnInformacion_Click(sender As Object, e As EventArgs) Handles BtnInformacion.Click
        MsgBox("Equipo #2", MsgBoxStyle.Information, "Desarrollo de Software")
    End Sub

    Private Sub BtnMantenimiento_Click(sender As Object, e As EventArgs) Handles BtnMantenimiento.Click
        AbrirFormEnPanel(Of FrmMantenimiento)()
        BtnMantenimiento.BackColor = Color.FromArgb(12, 61, 92)

        If Application.OpenForms("FrmLibrosYCatalogos") IsNot Nothing Then
            Application.OpenForms("FrmLibrosYCatalogos").Close()
        End If
        If Application.OpenForms("FrmPrestamos") IsNot Nothing Then
            Application.OpenForms("FrmPrestamos").Close()
        End If
    End Sub
    ''' <summary>
    ''' Funcion para cerrar aquel formulario que quedo abierto y dejando en la ventana de inicio
    ''' </summary>
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        If Application.OpenForms("FrmLibrosYCatalogos") IsNot Nothing Then
            Application.OpenForms("FrmLibrosYCatalogos").Close()
        End If
        If Application.OpenForms("FrmPrestamos") IsNot Nothing Then
            Application.OpenForms("FrmPrestamos").Close()
        End If
        If Application.OpenForms("FrmMantenimiento") IsNot Nothing Then
            Application.OpenForms("FrmMantenimiento").Close()
        End If

    End Sub

    'METODO AL CERRAR FORMS
    Private Sub cerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("FrmLibrosYCatalogos") Is Nothing) Then
            BtnLibros.BackColor = Color.FromArgb(4, 41, 68)
        End If
        'Una condicion para cada formuario
        If (Application.OpenForms("FrmPrestamos") Is Nothing) Then
            BtnPrestamos.BackColor = Color.FromArgb(4, 41, 68)
        End If

        If (Application.OpenForms("FrmMantenimiento") Is Nothing) Then
            BtnMantenimiento.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

    Private Sub PanelBarraTituo_Paint(sender As Object, e As PaintEventArgs) Handles PanelBarraTituo.Paint

    End Sub

#End Region

#Region "EVENTO DEL TIMER"
    Public Sub SetBibliotecario(UsuarioEnLinea As String)
        admin = UsuarioEnLinea 'PARA COLOCAR EL NOMBRE DEL BIBLIOTECARIO EN LINEA

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblUsuario.Text = "Bibliotecario(a): [" & admin & "]" 'ESTETICA
        LblFechayHora.Text = "               Fecha y Hora: [" &
            Date.Now.ToString("dd-MM-yyyy hh:mm:ss]")

    End Sub
#End Region
End Class
