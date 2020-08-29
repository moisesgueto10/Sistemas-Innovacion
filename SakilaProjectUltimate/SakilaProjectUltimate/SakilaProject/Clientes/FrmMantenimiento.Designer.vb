<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimiento))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnConfigBibliotecario = New System.Windows.Forms.PictureBox()
        Me.BtnConfigLibro = New System.Windows.Forms.PictureBox()
        Me.BtnConfigUsuario = New System.Windows.Forms.PictureBox()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblEjemplares = New System.Windows.Forms.Label()
        Me.BtnConfigEjemplares = New System.Windows.Forms.PictureBox()
        CType(Me.BtnConfigBibliotecario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnConfigLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnConfigUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnConfigEjemplares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(608, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "BIBLIOTECARIO"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(375, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "LIBROS"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(87, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "USUARIO"
        '
        'BtnConfigBibliotecario
        '
        Me.BtnConfigBibliotecario.Image = CType(resources.GetObject("BtnConfigBibliotecario.Image"), System.Drawing.Image)
        Me.BtnConfigBibliotecario.Location = New System.Drawing.Point(600, 71)
        Me.BtnConfigBibliotecario.Name = "BtnConfigBibliotecario"
        Me.BtnConfigBibliotecario.Size = New System.Drawing.Size(144, 157)
        Me.BtnConfigBibliotecario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnConfigBibliotecario.TabIndex = 39
        Me.BtnConfigBibliotecario.TabStop = False
        '
        'BtnConfigLibro
        '
        Me.BtnConfigLibro.Image = CType(resources.GetObject("BtnConfigLibro.Image"), System.Drawing.Image)
        Me.BtnConfigLibro.Location = New System.Drawing.Point(333, 71)
        Me.BtnConfigLibro.Name = "BtnConfigLibro"
        Me.BtnConfigLibro.Size = New System.Drawing.Size(144, 157)
        Me.BtnConfigLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnConfigLibro.TabIndex = 38
        Me.BtnConfigLibro.TabStop = False
        '
        'BtnConfigUsuario
        '
        Me.BtnConfigUsuario.Image = CType(resources.GetObject("BtnConfigUsuario.Image"), System.Drawing.Image)
        Me.BtnConfigUsuario.Location = New System.Drawing.Point(65, 71)
        Me.BtnConfigUsuario.Name = "BtnConfigUsuario"
        Me.BtnConfigUsuario.Size = New System.Drawing.Size(144, 157)
        Me.BtnConfigUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnConfigUsuario.TabIndex = 37
        Me.BtnConfigUsuario.TabStop = False
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(7, 11)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 36
        Me.BtnCerrarForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "MANTENIMIENTO"
        '
        'LblEjemplares
        '
        Me.LblEjemplares.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEjemplares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblEjemplares.Location = New System.Drawing.Point(879, 231)
        Me.LblEjemplares.Name = "LblEjemplares"
        Me.LblEjemplares.Size = New System.Drawing.Size(122, 23)
        Me.LblEjemplares.TabIndex = 46
        Me.LblEjemplares.Text = "EJEMPLARES"
        '
        'BtnConfigEjemplares
        '
        Me.BtnConfigEjemplares.Image = CType(resources.GetObject("BtnConfigEjemplares.Image"), System.Drawing.Image)
        Me.BtnConfigEjemplares.Location = New System.Drawing.Point(866, 88)
        Me.BtnConfigEjemplares.Name = "BtnConfigEjemplares"
        Me.BtnConfigEjemplares.Size = New System.Drawing.Size(144, 140)
        Me.BtnConfigEjemplares.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnConfigEjemplares.TabIndex = 45
        Me.BtnConfigEjemplares.TabStop = False
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 450)
        Me.Controls.Add(Me.LblEjemplares)
        Me.Controls.Add(Me.BtnConfigEjemplares)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnConfigBibliotecario)
        Me.Controls.Add(Me.BtnConfigLibro)
        Me.Controls.Add(Me.BtnConfigUsuario)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMantenimiento"
        Me.Text = "FrmMantenimiento"
        CType(Me.BtnConfigBibliotecario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnConfigLibro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnConfigUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnConfigEjemplares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents BtnConfigBibliotecario As PictureBox
    Private WithEvents BtnConfigLibro As PictureBox
    Private WithEvents BtnConfigUsuario As PictureBox
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblEjemplares As Label
    Private WithEvents BtnConfigEjemplares As PictureBox
End Class
