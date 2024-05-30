Imports System.Data.SqlClient
Module Module2
    Public conn As SqlConnection 'var untuk koneksi
    Public da As SqlDataAdapter 'var untuk tampilkan data ke dgv
    Public ds As DataSet 'var untuk tampilkan data ke dgv
    Public cmd As SqlCommand 'var untuk tampilkan data ke dalam textbox, listbox, combobox, dll
    Public dr As SqlDataReader 'var untuk tampilkan data ke dalam textbox, listbox, combobox, dll
    Public Sub koneksi()
        conn = New SqlConnection("data source=USER;initial catalog=DBTI3P;integrated security=true")
        conn.Open()
    End Sub
End Module
