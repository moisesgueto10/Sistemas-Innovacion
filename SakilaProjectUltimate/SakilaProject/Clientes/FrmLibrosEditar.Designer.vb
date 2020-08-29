<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLibrosEditar
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibrosEditar))
        Me.BtnGuardarNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtESBN = New System.Windows.Forms.MaskedTextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.TxtEdicion = New System.Windows.Forms.TextBox()
        Me.ComboBoxautor = New System.Windows.Forms.ComboBox()
        Me.ComboBoxeditorial = New System.Windows.Forms.ComboBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnGuardarNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarNuevo.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnGuardarNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarNuevo.Location = New System.Drawing.Point(129, 235)
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
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(235, 235)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 56
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(377, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(144, 157)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 55
        Me.pictureBox1.TabStop = False
        '
        'TxtESBN
        '
        Me.TxtESBN.Location = New System.Drawing.Point(129, 191)
        Me.TxtESBN.Mask = "000-0-0000-0000-0"
        Me.TxtESBN.Name = "TxtESBN"
        Me.TxtESBN.Size = New System.Drawing.Size(244, 20)
        Me.TxtESBN.TabIndex = 79
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(128, 158)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(244, 25)
        Me.TxtDescripcion.TabIndex = 78
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitulo.Location = New System.Drawing.Point(128, 9)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(244, 25)
        Me.TxtTitulo.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Codigo(ESBN):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Titulo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(13, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Autor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(13, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 20)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Area:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(13, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 20)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Edicion:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(13, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 20)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Editorial:"
        '
        'TxtArea
        '
        Me.TxtArea.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArea.Location = New System.Drawing.Point(128, 98)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(244, 25)
        Me.TxtArea.TabIndex = 68
        '
        'TxtEdicion
        '
        Me.TxtEdicion.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdicion.Location = New System.Drawing.Point(128, 69)
        Me.TxtEdicion.Name = "TxtEdicion"
        Me.TxtEdicion.Size = New System.Drawing.Size(244, 25)
        Me.TxtEdicion.TabIndex = 67
        '
        'ComboBoxautor
        '
        Me.ComboBoxautor.FormattingEnabled = True
        Me.ComboBoxautor.Location = New System.Drawing.Point(128, 130)
        Me.ComboBoxautor.Name = "ComboBoxautor"
        Me.ComboBoxautor.Size = New System.Drawing.Size(245, 21)
        Me.ComboBoxautor.TabIndex = 80
        '
        'ComboBoxeditorial
        '
        Me.ComboBoxeditorial.FormattingEnabled = True
        Me.ComboBoxeditorial.Location = New System.Drawing.Point(128, 42)
        Me.ComboBoxeditorial.Name = "ComboBoxeditorial"
        Me.ComboBoxeditorial.Size = New System.Drawing.Size(244, 21)
        Me.ComboBoxeditorial.TabIndex = 81
        '
        'FrmLibrosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxeditorial)
        Me.Controls.Add(Me.ComboBoxautor)
        Me.Controls.Add(Me.TxtESBN)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtTitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtArea)
        Me.Controls.Add(Me.TxtEdicion)
        Me.Controls.Add(Me.BtnGuardarNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmLibrosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edicion Libro"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BtnGuardarNuevo As Button
    Private WithEvents BtnCancelar As Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents TxtESBN As MaskedTextBox
    Public WithEvents TxtDescripcion As TextBox
    Public WithEvents TxtTitulo As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Private WithEvents Label15 As Label
    Public WithEvents TxtArea As TextBox
    Public WithEvents TxtEdicion As TextBox
    Friend WithEvents ComboBoxautor As ComboBox
    Friend WithEvents ComboBoxeditorial As ComboBox
End Class
