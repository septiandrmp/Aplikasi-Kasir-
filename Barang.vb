Imports System.Data.SqlClient
Public Class BARANG
    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub
    Sub databaru()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub
    Sub ketemu()
        On Error Resume Next
        TextBox2.Text = dr.Item("nama_barang")
        ComboBox1.Text = dr.Item("satuan")
        TextBox3.Text = dr.Item("harga_beli")
        TextBox4.Text = dr.Item("harga_jual")
        TextBox5.Text = dr.Item("stok")
        TextBox2.Focus()
    End Sub
    Sub Tampilgrid()
        Call koneksi()
        da = New SqlDataAdapter("select * from TBLBARANG", conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True
    End Sub

    Sub Tampilsatuan()
        Call koneksi()
        cmd = New SqlCommand("select distinct satuan from TBLbarang", conn)
        dr = cmd.ExecuteReader ' digunakan saat select data
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr(0))
        Loop
    End Sub
    Sub carikode()
        Call koneksi()
        cmd = New SqlCommand("select * from TBLBARANG where kode_barang = '" & TextBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()

    End Sub

    Private Sub BARANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilgrid()
        Call Tampilsatuan()
        Call kosongkan()
    End Sub
    'memanggil koode barang pada textbox1
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call carikode()
            If dr.HasRows Then
                Call ketemu()
            Else
                Call databaru()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("data belum lengkap")
            Exit Sub
        End If
        Call carikode()
        If Not dr.HasRows Then
            Call koneksi()
            Dim simpan As String = "insert into TBLBARANG velues('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            Call kosongkan()
            Call Tampilgrid()
            Call Tampilsatuan()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Lengkapi Data Dahulu")
            Exit Sub
        End If

        Call carikode()
        If dr.HasRows Then
            Call koneksi()
            Dim edit As String = "Update TBLBARANG set nama_barang='" & TextBox2.Text & "',satuan='" & ComboBox1.Text & "', harga_beli ='" & TextBox3.Text & "',Harga_Jual='" & TextBox4.Text & "',Stok'" & TextBox5.Text & "' where Kode_Barang='" & TextBox1.Text & "'"
            cmd = New SqlCommand(edit, conn)
            cmd.ExecuteNonQuery()
            Call Tampilgrid()
            Call Tampilsatuan()
            Call kosongkan()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Call kosongkan()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    'mencari data
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call koneksi()
        da = New SqlDataAdapter("select * from tblBarang where nama_Barang like '%" & TextBox6.Text & "%' or SATUAN like '%" & TextBox6.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
    End Sub
    'menampilkan data dari grid ke masing masing objek
    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        TextBox1.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub

End Class
