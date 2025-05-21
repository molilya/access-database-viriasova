Public Class Form8
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
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
            АбитуриентыBindingSource4.EndEdit()
            АбитуриентыTableAdapter3.Update(PriemnayaKomissiyaDataSet4.Абитуриенты)
            Me.Close()
            Form2.Visible = True
        End If

SaveError:
        Exit Sub

    End Sub

    Private Sub BtnOtm_Click(sender As Object, e As EventArgs) Handles BtnOtm.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet13.Специальности". При необходимости она может быть перемещена или удалена.
        Me.СпециальностиTableAdapter.Fill(Me.PriemnayaKomissiyaDataSet13.Специальности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet4.Абитуриенты". При необходимости она может быть перемещена или удалена.
        Me.АбитуриентыTableAdapter3.Fill(Me.PriemnayaKomissiyaDataSet4.Абитуриенты)

        АбитуриентыBindingSource4.AddNew()
        CheckBoxOriginal.Checked = False
        CheckBoxPayed.Checked = False

        For i = 0 To Me.DataGridView2.RowCount - 2
            ComboBoxSpecial.Items.Add(Me.DataGridView2.Rows(i).Cells(0).Value)
        Next i

        Label12.Text = "5"
    End Sub
    Private Sub RadioButtonSchool_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSchool.CheckedChanged
        SplitContainer1.Panel1.Visible = True
        SplitContainer1.Panel2.Visible = False
        TxtPredpName.Text = ""
        TxtPredpAdress.Text = ""
        TxtDogovor.Text = ""
    End Sub

    Private Sub RadioButtonPredp_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPredp.CheckedChanged
        SplitContainer1.Panel2.Visible = True
        SplitContainer1.Panel1.Visible = False
        TxtSchoolName.Text = ""
        CheckBoxOriginal.Checked = False
        Label12.Text = ""
    End Sub

    Private Sub SrBall_TextChanged(sender As Object, e As EventArgs) Handles SrBall.TextChanged
        Label12.Text = SrBall.Text
    End Sub

End Class