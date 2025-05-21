<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PriemnayaKomissiyaDataSet13 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet13()
        Me.СпециальностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностиTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet13TableAdapters.СпециальностиTableAdapter()
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.НаименованиеСпециальностиDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.СпециальностиBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(182, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(702, 378)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 599)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Добавить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(449, 599)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Удалить"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(634, 599)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 56)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Сохранить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СпециальностиBindingSource, "Наименование специальности", True))
        Me.TextBox1.Location = New System.Drawing.Point(330, 525)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(417, 22)
        Me.TextBox1.TabIndex = 4
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.IndianRed
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBack.Location = New System.Drawing.Point(224, 732)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(651, 37)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Назад"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'PriemnayaKomissiyaDataSet13
        '
        Me.PriemnayaKomissiyaDataSet13.DataSetName = "PriemnayaKomissiyaDataSet13"
        Me.PriemnayaKomissiyaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СпециальностиBindingSource
        '
        Me.СпециальностиBindingSource.DataMember = "Специальности"
        Me.СпециальностиBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet13
        '
        'СпециальностиTableAdapter
        '
        Me.СпециальностиTableAdapter.ClearBeforeFill = True
        '
        'НаименованиеСпециальностиDataGridViewTextBoxColumn
        '
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Наименование специальности"
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.HeaderText = "Наименование специальности"
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.Name = "НаименованиеСпециальностиDataGridViewTextBoxColumn"
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.Width = 445
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 770)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Location = New System.Drawing.Point(776, 223)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Специальности"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents PriemnayaKomissiyaDataSet13 As PriemnayaKomissiyaDataSet13
    Friend WithEvents СпециальностиBindingSource As BindingSource
    Friend WithEvents СпециальностиTableAdapter As PriemnayaKomissiyaDataSet13TableAdapters.СпециальностиTableAdapter
    Friend WithEvents НаименованиеСпециальностиDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
