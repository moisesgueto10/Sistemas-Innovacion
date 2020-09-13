<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_Reporte = New System.Windows.Forms.Button()
        Me.btn_Usuarios = New System.Windows.Forms.Button()
        Me.btn_Productos = New System.Windows.Forms.Button()
        Me.btn_Clientes = New System.Windows.Forms.Button()
        Me.btn_Servicios = New System.Windows.Forms.Button()
        Me.btn_Ventas = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Reporte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Usuarios)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Productos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Clientes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Servicios)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Ventas)
        Me.SplitContainer1.Size = New System.Drawing.Size(1364, 714)
        Me.SplitContainer1.SplitterDistance = 214
        Me.SplitContainer1.TabIndex = 1
        '
        'btn_Reporte
        '
        Me.btn_Reporte.BackColor = System.Drawing.Color.Orchid
        Me.btn_Reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Reporte.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_reportes
        Me.btn_Reporte.Location = New System.Drawing.Point(7, 609)
        Me.btn_Reporte.Name = "btn_Reporte"
        Me.btn_Reporte.Size = New System.Drawing.Size(201, 89)
        Me.btn_Reporte.TabIndex = 23
        Me.btn_Reporte.Text = "Generar Reporte"
        Me.btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Reporte.UseVisualStyleBackColor = False
        '
        'btn_Usuarios
        '
        Me.btn_Usuarios.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Usuarios.Font = New System.Drawing.Font("Adobe Devanagari", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Usuarios.ForeColor = System.Drawing.Color.GreenYellow
        Me.btn_Usuarios.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_usuarios
        Me.btn_Usuarios.Location = New System.Drawing.Point(7, 502)
        Me.btn_Usuarios.Name = "btn_Usuarios"
        Me.btn_Usuarios.Size = New System.Drawing.Size(201, 61)
        Me.btn_Usuarios.TabIndex = 22
        Me.btn_Usuarios.Text = "USUARIOS"
        Me.btn_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Usuarios.UseVisualStyleBackColor = False
        '
        'btn_Productos
        '
        Me.btn_Productos.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Productos.Font = New System.Drawing.Font("Adobe Devanagari", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Productos.ForeColor = System.Drawing.Color.GreenYellow
        Me.btn_Productos.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_productos
        Me.btn_Productos.Location = New System.Drawing.Point(7, 265)
        Me.btn_Productos.Name = "btn_Productos"
        Me.btn_Productos.Size = New System.Drawing.Size(201, 61)
        Me.btn_Productos.TabIndex = 21
        Me.btn_Productos.Text = "PRODUCTOS"
        Me.btn_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Productos.UseVisualStyleBackColor = False
        '
        'btn_Clientes
        '
        Me.btn_Clientes.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Clientes.Font = New System.Drawing.Font("Adobe Devanagari", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clientes.ForeColor = System.Drawing.Color.GreenYellow
        Me.btn_Clientes.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_clientes
        Me.btn_Clientes.Location = New System.Drawing.Point(7, 149)
        Me.btn_Clientes.Name = "btn_Clientes"
        Me.btn_Clientes.Size = New System.Drawing.Size(201, 61)
        Me.btn_Clientes.TabIndex = 20
        Me.btn_Clientes.Text = "CLIENTES"
        Me.btn_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Clientes.UseVisualStyleBackColor = False
        '
        'btn_Servicios
        '
        Me.btn_Servicios.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Servicios.Font = New System.Drawing.Font("Adobe Devanagari", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Servicios.ForeColor = System.Drawing.Color.GreenYellow
        Me.btn_Servicios.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_servicios
        Me.btn_Servicios.Location = New System.Drawing.Point(7, 386)
        Me.btn_Servicios.Name = "btn_Servicios"
        Me.btn_Servicios.Size = New System.Drawing.Size(201, 61)
        Me.btn_Servicios.TabIndex = 19
        Me.btn_Servicios.Text = "SERVICIOS"
        Me.btn_Servicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Servicios.UseVisualStyleBackColor = False
        '
        'btn_Ventas
        '
        Me.btn_Ventas.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Ventas.Font = New System.Drawing.Font("Adobe Devanagari", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ventas.ForeColor = System.Drawing.Color.GreenYellow
        Me.btn_Ventas.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_ventas
        Me.btn_Ventas.Location = New System.Drawing.Point(7, 17)
        Me.btn_Ventas.Name = "btn_Ventas"
        Me.btn_Ventas.Size = New System.Drawing.Size(201, 61)
        Me.btn_Ventas.TabIndex = 18
        Me.btn_Ventas.Text = "VENTAS"
        Me.btn_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Ventas.UseVisualStyleBackColor = False
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1364, 714)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evah´s Nails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btn_Reporte As Button
    Friend WithEvents btn_Usuarios As Button
    Friend WithEvents btn_Productos As Button
    Friend WithEvents btn_Clientes As Button
    Friend WithEvents btn_Servicios As Button
    Friend WithEvents btn_Ventas As Button
End Class
