Imports hesap.Hesap
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Dim connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath.ToString() & "/maliyet.mdb"
    Dim cmd As New OleDbCommand
    Dim sorgu As String = "select * from maliyet"
    Dim conn As New OLEDBConnection(connStr)
    Dim bs As New BindingSource()
    Dim da As New OleDbDataAdapter(sorgu, conn)
    Dim dt As New DataTable()
    Dim ds As New DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(dt)
        ds.Tables.Add(dt)
        bs.DataSource = ds
        bs.DataMember = ds.Tables(0).TableName
        DataGridView1.DataSource = bs

        DataGridView1.Columns(0).Visible = False

    End Sub

    Dim urunMaliyet As Double
    Dim makineMaliyet As Double
    Dim iscilikMaliyet As Double
    Dim toplamMaliyet As Double


    Dim plastikMiktar As Double
    Dim plastikFiyat As Double

    Dim celikMiktar As Double
    Dim celikFiyat As Double

    Dim makineFiyat As Double
    Dim makineSure As Double

    Dim isci1Sure As Double
    Dim isci1Fiyat As Double

    Dim isci2Sure As Double
    Dim isci2Fiyat As Double

    Dim calisanMaas As Double

    Dim hesap As New hesap.Hesap
    Private Sub btnHesapla_Click(sender As Object, e As EventArgs) Handles btnHesapla.Click
        Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        If empty.Any Then
            MessageBox.Show(String.Format("Lutfen alanlari doldurunuz: {0}",
                            String.Join(", ", empty.Select(Function(txt) txt.Name))))
        Else
            Try
                plastikMiktar = Convert.ToDouble(txtPlastik.Text)
                plastikFiyat = Convert.ToDouble(txtPlastikFiyat.Text)

                celikMiktar = Convert.ToDouble(txtCelik.Text)
                celikFiyat = Convert.ToDouble(txtCelikFiyat.Text)

                makineFiyat = Convert.ToDouble(txtMakineFiyat.Text)
                makineSure = Convert.ToDouble(txtMakineSure.Text)

                isci1Sure = Convert.ToDouble(txtIsciSure.Text)
                isci1Fiyat = Convert.ToDouble(TxtIsciFiyat.Text)

                isci2Sure = Convert.ToDouble(TxtIsci2Sure.Text)
                isci2Fiyat = Convert.ToDouble(TxtIsci2Fiyat.Text)

                calisanMaas = Convert.ToDouble(txtCalisanMaas.Text)

                urunMaliyet = hesap.urunMaliyet(celikMiktar, celikFiyat, plastikMiktar, plastikFiyat)

                makineMaliyet = hesap.makineMaliyet(makineFiyat, makineSure)

                iscilikMaliyet = hesap.iscilikMaliyet(isci1Fiyat, isci1Sure) + hesap.iscilikMaliyet(isci2Fiyat, isci2Sure)

                toplamMaliyet = hesap.toplamMaliyet(urunMaliyet, makineMaliyet, iscilikMaliyet, calisanMaas)

                MessageBox.Show("toplamm: " & toplamMaliyet)

                MessageBox.Show(DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(0).Value + 1)

                ds.Tables(0).Rows.Add(DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(0).Value + 1, plastikMiktar, plastikFiyat, celikMiktar, celikFiyat, urunMaliyet, makineFiyat, makineSure, makineMaliyet, isci1Sure, isci1Fiyat, isci2Sure, isci2Fiyat, iscilikMaliyet, calisanMaas, toplamMaliyet)
            Catch ex As Exception
                MessageBox.Show("Hata")
            End Try

        End If
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Try
            conn.Open()

            Dim com As OleDbCommandBuilder = New OleDbCommandBuilder(da)
            da.Update(ds.Tables(0))
            MessageBox.Show("Kayit basarili!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            plastikMiktar = Convert.ToDouble(txtPlastik.Text)
            plastikFiyat = Convert.ToDouble(txtPlastikFiyat.Text)

            celikMiktar = Convert.ToDouble(txtCelik.Text)
            celikFiyat = Convert.ToDouble(txtCelikFiyat.Text)

            makineFiyat = Convert.ToDouble(txtMakineFiyat.Text)
            makineSure = Convert.ToDouble(txtMakineSure.Text)

            isci1Sure = Convert.ToDouble(txtIsciSure.Text)
            isci1Fiyat = Convert.ToDouble(TxtIsciFiyat.Text)

            isci2Sure = Convert.ToDouble(TxtIsci2Sure.Text)
            isci2Fiyat = Convert.ToDouble(TxtIsci2Fiyat.Text)

            calisanMaas = Convert.ToDouble(txtCalisanMaas.Text)

            urunMaliyet = hesap.urunMaliyet(celikMiktar, celikFiyat, plastikMiktar, plastikFiyat)

            makineMaliyet = hesap.makineMaliyet(makineFiyat, makineSure)

            iscilikMaliyet = hesap.iscilikMaliyet(isci1Fiyat, isci1Sure) + hesap.iscilikMaliyet(isci2Fiyat, isci2Sure)

            toplamMaliyet = hesap.toplamMaliyet(urunMaliyet, makineMaliyet, iscilikMaliyet, calisanMaas)

            MessageBox.Show("toplamm: " & toplamMaliyet)

            cmd.CommandText = "UPDATE maliyet SET plastikMiktar=" & plastikMiktar &
                                ", plastikFiyat=" & plastikMiktar &
                                ", celikMiktar=" & celikMiktar &
                                ", celikFiyat=" & celikFiyat &
                                ", urunMaliyet=" & urunMaliyet &
                                ", makineFiyat=" & makineFiyat &
                                ", makineSure=" & makineSure &
                                ", makineMaliyet=" & makineMaliyet &
                                ", isci1Sure=" & isci1Sure &
                                ", isci1Fiyat=" & isci1Fiyat &
                                ", isci2Sure=" & isci2Sure &
                                ", isci2Fiyat=" & isci2Fiyat &
                                ", iscilikMaliyet=" & iscilikMaliyet &
                                ", calisanMaas=" & calisanMaas &
                                ", toplamMaliyet=" & toplamMaliyet &
                                " where id=" & Convert.ToInt32(lblID.Text)


            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Guncellendi")

                DataGridView1.DataSource = Nothing
                ds.Clear()
                da.Fill(dt)
                bs.DataSource = ds
                bs.DataMember = ds.Tables(0).TableName
                DataGridView1.DataSource = bs

            Else
                MessageBox.Show("Guncelleme islemi basarisiz")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'MessageBox.Show("Lutfen gecerli bir sayi degeri girin.")
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        For i = 0 To DataGridView1.Columns.Count
            lblID.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
            txtPlastik.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            txtPlastikFiyat.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
            txtCelik.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
            txtCelikFiyat.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value
            txtMakineFiyat.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(6).Value
            txtMakineSure.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(7).Value
            txtIsciSure.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(9).Value
            TxtIsciFiyat.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(10).Value
            TxtIsci2Sure.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(11).Value
            TxtIsci2Fiyat.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(12).Value
            txtCalisanMaas.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(14).Value

        Next
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        txtPlastik.Clear()
        txtPlastikFiyat.Clear()
        txtCelik.Clear()
        txtCelikFiyat.Clear()
        txtMakineFiyat.Clear()
        txtMakineSure.Clear()
        txtIsciSure.Clear()
        TxtIsciFiyat.Clear()
        TxtIsci2Sure.Clear()
        TxtIsci2Fiyat.Clear()
        txtCalisanMaas.Clear()
        ds.Tables(0).NewRow()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Try
            Dim sil = MsgBox("Silmek istedigine emin misin?", MsgBoxStyle.YesNo, "Sil")
            If sil = MsgBoxResult.Yes Then
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM maliyet WHERE id=" & lblID.Text

                If cmd.ExecuteNonQuery Then
                    MessageBox.Show("Silindi")

                    DataGridView1.DataSource = Nothing
                    ds.Clear()
                    da.Fill(dt)
                    bs.DataSource = ds
                    bs.DataMember = ds.Tables(0).TableName
                    DataGridView1.DataSource = bs

                Else
                    MessageBox.Show("Silme islemi basarisiz")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnAktar_Click(sender As Object, e As EventArgs) Handles btnAktar.Click
        Try
            Dim excelApp = New Excel.Application()
            excelApp.Workbooks.Add()
            Dim workSheet As Excel._Worksheet = excelApp.ActiveSheet

            For i = 0 To dt.Columns.Count - 1
                workSheet.Cells(1, i + 1) = dt.Columns(i).ColumnName
            Next

            For i = 0 To dt.Rows.Count - 1

                For j = 0 To dt.Columns.Count - 1
                    workSheet.Cells(i + 2, j + 1) = dt.Rows(i)(j)
                Next
            Next

            If Not String.IsNullOrEmpty(Application.StartupPath.ToString() & "/maliyet.xlsx") Then

                Try
                    workSheet.SaveAs(Application.StartupPath.ToString() & "/maliyet.xlsx")
                    excelApp.Quit()
                    MessageBox.Show("Aktarildi: " & Application.StartupPath.ToString() & "/maliyet.xlsx")
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            Else
                excelApp.Visible = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMail.Click
        Form2.Show()
    End Sub
End Class
