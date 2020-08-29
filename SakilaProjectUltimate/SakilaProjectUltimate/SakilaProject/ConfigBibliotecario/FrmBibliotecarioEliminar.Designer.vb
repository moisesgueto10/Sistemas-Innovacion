<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBibliotecarioEliminar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBibliotecarioEliminar))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.txtnacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidentidad = New System.Windows.Forms.TextBox()
        Me.Cbcampus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardarNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Contraseña:"
        '
        'txtcontra
        '
        Me.txtcontra.Enabled = False
        Me.txtcontra.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontra.Location = New System.Drawing.Point(116, 36)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(244, 26)
        Me.txtcontra.TabIndex = 86
        '
        'txtnacimiento
        '
        Me.txtnacimiento.Enabled = False
        Me.txtnacimiento.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnacimiento.Location = New System.Drawing.Point(179, 170)
        Me.txtnacimiento.Mask = "0000-00-00"
        Me.txtnacimiento.Name = "txtnacimiento"
        Me.txtnacimiento.Size = New System.Drawing.Size(181, 26)
        Me.txtnacimiento.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 19)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Nombre de usuario:"
        '
        'txtusuario
        '
        Me.txtusuario.Enabled = False
        Me.txtusuario.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(172, 6)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(188, 26)
        Me.txtusuario.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Identidad:"
        '
        'txtidentidad
        '
        Me.txtidentidad.Enabled = False
        Me.txtidentidad.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidentidad.Location = New System.Drawing.Point(118, 200)
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Size = New System.Drawing.Size(244, 26)
        Me.txtidentidad.TabIndex = 81
        '
        'Cbcampus
        '
        Me.Cbcampus.Enabled = False
        Me.Cbcampus.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbcampus.FormattingEnabled = True
        Me.Cbcampus.Location = New System.Drawing.Point(116, 71)
        Me.Cbcampus.Name = "Cbcampus"
        Me.Cbcampus.Size = New System.Drawing.Size(244, 27)
        Me.Cbcampus.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Campus:"
        '
        'BtnGuardarNuevo
        '
        Me.BtnGuardarNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BtnGuardarNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGuardarNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnGuardarNuevo.FlatAppearance.BorderSize = 0
        Me.BtnGuardarNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnGuardarNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnGuardarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarNuevo.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarNuevo.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnGuardarNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarNuevo.Location = New System.Drawing.Point(141, 268)
        Me.BtnGuardarNuevo.Name = "BtnGuardarNuevo"
        Me.BtnGuardarNuevo.Size = New System.Drawing.Size(100, 30)
        Me.BtnGuardarNuevo.TabIndex = 78
        Me.BtnGuardarNuevo.Text = "Eliminar"
        Me.BtnGuardarNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardarNuevo.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(247, 268)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 77
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(376, 9)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(144, 157)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 76
        Me.pictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(10, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 19)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Direccion:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(169, 19)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Fecha de nacimiento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 19)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Apellido:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(8, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 19)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Nombre:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Enabled = False
        Me.TxtDireccion.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(118, 236)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(244, 26)
        Me.TxtDireccion.TabIndex = 71
        '
        'TxtApellido
        '
        Me.TxtApellido.Enabled = False
        Me.TxtApellido.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(116, 136)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(244, 26)
        Me.TxtApellido.TabIndex = 70
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(116, 104)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(244, 26)
        Me.TxtNombre.TabIndex = 69
        '
        'FrmBibliotecarioEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.txtnacimiento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidentidad)
        Me.Controls.Add(Me.Cbcampus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuardarNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBibliotecarioEliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminacion Bibliotecario"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label4 As Label
    Public WithEvents txtcontra As TextBox
    Friend WithEvents txtnacimiento As MaskedTextBox
    Private WithEvents Label3 As Label
    Public WithEvents txtusuario As TextBox
    Private WithEvents Label2 As Label
    Public WithEvents txtidentidad As TextBox
    Friend WithEvents Cbcampus As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents BtnGuardarNuevo As Button
    Private WithEvents BtnCancelar As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Private WithEvents Label15 As Label
    Public WithEvents TxtDireccion As TextBox
    Public WithEvents TxtApellido As TextBox
    Public WithEvents TxtNombre As TextBox
End Class
