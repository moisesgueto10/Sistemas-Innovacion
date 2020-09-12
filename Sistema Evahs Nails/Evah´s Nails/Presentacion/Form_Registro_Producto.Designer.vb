<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registro_Producto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Registro_Producto))
        Me.dgv_Tabla_Producto = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_Total_Productos = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Compra = New System.Windows.Forms.TextBox()
        Me.txt_Venta = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.cBox_Tipo = New System.Windows.Forms.ComboBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        CType(Me.dgv_Tabla_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Tabla_Producto
        '
        Me.dgv_Tabla_Producto.AllowUserToAddRows = False
        Me.dgv_Tabla_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Tabla_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tabla_Producto.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tabla_Producto.Location = New System.Drawing.Point(12, 77)
        Me.dgv_Tabla_Producto.Name = "dgv_Tabla_Producto"
        Me.dgv_Tabla_Producto.ReadOnly = True
        Me.dgv_Tabla_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tabla_Producto.Size = New System.Drawing.Size(725, 562)
        Me.dgv_Tabla_Producto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BUSCAR PRODUCTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(786, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID PRODUCTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(844, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NOMBRE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(844, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "COMPRA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(867, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "VENTA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(828, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "CANTIDAD:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(756, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TIPO PRODUCTO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(743, 442)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "FECHA REGISTRO:"
        '
        'lbl_Total_Productos
        '
        Me.lbl_Total_Productos.AutoSize = True
        Me.lbl_Total_Productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Productos.Location = New System.Drawing.Point(594, 653)
        Me.lbl_Total_Productos.Name = "lbl_Total_Productos"
        Me.lbl_Total_Productos.Size = New System.Drawing.Size(106, 16)
        Me.lbl_Total_Productos.TabIndex = 9
        Me.lbl_Total_Productos.Text = "Total Productos:"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Buscar.Location = New System.Drawing.Point(278, 38)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(265, 26)
        Me.txt_Buscar.TabIndex = 10
        '
        'txt_Id
        '
        Me.txt_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Id.Location = New System.Drawing.Point(967, 77)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(337, 26)
        Me.txt_Id.TabIndex = 11
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(967, 134)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(337, 26)
        Me.txt_Nombre.TabIndex = 12
        '
        'txt_Compra
        '
        Me.txt_Compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Compra.Location = New System.Drawing.Point(967, 189)
        Me.txt_Compra.Name = "txt_Compra"
        Me.txt_Compra.Size = New System.Drawing.Size(118, 26)
        Me.txt_Compra.TabIndex = 13
        '
        'txt_Venta
        '
        Me.txt_Venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Venta.Location = New System.Drawing.Point(967, 250)
        Me.txt_Venta.Name = "txt_Venta"
        Me.txt_Venta.Size = New System.Drawing.Size(118, 26)
        Me.txt_Venta.TabIndex = 14
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.Location = New System.Drawing.Point(967, 313)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(118, 26)
        Me.txt_Cantidad.TabIndex = 15
        '
        'cBox_Tipo
        '
        Me.cBox_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cBox_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.cBox_Tipo.FormattingEnabled = True
        Me.cBox_Tipo.Items.AddRange(New Object() {"SALON", "VENTA"})
        Me.cBox_Tipo.Location = New System.Drawing.Point(967, 376)
        Me.cBox_Tipo.Name = "cBox_Tipo"
        Me.cBox_Tipo.Size = New System.Drawing.Size(147, 28)
        Me.cBox_Tipo.TabIndex = 16
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.dtp_Fecha.Location = New System.Drawing.Point(967, 441)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(305, 26)
        Me.dtp_Fecha.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Evah_s_Nails.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(31, 648)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Location = New System.Drawing.Point(872, 551)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(343, 88)
        Me.btn_Guardar.TabIndex = 19
        Me.btn_Guardar.Text = "GUARDAR"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Location = New System.Drawing.Point(585, 38)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(145, 33)
        Me.btn_Editar.TabIndex = 20
        Me.btn_Editar.Text = "Editar Producto"
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'Form_Registro_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1364, 710)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtp_Fecha)
        Me.Controls.Add(Me.cBox_Tipo)
        Me.Controls.Add(Me.txt_Cantidad)
        Me.Controls.Add(Me.txt_Venta)
        Me.Controls.Add(Me.txt_Compra)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.txt_Buscar)
        Me.Controls.Add(Me.lbl_Total_Productos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_Tabla_Producto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Registro_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_Tabla_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Tabla_Producto As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_Total_Productos As Label
    Friend WithEvents txt_Buscar As TextBox
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Compra As TextBox
    Friend WithEvents txt_Venta As TextBox
    Friend WithEvents txt_Cantidad As TextBox
    Friend WithEvents cBox_Tipo As ComboBox
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents btn_Editar As Button
End Class
