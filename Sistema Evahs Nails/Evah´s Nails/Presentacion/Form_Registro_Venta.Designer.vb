<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registro_Venta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStockProducto = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBEstadoProducto = New System.Windows.Forms.ComboBox()
        Me.txtCantidadProducto = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrecioServicio = New System.Windows.Forms.TextBox()
        Me.btnAgregarServicio = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBEstadoServicio = New System.Windows.Forms.ComboBox()
        Me.txtCantidadServicio = New System.Windows.Forms.NumericUpDown()
        Me.CBNombreServicio = New System.Windows.Forms.ComboBox()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Evahs_NailsDataSet = New Evah_s_Nails.Evahs_NailsDataSet()
        Me.DGFactura = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnGuardarEImprimir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNumeroFactura = New System.Windows.Forms.Label()
        Me.Evahs_NailsDataSet1 = New Evah_s_Nails.Evahs_NailsDataSet()
        Me.Evahs_NailsDataSet2 = New Evah_s_Nails.Evahs_NailsDataSet()
        Me.ServiciosTableAdapter = New Evah_s_Nails.Evahs_NailsDataSetTableAdapters.ServiciosTableAdapter()
        Me.lblFacturaNumero = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtStockProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCantidadServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Evahs_NailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Evahs_NailsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Evahs_NailsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPrecioProducto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtStockProducto)
        Me.GroupBox1.Controls.Add(Me.btnAgregarProducto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionProducto)
        Me.GroupBox1.Controls.Add(Me.txtCodigoProducto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CBEstadoProducto)
        Me.GroupBox1.Controls.Add(Me.txtCantidadProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 213)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.Location = New System.Drawing.Point(65, 70)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(121, 20)
        Me.txtPrecioProducto.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(213, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Stock"
        '
        'txtStockProducto
        '
        Me.txtStockProducto.Location = New System.Drawing.Point(254, 97)
        Me.txtStockProducto.Name = "txtStockProducto"
        Me.txtStockProducto.Size = New System.Drawing.Size(44, 20)
        Me.txtStockProducto.TabIndex = 21
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Enabled = False
        Me.btnAgregarProducto.Location = New System.Drawing.Point(6, 155)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(121, 23)
        Me.btnAgregarProducto.TabIndex = 20
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Codigo"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(65, 43)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(121, 20)
        Me.txtDescripcionProducto.TabIndex = 18
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(65, 14)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoProducto.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Producto"
        '
        'CBEstadoProducto
        '
        Me.CBEstadoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEstadoProducto.Items.AddRange(New Object() {"No Pagado", "Pagado"})
        Me.CBEstadoProducto.Location = New System.Drawing.Point(64, 123)
        Me.CBEstadoProducto.Name = "CBEstadoProducto"
        Me.CBEstadoProducto.Size = New System.Drawing.Size(121, 21)
        Me.CBEstadoProducto.TabIndex = 12
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.Location = New System.Drawing.Point(65, 97)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(120, 20)
        Me.txtCantidadProducto.TabIndex = 11
        Me.txtCantidadProducto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPrecioServicio)
        Me.GroupBox2.Controls.Add(Me.btnAgregarServicio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CBEstadoServicio)
        Me.GroupBox2.Controls.Add(Me.txtCantidadServicio)
        Me.GroupBox2.Controls.Add(Me.CBNombreServicio)
        Me.GroupBox2.Location = New System.Drawing.Point(534, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 213)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servicios"
        '
        'txtPrecioServicio
        '
        Me.txtPrecioServicio.Location = New System.Drawing.Point(99, 50)
        Me.txtPrecioServicio.Name = "txtPrecioServicio"
        Me.txtPrecioServicio.Size = New System.Drawing.Size(121, 20)
        Me.txtPrecioServicio.TabIndex = 24
        '
        'btnAgregarServicio
        '
        Me.btnAgregarServicio.Location = New System.Drawing.Point(10, 155)
        Me.btnAgregarServicio.Name = "btnAgregarServicio"
        Me.btnAgregarServicio.Size = New System.Drawing.Size(121, 23)
        Me.btnAgregarServicio.TabIndex = 21
        Me.btnAgregarServicio.Text = "Agregar Servicio"
        Me.btnAgregarServicio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Servicio"
        '
        'CBEstadoServicio
        '
        Me.CBEstadoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEstadoServicio.FormattingEnabled = True
        Me.CBEstadoServicio.Items.AddRange(New Object() {"No Pagado", "Pagado"})
        Me.CBEstadoServicio.Location = New System.Drawing.Point(99, 103)
        Me.CBEstadoServicio.Name = "CBEstadoServicio"
        Me.CBEstadoServicio.Size = New System.Drawing.Size(121, 21)
        Me.CBEstadoServicio.TabIndex = 4
        '
        'txtCantidadServicio
        '
        Me.txtCantidadServicio.Location = New System.Drawing.Point(99, 77)
        Me.txtCantidadServicio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidadServicio.Name = "txtCantidadServicio"
        Me.txtCantidadServicio.Size = New System.Drawing.Size(120, 20)
        Me.txtCantidadServicio.TabIndex = 3
        Me.txtCantidadServicio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CBNombreServicio
        '
        Me.CBNombreServicio.DataSource = Me.ServiciosBindingSource
        Me.CBNombreServicio.DisplayMember = "Nombre_Servicio"
        Me.CBNombreServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNombreServicio.FormattingEnabled = True
        Me.CBNombreServicio.Location = New System.Drawing.Point(99, 23)
        Me.CBNombreServicio.Name = "CBNombreServicio"
        Me.CBNombreServicio.Size = New System.Drawing.Size(121, 21)
        Me.CBNombreServicio.TabIndex = 0
        Me.CBNombreServicio.ValueMember = "Id_Servicio"
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.Evahs_NailsDataSet
        '
        'Evahs_NailsDataSet
        '
        Me.Evahs_NailsDataSet.DataSetName = "Evahs_NailsDataSet"
        Me.Evahs_NailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGFactura
        '
        Me.DGFactura.AllowUserToAddRows = False
        Me.DGFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGFactura.Location = New System.Drawing.Point(13, 260)
        Me.DGFactura.Name = "DGFactura"
        Me.DGFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGFactura.Size = New System.Drawing.Size(1037, 274)
        Me.DGFactura.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(13, 540)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(94, 540)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnGuardarEImprimir
        '
        Me.btnGuardarEImprimir.Location = New System.Drawing.Point(175, 540)
        Me.btnGuardarEImprimir.Name = "btnGuardarEImprimir"
        Me.btnGuardarEImprimir.Size = New System.Drawing.Size(103, 23)
        Me.btnGuardarEImprimir.TabIndex = 7
        Me.btnGuardarEImprimir.Text = "Guardar e imprimir"
        Me.btnGuardarEImprimir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Numero factura:"
        '
        'lblNumeroFactura
        '
        Me.lblNumeroFactura.AutoSize = True
        Me.lblNumeroFactura.Location = New System.Drawing.Point(620, 40)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(0, 13)
        Me.lblNumeroFactura.TabIndex = 9
        '
        'Evahs_NailsDataSet1
        '
        Me.Evahs_NailsDataSet1.DataSetName = "Evahs_NailsDataSet"
        Me.Evahs_NailsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Evahs_NailsDataSet2
        '
        Me.Evahs_NailsDataSet2.DataSetName = "Evahs_NailsDataSet"
        Me.Evahs_NailsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'lblFacturaNumero
        '
        Me.lblFacturaNumero.AutoSize = True
        Me.lblFacturaNumero.Location = New System.Drawing.Point(98, 9)
        Me.lblFacturaNumero.Name = "lblFacturaNumero"
        Me.lblFacturaNumero.Size = New System.Drawing.Size(0, 13)
        Me.lblFacturaNumero.TabIndex = 10
        '
        'Form_Registro_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 575)
        Me.Controls.Add(Me.lblFacturaNumero)
        Me.Controls.Add(Me.lblNumeroFactura)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnGuardarEImprimir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.DGFactura)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Registro_Venta"
        Me.Text = "Form_Registro_Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtStockProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCantidadServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Evahs_NailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Evahs_NailsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Evahs_NailsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBEstadoServicio As ComboBox
    Friend WithEvents txtCantidadServicio As NumericUpDown
    Friend WithEvents CBNombreServicio As ComboBox
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CBEstadoProducto As ComboBox
    Friend WithEvents txtCantidadProducto As NumericUpDown
    Friend WithEvents btnAgregarServicio As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGFactura As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnGuardarEImprimir As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNumeroFactura As Label
    Friend WithEvents Evahs_NailsDataSet1 As Evahs_NailsDataSet
    Friend WithEvents Evahs_NailsDataSet2 As Evahs_NailsDataSet
    Friend WithEvents Evahs_NailsDataSet As Evahs_NailsDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As Evahs_NailsDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStockProducto As NumericUpDown
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents txtPrecioServicio As TextBox
    Friend WithEvents lblFacturaNumero As Label
End Class
