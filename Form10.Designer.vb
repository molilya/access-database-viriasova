<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ФИОDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДатаРожденияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПаспортDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ТелефонDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ШколаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СреднийБаллDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОригиналDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ПредприятиеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АдресDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДоговорDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СпециальностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОплаченоDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.АбитуриентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet9 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet9()
        Me.ЗачисленныеИСBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet11 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet11()
        Me.ЗачисленныеИСBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Зачисленные_ИСTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet11TableAdapters.Зачисленные_ИСTableAdapter()
        Me.ComboBoxSpecial = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.АбитуриентыTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet9TableAdapters.АбитуриентыTableAdapter()
        Me.FillBy15ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy15ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеИСBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеИСBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy15ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.IndianRed
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBack.Location = New System.Drawing.Point(207, 686)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(651, 37)
        Me.BtnBack.TabIndex = 7
        Me.BtnBack.Text = "Назад"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ФИОDataGridViewTextBoxColumn, Me.ДатаРожденияDataGridViewTextBoxColumn, Me.ПаспортDataGridViewTextBoxColumn, Me.ТелефонDataGridViewTextBoxColumn, Me.ШколаDataGridViewTextBoxColumn, Me.СреднийБаллDataGridViewTextBoxColumn, Me.ОригиналDataGridViewCheckBoxColumn, Me.ПредприятиеDataGridViewTextBoxColumn, Me.АдресDataGridViewTextBoxColumn, Me.ДоговорDataGridViewTextBoxColumn, Me.СпециальностьDataGridViewTextBoxColumn, Me.ОплаченоDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.АбитуриентыBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(153, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(756, 508)
        Me.DataGridView1.TabIndex = 8
        '
        'ФИОDataGridViewTextBoxColumn
        '
        Me.ФИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.HeaderText = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ФИОDataGridViewTextBoxColumn.Name = "ФИОDataGridViewTextBoxColumn"
        Me.ФИОDataGridViewTextBoxColumn.ReadOnly = True
        Me.ФИОDataGridViewTextBoxColumn.Width = 205
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
        'ПредприятиеDataGridViewTextBoxColumn
        '
        Me.ПредприятиеDataGridViewTextBoxColumn.DataPropertyName = "Предприятие"
        Me.ПредприятиеDataGridViewTextBoxColumn.HeaderText = "Предприятие"
        Me.ПредприятиеDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ПредприятиеDataGridViewTextBoxColumn.Name = "ПредприятиеDataGridViewTextBoxColumn"
        Me.ПредприятиеDataGridViewTextBoxColumn.ReadOnly = True
        Me.ПредприятиеDataGridViewTextBoxColumn.Width = 185
        '
        'АдресDataGridViewTextBoxColumn
        '
        Me.АдресDataGridViewTextBoxColumn.DataPropertyName = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.HeaderText = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.АдресDataGridViewTextBoxColumn.Name = "АдресDataGridViewTextBoxColumn"
        Me.АдресDataGridViewTextBoxColumn.ReadOnly = True
        Me.АдресDataGridViewTextBoxColumn.Width = 185
        '
        'ДоговорDataGridViewTextBoxColumn
        '
        Me.ДоговорDataGridViewTextBoxColumn.DataPropertyName = "Договор"
        Me.ДоговорDataGridViewTextBoxColumn.HeaderText = "Договор"
        Me.ДоговорDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ДоговорDataGridViewTextBoxColumn.Name = "ДоговорDataGridViewTextBoxColumn"
        Me.ДоговорDataGridViewTextBoxColumn.ReadOnly = True
        Me.ДоговорDataGridViewTextBoxColumn.Width = 125
        '
        'СпециальностьDataGridViewTextBoxColumn
        '
        Me.СпециальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность"
        Me.СпециальностьDataGridViewTextBoxColumn.HeaderText = "Специальность"
        Me.СпециальностьDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.СпециальностьDataGridViewTextBoxColumn.Name = "СпециальностьDataGridViewTextBoxColumn"
        Me.СпециальностьDataGridViewTextBoxColumn.ReadOnly = True
        Me.СпециальностьDataGridViewTextBoxColumn.Width = 225
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
        'АбитуриентыBindingSource
        '
        Me.АбитуриентыBindingSource.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet9
        '
        'PriemnayaKomissiyaDataSet9
        '
        Me.PriemnayaKomissiyaDataSet9.DataSetName = "PriemnayaKomissiyaDataSet9"
        Me.PriemnayaKomissiyaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЗачисленныеИСBindingSource1
        '
        Me.ЗачисленныеИСBindingSource1.DataMember = "Зачисленные_ИС"
        Me.ЗачисленныеИСBindingSource1.DataSource = Me.PriemnayaKomissiyaDataSet11
        '
        'PriemnayaKomissiyaDataSet11
        '
        Me.PriemnayaKomissiyaDataSet11.DataSetName = "PriemnayaKomissiyaDataSet11"
        Me.PriemnayaKomissiyaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЗачисленныеИСBindingSource
        '
        Me.ЗачисленныеИСBindingSource.DataMember = "Зачисленные_ИС"
        Me.ЗачисленныеИСBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet11
        '
        'Зачисленные_ИСTableAdapter
        '
        Me.Зачисленные_ИСTableAdapter.ClearBeforeFill = True
        '
        'ComboBoxSpecial
        '
        Me.ComboBoxSpecial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxSpecial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSpecial.FormattingEnabled = True
        Me.ComboBoxSpecial.Items.AddRange(New Object() {"Бухгалтерский учет", "Информационные системы и программирование ", "Технология машиностроения", "Металлургическое производство", "Автомобиле- и тракторостроение"})
        Me.ComboBoxSpecial.Location = New System.Drawing.Point(367, 61)
        Me.ComboBoxSpecial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxSpecial.Name = "ComboBoxSpecial"
        Me.ComboBoxSpecial.Size = New System.Drawing.Size(324, 24)
        Me.ComboBoxSpecial.TabIndex = 25
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = Global.Kursovaya_Viriasova.My.Resources.Resources._1639223823_36_papik_pro_p_klipart_lupa_36
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSearch.Location = New System.Drawing.Point(697, 53)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(41, 38)
        Me.BtnSearch.TabIndex = 24
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'АбитуриентыTableAdapter
        '
        Me.АбитуриентыTableAdapter.ClearBeforeFill = True
        '
        'FillBy15ToolStrip
        '
        Me.FillBy15ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillBy15ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy15ToolStripButton})
        Me.FillBy15ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy15ToolStrip.Name = "FillBy15ToolStrip"
        Me.FillBy15ToolStrip.Size = New System.Drawing.Size(1051, 27)
        Me.FillBy15ToolStrip.TabIndex = 31
        Me.FillBy15ToolStrip.Text = "FillBy15ToolStrip"
        Me.FillBy15ToolStrip.Visible = False
        '
        'FillBy15ToolStripButton
        '
        Me.FillBy15ToolStripButton.Checked = True
        Me.FillBy15ToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FillBy15ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy15ToolStripButton.Enabled = False
        Me.FillBy15ToolStripButton.Name = "FillBy15ToolStripButton"
        Me.FillBy15ToolStripButton.Size = New System.Drawing.Size(64, 24)
        Me.FillBy15ToolStripButton.Text = "FillBy15"
        Me.FillBy15ToolStripButton.Visible = False
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 770)
        Me.Controls.Add(Me.FillBy15ToolStrip)
        Me.Controls.Add(Me.ComboBoxSpecial)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "группа информационные системы и программирование"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеИСBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеИСBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy15ToolStrip.ResumeLayout(False)
        Me.FillBy15ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PriemnayaKomissiyaDataSet11 As PriemnayaKomissiyaDataSet11
    Friend WithEvents ЗачисленныеИСBindingSource As BindingSource
    Friend WithEvents Зачисленные_ИСTableAdapter As PriemnayaKomissiyaDataSet11TableAdapters.Зачисленные_ИСTableAdapter
    Friend WithEvents ЗачисленныеИСBindingSource1 As BindingSource
    Friend WithEvents PriemnayaKomissiyaDataSet9 As PriemnayaKomissiyaDataSet9
    Friend WithEvents АбитуриентыBindingSource As BindingSource
    Friend WithEvents АбитуриентыTableAdapter As PriemnayaKomissiyaDataSet9TableAdapters.АбитуриентыTableAdapter
    Friend WithEvents ComboBoxSpecial As ComboBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents ФИОDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДатаРожденияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПаспортDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ТелефонDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ШколаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents СреднийБаллDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОригиналDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ПредприятиеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents АдресDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДоговорDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents СпециальностьDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОплаченоDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FillBy15ToolStrip As ToolStrip
    Friend WithEvents FillBy15ToolStripButton As ToolStripButton
End Class
