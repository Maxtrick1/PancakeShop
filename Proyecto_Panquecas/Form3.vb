Public Class Form3
    Dim iva As Double
    Public ct, ct1 As Double
    Dim d As Boolean

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ProductosTableAdapter.Buscar(Clientes_ProductosDataSet.Productos, ComboBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If d = True Then
            ct1 = ct1 + 5
        End If

        Dim i As Integer
        Try
            i = InputBox("¿Cuantas unidades desea?")

            ListBox1.Items.Add(ComboBox1.Text)
            ListBox2.Items.Add(i)
            ct = PrecioTextBox.Text

            If i > 0 Then
                ct = ct * i
                ct1 = ct + ct1
            Else
                MessageBox.Show("No se puede colocar 0 unidades")
                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
                ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)
            End If
        Catch ex As InvalidCastException
        End Try
        TextBox1.Text = ct1 & "$ + IVA"

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        d = True
        If d = True Then
            ct1 = ct1 + 5
        End If
        Button1.Show()
        TextBox1.Text = ct1 & "$ + IVA"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        d = False
        Button1.Show()
        TextBox1.Text = ct1 & "$ + IVA"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iva = ct1 * (13 / 100)
        ct1 = ct1 + iva
        If ct1 >= 922337203685.47754 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            ct1 = 0
            MessageBox.Show("Demasiados productos")

        End If

        Form4.Show()
        Form4.Ultima_CompraLabel1.Text = ct1
        Me.Hide()
        Form2.Hide()
        ImagenesMenu1.Hide()
        ImagenesMenu2.Hide()
        ImagenesMenu3.Hide()


        Form4.IDTextBox.Clear()
        Form4.Nombre_y_ApellidoTextBox.Clear()
        Form4.TelefonoTextBox.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (ListBox1.SelectedIndex > -1) Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If

        ct1 = ct1 - ct

        If (ListBox2.SelectedIndex > -1) Then
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If

        TextBox1.Text = ct1 & "$ + IVA"
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter1.Fill(Me.Clientes_ProductosDataSet1.Productos)

        Me.ProductosTableAdapter.Fill(Me.Clientes_ProductosDataSet.Productos)
    End Sub
End Class
