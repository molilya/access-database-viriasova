Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet.ЗачисленныеПредприятие". При необходимости она может быть перемещена или удалена.
        Me.ЗачисленныеПредприятиеTableAdapter.Fill(Me.PriemnayaKomissiyaDataSet.ЗачисленныеПредприятие)
        ComboBoxSpecial.Text = ""
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim i As Integer = 0
        Do While (i < DataGridView1.RowCount)
            DataGridView1.Rows(i).Selected = False
            Dim j As Integer = 0
            Do While (j < DataGridView1.ColumnCount)
                If (Not (DataGridView1.Rows(i).Cells(j).Value) Is Nothing) Then
                    If DataGridView1.Rows(i).Cells(j).Value.ToString.Contains(ComboBoxSpecial.Text) Then
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

End Class