Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter.Fill(Me.Clientes_ProductosDataSet.Productos)

        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.White
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.LightCyan

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Hide()
        ImagenesMenu1.Hide()
        ImagenesMenu2.Hide()
        ImagenesMenu3.Hide()
        Form5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.Show()

    End Sub
End Class

