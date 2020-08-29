<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLibrosYCatalogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibrosYCatalogos))
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvPrincipal = New System.Windows.Forms.ListView()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(10, 11)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 38
        Me.BtnCerrarForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "LIBROS Y CATALOGOS"
        '
        'lvPrincipal
        '
        Me.lvPrincipal.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvPrincipal.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPrincipal.FullRowSelect = True
        Me.lvPrincipal.GridLines = True
        Me.lvPrincipal.Location = New System.Drawing.Point(1, 34)
        Me.lvPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.lvPrincipal.MultiSelect = False
        Me.lvPrincipal.Name = "lvPrincipal"
        Me.lvPrincipal.Size = New System.Drawing.Size(846, 416)
        Me.lvPrincipal.TabIndex = 39
        Me.lvPrincipal.UseCompatibleStateImageBehavior = False
        Me.lvPrincipal.View = System.Windows.Forms.View.Details
        '
        'FrmLibrosYCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 450)
        Me.Controls.Add(Me.lvPrincipal)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLibrosYCatalogos"
        Me.Text = "FrmLibrosYCatalogos"
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lvPrincipal As ListView
End Class
