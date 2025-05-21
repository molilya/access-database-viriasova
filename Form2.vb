Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet13.Специальности". При необходимости она может быть перемещена или удалена.
        Me.СпециальностиTableAdapter.Fill(Me.PriemnayaKomissiyaDataSet13.Специальности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet4.Абитуриенты". При необходимости она может быть перемещена или удалена.
        Me.АбитуриентыTableAdapter1.Fill(Me.PriemnayaKomissiyaDataSet4.Абитуриенты)

        If TxtSchoolName.Text = "" Then
            RadioButtonPredp.Checked = True
            SplitContainer1.Panel2.Visible = True
            SplitContainer1.Panel1.Visible = False
            TxtSchoolName.Text = ""
            Label12.Text = ""
            CheckBoxOriginal.Checked = False
        Else RadioButtonSchool.Checked = True
            SplitContainer1.Panel1.Visible = True
            SplitContainer1.Panel2.Visible = False
            TxtPredpName.Text = ""
            TxtPredpAdress.Text = ""
            TxtDogovor.Text = ""
        End If

        For i = 0 To Me.DataGridView2.RowCount - 2
            ComboBoxSpecial.Items.Add(Me.DataGridView2.Rows(i).Cells(0).Value)
        Next i


    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        Form1.Visible = True
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.Close()
        Form8.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        On Error GoTo SaveError
        Dim result As DialogResult
        result = MessageBox.Show(
            "Вы действительно хотите удалить абитуриента?",
            "Удаление абитуриента", MessageBoxButtons.YesNo,
            MessageBoxIcon.Asterisk)
        If result = DialogResult.Yes Then
            АбитуриентыBindingSource4.RemoveCurrent()
        End If
SaveError:
        Exit Sub
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        On Error GoTo SaveError

        If RadioButtonSchool.Checked = False And RadioButtonPredp.Checked = False Then
            MessageBox.Show(
            "Заполните все поля!",
            "Ошибка", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        ElseIf RadioButtonSchool.Checked = True And (TxtSchoolName.Text = "" Or SrBall.Text = "") Then
            MessageBox.Show(
            "Заполните все поля!",
            "Ошибка", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        ElseIf RadioButtonPredp.Checked = True And (TxtPredpName.Text = "" Or TxtPredpAdress.Text = "" Or TxtDogovor.Text = "") Then
            MessageBox.Show(
            "Заполните все поля!",
            "Ошибка", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        ElseIf TxtFio.Text = "" Or ComboBoxSpecial.Text = "" Or TxtPhone.Text = "" Or TxtPassport.Text = "" Then
            MessageBox.Show(
            "Заполните все поля!",
            "Ошибка", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub
        Else

            MessageBox.Show(
            "", "Сохранено!",
            MessageBoxButtons.OK, MessageBoxIcon.None)
            АбитуриентыBindingSource4.EndEdit()
            АбитуриентыTableAdapter1.Update(PriemnayaKomissiyaDataSet4.Абитуриенты)
        End If

SaveError:
        Exit Sub

    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        TxtFio.Text = ""
        TxtPhone.Text = ""
        DateBirth.Value = Today
        TxtPassport.Text = ""
        RadioButtonSchool.Checked = False
        RadioButtonPredp.Checked = False
        SplitContainer1.Panel1.Visible = False
        SplitContainer1.Panel2.Visible = False
        TxtSchoolName.Text = ""
        SrBall.Text = ""
        Label12.Text = ""
        CheckBoxOriginal.Checked = False
        TxtPredpName.Text = ""
        TxtPredpAdress.Text = ""
        TxtDogovor.Text = ""
        ComboBoxSpecial.Text = ""
        CheckBoxPayed.Checked = False
        TextBox1.Text = ""
    End Sub

    Private Sub TxtSchoolName_TextChanged(sender As Object, e As EventArgs) Handles TxtSchoolName.TextChanged
        If TxtSchoolName.Text = "" Then
            RadioButtonPredp.Checked = True
            SplitContainer1.Panel2.Visible = True
            SplitContainer1.Panel1.Visible = False
            TxtSchoolName.Text = ""
            Label12.Text = ""
            CheckBoxOriginal.Checked = False
        Else RadioButtonSchool.Checked = True
            SplitContainer1.Panel1.Visible = True
            SplitContainer1.Panel2.Visible = False
            TxtPredpName.Text = ""
            TxtPredpAdress.Text = ""
            TxtDogovor.Text = ""
        End If
    End Sub

    Private Sub RadioButtonSchool_Click(sender As Object, e As EventArgs) Handles RadioButtonSchool.Click
        SplitContainer1.Panel1.Visible = True
        SplitContainer1.Panel2.Visible = False
        TxtPredpName.Text = ""
        TxtPredpAdress.Text = ""
        TxtDogovor.Text = ""
    End Sub

    Private Sub RadioButtonPredp_Click(sender As Object, e As EventArgs) Handles RadioButtonPredp.Click
        SplitContainer1.Panel2.Visible = True
        SplitContainer1.Panel1.Visible = False
        TxtSchoolName.Text = ""
        Label12.Text = ""
        CheckBoxOriginal.Checked = False
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim i As Integer = 0
        Do While (i < DataGridView1.RowCount)
            DataGridView1.Rows(i).Selected = False
            Dim j As Integer = 0
            Do While (j < DataGridView1.ColumnCount)
                If (Not (DataGridView1.Rows(i).Cells(j).Value) Is Nothing) Then
                    If DataGridView1.Rows(i).Cells(j).Value.ToString.Contains(TextBox1.Text) Then
                        DataGridView1.Rows(i).Selected = True
                        DataGridView1.FirstDisplayedScrollingRowIndex = i
                        Exit Do
                    End If

                End If

                j = (j + 1)
            Loop

            i = (i + 1)
        Loop

    End Sub

    Private Sub SrBall_TextChanged(sender As Object, e As EventArgs) Handles SrBall.TextChanged
        Label12.Text = SrBall.Text
    End Sub


End Class