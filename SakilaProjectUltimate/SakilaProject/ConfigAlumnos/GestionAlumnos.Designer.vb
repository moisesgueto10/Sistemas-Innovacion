<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionAlumnos))
        Me.lvPrincipal = New System.Windows.Forms.ListView()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcantidadalumnos = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvPrincipal
        '
        Me.lvPrincipal.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvPrincipal.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPrincipal.FullRowSelect = True
        Me.lvPrincipal.GridLines = True
        Me.lvPrincipal.Location = New System.Drawing.Point(0, 39)
        Me.lvPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.lvPrincipal.MultiSelect = False
        Me.lvPrincipal.Name = "lvPrincipal"
        Me.lvPrincipal.Size = New System.Drawing.Size(800, 411)
        Me.lvPrincipal.TabIndex = 5
        Me.lvPrincipal.UseCompatibleStateImageBehavior = False
        Me.lvPrincipal.View = System.Windows.Forms.View.Details
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelCabecera.Controls.Add(Me.Label2)
        Me.PanelCabecera.Controls.Add(Me.lblcantidadalumnos)
        Me.PanelCabecera.Controls.Add(Me.BtnCerrarForm)
        Me.PanelCabecera.Controls.Add(Me.Label1)
        Me.PanelCabecera.Controls.Add(Me.btnNuevo)
        Me.PanelCabecera.Controls.Add(Me.BtnEliminar)
        Me.PanelCabecera.Controls.Add(Me.btnEditar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(800, 41)
        Me.PanelCabecera.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(309, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Cantidad:"
        '
        'lblcantidadalumnos
        '
        Me.lblcantidadalumnos.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidadalumnos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lblcantidadalumnos.Location = New System.Drawing.Point(419, 5)
        Me.lblcantidadalumnos.Name = "lblcantidadalumnos"
        Me.lblcantidadalumnos.Size = New System.Drawing.Size(33, 23)
        Me.lblcantidadalumnos.TabIndex = 44
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(11, 11)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 42
        Me.BtnCerrarForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 23)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "GESTION ALUMNOS"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(477, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 30)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(689, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(583, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'GestionAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelCabecera)
        Me.Controls.Add(Me.lvPrincipal)
        Me.Name = "GestionAlumnos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionUsuarios"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvPrincipal As ListView
    Friend WithEvents PanelCabecera As Panel
    Private WithEvents btnNuevo As Button
    Private WithEvents BtnEliminar As Button
    Private WithEvents btnEditar As Button
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcantidadalumnos As Label
    Friend WithEvents Label2 As Label
End Class
