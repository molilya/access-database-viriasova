<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.АбитуриентыBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet4 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet4()
        Me.ЗачисленныеШколаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet()
        Me.ЗачисленныеШколаTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSetTableAdapters.ЗачисленныеШколаTableAdapter()
        Me.ComboBoxSpecial = New System.Windows.Forms.ComboBox()
        Me.ЗачисленныеШколаBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗачисленныеШколаTableAdapter1 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet4TableAdapters.ЗачисленныеШколаTableAdapter()
        Me.ЗачисленныеШколаBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet5 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet5()
        Me.АбитуриентыШколаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.АбитуриентыШколаTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet5TableAdapters.АбитуриентыШколаTableAdapter()
        Me.ЗачисленныеШколаBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗачисленныеШколаTableAdapter2 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet5TableAdapters.ЗачисленныеШколаTableAdapter()
        Me.ЗачисленныеШколаBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗачисленныеШколаBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗачисленныеШколаBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.АбитуриентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.АбитуриентыTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet4TableAdapters.АбитуриентыTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФИОDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СпециальностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СреднийБаллDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Оплачено = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеШколаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеШколаBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеШколаBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыШколаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеШколаBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеШколаBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеШколаBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗачисленныеШколаBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(202, 619)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(651, 37)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Назад"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ФИОDataGridViewTextBoxColumn, Me.СпециальностьDataGridViewTextBoxColumn, Me.СреднийБаллDataGridViewTextBoxColumn, Me.Оплачено})
        Me.DataGridView1.DataSource = Me.АбитуриентыBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(40, 114)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(938, 501)
        Me.DataGridView1.TabIndex = 7
        '
        'АбитуриентыBindingSource1
        '
        Me.АбитуриентыBindingSource1.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource1.DataSource = Me.PriemnayaKomissiyaDataSet4
        '
        'PriemnayaKomissiyaDataSet4
        '
        Me.PriemnayaKomissiyaDataSet4.DataSetName = "PriemnayaKomissiyaDataSet4"
        Me.PriemnayaKomissiyaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЗачисленныеШколаBindingSource
        '
        Me.ЗачисленныеШколаBindingSource.DataMember = "ЗачисленныеШкола"
        Me.ЗачисленныеШколаBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet
        '
        'PriemnayaKomissiyaDataSet
        '
        Me.PriemnayaKomissiyaDataSet.DataSetName = "PriemnayaKomissiyaDataSet"
        Me.PriemnayaKomissiyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЗачисленныеШколаTableAdapter
        '
        Me.ЗачисленныеШколаTableAdapter.ClearBeforeFill = True
        '
        'ComboBoxSpecial
        '
        Me.ComboBoxSpecial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxSpecial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSpecial.FormattingEnabled = True
        Me.ComboBoxSpecial.Items.AddRange(New Object() {"Бухгалтерский учет", "Информационные системы и программирование ", "Технология машиностроения", "Металлургическое производство", "Автомобиле- и тракторостроение"})
        Me.ComboBoxSpecial.Location = New System.Drawing.Point(329, 52)
        Me.ComboBoxSpecial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxSpecial.Name = "ComboBoxSpecial"
        Me.ComboBoxSpecial.Size = New System.Drawing.Size(324, 24)
        Me.ComboBoxSpecial.TabIndex = 23
        '
        'ЗачисленныеШколаBindingSource1
        '
        Me.ЗачисленныеШколаBindingSource1.DataMember = "ЗачисленныеШкола"
        Me.ЗачисленныеШколаBindingSource1.DataSource = Me.PriemnayaKomissiyaDataSet4
        '
        'ЗачисленныеШколаTableAdapter1
        '
        Me.ЗачисленныеШколаTableAdapter1.ClearBeforeFill = True
        '
        'ЗачисленныеШколаBindingSource6
        '
        Me.ЗачисленныеШколаBindingSource6.DataMember = "ЗачисленныеШкола"
        Me.ЗачисленныеШколаBindingSource6.DataSource = Me.PriemnayaKomissiyaDataSet5
        '
        'PriemnayaKomissiyaDataSet5
        '
        Me.PriemnayaKomissiyaDataSet5.DataSetName = "PriemnayaKomissiyaDataSet5"
        Me.PriemnayaKomissiyaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'АбитуриентыШколаBindingSource
        '
        Me.АбитуриентыШколаBindingSource.DataMember = "АбитуриентыШкола"
        Me.АбитуриентыШколаBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet5
        '
        'АбитуриентыШколаTableAdapter
        '
        Me.АбитуриентыШколаTableAdapter.ClearBeforeFill = True
        '
        'ЗачисленныеШколаBindingSource2
        '
        Me.ЗачисленныеШколаBindingSource2.DataMember = "ЗачисленныеШкола"
        Me.ЗачисленныеШколаBindingSource2.DataSource = Me.PriemnayaKomissiyaDataSet5
        '
        'ЗачисленныеШколаTableAdapter2
        '
        Me.ЗачисленныеШколаTableAdapter2.ClearBeforeFill = True
        '
        'ЗачисленныеШколаBindingSource3
        '
        Me.ЗачисленныеШколаBindingSource3.DataMember = "ЗачисленныеШкола"
        Me.ЗачисленныеШколаBindingSource3.DataSource = Me.PriemnayaKomissiyaDataSet5
        '
        'ЗачисленныеШколаBindingSource4
        '
        Me.ЗачисленныеШколаBindingSource4.DataMember = "ЗачисленныеШкола"
        Me.ЗачисленныеШколаBindingSource4.DataSource = Me.PriemnayaKomissiyaDataSet5
        '
        'ЗачисленныеШколаBindingSource5
        '
        Me.ЗачисленныеШколаBindingSource5.DataMember = "ЗачисленныеШкола"
        Me.ЗачисленныеШколаBindingSource5.DataSource = Me.PriemnayaKomissiyaDataSet5
        '
        'АбитуриентыBindingSource
        '
        Me.АбитуриентыBindingSource.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet4
        '
        'АбитуриентыTableAdapter
        '
        Me.АбитуриентыTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Enabled = False
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1051, 27)
        Me.FillByToolStrip.TabIndex = 26
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.Checked = True
        Me.FillByToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Enabled = False
        Me.FillByToolStripButton.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        Me.FillByToolStripButton.Visible = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = Global.Kursovaya_Viriasova.My.Resources.Resources._1639223823_36_papik_pro_p_klipart_lupa_36
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSearch.Location = New System.Drawing.Point(659, 44)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(41, 38)
        Me.BtnSearch.TabIndex = 22
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
        Me.ФИОDataGridViewTextBoxColumn.Width = 250
        '
        'СпециальностьDataGridViewTextBoxColumn
        '
        Me.СпециальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность"
        Me.СпециальностьDataGridViewTextBoxColumn.HeaderText = "Специальность"
        Me.СпециальностьDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.СпециальностьDataGridViewTextBoxColumn.Name = "СпециальностьDataGridViewTextBoxColumn"
        Me.СпециальностьDataGridViewTextBoxColumn.ReadOnly = True
        Me.СпециальностьDataGridViewTextBoxColumn.Width = 280
        '
        'СреднийБаллDataGridViewTextBoxColumn
        '
        Me.СреднийБаллDataGridViewTextBoxColumn.DataPropertyName = "СреднийБалл"
        Me.СреднийБаллDataGridViewTextBoxColumn.HeaderText = "СреднийБалл"
        Me.СреднийБаллDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.СреднийБаллDataGridViewTextBoxColumn.Name = "СреднийБаллDataGridViewTextBoxColumn"
        Me.СреднийБаллDataGridViewTextBoxColumn.ReadOnly = True
        Me.СреднийБаллDataGridViewTextBoxColumn.Width = 120
        '
        'Оплачено
        '
        Me.Оплачено.DataPropertyName = "Оплачено"
        Me.Оплачено.HeaderText = "Оплачено"
        Me.Оплачено.MinimumWidth = 6
        Me.Оплачено.Name = "Оплачено"
        Me.Оплачено.ReadOnly = True
        Me.Оплачено.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Оплачено.Width = 125
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 770)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.ComboBoxSpecial)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnBack)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Поступившие по аттестату"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеШколаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеШколаBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеШколаBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыШколаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеШколаBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеШколаBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеШколаBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗачисленныеШколаBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PriemnayaKomissiyaDataSet As PriemnayaKomissiyaDataSet
    Friend WithEvents ЗачисленныеШколаBindingSource As BindingSource
    Friend WithEvents ЗачисленныеШколаTableAdapter As PriemnayaKomissiyaDataSetTableAdapters.ЗачисленныеШколаTableAdapter
    Friend WithEvents ComboBoxSpecial As ComboBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents PriemnayaKomissiyaDataSet4 As PriemnayaKomissiyaDataSet4
    Friend WithEvents ЗачисленныеШколаBindingSource1 As BindingSource
    Friend WithEvents ЗачисленныеШколаTableAdapter1 As PriemnayaKomissiyaDataSet4TableAdapters.ЗачисленныеШколаTableAdapter
    Friend WithEvents PriemnayaKomissiyaDataSet5 As PriemnayaKomissiyaDataSet5
    Friend WithEvents АбитуриентыШколаBindingSource As BindingSource
    Friend WithEvents АбитуриентыШколаTableAdapter As PriemnayaKomissiyaDataSet5TableAdapters.АбитуриентыШколаTableAdapter
    Friend WithEvents ЗачисленныеШколаBindingSource2 As BindingSource
    Friend WithEvents ЗачисленныеШколаTableAdapter2 As PriemnayaKomissiyaDataSet5TableAdapters.ЗачисленныеШколаTableAdapter
    Friend WithEvents ЗачисленныеШколаBindingSource5 As BindingSource
    Friend WithEvents ЗачисленныеШколаBindingSource3 As BindingSource
    Friend WithEvents ЗачисленныеШколаBindingSource4 As BindingSource
    Friend WithEvents ЗачисленныеШколаBindingSource6 As BindingSource
    Friend WithEvents АбитуриентыBindingSource As BindingSource
    Friend WithEvents АбитуриентыTableAdapter As PriemnayaKomissiyaDataSet4TableAdapters.АбитуриентыTableAdapter
    Friend WithEvents АбитуриентыBindingSource1 As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents КодDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ФИОDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents СпециальностьDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents СреднийБаллDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Оплачено As DataGridViewCheckBoxColumn
End Class
