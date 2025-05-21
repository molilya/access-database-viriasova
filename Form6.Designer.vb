<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.АбитуриентыШколаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet()
        Me.АбитуриентыШколаTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSetTableAdapters.АбитуриентыШколаTableAdapter()
        Me.ComboBoxSpecial = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФИОDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДатаРожденияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПаспортDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ТелефонDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ШколаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СреднийБаллDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОригиналDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.СпециальностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОплаченоDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыШколаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(241, 639)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(651, 37)
        Me.BtnBack.TabIndex = 8
        Me.BtnBack.Text = "Назад"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ФИОDataGridViewTextBoxColumn, Me.ДатаРожденияDataGridViewTextBoxColumn, Me.ПаспортDataGridViewTextBoxColumn, Me.ТелефонDataGridViewTextBoxColumn, Me.ШколаDataGridViewTextBoxColumn, Me.СреднийБаллDataGridViewTextBoxColumn, Me.ОригиналDataGridViewCheckBoxColumn, Me.СпециальностьDataGridViewTextBoxColumn, Me.ОплаченоDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.АбитуриентыШколаBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(60, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(928, 495)
        Me.DataGridView1.TabIndex = 9
        '
        'АбитуриентыШколаBindingSource
        '
        Me.АбитуриентыШколаBindingSource.DataMember = "АбитуриентыШкола"
        Me.АбитуриентыШколаBindingSource.DataSource = Me.PriemnayaKomissiyaDataSetBindingSource
        '
        'PriemnayaKomissiyaDataSetBindingSource
        '
        Me.PriemnayaKomissiyaDataSetBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet
        Me.PriemnayaKomissiyaDataSetBindingSource.Position = 0
        '
        'PriemnayaKomissiyaDataSet
        '
        Me.PriemnayaKomissiyaDataSet.DataSetName = "PriemnayaKomissiyaDataSet"
        Me.PriemnayaKomissiyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'АбитуриентыШколаTableAdapter
        '
        Me.АбитуриентыШколаTableAdapter.ClearBeforeFill = True
        '
        'ComboBoxSpecial
        '
        Me.ComboBoxSpecial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxSpecial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSpecial.FormattingEnabled = True
        Me.ComboBoxSpecial.Items.AddRange(New Object() {"Бухгалтерский учет", "Информационные системы и программирование ", "Технология машиностроения", "Металлургическое производство", "Автомобиле- и тракторостроение"})
        Me.ComboBoxSpecial.Location = New System.Drawing.Point(332, 28)
        Me.ComboBoxSpecial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxSpecial.Name = "ComboBoxSpecial"
        Me.ComboBoxSpecial.Size = New System.Drawing.Size(324, 24)
        Me.ComboBoxSpecial.TabIndex = 19
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = Global.Kursovaya_Viriasova.My.Resources.Resources._1639223823_36_papik_pro_p_klipart_lupa_36
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSearch.Location = New System.Drawing.Point(662, 20)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(41, 38)
        Me.BtnSearch.TabIndex = 18
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        Me.КодDataGridViewTextBoxColumn.ReadOnly = True
        Me.КодDataGridViewTextBoxColumn.Visible = False
        Me.КодDataGridViewTextBoxColumn.Width = 125
        '
        'ФИОDataGridViewTextBoxColumn
        '
        Me.ФИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.HeaderText = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ФИОDataGridViewTextBoxColumn.Name = "ФИОDataGridViewTextBoxColumn"
        Me.ФИОDataGridViewTextBoxColumn.ReadOnly = True
        Me.ФИОDataGridViewTextBoxColumn.Width = 200
        '
        'ДатаРожденияDataGridViewTextBoxColumn
        '
        Me.ДатаРожденияDataGridViewTextBoxColumn.DataPropertyName = "ДатаРождения"
        Me.ДатаРожденияDataGridViewTextBoxColumn.HeaderText = "ДатаРождения"
        Me.ДатаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ДатаРожденияDataGridViewTextBoxColumn.Name = "ДатаРожденияDataGridViewTextBoxColumn"
        Me.ДатаРожденияDataGridViewTextBoxColumn.ReadOnly = True
        Me.ДатаРожденияDataGridViewTextBoxColumn.Width = 125
        '
        'ПаспортDataGridViewTextBoxColumn
        '
        Me.ПаспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт"
        Me.ПаспортDataGridViewTextBoxColumn.HeaderText = "Паспорт"
        Me.ПаспортDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ПаспортDataGridViewTextBoxColumn.Name = "ПаспортDataGridViewTextBoxColumn"
        Me.ПаспортDataGridViewTextBoxColumn.ReadOnly = True
        Me.ПаспортDataGridViewTextBoxColumn.Width = 125
        '
        'ТелефонDataGridViewTextBoxColumn
        '
        Me.ТелефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон"
        Me.ТелефонDataGridViewTextBoxColumn.HeaderText = "Телефон"
        Me.ТелефонDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ТелефонDataGridViewTextBoxColumn.Name = "ТелефонDataGridViewTextBoxColumn"
        Me.ТелефонDataGridViewTextBoxColumn.ReadOnly = True
        Me.ТелефонDataGridViewTextBoxColumn.Width = 125
        '
        'ШколаDataGridViewTextBoxColumn
        '
        Me.ШколаDataGridViewTextBoxColumn.DataPropertyName = "Школа"
        Me.ШколаDataGridViewTextBoxColumn.HeaderText = "Школа"
        Me.ШколаDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ШколаDataGridViewTextBoxColumn.Name = "ШколаDataGridViewTextBoxColumn"
        Me.ШколаDataGridViewTextBoxColumn.ReadOnly = True
        Me.ШколаDataGridViewTextBoxColumn.Width = 125
        '
        'СреднийБаллDataGridViewTextBoxColumn
        '
        Me.СреднийБаллDataGridViewTextBoxColumn.DataPropertyName = "СреднийБалл"
        Me.СреднийБаллDataGridViewTextBoxColumn.HeaderText = "СреднийБалл"
        Me.СреднийБаллDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.СреднийБаллDataGridViewTextBoxColumn.Name = "СреднийБаллDataGridViewTextBoxColumn"
        Me.СреднийБаллDataGridViewTextBoxColumn.ReadOnly = True
        Me.СреднийБаллDataGridViewTextBoxColumn.Width = 125
        '
        'ОригиналDataGridViewCheckBoxColumn
        '
        Me.ОригиналDataGridViewCheckBoxColumn.DataPropertyName = "Оригинал"
        Me.ОригиналDataGridViewCheckBoxColumn.HeaderText = "Оригинал"
        Me.ОригиналDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ОригиналDataGridViewCheckBoxColumn.Name = "ОригиналDataGridViewCheckBoxColumn"
        Me.ОригиналDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ОригиналDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ОригиналDataGridViewCheckBoxColumn.Width = 125
        '
        'СпециальностьDataGridViewTextBoxColumn
        '
        Me.СпециальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность"
        Me.СпециальностьDataGridViewTextBoxColumn.HeaderText = "Специальность"
        Me.СпециальностьDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.СпециальностьDataGridViewTextBoxColumn.Name = "СпециальностьDataGridViewTextBoxColumn"
        Me.СпециальностьDataGridViewTextBoxColumn.ReadOnly = True
        Me.СпециальностьDataGridViewTextBoxColumn.Width = 125
        '
        'ОплаченоDataGridViewCheckBoxColumn
        '
        Me.ОплаченоDataGridViewCheckBoxColumn.DataPropertyName = "Оплачено"
        Me.ОплаченоDataGridViewCheckBoxColumn.HeaderText = "Оплачено"
        Me.ОплаченоDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ОплаченоDataGridViewCheckBoxColumn.Name = "ОплаченоDataGridViewCheckBoxColumn"
        Me.ОплаченоDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ОплаченоDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ОплаченоDataGridViewCheckBoxColumn.Width = 125
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 770)
        Me.Controls.Add(Me.ComboBoxSpecial)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Поступающие из школ"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыШколаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PriemnayaKomissiyaDataSetBindingSource As BindingSource
    Friend WithEvents PriemnayaKomissiyaDataSet As PriemnayaKomissiyaDataSet
    Friend WithEvents АбитуриентыШколаBindingSource As BindingSource
    Friend WithEvents АбитуриентыШколаTableAdapter As PriemnayaKomissiyaDataSetTableAdapters.АбитуриентыШколаTableAdapter
    Friend WithEvents ComboBoxSpecial As ComboBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents КодDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ФИОDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДатаРожденияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПаспортDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ТелефонDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ШколаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents СреднийБаллDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОригиналDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents СпециальностьDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОплаченоDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
