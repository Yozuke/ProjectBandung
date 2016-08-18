Imports MySql.Data.MySqlClient
Public Class MainMenu
    Public Property catchstid As String
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim LS = New LoginScreen()
        LS.Show()
        Me.Close()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        output_id.Text = catchstid
        ConnectDatabase()
        Dim ds As New DataSet()
        Dim ld As String = "SELECT kode_barang,nama_barang,satuan,supplier,tanggal_beli AS 'tanggal',harga_satuan, total_pembelian AS 'Qty', STATUS FROM master_barang_masuk UNION SELECT kode_barang,nama_barang,satuan,supplier,tanggal_jual AS 'tanggal', harga_satuan, jumlah_penjualan AS 'Qty', STATUS  FROM master_barang_keluar LIMIT 50"
        Dim dc As MySqlCommand = New MySqlCommand(ld, conn)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(dc)
        da.Fill(ds)
        DGrid.DataSource = ds.Tables(0)
        DGrid.AllowUserToResizeColumns = False
    End Sub
End Class