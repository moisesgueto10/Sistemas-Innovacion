<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.LblContaNotificacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.BtnPrestamosPendientes = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnInformacion = New System.Windows.Forms.Button()
        Me.UNICAH = New System.Windows.Forms.PictureBox()
        Me.BtnMantenimiento = New System.Windows.Forms.Button()
        Me.BtnPrestamos = New System.Windows.Forms.Button()
        Me.BtnLibros = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.PanelBarraTituo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRestaurar = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblFechayHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.PanelBarraTitulo.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrestamosPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.UNICAH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTituo.SuspendLayout()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelBarraTitulo.Controls.Add(Me.PanelFormularios)
        Me.PanelBarraTitulo.Controls.Add(Me.PanelMenu)
        Me.PanelBarraTitulo.Controls.Add(Me.PanelBarraTituo)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1100, 558)
        Me.PanelBarraTitulo.TabIndex = 11
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelFormularios.Controls.Add(Me.LblContaNotificacion)
        Me.PanelFormularios.Controls.Add(Me.Label2)
        Me.PanelFormularios.Controls.Add(Me.LOGO)
        Me.PanelFormularios.Controls.Add(Me.BtnPrestamosPendientes)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(850, 518)
        Me.PanelFormularios.TabIndex = 2
        '
        'LblContaNotificacion
        '
        Me.LblContaNotificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LblContaNotificacion.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContaNotificacion.ForeColor = System.Drawing.Color.White
        Me.LblContaNotificacion.Image = CType(resources.GetObject("LblContaNotificacion.Image"), System.Drawing.Image)
        Me.LblContaNotificacion.Location = New System.Drawing.Point(170, 21)
        Me.LblContaNotificacion.Name = "LblContaNotificacion"
        Me.LblContaNotificacion.Size = New System.Drawing.Size(30, 25)
        Me.LblContaNotificacion.TabIndex = 42
        Me.LblContaNotificacion.Text = "1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(44, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 42)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "PRESTAMOS PENDIENTES"
        '
        'LOGO
        '
        Me.LOGO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LOGO.Image = CType(resources.GetObject("LOGO.Image"), System.Drawing.Image)
        Me.LOGO.Location = New System.Drawing.Point(266, 137)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(364, 280)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 0
        Me.LOGO.TabStop = False
        '
        'BtnPrestamosPendientes
        '
        Me.BtnPrestamosPendientes.Image = CType(resources.GetObject("BtnPrestamosPendientes.Image"), System.Drawing.Image)
        Me.BtnPrestamosPendientes.Location = New System.Drawing.Point(23, 21)
        Me.BtnPrestamosPendientes.Name = "BtnPrestamosPendientes"
        Me.BtnPrestamosPendientes.Size = New System.Drawing.Size(158, 131)
        Me.BtnPrestamosPendientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnPrestamosPendientes.TabIndex = 1
        Me.BtnPrestamosPendientes.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnInformacion)
        Me.PanelMenu.Controls.Add(Me.UNICAH)
        Me.PanelMenu.Controls.Add(Me.BtnMantenimiento)
        Me.PanelMenu.Controls.Add(Me.BtnPrestamos)
        Me.PanelMenu.Controls.Add(Me.BtnLibros)
        Me.PanelMenu.Controls.Add(Me.BtnInicio)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 518)
        Me.PanelMenu.TabIndex = 1
        '
        'BtnInformacion
        '
        Me.BtnInformacion.FlatAppearance.BorderSize = 0
        Me.BtnInformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInformacion.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInformacion.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnInformacion.Image = CType(resources.GetObject("BtnInformacion.Image"), System.Drawing.Image)
        Me.BtnInformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInformacion.Location = New System.Drawing.Point(0, 229)
        Me.BtnInformacion.Name = "BtnInformacion"
        Me.BtnInformacion.Size = New System.Drawing.Size(250, 40)
        Me.BtnInformacion.TabIndex = 4
        Me.BtnInformacion.Text = "    Acerca de"
        Me.BtnInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInformacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInformacion.UseVisualStyleBackColor = True
        '
        'UNICAH
        '
        Me.UNICAH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UNICAH.Image = CType(resources.GetObject("UNICAH.Image"), System.Drawing.Image)
        Me.UNICAH.Location = New System.Drawing.Point(0, 289)
        Me.UNICAH.Name = "UNICAH"
        Me.UNICAH.Size = New System.Drawing.Size(250, 174)
        Me.UNICAH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UNICAH.TabIndex = 1
        Me.UNICAH.TabStop = False
        '
        'BtnMantenimiento
        '
        Me.BtnMantenimiento.FlatAppearance.BorderSize = 0
        Me.BtnMantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMantenimiento.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMantenimiento.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnMantenimiento.Image = CType(resources.GetObject("BtnMantenimiento.Image"), System.Drawing.Image)
        Me.BtnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMantenimiento.Location = New System.Drawing.Point(3, 183)
        Me.BtnMantenimiento.Name = "BtnMantenimiento"
        Me.BtnMantenimiento.Size = New System.Drawing.Size(250, 40)
        Me.BtnMantenimiento.TabIndex = 3
        Me.BtnMantenimiento.Text = "Mantenimiento"
        Me.BtnMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnMantenimiento.UseVisualStyleBackColor = True
        '
        'BtnPrestamos
        '
        Me.BtnPrestamos.FlatAppearance.BorderSize = 0
        Me.BtnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrestamos.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrestamos.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnPrestamos.Image = CType(resources.GetObject("BtnPrestamos.Image"), System.Drawing.Image)
        Me.BtnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrestamos.Location = New System.Drawing.Point(0, 137)
        Me.BtnPrestamos.Name = "BtnPrestamos"
        Me.BtnPrestamos.Size = New System.Drawing.Size(250, 40)
        Me.BtnPrestamos.TabIndex = 2
        Me.BtnPrestamos.Text = " Prestamos"
        Me.BtnPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrestamos.UseVisualStyleBackColor = True
        '
        'BtnLibros
        '
        Me.BtnLibros.FlatAppearance.BorderSize = 0
        Me.BtnLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLibros.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLibros.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnLibros.Image = CType(resources.GetObject("BtnLibros.Image"), System.Drawing.Image)
        Me.BtnLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLibros.Location = New System.Drawing.Point(0, 91)
        Me.BtnLibros.Name = "BtnLibros"
        Me.BtnLibros.Size = New System.Drawing.Size(250, 40)
        Me.BtnLibros.TabIndex = 1
        Me.BtnLibros.Text = " Libros y Catalogos"
        Me.BtnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLibros.UseVisualStyleBackColor = True
        '
        'BtnInicio
        '
        Me.BtnInicio.FlatAppearance.BorderSize = 0
        Me.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnInicio.Image = CType(resources.GetObject("BtnInicio.Image"), System.Drawing.Image)
        Me.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.Location = New System.Drawing.Point(0, 45)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(250, 40)
        Me.BtnInicio.TabIndex = 0
        Me.BtnInicio.Text = "     Inicio"
        Me.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'PanelBarraTituo
        '
        Me.PanelBarraTituo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PanelBarraTituo.Controls.Add(Me.Label1)
        Me.PanelBarraTituo.Controls.Add(Me.BtnRestaurar)
        Me.PanelBarraTituo.Controls.Add(Me.BtnMinimizar)
        Me.PanelBarraTituo.Controls.Add(Me.BtnMaximizar)
        Me.PanelBarraTituo.Controls.Add(Me.BtnCerrar)
        Me.PanelBarraTituo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTituo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTituo.Name = "PanelBarraTituo"
        Me.PanelBarraTituo.Size = New System.Drawing.Size(1100, 40)
        Me.PanelBarraTituo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "READER SYSTEM"
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Image = CType(resources.GetObject("BtnRestaurar.Image"), System.Drawing.Image)
        Me.BtnRestaurar.Location = New System.Drawing.Point(1050, 12)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnRestaurar.TabIndex = 3
        Me.BtnRestaurar.TabStop = False
        Me.BtnRestaurar.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), System.Drawing.Image)
        Me.BtnMinimizar.Location = New System.Drawing.Point(1028, 12)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMinimizar.TabIndex = 2
        Me.BtnMinimizar.TabStop = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), System.Drawing.Image)
        Me.BtnMaximizar.Location = New System.Drawing.Point(1050, 12)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMaximizar.TabIndex = 1
        Me.BtnMaximizar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(1072, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'Timer1
        '
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LblUsuario.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(64, 17)
        Me.LblUsuario.Text = "Usuario : []"
        '
        'LblFechayHora
        '
        Me.LblFechayHora.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblFechayHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LblFechayHora.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblFechayHora.Name = "LblFechayHora"
        Me.LblFechayHora.Size = New System.Drawing.Size(88, 17)
        Me.LblFechayHora.Text = "Fecha y hora: []"
        '
        'LblInfo
        '
        Me.LblInfo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(600, 17)
        Me.LblInfo.Text = "Copyright © 2019 - Software creado por Grupo numero 2 Desarrollo de Software - To" &
    "dos los derechos reservados"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblUsuario, Me.LblFechayHora, Me.LblInfo})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 558)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1100, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMenu"
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrestamosPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.UNICAH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTituo.ResumeLayout(False)
        Me.PanelBarraTituo.PerformLayout()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelBarraTituo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnMaximizar As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnRestaurar As PictureBox
    Friend WithEvents BtnPrestamos As Button
    Friend WithEvents BtnLibros As Button
    Friend WithEvents BtnInicio As Button
    Friend WithEvents UNICAH As PictureBox
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents BtnMantenimiento As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnInformacion As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnPrestamosPendientes As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblContaNotificacion As Label
    Friend WithEvents LblUsuario As ToolStripStatusLabel
    Friend WithEvents LblFechayHora As ToolStripStatusLabel
    Friend WithEvents LblInfo As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
End Class
