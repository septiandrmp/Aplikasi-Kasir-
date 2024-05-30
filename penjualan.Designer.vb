<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Lnamacustomer = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ltanggal = New System.Windows.Forms.Label()
        Me.Lfaktur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TDbayar = New System.Windows.Forms.TextBox()
        Me.Lkembali = New System.Windows.Forms.Label()
        Me.Ltotalharga = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Lnamacustomer)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Ltanggal)
        Me.GroupBox2.Controls.Add(Me.Lfaktur)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(794, 80)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(358, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Lnamacustomer
        '
        Me.Lnamacustomer.AutoSize = True
        Me.Lnamacustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lnamacustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lnamacustomer.Location = New System.Drawing.Point(355, 49)
        Me.Lnamacustomer.Name = "Lnamacustomer"
        Me.Lnamacustomer.Size = New System.Drawing.Size(84, 15)
        Me.Lnamacustomer.TabIndex = 6
        Me.Lnamacustomer.Text = "Lnamacustomer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(252, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Location = New System.Drawing.Point(252, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Customer"
        '
        'Ltanggal
        '
        Me.Ltanggal.AutoSize = True
        Me.Ltanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ltanggal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ltanggal.Location = New System.Drawing.Point(133, 49)
        Me.Ltanggal.Name = "Ltanggal"
        Me.Ltanggal.Size = New System.Drawing.Size(50, 15)
        Me.Ltanggal.TabIndex = 3
        Me.Ltanggal.Text = "Ltanggal"
        '
        'Lfaktur
        '
        Me.Lfaktur.AutoSize = True
        Me.Lfaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lfaktur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lfaktur.Location = New System.Drawing.Point(133, 16)
        Me.Lfaktur.Name = "Lfaktur"
        Me.Lfaktur.Size = New System.Drawing.Size(42, 15)
        Me.Lfaktur.TabIndex = 2
        Me.Lfaktur.Text = "Lfaktur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(27, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode, Me.nama, Me.harga, Me.jumlah, Me.total})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.Location = New System.Drawing.Point(0, 100)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(800, 198)
        Me.dgv.TabIndex = 1
        '
        'kode
        '
        Me.kode.HeaderText = "Kode Barang"
        Me.kode.Name = "kode"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Barang"
        Me.nama.Name = "nama"
        '
        'harga
        '
        Me.harga.HeaderText = "harga"
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 134)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proses"
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(223, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 115)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Tutup"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(113, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 115)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Batal"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(3, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 115)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TDbayar)
        Me.GroupBox4.Controls.Add(Me.Lkembali)
        Me.GroupBox4.Controls.Add(Me.Ltotalharga)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(386, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 115)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Transaksi"
        '
        'TDbayar
        '
        Me.TDbayar.Location = New System.Drawing.Point(226, 59)
        Me.TDbayar.Name = "TDbayar"
        Me.TDbayar.Size = New System.Drawing.Size(100, 20)
        Me.TDbayar.TabIndex = 5
        Me.TDbayar.Text = "TDbayar"
        '
        'Lkembali
        '
        Me.Lkembali.AutoSize = True
        Me.Lkembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lkembali.Location = New System.Drawing.Point(223, 98)
        Me.Lkembali.Name = "Lkembali"
        Me.Lkembali.Size = New System.Drawing.Size(51, 15)
        Me.Lkembali.TabIndex = 4
        Me.Lkembali.Text = "Lkembali"
        '
        'Ltotalharga
        '
        Me.Ltotalharga.AutoSize = True
        Me.Ltotalharga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ltotalharga.Location = New System.Drawing.Point(223, 30)
        Me.Ltotalharga.Name = "Ltotalharga"
        Me.Ltotalharga.Size = New System.Drawing.Size(62, 15)
        Me.Ltotalharga.TabIndex = 3
        Me.Ltotalharga.Text = "Ltotalharga"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(28, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Kembali"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(28, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Dibayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(28, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Harga"
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Penjualan"
        Me.Text = "penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Lnamacustomer As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Ltanggal As Label
    Friend WithEvents Lfaktur As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TDbayar As TextBox
    Friend WithEvents Lkembali As Label
    Friend WithEvents Ltotalharga As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
