﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registro_Servicios
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Registro_Servicios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.txt_Buscar_Servicio = New System.Windows.Forms.TextBox()
        Me.dgv_Tabla_Servicios = New System.Windows.Forms.DataGridView()
        Me.IdServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Evahs_NailsDataSet1 = New Evah_s_Nails.Evahs_NailsDataSet1()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Total_Servicios = New System.Windows.Forms.Label()
        Me.ServiciosTableAdapter = New Evah_s_Nails.Evahs_NailsDataSet1TableAdapters.ServiciosTableAdapter()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_Tabla_Servicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Evahs_NailsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID SERVICIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Text", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DESCRIPCIÓN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 39)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BUSCAR SERVICIO:"
        '
        'txt_Id
        '
        Me.txt_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Id.Location = New System.Drawing.Point(176, 256)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(183, 29)
        Me.txt_Id.TabIndex = 4
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(176, 351)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(183, 29)
        Me.txt_Nombre.TabIndex = 5
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descripcion.Location = New System.Drawing.Point(24, 460)
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(335, 115)
        Me.txt_Descripcion.TabIndex = 6
        '
        'txt_Buscar_Servicio
        '
        Me.txt_Buscar_Servicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Buscar_Servicio.Location = New System.Drawing.Point(649, 110)
        Me.txt_Buscar_Servicio.Name = "txt_Buscar_Servicio"
        Me.txt_Buscar_Servicio.Size = New System.Drawing.Size(311, 29)
        Me.txt_Buscar_Servicio.TabIndex = 7
        Me.txt_Buscar_Servicio.Tag = ""
        '
        'dgv_Tabla_Servicios
        '
        Me.dgv_Tabla_Servicios.AllowUserToAddRows = False
        Me.dgv_Tabla_Servicios.AutoGenerateColumns = False
        Me.dgv_Tabla_Servicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Tabla_Servicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Tabla_Servicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_Tabla_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Tabla_Servicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdServicioDataGridViewTextBoxColumn, Me.NombreServicioDataGridViewTextBoxColumn, Me.DescripcionServicioDataGridViewTextBoxColumn})
        Me.dgv_Tabla_Servicios.DataSource = Me.ServiciosBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tabla_Servicios.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tabla_Servicios.Location = New System.Drawing.Point(378, 214)
        Me.dgv_Tabla_Servicios.MultiSelect = False
        Me.dgv_Tabla_Servicios.Name = "dgv_Tabla_Servicios"
        Me.dgv_Tabla_Servicios.ReadOnly = True
        Me.dgv_Tabla_Servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tabla_Servicios.Size = New System.Drawing.Size(760, 535)
        Me.dgv_Tabla_Servicios.TabIndex = 8
        '
        'IdServicioDataGridViewTextBoxColumn
        '
        Me.IdServicioDataGridViewTextBoxColumn.DataPropertyName = "Id_Servicio"
        Me.IdServicioDataGridViewTextBoxColumn.HeaderText = "Id_Servicio"
        Me.IdServicioDataGridViewTextBoxColumn.Name = "IdServicioDataGridViewTextBoxColumn"
        Me.IdServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreServicioDataGridViewTextBoxColumn
        '
        Me.NombreServicioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Servicio"
        Me.NombreServicioDataGridViewTextBoxColumn.HeaderText = "Nombre_Servicio"
        Me.NombreServicioDataGridViewTextBoxColumn.Name = "NombreServicioDataGridViewTextBoxColumn"
        Me.NombreServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionServicioDataGridViewTextBoxColumn
        '
        Me.DescripcionServicioDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Servicio"
        Me.DescripcionServicioDataGridViewTextBoxColumn.HeaderText = "Descripcion_Servicio"
        Me.DescripcionServicioDataGridViewTextBoxColumn.Name = "DescripcionServicioDataGridViewTextBoxColumn"
        Me.DescripcionServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.Evahs_NailsDataSet1
        '
        'Evahs_NailsDataSet1
        '
        Me.Evahs_NailsDataSet1.DataSetName = "Evahs_NailsDataSet1"
        Me.Evahs_NailsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Evah_s_Nails.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(24, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lbl_Total_Servicios
        '
        Me.lbl_Total_Servicios.AutoSize = True
        Me.lbl_Total_Servicios.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Servicios.Location = New System.Drawing.Point(919, 686)
        Me.lbl_Total_Servicios.Name = "lbl_Total_Servicios"
        Me.lbl_Total_Servicios.Size = New System.Drawing.Size(186, 21)
        Me.lbl_Total_Servicios.TabIndex = 11
        Me.lbl_Total_Servicios.Text = "Total Servicios:"
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'btn_Registrar
        '
        Me.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Registrar.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Registrar.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_agregar
        Me.btn_Registrar.Location = New System.Drawing.Point(89, 595)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(220, 88)
        Me.btn_Registrar.TabIndex = 20
        Me.btn_Registrar.Text = "GUARDAR"
        Me.btn_Registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Registrar.UseVisualStyleBackColor = False
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Editar.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = Global.Evah_s_Nails.My.Resources.Resources.icono_editar
        Me.btn_Editar.Location = New System.Drawing.Point(966, 80)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(172, 62)
        Me.btn_Editar.TabIndex = 21
        Me.btn_Editar.Text = "Editar Producto"
        Me.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Editar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Plum
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(511, 41)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "RESGISTRO   DE   SERVICIOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form_Registro_Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1150, 714)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.btn_Registrar)
        Me.Controls.Add(Me.lbl_Total_Servicios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_Tabla_Servicios)
        Me.Controls.Add(Me.txt_Buscar_Servicio)
        Me.Controls.Add(Me.txt_Descripcion)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Registro_Servicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registro de Servicios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_Tabla_Servicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Evahs_NailsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Descripcion As TextBox
    Friend WithEvents txt_Buscar_Servicio As TextBox
    Friend WithEvents dgv_Tabla_Servicios As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_Total_Servicios As Label
    Friend WithEvents Evahs_NailsDataSet1 As Evahs_NailsDataSet1
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As Evahs_NailsDataSet1TableAdapters.ServiciosTableAdapter
    Friend WithEvents IdServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents btn_Editar As Button
    Friend WithEvents Label5 As Label
End Class
