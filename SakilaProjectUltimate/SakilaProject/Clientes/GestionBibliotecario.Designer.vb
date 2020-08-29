<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionBibliotecario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionBibliotecario))
        Me.lvPrincipal = New System.Windows.Forms.ListView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.lvPrincipal.Location = New System.Drawing.Point(0, 43)
        Me.lvPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.lvPrincipal.MultiSelect = False
        Me.lvPrincipal.Name = "lvPrincipal"
        Me.lvPrincipal.Size = New System.Drawing.Size(800, 407)
        Me.lvPrincipal.TabIndex = 4
        Me.lvPrincipal.UseCompatibleStateImageBehavior = False
        Me.lvPrincipal.View = System.Windows.Forms.View.Details
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
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(583, 5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(689, 5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelCabecera.Controls.Add(Me.BtnCerrarForm)
        Me.PanelCabecera.Controls.Add(Me.Label1)
        Me.PanelCabecera.Controls.Add(Me.btnNuevo)
        Me.PanelCabecera.Controls.Add(Me.BtnEliminar)
        Me.PanelCabecera.Controls.Add(Me.btnEditar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(800, 41)
        Me.PanelCabecera.TabIndex = 13
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(13, 14)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 38
        Me.BtnCerrarForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "GESTION BIBLIOTECARIO"
        '
        'GestionBibliotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelCabecera)
        Me.Controls.Add(Me.lvPrincipal)
        Me.Name = "GestionBibliotecario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionBibliotecario"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvPrincipal As ListView
    Private WithEvents btnNuevo As Button
    Private WithEvents btnEditar As Button
    Private WithEvents BtnEliminar As Button
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents Label1 As Label
End Class
