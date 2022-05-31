<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Nombre_y_ApellidoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Ultima_CompraLabel As System.Windows.Forms.Label
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreYApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes_ProductosDataSet4 = New WindowsApplication1.Clientes_ProductosDataSet4()
        Me.ClientesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter3 = New WindowsApplication1.Clientes_ProductosDataSet4TableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager2 = New WindowsApplication1.Clientes_ProductosDataSet4TableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_y_ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Ultima_CompraLabel1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        IDLabel = New System.Windows.Forms.Label()
        Nombre_y_ApellidoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Ultima_CompraLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes_ProductosDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(21, 88)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 16
        IDLabel.Text = "ID:"
        '
        'Nombre_y_ApellidoLabel
        '
        Nombre_y_ApellidoLabel.AutoSize = True
        Nombre_y_ApellidoLabel.Location = New System.Drawing.Point(21, 114)
        Nombre_y_ApellidoLabel.Name = "Nombre_y_ApellidoLabel"
        Nombre_y_ApellidoLabel.Size = New System.Drawing.Size(95, 13)
        Nombre_y_ApellidoLabel.TabIndex = 18
        Nombre_y_ApellidoLabel.Text = "Nombre y Apellido:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(21, 140)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 20
        TelefonoLabel.Text = "Telefono:"
        '
        'Ultima_CompraLabel
        '
        Ultima_CompraLabel.AutoSize = True
        Ultima_CompraLabel.Location = New System.Drawing.Point(21, 160)
        Ultima_CompraLabel.Name = "Ultima_CompraLabel"
        Ultima_CompraLabel.Size = New System.Drawing.Size(78, 13)
        Ultima_CompraLabel.TabIndex = 22
        Ultima_CompraLabel.Text = "Ultima Compra:"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 74)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Porfavor registra sus datos para la factura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(531, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(14, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(148, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(541, 292)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 59)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Finalizar"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Clientes Registrados"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(289, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 33)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 86)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Gracias por su compra de: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(305, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 40)
        Me.Label4.TabIndex = 15
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NombreYApellidoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.UltimaCompraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NombreYApellidoDataGridViewTextBoxColumn
        '
        Me.NombreYApellidoDataGridViewTextBoxColumn.DataPropertyName = "Nombre y Apellido"
        Me.NombreYApellidoDataGridViewTextBoxColumn.HeaderText = "Nombre y Apellido"
        Me.NombreYApellidoDataGridViewTextBoxColumn.Name = "NombreYApellidoDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'UltimaCompraDataGridViewTextBoxColumn
        '
        Me.UltimaCompraDataGridViewTextBoxColumn.DataPropertyName = "Ultima Compra"
        Me.UltimaCompraDataGridViewTextBoxColumn.HeaderText = "Ultima Compra"
        Me.UltimaCompraDataGridViewTextBoxColumn.Name = "UltimaCompraDataGridViewTextBoxColumn"
        '
        'ClientesBindingSource3
        '
        Me.ClientesBindingSource3.DataMember = "Clientes"
        Me.ClientesBindingSource3.DataSource = Me.Clientes_ProductosDataSet4
        '
        'Clientes_ProductosDataSet4
        '
        Me.Clientes_ProductosDataSet4.DataSetName = "Clientes_ProductosDataSet4"
        Me.Clientes_ProductosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource2
        '
        Me.ClientesBindingSource2.DataMember = "Clientes"
        '
        'ClientesTableAdapter3
        '
        Me.ClientesTableAdapter3.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ClientesTableAdapter = Me.ClientesTableAdapter3
        Me.TableAdapterManager2.UpdateOrder = WindowsApplication1.Clientes_ProductosDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource3, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(122, 85)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 17
        '
        'Nombre_y_ApellidoTextBox
        '
        Me.Nombre_y_ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource3, "Nombre y Apellido", True))
        Me.Nombre_y_ApellidoTextBox.Location = New System.Drawing.Point(122, 111)
        Me.Nombre_y_ApellidoTextBox.Name = "Nombre_y_ApellidoTextBox"
        Me.Nombre_y_ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_y_ApellidoTextBox.TabIndex = 19
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource3, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(122, 137)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 21
        '
        'Ultima_CompraLabel1
        '
        Me.Ultima_CompraLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource3, "Ultima Compra", True))
        Me.Ultima_CompraLabel1.Location = New System.Drawing.Point(122, 160)
        Me.Ultima_CompraLabel1.Name = "Ultima_CompraLabel1"
        Me.Ultima_CompraLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Ultima_CompraLabel1.TabIndex = 23
        Me.Ultima_CompraLabel1.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(282, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 45)
        Me.Label5.TabIndex = 24
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(27, 207)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 62)
        Me.Panel1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Ultima_CompraLabel1)
        Me.Panel2.Controls.Add(Ultima_CompraLabel)
        Me.Panel2.Controls.Add(IDLabel)
        Me.Panel2.Controls.Add(Me.TelefonoTextBox)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Controls.Add(TelefonoLabel)
        Me.Panel2.Controls.Add(Nombre_y_ApellidoLabel)
        Me.Panel2.Controls.Add(Me.Nombre_y_ApellidoTextBox)
        Me.Panel2.Location = New System.Drawing.Point(476, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 186)
        Me.Panel2.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(9, 262)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(512, 107)
        Me.Panel3.TabIndex = 27
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(730, 374)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Location = New System.Drawing.Point(370, 100)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Factura"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes_ProductosDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClientesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Clientes_ProductosDataSet4 As WindowsApplication1.Clientes_ProductosDataSet4
    Friend WithEvents ClientesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter3 As WindowsApplication1.Clientes_ProductosDataSet4TableAdapters.ClientesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreYApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimaCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager2 As WindowsApplication1.Clientes_ProductosDataSet4TableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_y_ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ultima_CompraLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
