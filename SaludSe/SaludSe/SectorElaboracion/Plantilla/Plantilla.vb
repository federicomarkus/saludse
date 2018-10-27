Public Class Plantilla

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("Campo1", "Campo2", "Campo3", "Campo4", "Campo5")
        DataGridView1.Rows.Add("Campo1", "Campo2", "Campo3", "Campo4", "Campo5")
        DataGridView1.Rows.Add("Campo1", "Campo2", "Campo3", "Campo4", "Campo5")
        DataGridView1.Rows.Add("Campo1", "Campo2", "Campo3", "Campo4", "Campo5")
    End Sub
End Class
