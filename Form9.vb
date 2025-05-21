Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet13.Специальности". При необходимости она может быть перемещена или удалена.
        Me.СпециальностиTableAdapter.Fill(Me.PriemnayaKomissiyaDataSet13.Специальности)

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error GoTo SaveError

        If TextBox1.Text = "" Then
            MessageBox.Show(
            "Заполните поле!",
            "Ошибка", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Exit Sub

        Else
            СпециальностиBindingSource.EndEdit()
            СпециальностиTableAdapter.Update(PriemnayaKomissiyaDataSet13.Специальности)
        End If

SaveError:
        Exit Sub
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo SaveError
        Dim result As DialogResult
        result = MessageBox.Show(
            "Вы действительно хотите удалить запись?",
            "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Asterisk)
        If result = DialogResult.Yes Then
            СпециальностиBindingSource.RemoveCurrent()

        End If
SaveError:
        Exit Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        СпециальностиBindingSource.AddNew()
    End Sub
End Class