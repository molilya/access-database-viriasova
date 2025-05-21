Public Class Form3
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet4.Абитуриенты". При необходимости она может быть перемещена или удалена.
        Me.АбитуриентыTableAdapter.Fill(Me.PriemnayaKomissiyaDataSet4.Абитуриенты)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet5.ЗачисленныеШкола". При необходимости она может быть перемещена или удалена.
        Me.ЗачисленныеШколаTableAdapter2.Fill(Me.PriemnayaKomissiyaDataSet5.ЗачисленныеШкола)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet5.АбитуриентыШкола". При необходимости она может быть перемещена или удалена.
        Me.АбитуриентыШколаTableAdapter.Fill(Me.PriemnayaKomissiyaDataSet5.АбитуриентыШкола)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PriemnayaKomissiyaDataSet4.ЗачисленныеШкола". При необходимости она может быть перемещена или удалена.
        Me.ЗачисленныеШколаTableAdapter1.Fill(Me.PriemnayaKomissiyaDataSet4.ЗачисленныеШкола)
        Try
            Me.АбитуриентыTableAdapter.FillBy(Me.PriemnayaKomissiyaDataSet4.Абитуриенты)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        ComboBoxSpecial.Text = ""
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

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.АбитуриентыTableAdapter.FillBy(Me.PriemnayaKomissiyaDataSet4.Абитуриенты)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBoxSpecial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSpecial.SelectedIndexChanged

    End Sub
End Class