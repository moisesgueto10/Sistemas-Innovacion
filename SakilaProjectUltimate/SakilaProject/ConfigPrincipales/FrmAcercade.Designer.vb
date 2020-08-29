<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAcercade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcercade))
        Me.LblContenido = New System.Windows.Forms.Label()
        Me.BtnRestricciones = New System.Windows.Forms.Button()
        Me.BtnExtras = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblContenido
        '
        Me.LblContenido.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblContenido.Location = New System.Drawing.Point(70, 65)
        Me.LblContenido.Name = "LblContenido"
        Me.LblContenido.Size = New System.Drawing.Size(718, 385)
        Me.LblContenido.TabIndex = 196
        Me.LblContenido.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'BtnRestricciones
        '
        Me.BtnRestricciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestricciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BtnRestricciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnRestricciones.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnRestricciones.FlatAppearance.BorderSize = 0
        Me.BtnRestricciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnRestricciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnRestricciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestricciones.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestricciones.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnRestricciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRestricciones.Location = New System.Drawing.Point(526, 8)
        Me.BtnRestricciones.Name = "BtnRestricciones"
        Me.BtnRestricciones.Size = New System.Drawing.Size(128, 30)
        Me.BtnRestricciones.TabIndex = 198
        Me.BtnRestricciones.Text = "Restricciones"
        Me.BtnRestricciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRestricciones.UseVisualStyleBackColor = False
        '
        'BtnExtras
        '
        Me.BtnExtras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BtnExtras.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnExtras.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnExtras.FlatAppearance.BorderSize = 0
        Me.BtnExtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnExtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExtras.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExtras.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExtras.Location = New System.Drawing.Point(660, 8)
        Me.BtnExtras.Name = "BtnExtras"
        Me.BtnExtras.Size = New System.Drawing.Size(128, 30)
        Me.BtnExtras.TabIndex = 199
        Me.BtnExtras.Text = "Extras"
        Me.BtnExtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExtras.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 23)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "ACERCA DE "
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelCabecera.Controls.Add(Me.BtnCerrarForm)
        Me.PanelCabecera.Controls.Add(Me.Label1)
        Me.PanelCabecera.Controls.Add(Me.BtnExtras)
        Me.PanelCabecera.Controls.Add(Me.BtnRestricciones)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(800, 41)
        Me.PanelCabecera.TabIndex = 201
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(10, 13)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnCerrarForm.TabIndex = 40
        Me.BtnCerrarForm.TabStop = False
        '
        'FrmAcercade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelCabecera)
        Me.Controls.Add(Me.LblContenido)
        Me.Name = "FrmAcercade"
        Me.Text = "FrmAcercade"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents LblContenido As Label
    Private WithEvents BtnRestricciones As Button
    Private WithEvents BtnExtras As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents BtnCerrarForm As PictureBox
End Class
