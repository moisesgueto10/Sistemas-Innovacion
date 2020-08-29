<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditorialNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditorialNuevo))
        Me.BtnGuardarNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnConfigEditorial = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtorigen = New System.Windows.Forms.TextBox()
        CType(Me.BtnConfigEditorial, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnGuardarNuevo.Location = New System.Drawing.Point(75, 166)
        Me.BtnGuardarNuevo.Name = "BtnGuardarNuevo"
        Me.BtnGuardarNuevo.Size = New System.Drawing.Size(100, 30)
        Me.BtnGuardarNuevo.TabIndex = 61
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
        Me.BtnCancelar.Location = New System.Drawing.Point(181, 166)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 60
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(12, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(162, 19)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Nombre de editorial:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(16, 54)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(313, 26)
        Me.TxtNombre.TabIndex = 58
        '
        'BtnConfigEditorial
        '
        Me.BtnConfigEditorial.Image = CType(resources.GetObject("BtnConfigEditorial.Image"), System.Drawing.Image)
        Me.BtnConfigEditorial.Location = New System.Drawing.Point(335, 12)
        Me.BtnConfigEditorial.Name = "BtnConfigEditorial"
        Me.BtnConfigEditorial.Size = New System.Drawing.Size(144, 157)
        Me.BtnConfigEditorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnConfigEditorial.TabIndex = 62
        Me.BtnConfigEditorial.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 19)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Procedencia de origen:"
        '
        'txtorigen
        '
        Me.txtorigen.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorigen.Location = New System.Drawing.Point(16, 125)
        Me.txtorigen.Name = "txtorigen"
        Me.txtorigen.Size = New System.Drawing.Size(313, 26)
        Me.txtorigen.TabIndex = 63
        '
        'FrmEditorialNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtorigen)
        Me.Controls.Add(Me.BtnConfigEditorial)
        Me.Controls.Add(Me.BtnGuardarNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditorialNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Editorial"
        CType(Me.BtnConfigEditorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BtnGuardarNuevo As Button
    Private WithEvents BtnCancelar As Button
    Private WithEvents Label15 As Label
    Public WithEvents TxtNombre As TextBox
    Private WithEvents BtnConfigEditorial As PictureBox
    Private WithEvents Label1 As Label
    Public WithEvents txtorigen As TextBox
End Class
