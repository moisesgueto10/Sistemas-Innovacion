<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrestamoNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrestamoNuevo))
        Me.BtnCalDevolucion = New System.Windows.Forms.PictureBox()
        Me.BtnCalEntrega = New System.Windows.Forms.PictureBox()
        Me.BtnCalPrestamo = New System.Windows.Forms.PictureBox()
        Me.Calendario3 = New System.Windows.Forms.MonthCalendar()
        Me.cbdevolucion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtedicion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Calendario2 = New System.Windows.Forms.MonthCalendar()
        Me.Calendario1 = New System.Windows.Forms.MonthCalendar()
        Me.txtidentidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbISBN = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtentrega = New System.Windows.Forms.TextBox()
        Me.CBRetraso = New System.Windows.Forms.ComboBox()
        Me.CBLibro = New System.Windows.Forms.ComboBox()
        Me.CBRecibido = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtprestamo = New System.Windows.Forms.TextBox()
        Me.BtnGuardarNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BtnCalDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCalEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCalPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCalDevolucion
        '
        Me.BtnCalDevolucion.Image = CType(resources.GetObject("BtnCalDevolucion.Image"), System.Drawing.Image)
        Me.BtnCalDevolucion.Location = New System.Drawing.Point(383, 232)
        Me.BtnCalDevolucion.Name = "BtnCalDevolucion"
        Me.BtnCalDevolucion.Size = New System.Drawing.Size(49, 33)
        Me.BtnCalDevolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCalDevolucion.TabIndex = 220
        Me.BtnCalDevolucion.TabStop = False
        '
        'BtnCalEntrega
        '
        Me.BtnCalEntrega.Image = CType(resources.GetObject("BtnCalEntrega.Image"), System.Drawing.Image)
        Me.BtnCalEntrega.Location = New System.Drawing.Point(383, 186)
        Me.BtnCalEntrega.Name = "BtnCalEntrega"
        Me.BtnCalEntrega.Size = New System.Drawing.Size(49, 33)
        Me.BtnCalEntrega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCalEntrega.TabIndex = 219
        Me.BtnCalEntrega.TabStop = False
        '
        'BtnCalPrestamo
        '
        Me.BtnCalPrestamo.Image = CType(resources.GetObject("BtnCalPrestamo.Image"), System.Drawing.Image)
        Me.BtnCalPrestamo.Location = New System.Drawing.Point(383, 142)
        Me.BtnCalPrestamo.Name = "BtnCalPrestamo"
        Me.BtnCalPrestamo.Size = New System.Drawing.Size(49, 33)
        Me.BtnCalPrestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCalPrestamo.TabIndex = 218
        Me.BtnCalPrestamo.TabStop = False
        '
        'Calendario3
        '
        Me.Calendario3.Location = New System.Drawing.Point(455, 198)
        Me.Calendario3.Name = "Calendario3"
        Me.Calendario3.TabIndex = 217
        Me.Calendario3.Visible = False
        '
        'cbdevolucion
        '
        Me.cbdevolucion.Enabled = False
        Me.cbdevolucion.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbdevolucion.Location = New System.Drawing.Point(157, 232)
        Me.cbdevolucion.Name = "cbdevolucion"
        Me.cbdevolucion.ReadOnly = True
        Me.cbdevolucion.Size = New System.Drawing.Size(220, 26)
        Me.cbdevolucion.TabIndex = 216
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 19)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "Fecha devolucion:"
        '
        'txtedicion
        '
        Me.txtedicion.Enabled = False
        Me.txtedicion.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedicion.Location = New System.Drawing.Point(408, 77)
        Me.txtedicion.Name = "txtedicion"
        Me.txtedicion.ReadOnly = True
        Me.txtedicion.Size = New System.Drawing.Size(22, 26)
        Me.txtedicion.TabIndex = 214
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(346, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 213
        Me.Label3.Text = "Edicion:"
        '
        'Calendario2
        '
        Me.Calendario2.Location = New System.Drawing.Point(453, 187)
        Me.Calendario2.Name = "Calendario2"
        Me.Calendario2.TabIndex = 212
        Me.Calendario2.Visible = False
        '
        'Calendario1
        '
        Me.Calendario1.Location = New System.Drawing.Point(450, 180)
        Me.Calendario1.Name = "Calendario1"
        Me.Calendario1.TabIndex = 211
        Me.Calendario1.Visible = False
        '
        'txtidentidad
        '
        Me.txtidentidad.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidentidad.Location = New System.Drawing.Point(128, 46)
        Me.txtidentidad.MaxLength = 13
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Size = New System.Drawing.Size(302, 26)
        Me.txtidentidad.TabIndex = 210
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Identidad:"
        '
        'cbISBN
        '
        Me.cbISBN.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbISBN.FormattingEnabled = True
        Me.cbISBN.Location = New System.Drawing.Point(157, 111)
        Me.cbISBN.Name = "cbISBN"
        Me.cbISBN.Size = New System.Drawing.Size(273, 27)
        Me.cbISBN.TabIndex = 208
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 19)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Codigo ISBN:"
        '
        'txtentrega
        '
        Me.txtentrega.Enabled = False
        Me.txtentrega.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtentrega.Location = New System.Drawing.Point(157, 186)
        Me.txtentrega.Name = "txtentrega"
        Me.txtentrega.ReadOnly = True
        Me.txtentrega.Size = New System.Drawing.Size(220, 26)
        Me.txtentrega.TabIndex = 206
        '
        'CBRetraso
        '
        Me.CBRetraso.Enabled = False
        Me.CBRetraso.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRetraso.FormattingEnabled = True
        Me.CBRetraso.Items.AddRange(New Object() {"SÍ", "NO"})
        Me.CBRetraso.Location = New System.Drawing.Point(159, 315)
        Me.CBRetraso.Name = "CBRetraso"
        Me.CBRetraso.Size = New System.Drawing.Size(273, 27)
        Me.CBRetraso.TabIndex = 205
        '
        'CBLibro
        '
        Me.CBLibro.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLibro.FormattingEnabled = True
        Me.CBLibro.Location = New System.Drawing.Point(128, 77)
        Me.CBLibro.Name = "CBLibro"
        Me.CBLibro.Size = New System.Drawing.Size(212, 27)
        Me.CBLibro.TabIndex = 204
        '
        'CBRecibido
        '
        Me.CBRecibido.Enabled = False
        Me.CBRecibido.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRecibido.FormattingEnabled = True
        Me.CBRecibido.Items.AddRange(New Object() {"SÍ", "NO"})
        Me.CBRecibido.Location = New System.Drawing.Point(157, 274)
        Me.CBRecibido.Name = "CBRecibido"
        Me.CBRecibido.Size = New System.Drawing.Size(273, 27)
        Me.CBRecibido.TabIndex = 203
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Retraso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Recibido:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(172, 14)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(258, 26)
        Me.TxtNombre.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 19)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Nombre Completo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(14, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 19)
        Me.Label12.TabIndex = 198
        Me.Label12.Text = "Fecha entrega:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(13, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 19)
        Me.Label13.TabIndex = 197
        Me.Label13.Text = "Fecha prestamo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(12, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 19)
        Me.Label14.TabIndex = 196
        Me.Label14.Text = "Titulo del libro:"
        '
        'txtprestamo
        '
        Me.txtprestamo.Enabled = False
        Me.txtprestamo.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprestamo.Location = New System.Drawing.Point(157, 144)
        Me.txtprestamo.Name = "txtprestamo"
        Me.txtprestamo.ReadOnly = True
        Me.txtprestamo.Size = New System.Drawing.Size(221, 26)
        Me.txtprestamo.TabIndex = 195
        '
        'BtnGuardarNuevo
        '
        Me.BtnGuardarNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnGuardarNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BtnGuardarNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGuardarNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnGuardarNuevo.FlatAppearance.BorderSize = 0
        Me.BtnGuardarNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnGuardarNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnGuardarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarNuevo.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarNuevo.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnGuardarNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarNuevo.Location = New System.Drawing.Point(182, 357)
        Me.BtnGuardarNuevo.Name = "BtnGuardarNuevo"
        Me.BtnGuardarNuevo.Size = New System.Drawing.Size(100, 30)
        Me.BtnGuardarNuevo.TabIndex = 194
        Me.BtnGuardarNuevo.Text = "Guardar"
        Me.BtnGuardarNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardarNuevo.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(303, 357)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 193
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(450, 18)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(190, 157)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 192
        Me.pictureBox1.TabStop = False
        '
        'FrmPrestamoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCalDevolucion)
        Me.Controls.Add(Me.BtnCalEntrega)
        Me.Controls.Add(Me.BtnCalPrestamo)
        Me.Controls.Add(Me.Calendario3)
        Me.Controls.Add(Me.cbdevolucion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtedicion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Calendario2)
        Me.Controls.Add(Me.Calendario1)
        Me.Controls.Add(Me.txtidentidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbISBN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtentrega)
        Me.Controls.Add(Me.CBRetraso)
        Me.Controls.Add(Me.CBLibro)
        Me.Controls.Add(Me.CBRecibido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtprestamo)
        Me.Controls.Add(Me.BtnGuardarNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrestamoNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BtnCalDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCalEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCalPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalDevolucion As PictureBox
    Friend WithEvents BtnCalEntrega As PictureBox
    Friend WithEvents BtnCalPrestamo As PictureBox
    Friend WithEvents Calendario3 As MonthCalendar
    Public WithEvents cbdevolucion As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents txtedicion As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents Calendario2 As MonthCalendar
    Friend WithEvents Calendario1 As MonthCalendar
    Public WithEvents txtidentidad As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents cbISBN As ComboBox
    Private WithEvents Label5 As Label
    Public WithEvents txtentrega As TextBox
    Friend WithEvents CBRetraso As ComboBox
    Friend WithEvents CBLibro As ComboBox
    Friend WithEvents CBRecibido As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents Label4 As Label
    Public WithEvents TxtNombre As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Public WithEvents txtprestamo As TextBox
    Private WithEvents BtnGuardarNuevo As Button
    Private WithEvents BtnCancelar As Button
    Private WithEvents pictureBox1 As PictureBox
End Class
