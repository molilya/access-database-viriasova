Public Class Form1


    Private Sub BtnToChange_Click(sender As Object, e As EventArgs) Handles BtnToChange.Click
        Me.Visible = False
        Form2.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim result As DialogResult
        result = MessageBox.Show(
            "вы действительно хотите закрыть приложение?",
            "Закрытие приложения", MessageBoxButtons.YesNo,
            MessageBoxIcon.Asterisk)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub BtnPostupAttestat_Click(sender As Object, e As EventArgs) Handles BtnPostupAttestat.Click
        Me.Visible = False
        Form3.Visible = True
    End Sub

    Private Sub BtnPostupPredp_Click(sender As Object, e As EventArgs) Handles BtnPostupPredp.Click
        Me.Visible = False
        Form4.Visible = True
    End Sub

    Private Sub BtnToAll_Click(sender As Object, e As EventArgs) Handles BtnToAll.Click
        Me.Visible = False
        Form5.Visible = True
    End Sub

    Private Sub BtnToSchool_Click(sender As Object, e As EventArgs) Handles BtnToSchool.Click
        Me.Visible = False
        Form6.Visible = True
    End Sub

    Private Sub BtnToPredp_Click(sender As Object, e As EventArgs) Handles BtnToPredp.Click
        Me.Visible = False
        Form7.Visible = True
    End Sub

    Private Sub ButtonToSpec_Click(sender As Object, e As EventArgs) Handles ButtonToSpec.Click
        Me.Visible = False
        Form9.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form10.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Form11.Visible = True
    End Sub
End Class
