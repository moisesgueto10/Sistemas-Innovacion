<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registro_Cliente
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
        Me.lbl_BuscarCliente = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.data_TablaClientes = New System.Windows.Forms.DataGridView()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.lbl_TotalRegistros = New System.Windows.Forms.Label()
        Me.Evahs_NailsDataSet = New Evah_s_Nails.Evahs_NailsDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Evah_s_Nails.Evahs_NailsDataSetTableAdapters.ClientesTableAdapter()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.data_TablaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Evahs_NailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_BuscarCliente
        '
        Me.lbl_BuscarCliente.AutoSize = True
        Me.lbl_BuscarCliente.Font = New System.Drawing.Font("Articulate", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BuscarCliente.Location = New System.Drawing.Point(57, 71)
        Me.lbl_BuscarCliente.Name = "lbl_BuscarCliente"
        Me.lbl_BuscarCliente.Size = New System.Drawing.Size(155, 23)
        Me.lbl_BuscarCliente.TabIndex = 0
        Me.lbl_BuscarCliente.Text = "Buscar Cliente ..."
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Buscar.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txt_Buscar.Location = New System.Drawing.Point(226, 68)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(590, 26)
        Me.txt_Buscar.TabIndex = 1
        '
        'data_TablaClientes
        '
        Me.data_TablaClientes.AutoGenerateColumns = False
        Me.data_TablaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.data_TablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_TablaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.IdentificacionDataGridViewTextBoxColumn, Me.FechaRegistroDataGridViewTextBoxColumn})
        Me.data_TablaClientes.DataSource = Me.ClientesBindingSource
        Me.data_TablaClientes.Location = New System.Drawing.Point(12, 169)
        Me.data_TablaClientes.Name = "data_TablaClientes"
        Me.data_TablaClientes.Size = New System.Drawing.Size(1121, 534)
        Me.data_TablaClientes.TabIndex = 2
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Font = New System.Drawing.Font("Swis721 Blk BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.Location = New System.Drawing.Point(1151, 169)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(189, 57)
        Me.btn_Nuevo.TabIndex = 3
        Me.btn_Nuevo.Text = "NUEVO"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Swis721 Blk BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Location = New System.Drawing.Point(1151, 266)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(189, 57)
        Me.btn_Editar.TabIndex = 4
        Me.btn_Editar.Text = "EDITAR"
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'lbl_TotalRegistros
        '
        Me.lbl_TotalRegistros.AutoSize = True
        Me.lbl_TotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalRegistros.Location = New System.Drawing.Point(1139, 687)
        Me.lbl_TotalRegistros.Name = "lbl_TotalRegistros"
        Me.lbl_TotalRegistros.Size = New System.Drawing.Size(119, 16)
        Me.lbl_TotalRegistros.TabIndex = 5
        Me.lbl_TotalRegistros.Text = "Total de Registros"
        '
        'Evahs_NailsDataSet
        '
        Me.Evahs_NailsDataSet.DataSetName = "Evahs_NailsDataSet"
        Me.Evahs_NailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Evahs_NailsDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Cliente"
        Me.IdClienteDataGridViewTextBoxColumn.Frozen = True
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdClienteDataGridViewTextBoxColumn.Width = 130
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.Frozen = True
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.Width = 300
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Frozen = True
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.Width = 150
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Frozen = True
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 150
        '
        'IdentificacionDataGridViewTextBoxColumn
        '
        Me.IdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.Frozen = True
        Me.IdentificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.Name = "IdentificacionDataGridViewTextBoxColumn"
        Me.IdentificacionDataGridViewTextBoxColumn.Width = 200
        '
        'FechaRegistroDataGridViewTextBoxColumn
        '
        Me.FechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Registro"
        Me.FechaRegistroDataGridViewTextBoxColumn.Frozen = True
        Me.FechaRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha de Registro"
        Me.FechaRegistroDataGridViewTextBoxColumn.Name = "FechaRegistroDataGridViewTextBoxColumn"
        Me.FechaRegistroDataGridViewTextBoxColumn.Width = 150
        '
        'Form_Registro_Cliente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1360, 706)
        Me.Controls.Add(Me.lbl_TotalRegistros)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.data_TablaClientes)
        Me.Controls.Add(Me.txt_Buscar)
        Me.Controls.Add(Me.lbl_BuscarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(850, 520)
        Me.Name = "Form_Registro_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data_TablaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Evahs_NailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_BuscarCliente As Label
    Friend WithEvents txt_Buscar As TextBox
    Friend WithEvents data_TablaClientes As DataGridView
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Editar As Button
    Friend WithEvents lbl_TotalRegistros As Label
    Friend WithEvents Evahs_NailsDataSet As Evahs_NailsDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As Evahs_NailsDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
