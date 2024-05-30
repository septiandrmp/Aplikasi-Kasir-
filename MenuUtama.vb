Public Class MenuUtama
    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) 

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles User.Click
        User.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Barang.Click
        Barang.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Customer.Click
        Customer.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Supplier.Click
        Supplier.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Master.Click
        Master.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Manual.Click
        Manual.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Penjualan.Show()

    End Sub
End Class