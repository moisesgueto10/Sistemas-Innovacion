<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCampusNuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCampusNuevo))
        Me.BtnGuardarNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnConfigCampus = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbciudad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcampusnombre = New System.Windows.Forms.TextBox()
        CType(Me.BtnConfigCampus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnGuardarNuevo.Location = New System.Drawing.Point(121, 139)
        Me.BtnGuardarNuevo.Name = "BtnGuardarNuevo"
        Me.BtnGuardarNuevo.Size = New System.Drawing.Size(100, 30)
        Me.BtnGuardarNuevo.TabIndex = 57
        Me.BtnGuardarNuevo.Text = "Guardar"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(227, 139)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 56
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnConfigCampus
        '
        Me.BtnConfigCampus.Image = CType(resources.GetObject("BtnConfigCampus.Image"), System.Drawing.Image)
        Me.BtnConfigCampus.Location = New System.Drawing.Point(379, 12)
        Me.BtnConfigCampus.Name = "BtnConfigCampus"
        Me.BtnConfigCampus.Size = New System.Drawing.Size(144, 157)
        Me.BtnConfigCampus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnConfigCampus.TabIndex = 60
        Me.BtnConfigCampus.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Campus:"
        '
        'Cbciudad
        '
        Me.Cbciudad.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbciudad.FormattingEnabled = True
        Me.Cbciudad.Location = New System.Drawing.Point(100, 54)
        Me.Cbciudad.Name = "Cbciudad"
        Me.Cbciudad.Size = New System.Drawing.Size(244, 27)
        Me.Cbciudad.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Ciudad:"
        '
        'txtcampusnombre
        '
        Me.txtcampusnombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcampusnombre.Location = New System.Drawing.Point(100, 91)
        Me.txtcampusnombre.Name = "txtcampusnombre"
        Me.txtcampusnombre.Size = New System.Drawing.Size(244, 26)
        Me.txtcampusnombre.TabIndex = 116
        '
        'FrmCampusNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 195)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtcampusnombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cbciudad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConfigCampus)
        Me.Controls.Add(Me.BtnGuardarNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "FrmCampusNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campus Nuevo"
        CType(Me.BtnConfigCampus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BtnGuardarNuevo As Button
    Private WithEvents BtnCancelar As Button
    Private WithEvents BtnConfigCampus As PictureBox
    Private WithEvents Label4 As Label
    Friend WithEvents Cbciudad As ComboBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtcampusnombre As TextBox
End Class
