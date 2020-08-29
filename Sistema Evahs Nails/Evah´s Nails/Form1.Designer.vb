<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.PictureBox()
        Me.btn_Close = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Contrasenia = New System.Windows.Forms.TextBox()
        Me.cBox_MostrarContraseña = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleBar.SuspendLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.Label2)
        Me.TitleBar.Controls.Add(Me.btn_Minimize)
        Me.TitleBar.Controls.Add(Me.btn_Close)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(401, 50)
        Me.TitleBar.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Evah´s Nails"
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Minimize.Image = Global.Evah_s_Nails.My.Resources.Resources.icon_Minimizar
        Me.btn_Minimize.Location = New System.Drawing.Point(338, 12)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(20, 20)
        Me.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Minimize.TabIndex = 1
        Me.btn_Minimize.TabStop = False
        '
        'btn_Close
        '
        Me.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Close.Image = Global.Evah_s_Nails.My.Resources.Resources.icon_Cerrar
        Me.btn_Close.Location = New System.Drawing.Point(369, 12)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(20, 20)
        Me.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Close.TabIndex = 0
        Me.btn_Close.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 567)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 15)
        Me.Panel1.TabIndex = 1
        '
        'txt_Usuario
        '
        Me.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.ForeColor = System.Drawing.Color.Indigo
        Me.txt_Usuario.Location = New System.Drawing.Point(47, 306)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(317, 19)
        Me.txt_Usuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(43, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User"
        '
        'txt_Contrasenia
        '
        Me.txt_Contrasenia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Contrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contrasenia.ForeColor = System.Drawing.Color.Indigo
        Me.txt_Contrasenia.Location = New System.Drawing.Point(47, 363)
        Me.txt_Contrasenia.Name = "txt_Contrasenia"
        Me.txt_Contrasenia.Size = New System.Drawing.Size(317, 19)
        Me.txt_Contrasenia.TabIndex = 4
        Me.txt_Contrasenia.UseSystemPasswordChar = True
        '
        'cBox_MostrarContraseña
        '
        Me.cBox_MostrarContraseña.AutoSize = True
        Me.cBox_MostrarContraseña.ForeColor = System.Drawing.Color.DarkViolet
        Me.cBox_MostrarContraseña.Location = New System.Drawing.Point(48, 427)
        Me.cBox_MostrarContraseña.Name = "cBox_MostrarContraseña"
        Me.cBox_MostrarContraseña.Size = New System.Drawing.Size(118, 17)
        Me.cBox_MostrarContraseña.TabIndex = 6
        Me.cBox_MostrarContraseña.Text = "Mostrar Contraseña"
        Me.cBox_MostrarContraseña.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(42, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Plum
        Me.btn_Login.FlatAppearance.BorderSize = 0
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.ForeColor = System.Drawing.Color.Indigo
        Me.btn_Login.Location = New System.Drawing.Point(48, 478)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(316, 58)
        Me.btn_Login.TabIndex = 8
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(401, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cBox_MostrarContraseña)
        Me.Controls.Add(Me.txt_Contrasenia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleBar As Panel
    Friend WithEvents btn_Close As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Minimize As PictureBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Contrasenia As TextBox
    Friend WithEvents cBox_MostrarContraseña As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
