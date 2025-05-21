<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnToSchool = New System.Windows.Forms.Button()
        Me.BtnToPredp = New System.Windows.Forms.Button()
        Me.BtnToAll = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.BtnToChange = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPostupPredp = New System.Windows.Forms.Button()
        Me.BtnPostupAttestat = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonToSpec = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox1.Controls.Add(Me.BtnToSchool)
        Me.GroupBox1.Controls.Add(Me.BtnToPredp)
        Me.GroupBox1.Controls.Add(Me.BtnToAll)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(264, 298)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(236, 235)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'BtnToSchool
        '
        Me.BtnToSchool.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnToSchool.Location = New System.Drawing.Point(21, 171)
        Me.BtnToSchool.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnToSchool.Name = "BtnToSchool"
        Me.BtnToSchool.Size = New System.Drawing.Size(200, 50)
        Me.BtnToSchool.TabIndex = 4
        Me.BtnToSchool.Text = "Поступающие из школ"
        Me.BtnToSchool.UseVisualStyleBackColor = False
        '
        'BtnToPredp
        '
        Me.BtnToPredp.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnToPredp.Location = New System.Drawing.Point(21, 83)
        Me.BtnToPredp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnToPredp.Name = "BtnToPredp"
        Me.BtnToPredp.Size = New System.Drawing.Size(200, 75)
        Me.BtnToPredp.TabIndex = 1
        Me.BtnToPredp.Text = "Поступающие по программе целевого обучения"
        Me.BtnToPredp.UseVisualStyleBackColor = False
        '
        'BtnToAll
        '
        Me.BtnToAll.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnToAll.Location = New System.Drawing.Point(21, 24)
        Me.BtnToAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnToAll.Name = "BtnToAll"
        Me.BtnToAll.Size = New System.Drawing.Size(200, 50)
        Me.BtnToAll.TabIndex = 0
        Me.BtnToAll.Text = "Все поступающие"
        Me.BtnToAll.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Btn1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn1.Location = New System.Drawing.Point(264, 223)
        Me.Btn1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(236, 71)
        Me.Btn1.TabIndex = 4
        Me.Btn1.Text = "Посмотреть списки поступающих"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'BtnToChange
        '
        Me.BtnToChange.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnToChange.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnToChange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnToChange.Location = New System.Drawing.Point(12, 223)
        Me.BtnToChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnToChange.Name = "BtnToChange"
        Me.BtnToChange.Size = New System.Drawing.Size(236, 71)
        Me.BtnToChange.TabIndex = 5
        Me.BtnToChange.Text = "Изменить или добавить данные об абитуриентах"
        Me.BtnToChange.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Btn2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn2.Location = New System.Drawing.Point(525, 223)
        Me.Btn2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(236, 71)
        Me.Btn2.TabIndex = 6
        Me.Btn2.Text = "Зачисленные"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnPostupPredp)
        Me.GroupBox2.Controls.Add(Me.BtnPostupAttestat)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(525, 298)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(236, 309)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.Location = New System.Drawing.Point(16, 141)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 70)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Информационные системы и программирование"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnPostupPredp
        '
        Me.BtnPostupPredp.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnPostupPredp.Location = New System.Drawing.Point(16, 87)
        Me.BtnPostupPredp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPostupPredp.Name = "BtnPostupPredp"
        Me.BtnPostupPredp.Size = New System.Drawing.Size(200, 50)
        Me.BtnPostupPredp.TabIndex = 1
        Me.BtnPostupPredp.Text = "Целевое обучение"
        Me.BtnPostupPredp.UseVisualStyleBackColor = False
        '
        'BtnPostupAttestat
        '
        Me.BtnPostupAttestat.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnPostupAttestat.Location = New System.Drawing.Point(16, 25)
        Me.BtnPostupAttestat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPostupAttestat.Name = "BtnPostupAttestat"
        Me.BtnPostupAttestat.Size = New System.Drawing.Size(200, 50)
        Me.BtnPostupAttestat.TabIndex = 0
        Me.BtnPostupAttestat.Text = "На основе аттестата"
        Me.BtnPostupAttestat.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.IndianRed
        Me.BtnClose.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnClose.Location = New System.Drawing.Point(327, 713)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(387, 57)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Выйти"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Location = New System.Drawing.Point(184, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(727, 105)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Приемная комиссия"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonToSpec
        '
        Me.ButtonToSpec.BackColor = System.Drawing.Color.LightSlateGray
        Me.ButtonToSpec.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonToSpec.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonToSpec.Location = New System.Drawing.Point(776, 223)
        Me.ButtonToSpec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonToSpec.Name = "ButtonToSpec"
        Me.ButtonToSpec.Size = New System.Drawing.Size(236, 71)
        Me.ButtonToSpec.TabIndex = 10
        Me.ButtonToSpec.Text = "Изменить или добавить данные о специальностях"
        Me.ButtonToSpec.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.Location = New System.Drawing.Point(16, 225)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 70)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Технология машиностроения"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1060, 796)
        Me.Controls.Add(Me.ButtonToSpec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.BtnToChange)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Главная"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnToSchool As Button
    Friend WithEvents BtnToPredp As Button
    Friend WithEvents BtnToAll As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents BtnToChange As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnPostupPredp As Button
    Friend WithEvents BtnPostupAttestat As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonToSpec As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
