<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Nuevo_Cliente
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
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_Identificacion = New System.Windows.Forms.Label()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.lbl_Fecha_Registro = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Identificacion = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.box_Fecha_Registro = New System.Windows.Forms.DateTimePicker()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.lbl_Nombre.Location = New System.Drawing.Point(36, 84)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(158, 22)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre Completo"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.lbl_Telefono.Location = New System.Drawing.Point(36, 142)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(79, 22)
        Me.lbl_Telefono.TabIndex = 2
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'lbl_Identificacion
        '
        Me.lbl_Identificacion.AutoSize = True
        Me.lbl_Identificacion.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.lbl_Identificacion.Location = New System.Drawing.Point(36, 199)
        Me.lbl_Identificacion.Name = "lbl_Identificacion"
        Me.lbl_Identificacion.Size = New System.Drawing.Size(120, 22)
        Me.lbl_Identificacion.TabIndex = 3
        Me.lbl_Identificacion.Text = "Identificación"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.lbl_Direccion.Location = New System.Drawing.Point(36, 258)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(87, 22)
        Me.lbl_Direccion.TabIndex = 4
        Me.lbl_Direccion.Text = "Dirección"
        '
        'lbl_Fecha_Registro
        '
        Me.lbl_Fecha_Registro.AutoSize = True
        Me.lbl_Fecha_Registro.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.lbl_Fecha_Registro.Location = New System.Drawing.Point(36, 317)
        Me.lbl_Fecha_Registro.Name = "lbl_Fecha_Registro"
        Me.lbl_Fecha_Registro.Size = New System.Drawing.Size(150, 22)
        Me.lbl_Fecha_Registro.TabIndex = 5
        Me.lbl_Fecha_Registro.Text = "Fecha de Registro"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(217, 80)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(265, 26)
        Me.txt_Nombre.TabIndex = 7
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Telefono.Location = New System.Drawing.Point(217, 138)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(265, 26)
        Me.txt_Telefono.TabIndex = 8
        '
        'txt_Identificacion
        '
        Me.txt_Identificacion.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Identificacion.Location = New System.Drawing.Point(217, 195)
        Me.txt_Identificacion.Name = "txt_Identificacion"
        Me.txt_Identificacion.Size = New System.Drawing.Size(265, 26)
        Me.txt_Identificacion.TabIndex = 9
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Direccion.Location = New System.Drawing.Point(217, 258)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(265, 26)
        Me.txt_Direccion.TabIndex = 10
        '
        'box_Fecha_Registro
        '
        Me.box_Fecha_Registro.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_Fecha_Registro.Location = New System.Drawing.Point(217, 319)
        Me.box_Fecha_Registro.Name = "box_Fecha_Registro"
        Me.box_Fecha_Registro.Size = New System.Drawing.Size(265, 23)
        Me.box_Fecha_Registro.TabIndex = 11
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_Guardar.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Location = New System.Drawing.Point(139, 412)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(217, 66)
        Me.btn_Guardar.TabIndex = 12
        Me.btn_Guardar.Text = "GUARDAR"
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'Form_Nuevo_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(494, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.box_Fecha_Registro)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.txt_Identificacion)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Fecha_Registro)
        Me.Controls.Add(Me.lbl_Direccion)
        Me.Controls.Add(Me.lbl_Identificacion)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.MaximizeBox = False
        Me.Name = "Form_Nuevo_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_Telefono As Label
    Friend WithEvents lbl_Identificacion As Label
    Friend WithEvents lbl_Direccion As Label
    Friend WithEvents lbl_Fecha_Registro As Label
    Friend WithEvents btn_Guardar As Button
    Public WithEvents txt_Nombre As TextBox
    Public WithEvents txt_Telefono As TextBox
    Public WithEvents txt_Identificacion As TextBox
    Public WithEvents txt_Direccion As TextBox
    Public WithEvents box_Fecha_Registro As DateTimePicker
End Class
