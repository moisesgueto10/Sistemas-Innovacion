<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editar_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Editar_Cliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Identificacion = New System.Windows.Forms.TextBox()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.box_Fecha_Registro = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(74, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(52, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(56, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TELEFONO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(2, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IDENTIFICACION"
        '
        'txt_Id
        '
        Me.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Id.Enabled = False
        Me.txt_Id.Font = New System.Drawing.Font("Sitka Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Id.Location = New System.Drawing.Point(189, 21)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.ReadOnly = True
        Me.txt_Id.Size = New System.Drawing.Size(70, 37)
        Me.txt_Id.TabIndex = 5
        Me.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(162, 133)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(223, 26)
        Me.txt_Nombre.TabIndex = 6
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Direccion.Location = New System.Drawing.Point(162, 184)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(223, 26)
        Me.txt_Direccion.TabIndex = 7
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Telefono.Location = New System.Drawing.Point(162, 253)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(223, 26)
        Me.txt_Telefono.TabIndex = 8
        '
        'txt_Identificacion
        '
        Me.txt_Identificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Identificacion.Location = New System.Drawing.Point(162, 319)
        Me.txt_Identificacion.Name = "txt_Identificacion"
        Me.txt_Identificacion.Size = New System.Drawing.Size(223, 26)
        Me.txt_Identificacion.TabIndex = 9
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Signika", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Location = New System.Drawing.Point(77, 376)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(265, 53)
        Me.btn_Editar.TabIndex = 10
        Me.btn_Editar.Text = "EDITAR"
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(7, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "FECHA DE REGISTRO"
        '
        'box_Fecha_Registro
        '
        Me.box_Fecha_Registro.Enabled = False
        Me.box_Fecha_Registro.Location = New System.Drawing.Point(198, 83)
        Me.box_Fecha_Registro.Name = "box_Fecha_Registro"
        Me.box_Fecha_Registro.Size = New System.Drawing.Size(200, 20)
        Me.box_Fecha_Registro.TabIndex = 12
        '
        'Form_Editar_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(414, 441)
        Me.Controls.Add(Me.box_Fecha_Registro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.txt_Identificacion)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Editar_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Direccion As TextBox
    Friend WithEvents txt_Telefono As TextBox
    Friend WithEvents txt_Identificacion As TextBox
    Friend WithEvents btn_Editar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents box_Fecha_Registro As DateTimePicker
End Class
