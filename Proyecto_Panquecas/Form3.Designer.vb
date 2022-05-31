<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim PrecioLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes_ProductosDataSet1 = New WindowsApplication1.Clientes_ProductosDataSet1()
        Me.ProductosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes_ProductosDataSet = New WindowsApplication1.Clientes_ProductosDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New WindowsApplication1.Clientes_ProductosDataSetTableAdapters.ProductosTableAdapter()
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New WindowsApplication1.Clientes_ProductosDataSetTableAdapters.TableAdapterManager()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ProductosTableAdapter1 = New WindowsApplication1.Clientes_ProductosDataSet1TableAdapters.ProductosTableAdapter()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.ProductosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes_ProductosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes_ProductosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(29, 95)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 21
        PrecioLabel.Text = "Precio:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(54, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Compra"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "¿Para llevar? (Coste: 5$)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seleccione"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(186, 272)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Coste Total"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(308, 208)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(308, 231)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProductosBindingSource4
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.ValueMember = "Nombre"
        '
        'ProductosBindingSource4
        '
        Me.ProductosBindingSource4.DataMember = "Productos"
        Me.ProductosBindingSource4.DataSource = Me.Clientes_ProductosDataSet1
        '
        'Clientes_ProductosDataSet1
        '
        Me.Clientes_ProductosDataSet1.DataSetName = "Clientes_ProductosDataSet1"
        Me.Clientes_ProductosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource3
        '
        Me.ProductosBindingSource3.DataMember = "Productos"
        '
        'Clientes_ProductosDataSet
        '
        Me.Clientes_ProductosDataSet.DataSetName = "Clientes_ProductosDataSet"
        Me.Clientes_ProductosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Clientes_ProductosDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "Productos"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(12, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 43)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Agregar a la compra"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Clientes_ProductosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(82, 92)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 22
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(188, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(141, 134)
        Me.ListBox1.TabIndex = 23
        '
        'ProductosTableAdapter1
        '
        Me.ProductosTableAdapter1.ClearBeforeFill = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(335, 27)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(33, 134)
        Me.ListBox2.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(291, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(277, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Si se equivoca, Seleccione para borrar: "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 33)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "IVA = 13% del total"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(379, 380)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Location = New System.Drawing.Point(150, 100)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transacción"
        CType(Me.ProductosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes_ProductosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes_ProductosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Clientes_ProductosDataSet As WindowsApplication1.Clientes_ProductosDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As WindowsApplication1.Clientes_ProductosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As WindowsApplication1.Clientes_ProductosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductosBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Clientes_ProductosDataSet1 As WindowsApplication1.Clientes_ProductosDataSet1
    Friend WithEvents ProductosBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter1 As WindowsApplication1.Clientes_ProductosDataSet1TableAdapters.ProductosTableAdapter
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
