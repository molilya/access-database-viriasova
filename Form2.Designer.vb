<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.АбитуриентыBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet4 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet4()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPassport = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxSpecial = New System.Windows.Forms.ComboBox()
        Me.CheckBoxPayed = New System.Windows.Forms.CheckBox()
        Me.АбитуриентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet3 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet3()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBoxOriginal = New System.Windows.Forms.CheckBox()
        Me.SrBall = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSchoolName = New System.Windows.Forms.TextBox()
        Me.TxtDogovor = New System.Windows.Forms.TextBox()
        Me.TxtPredpAdress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPredpName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonPredp = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSchool = New System.Windows.Forms.RadioButton()
        Me.DateBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClean = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.АбитуриентыBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.АбитуриентыTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet3TableAdapters.АбитуриентыTableAdapter()
        Me.АбитуриентыBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.АбитуриентыBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.АбитуриентыTableAdapter1 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet4TableAdapters.АбитуриентыTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СпециальностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriemnayaKomissiyaDataSet13 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet13()
        Me.PriemnayaKomissiyaDataSet12 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet12()
        Me.PriemnayaKomissiyaDataSet6 = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet6()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.СпециальностиTableAdapter = New Kursovaya_Viriasova.PriemnayaKomissiyaDataSet13TableAdapters.СпециальностиTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.АбитуриентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SrBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АбитуриентыBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriemnayaKomissiyaDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.IndianRed
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBack.Location = New System.Drawing.Point(61, 729)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(651, 37)
        Me.BtnBack.TabIndex = 5
        Me.BtnBack.Text = "Назад"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ФИОDataGridViewTextBoxColumn, Me.ДатаРожденияDataGridViewTextBoxColumn, Me.ПаспортDataGridViewTextBoxColumn, Me.ТелефонDataGridViewTextBoxColumn, Me.ШколаDataGridViewTextBoxColumn, Me.СреднийБаллDataGridViewTextBoxColumn, Me.ОригиналDataGridViewCheckBoxColumn, Me.ПредприятиеDataGridViewTextBoxColumn, Me.АдресDataGridViewTextBoxColumn, Me.ДоговорDataGridViewTextBoxColumn, Me.СпециальностьDataGridViewTextBoxColumn, Me.ОплаченоDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.АбитуриентыBindingSource4
        Me.DataGridView1.Location = New System.Drawing.Point(12, 46)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1021, 212)
        Me.DataGridView1.TabIndex = 3
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
        Me.ДатаРожденияDataGridViewTextBoxColumn.Width = 110
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
        Me.ТелефонDataGridViewTextBoxColumn.Width = 105
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
        Me.СреднийБаллDataGridViewTextBoxColumn.Width = 115
        '
        'ОригиналDataGridViewCheckBoxColumn
        '
        Me.ОригиналDataGridViewCheckBoxColumn.DataPropertyName = "Оригинал"
        Me.ОригиналDataGridViewCheckBoxColumn.HeaderText = "Оригинал"
        Me.ОригиналDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ОригиналDataGridViewCheckBoxColumn.Name = "ОригиналDataGridViewCheckBoxColumn"
        Me.ОригиналDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ОригиналDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ОригиналDataGridViewCheckBoxColumn.Width = 110
        '
        'ПредприятиеDataGridViewTextBoxColumn
        '
        Me.ПредприятиеDataGridViewTextBoxColumn.DataPropertyName = "Предприятие"
        Me.ПредприятиеDataGridViewTextBoxColumn.HeaderText = "Предприятие"
        Me.ПредприятиеDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ПредприятиеDataGridViewTextBoxColumn.Name = "ПредприятиеDataGridViewTextBoxColumn"
        Me.ПредприятиеDataGridViewTextBoxColumn.ReadOnly = True
        Me.ПредприятиеDataGridViewTextBoxColumn.Width = 170
        '
        'АдресDataGridViewTextBoxColumn
        '
        Me.АдресDataGridViewTextBoxColumn.DataPropertyName = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.HeaderText = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.АдресDataGridViewTextBoxColumn.Name = "АдресDataGridViewTextBoxColumn"
        Me.АдресDataGridViewTextBoxColumn.ReadOnly = True
        Me.АдресDataGridViewTextBoxColumn.Width = 200
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
        Me.СпециальностьDataGridViewTextBoxColumn.Width = 200
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
        'АбитуриентыBindingSource4
        '
        Me.АбитуриентыBindingSource4.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource4.DataSource = Me.PriemnayaKomissiyaDataSet4BindingSource
        '
        'PriemnayaKomissiyaDataSet4BindingSource
        '
        Me.PriemnayaKomissiyaDataSet4BindingSource.DataSource = Me.PriemnayaKomissiyaDataSet4
        Me.PriemnayaKomissiyaDataSet4BindingSource.Position = 0
        '
        'PriemnayaKomissiyaDataSet4
        '
        Me.PriemnayaKomissiyaDataSet4.DataSetName = "PriemnayaKomissiyaDataSet4"
        Me.PriemnayaKomissiyaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPhone)
        Me.GroupBox1.Controls.Add(Me.TxtPassport)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSpecial)
        Me.GroupBox1.Controls.Add(Me.CheckBoxPayed)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DateBirth)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtFio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(769, 486)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TxtPhone
        '
        Me.TxtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "Телефон", True))
        Me.TxtPhone.Location = New System.Drawing.Point(149, 148)
        Me.TxtPhone.Mask = "+7 (000) 000-00-00"
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(324, 22)
        Me.TxtPhone.TabIndex = 18
        Me.TxtPhone.ValidatingType = GetType(Date)
        '
        'TxtPassport
        '
        Me.TxtPassport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "Паспорт", True))
        Me.TxtPassport.Location = New System.Drawing.Point(149, 101)
        Me.TxtPassport.Mask = "0000 0000"
        Me.TxtPassport.Name = "TxtPassport"
        Me.TxtPassport.Size = New System.Drawing.Size(324, 22)
        Me.TxtPassport.TabIndex = 17
        '
        'ComboBoxSpecial
        '
        Me.ComboBoxSpecial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxSpecial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSpecial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "Специальность", True))
        Me.ComboBoxSpecial.FormattingEnabled = True
        Me.ComboBoxSpecial.Location = New System.Drawing.Point(149, 411)
        Me.ComboBoxSpecial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxSpecial.Name = "ComboBoxSpecial"
        Me.ComboBoxSpecial.Size = New System.Drawing.Size(324, 24)
        Me.ComboBoxSpecial.TabIndex = 16
        '
        'CheckBoxPayed
        '
        Me.CheckBoxPayed.AutoSize = True
        Me.CheckBoxPayed.Checked = True
        Me.CheckBoxPayed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPayed.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.АбитуриентыBindingSource4, "Оплачено", True))
        Me.CheckBoxPayed.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.АбитуриентыBindingSource, "Оплачено", True))
        Me.CheckBoxPayed.Location = New System.Drawing.Point(11, 455)
        Me.CheckBoxPayed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxPayed.Name = "CheckBoxPayed"
        Me.CheckBoxPayed.Size = New System.Drawing.Size(95, 20)
        Me.CheckBoxPayed.TabIndex = 15
        Me.CheckBoxPayed.Text = "Оплачено"
        Me.CheckBoxPayed.UseVisualStyleBackColor = True
        '
        'АбитуриентыBindingSource
        '
        Me.АбитуриентыBindingSource.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet3BindingSource
        '
        'PriemnayaKomissiyaDataSet3BindingSource
        '
        Me.PriemnayaKomissiyaDataSet3BindingSource.DataSource = Me.PriemnayaKomissiyaDataSet3
        Me.PriemnayaKomissiyaDataSet3BindingSource.Position = 0
        '
        'PriemnayaKomissiyaDataSet3
        '
        Me.PriemnayaKomissiyaDataSet3.DataSetName = "PriemnayaKomissiyaDataSet3"
        Me.PriemnayaKomissiyaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 414)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Специальность:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(31, 223)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxOriginal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SrBall)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtSchoolName)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtDogovor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtPredpAdress)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtPredpName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Size = New System.Drawing.Size(738, 177)
        Me.SplitContainer1.SplitterDistance = 326
        Me.SplitContainer1.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "СреднийБалл", True))
        Me.Label12.Location = New System.Drawing.Point(123, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 13
        Me.Label12.Visible = False
        '
        'CheckBoxOriginal
        '
        Me.CheckBoxOriginal.AutoSize = True
        Me.CheckBoxOriginal.Checked = True
        Me.CheckBoxOriginal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxOriginal.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.АбитуриентыBindingSource4, "Оригинал", True))
        Me.CheckBoxOriginal.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.АбитуриентыBindingSource4, "Оригинал", True))
        Me.CheckBoxOriginal.Location = New System.Drawing.Point(11, 126)
        Me.CheckBoxOriginal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxOriginal.Name = "CheckBoxOriginal"
        Me.CheckBoxOriginal.Size = New System.Drawing.Size(163, 20)
        Me.CheckBoxOriginal.TabIndex = 12
        Me.CheckBoxOriginal.Text = "Оригинал аттестата"
        Me.CheckBoxOriginal.UseVisualStyleBackColor = True
        '
        'SrBall
        '
        Me.SrBall.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.АбитуриентыBindingSource4, "СреднийБалл", True))
        Me.SrBall.DecimalPlaces = 2
        Me.SrBall.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.SrBall.Location = New System.Drawing.Point(123, 74)
        Me.SrBall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SrBall.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.SrBall.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.SrBall.Name = "SrBall"
        Me.SrBall.Size = New System.Drawing.Size(101, 22)
        Me.SrBall.TabIndex = 11
        Me.SrBall.Tag = ""
        Me.SrBall.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Средний балл"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 52)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Название учебного заведения"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSchoolName
        '
        Me.TxtSchoolName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "Школа", True))
        Me.TxtSchoolName.Location = New System.Drawing.Point(123, 23)
        Me.TxtSchoolName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSchoolName.Name = "TxtSchoolName"
        Me.TxtSchoolName.Size = New System.Drawing.Size(190, 22)
        Me.TxtSchoolName.TabIndex = 9
        '
        'TxtDogovor
        '
        Me.TxtDogovor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "Договор", True))
        Me.TxtDogovor.Location = New System.Drawing.Point(117, 127)
        Me.TxtDogovor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDogovor.Name = "TxtDogovor"
        Me.TxtDogovor.Size = New System.Drawing.Size(285, 22)
        Me.TxtDogovor.TabIndex = 10
        '
        'TxtPredpAdress
        '
        Me.TxtPredpAdress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "Адрес", True))
        Me.TxtPredpAdress.Location = New System.Drawing.Point(120, 78)
        Me.TxtPredpAdress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPredpAdress.Name = "TxtPredpAdress"
        Me.TxtPredpAdress.Size = New System.Drawing.Size(284, 22)
        Me.TxtPredpAdress.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Договор"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Адрес"
        '
        'TxtPredpName
        '
        Me.TxtPredpName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "Предприятие", True))
        Me.TxtPredpName.Location = New System.Drawing.Point(120, 30)
        Me.TxtPredpName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPredpName.Name = "TxtPredpName"
        Me.TxtPredpName.Size = New System.Drawing.Size(284, 22)
        Me.TxtPredpName.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Предприятие"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "На основе:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonPredp)
        Me.GroupBox2.Controls.Add(Me.RadioButtonSchool)
        Me.GroupBox2.Location = New System.Drawing.Point(149, 175)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(595, 38)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'RadioButtonPredp
        '
        Me.RadioButtonPredp.AutoSize = True
        Me.RadioButtonPredp.Location = New System.Drawing.Point(295, 12)
        Me.RadioButtonPredp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonPredp.Name = "RadioButtonPredp"
        Me.RadioButtonPredp.Size = New System.Drawing.Size(152, 20)
        Me.RadioButtonPredp.TabIndex = 1
        Me.RadioButtonPredp.TabStop = True
        Me.RadioButtonPredp.Text = "Целевое обучение"
        Me.RadioButtonPredp.UseVisualStyleBackColor = True
        '
        'RadioButtonSchool
        '
        Me.RadioButtonSchool.AutoSize = True
        Me.RadioButtonSchool.Location = New System.Drawing.Point(7, 12)
        Me.RadioButtonSchool.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonSchool.Name = "RadioButtonSchool"
        Me.RadioButtonSchool.Size = New System.Drawing.Size(88, 20)
        Me.RadioButtonSchool.TabIndex = 0
        Me.RadioButtonSchool.TabStop = True
        Me.RadioButtonSchool.Text = "Аттестат"
        Me.RadioButtonSchool.UseVisualStyleBackColor = True
        '
        'DateBirth
        '
        Me.DateBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "ДатаРождения", True))
        Me.DateBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateBirth.Location = New System.Drawing.Point(149, 62)
        Me.DateBirth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateBirth.Name = "DateBirth"
        Me.DateBirth.Size = New System.Drawing.Size(324, 22)
        Me.DateBirth.TabIndex = 7
        Me.DateBirth.Value = New Date(2024, 5, 15, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Телефон:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Паспорт:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Дата рождения:"
        '
        'TxtFio
        '
        Me.TxtFio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АбитуриентыBindingSource4, "ФИО", True))
        Me.TxtFio.Location = New System.Drawing.Point(149, 23)
        Me.TxtFio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFio.Name = "TxtFio"
        Me.TxtFio.Size = New System.Drawing.Size(324, 22)
        Me.TxtFio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ФИО:"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(787, 281)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(231, 65)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "Добавить"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnClean
        '
        Me.BtnClean.Location = New System.Drawing.Point(787, 562)
        Me.BtnClean.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(231, 60)
        Me.BtnClean.TabIndex = 7
        Me.BtnClean.Text = "Очистить"
        Me.BtnClean.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(787, 366)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(231, 62)
        Me.BtnRemove.TabIndex = 8
        Me.BtnRemove.Text = "Удалить"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(787, 462)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(231, 65)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Сохранить"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 22)
        Me.TextBox1.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'АбитуриентыBindingSource3
        '
        Me.АбитуриентыBindingSource3.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource3.DataSource = Me.PriemnayaKomissiyaDataSet3
        '
        'АбитуриентыTableAdapter
        '
        Me.АбитуриентыTableAdapter.ClearBeforeFill = True
        '
        'АбитуриентыBindingSource1
        '
        Me.АбитуриентыBindingSource1.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource1.DataSource = Me.PriemnayaKomissiyaDataSet3
        '
        'АбитуриентыBindingSource2
        '
        Me.АбитуриентыBindingSource2.DataMember = "Абитуриенты"
        Me.АбитуриентыBindingSource2.DataSource = Me.PriemnayaKomissiyaDataSet3
        '
        'АбитуриентыTableAdapter1
        '
        Me.АбитуриентыTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.НаименованиеСпециальностиDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.СпециальностиBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(839, 653)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(213, 113)
        Me.DataGridView2.TabIndex = 12
        Me.DataGridView2.Visible = False
        '
        'НаименованиеСпециальностиDataGridViewTextBoxColumn
        '
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Наименование специальности"
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.HeaderText = "Наименование специальности"
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.Name = "НаименованиеСпециальностиDataGridViewTextBoxColumn"
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.ReadOnly = True
        Me.НаименованиеСпециальностиDataGridViewTextBoxColumn.Width = 125
        '
        'СпециальностиBindingSource
        '
        Me.СпециальностиBindingSource.DataMember = "Специальности"
        Me.СпециальностиBindingSource.DataSource = Me.PriemnayaKomissiyaDataSet13
        '
        'PriemnayaKomissiyaDataSet13
        '
        Me.PriemnayaKomissiyaDataSet13.DataSetName = "PriemnayaKomissiyaDataSet13"
        Me.PriemnayaKomissiyaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PriemnayaKomissiyaDataSet12
        '
        Me.PriemnayaKomissiyaDataSet12.DataSetName = "PriemnayaKomissiyaDataSet12"
        Me.PriemnayaKomissiyaDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PriemnayaKomissiyaDataSet6
        '
        Me.PriemnayaKomissiyaDataSet6.DataSetName = "PriemnayaKomissiyaDataSet6"
        Me.PriemnayaKomissiyaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = Global.Kursovaya_Viriasova.My.Resources.Resources._1639223823_36_papik_pro_p_klipart_lupa_36
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSearch.Location = New System.Drawing.Point(748, 4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(41, 38)
        Me.BtnSearch.TabIndex = 11
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'СпециальностиTableAdapter
        '
        Me.СпециальностиTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 770)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnClean)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Изменение/добавление абитуриентов"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.АбитуриентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SrBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АбитуриентыBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriemnayaKomissiyaDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxPayed As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CheckBoxOriginal As CheckBox
    Friend WithEvents SrBall As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSchoolName As TextBox
    Friend WithEvents TxtDogovor As TextBox
    Friend WithEvents TxtPredpAdress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPredpName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonPredp As RadioButton
    Friend WithEvents RadioButtonSchool As RadioButton
    Friend WithEvents DateBirth As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnClean As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents ComboBoxSpecial As ComboBox
    Friend WithEvents TxtPhone As MaskedTextBox
    Friend WithEvents TxtPassport As MaskedTextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label12 As Label
    Friend WithEvents PriemnayaKomissiyaDataSet3BindingSource As BindingSource
    Friend WithEvents PriemnayaKomissiyaDataSet3 As PriemnayaKomissiyaDataSet3
    Friend WithEvents АбитуриентыBindingSource As BindingSource
    Friend WithEvents АбитуриентыTableAdapter As PriemnayaKomissiyaDataSet3TableAdapters.АбитуриентыTableAdapter
    Friend WithEvents АбитуриентыBindingSource2 As BindingSource
    Friend WithEvents АбитуриентыBindingSource1 As BindingSource
    Friend WithEvents АбитуриентыBindingSource3 As BindingSource
    Friend WithEvents PriemnayaKomissiyaDataSet4BindingSource As BindingSource
    Friend WithEvents PriemnayaKomissiyaDataSet4 As PriemnayaKomissiyaDataSet4
    Friend WithEvents АбитуриентыBindingSource4 As BindingSource
    Friend WithEvents АбитуриентыTableAdapter1 As PriemnayaKomissiyaDataSet4TableAdapters.АбитуриентыTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PriemnayaKomissiyaDataSet6 As PriemnayaKomissiyaDataSet6
    Friend WithEvents КодDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents PriemnayaKomissiyaDataSet12 As PriemnayaKomissiyaDataSet12
    Friend WithEvents PriemnayaKomissiyaDataSet13 As PriemnayaKomissiyaDataSet13
    Friend WithEvents СпециальностиBindingSource As BindingSource
    Friend WithEvents СпециальностиTableAdapter As PriemnayaKomissiyaDataSet13TableAdapters.СпециальностиTableAdapter
    Friend WithEvents НаименованиеСпециальностиDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
