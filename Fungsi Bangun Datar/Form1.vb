Public Class Form1
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Persegi")
        ComboBox1.Items.Add("Persegi Panjang")
        ComboBox1.Items.Add("Segitiga")
        ComboBox1.Items.Add("Jajargenjang")
        ComboBox1.Items.Add("Trapesium")
        ComboBox1.Items.Add("Layang-layang")
        ComboBox1.Items.Add("Belah Ketupat")
        ComboBox1.Items.Add("Lingkaran")
    End Sub

    Private Sub Btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_hitung.Click
        Select Case ComboBox1.Text
            Case "Persegi"
                TextBox12.Text = Val(TextBox4.Text) ^ 2
                TextBox13.Text = Val(TextBox4.Text) * 4
            Case "Persegi Panjang"
                TextBox12.Text = Val(TextBox1.Text) * (TextBox2.Text)
                TextBox13.Text = (Val(TextBox1.Text) + (TextBox2.Text)) * 2
            Case "Segitiga"
                TextBox12.Text = Val(TextBox6.Text) * Val(TextBox7.Text) * 0.5
                TextBox13.Text = Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
            Case "Jajargenjang"
                TextBox12.Text = Val(TextBox6.Text) * Val(TextBox7.Text)
                TextBox13.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox9.Text)
            Case "Trapesium"
                TextBox12.Text = Val(TextBox3.Text) + Val(TextBox9.Text) * Val(TextBox2.Text) * 0.5
                TextBox13.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox9.Text)
            Case "Layang-layang"
                TextBox12.Text = Val(TextBox10.Text) * Val(TextBox11.Text) * 0.5
                TextBox13.Text = (Val(TextBox4.Text) + Val(TextBox5.Text)) * 2
            Case "Belah Ketupat"
                TextBox12.Text = Val(TextBox10.Text) * Val(TextBox11.Text) * 0.5
                TextBox13.Text = (Val(TextBox4.Text) + Val(TextBox5.Text)) * 2
            Case "Lingkaran"
                TextBox12.Text = Val(TextBox8.Text) ^ 2 * 3.14 * 0.25
                TextBox13.Text = Val(TextBox8.Text) * 3.14
        End Select
    End Sub

    Private Sub Btn_ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ulang.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
    End Sub

    Private Sub Btn_selesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_selesai.Click
        Close()
    End Sub
End Class
