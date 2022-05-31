Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter3.Fill(Me.Clientes_ProductosDataSet4.Clientes)

        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.White
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.LightCyan
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.LightCyan
        DataGridView1.Columns(3).DefaultCellStyle.BackColor = Color.LightCyan
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Nombre_y_ApellidoTextBox.Text = "" Then

            MessageBox.Show("Tiene que colocar su nombre")
        Else
            Try
                Dim name As String

                name = Nombre_y_ApellidoTextBox.Text

                Me.ClientesTableAdapter3.Agregar(IDTextBox.Text, Nombre_y_ApellidoTextBox.Text, TelefonoTextBox.Text, Ultima_CompraLabel1.Text)
                Me.ClientesTableAdapter3.Fill(Me.Clientes_ProductosDataSet4.Clientes)

                Nombre_y_ApellidoTextBox.Clear()
                IDTextBox.Clear()
                TelefonoTextBox.Clear()

                Label4.Text = Form3.ct1 & ("$")
                Nombre_y_ApellidoTextBox.Text = name
                Label5.Text = Nombre_y_ApellidoTextBox.Text

            Catch ex As Exception
                Me.ClientesTableAdapter3.Modificar(IDTextBox.Text, Nombre_y_ApellidoTextBox.Text, TelefonoTextBox.Text, Ultima_CompraLabel1.Text, IDTextBox.Text)
                Me.ClientesTableAdapter3.Fill(Me.Clientes_ProductosDataSet4.Clientes)

                Label4.Text = Form3.ct1 & ("$")
                Label5.Text = Nombre_y_ApellidoTextBox.Text
            End Try

            Ultima_CompraLabel1.Hide()
            Button4.Show()
            Label3.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClientesTableAdapter3.Delete(IDTextBox.Text)
        Me.ClientesTableAdapter3.Fill(Me.Clientes_ProductosDataSet4.Clientes)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ClientesTableAdapter3.Modificar(IDTextBox.Text, Nombre_y_ApellidoTextBox.Text, TelefonoTextBox.Text, Ultima_CompraLabel1.Text, IDTextBox.Text)
        Me.ClientesTableAdapter3.Fill(Me.Clientes_ProductosDataSet4.Clientes)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.ClientesTableAdapter3.Buscar(Clientes_ProductosDataSet4.Clientes, IDTextBox.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class


