Imports System.Data.SqlClient

Public Class Penjualan
    Sub Faktis()
        Call koneksi()
        cmd = New SqlCommand("select faktur from TBLPENJUALANN order by faktur desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Lfaktur.Text = Format(Today, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(dr(0), 6) = Format(Today, "yyMMdd") Then
                Lfaktur.Text = dr(0) + 1
            Else
                Lfaktur.Text = Format(Today, "yyMMdd") + "0001"
            End If
        End If
    End Sub

    Sub TampilCustomer()
        Call koneksi()
        cmd = New SqlCommand("select * from TBLCUSTOMER", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("kode_customer") And Space(2) And dr.Item("nama_customer"))
        Loop

    End Sub

    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Faktis()
        Call bersihkan()
        Me.CenterToScreen()
        Ltanggal.Text = Format(Today, "dd MMMM yyyy")

        Call koneksi()
        cmd = New SqlCommand("select * from TBLCUSTOMER", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr(0)) 'kode_customer
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Call koneksi()
        cmd = New SqlCommand("select * from TBLCUSTOMER where kode_customer='" & ComboBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Lnamacustomer.Text = dr("nama_customer")
        End If
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Call koneksi()
        If e.ColumnIndex = 0 Then
            'ubah kode jadi huruf besar semua "UCase
            dgv.Rows(e.RowIndex).Cells(0).Value = UCase(dgv.Rows(e.RowIndex).Cells(0).Value)
            'cegah entry 2x atau lebih
            For barisatas As Integer = 0 To dgv.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To dgv.RowCount - 1
                    If dgv.Rows(barisbawah).Cells("kode").Value = dgv.Rows(barisatas).Cells("kode").Value Then
                        dgv.Rows(barisatas).Cells("jumlah").Value = dgv.Rows(barisatas).Cells("jumlah").Value + 1
                        'total harus di update = harga x jumlah
                        dgv.Rows(barisatas).Cells("total").Value = dgv.Rows(barisatas).Cells("Jumlah").Value * dgv.Rows(barisatas).Cells("harga").Value

                        dgv.Rows.Remove(dgv.CurrentRow)
                        SendKeys.Send("{down}")
                        Exit Sub
                    End If
                Next
            Next
            '=================================================================================================='

            Call koneksi()
            cmd = New SqlCommand("select * from TBLBARANG where left(kode_barang, 13)= '" & dgv.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dgv.Rows(e.RowIndex).Cells(1).Value = dr.Item("nama_barang")
                dgv.Rows(e.RowIndex).Cells(2).Value = FormatNumber(dr("harga_jual"), 0)
                'perataan di kanan-kolom harga
                dgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Rows(e.RowIndex).Cells(3).Value = 1
                dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Rows(e.RowIndex).Cells(4).Value = dgv.Rows(e.RowIndex).Cells(2).Value * dgv.Rows(e.RowIndex).Cells(3).Value
                dgv.Rows(e.RowIndex).Cells("total").Value = FormatNumber(dgv.Rows(e.RowIndex).Cells("total").Value, 0)
                dgv.Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Else
                MsgBox("Kode barang tidak ditemukan")
                SendKeys.Send("{up}")
                dgv.Rows(e.RowIndex).Cells(0).Value = ""
            End If
        End If

        '==============================================================================================='

        If e.ColumnIndex = 3 Then
            Call koneksi()
            cmd = New SqlCommand("select * from TBLBARANG where left(kode_barang,4)= '" & dgv.Rows(e.RowIndex).Cells("kode").Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dgv.Rows(e.RowIndex).Cells("jumlah").Value > dr("stok") Then
                    MsgBox("stok hanya ada " & dr("stok") & "")
                    dgv.Rows(e.RowIndex).Cells("jumlah").Value = dr("stok")
                End If
            End If
            dgv.Rows(e.RowIndex).Cells(4).Value = dgv.Rows(e.RowIndex).Cells(2).Value * dgv.Rows(e.RowIndex).Cells(3).Value
        End If
        Call hitungtotal()
    End Sub


    Sub hitungtotal()
        Dim hitung As Integer
        For baris As Integer = 0 To dgv.RowCount - 1
            hitung = hitung + dgv.Rows(baris).Cells(4).Value 'sub total
        Next
        Ltotalharga.Text = hitung
    End Sub


    Private Sub TDbayar_KeyDown(sender As Object, e As KeyEventArgs) Handles TDbayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TDbayar.Text) < Val(Ltotalharga.Text) Then
                MsgBox("Pembayaran kurang")
            ElseIf Val(TDbayar.Text) >= Val(Ltotalharga.Text) Then
                Lkembali.Text = Val(TDbayar.Text) - Val(Ltotalharga.Text)
                Button1.Focus()
            End If
        End If
    End Sub
    Sub bersihkan()
        ComboBox1.Text = ""
        Lnamacustomer.Text = ""
        Ltotalharga.Text = ""
        TDbayar.Clear()
        Lkembali.Text = ""
        dgv.Rows.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '1 validasi isian data
        If ComboBox1.Text = "" Or TDbayar.Text = "" Or dgv.RowCount - 1 = 0 Then
            MsgBox("transaksi belum lengkap")
            Exit Sub
        End If

        '2 simpan ke table penjualan (1x)
        Call koneksi()
        Dim simpan As String = "insert into TBLPENJUALANN values ('" & Lfaktur.Text & "','" & Format(DateValue(Ltanggal.Text), "yyyy-MM-dd") & "','" & ComboBox1.Text & "','" & Ltotalharga.Text & "','" & TDbayar.Text & "','" & Lkembali.Text & "','" & "')"
        cmd = New SqlCommand(simpan, conn)
        cmd.ExecuteNonQuery()

        '3 simpan ke tabel detailpenjualan
        For baris As Integer = 0 To dgv.RowCount - 2
            Call koneksi()
            Dim simpandetail As String = "insert into TBLdetailjual values ('" & Lfaktur.Text & "', '" & dgv.Rows(baris).Cells(0).Value & "', '" & Val(Microsoft.VisualBasic.Str(dgv.Rows(baris).Cells("harga").Value)) & "', '" & Val(Microsoft.VisualBasic.Str(dgv.Rows(baris).Cells("jumlah").Value)) & "', '" & Val(Microsoft.VisualBasic.Str(dgv.Rows(baris).Cells("Total").Value)) & "')"
            cmd = New SqlCommand(simpandetail, conn)
            cmd.ExecuteNonQuery()
        Next

        '4 kurangi stok barang yang dijual
        For baris As Integer = 0 To dgv.RowCount - 2
            Call koneksi()
            cmd = New SqlCommand("select * from TBLBARANG where left(kode_barang,4)='" & dgv.Rows(baris).Cells("kode").Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim kurangistok As String = "update TBLBARANG set stok='" & dr("stok") - dgv.Rows(baris).Cells("jumlah").Value & "' where left(kode_barang,4)='" & dgv.Rows(baris).Cells("kode").Value & "'"
                cmd = New SqlCommand(kurangistok, conn)
                cmd.ExecuteNonQuery()
            End If
        Next
        bersihkan()
        Faktis()

    End Sub


    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            dgv.Rows.Remove(dgv.CurrentRow)
            Call hitungtotal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class

