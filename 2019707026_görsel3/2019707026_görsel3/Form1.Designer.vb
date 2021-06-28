<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAktar = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnYeni = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.lblIsciSure = New System.Windows.Forms.Label()
        Me.txtIsciSure = New System.Windows.Forms.TextBox()
        Me.lblMakineSure = New System.Windows.Forms.Label()
        Me.txtMakineSure = New System.Windows.Forms.TextBox()
        Me.lblCelikFiyat = New System.Windows.Forms.Label()
        Me.txtCelikFiyat = New System.Windows.Forms.TextBox()
        Me.lblCelikMiktar = New System.Windows.Forms.Label()
        Me.txtCelik = New System.Windows.Forms.TextBox()
        Me.lblMakFiyat = New System.Windows.Forms.Label()
        Me.txtMakineFiyat = New System.Windows.Forms.TextBox()
        Me.lblPlastikFiyat = New System.Windows.Forms.Label()
        Me.txtPlastikFiyat = New System.Windows.Forms.TextBox()
        Me.lblPlastik = New System.Windows.Forms.Label()
        Me.txtPlastik = New System.Windows.Forms.TextBox()
        Me.btnHesapla = New System.Windows.Forms.Button()
        Me.lblIsciFiyat = New System.Windows.Forms.Label()
        Me.TxtIsciFiyat = New System.Windows.Forms.TextBox()
        Me.lblIsci2Fiyat = New System.Windows.Forms.Label()
        Me.TxtIsci2Fiyat = New System.Windows.Forms.TextBox()
        Me.lblIsci2Sure = New System.Windows.Forms.Label()
        Me.TxtIsci2Sure = New System.Windows.Forms.TextBox()
        Me.lblCalisanMaas = New System.Windows.Forms.Label()
        Me.txtCalisanMaas = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnMail = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAktar
        '
        Me.btnAktar.Location = New System.Drawing.Point(427, 629)
        Me.btnAktar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAktar.Name = "btnAktar"
        Me.btnAktar.Size = New System.Drawing.Size(112, 48)
        Me.btnAktar.TabIndex = 41
        Me.btnAktar.Text = "Aktar"
        Me.btnAktar.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(293, 629)
        Me.btnSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(112, 48)
        Me.btnSil.TabIndex = 40
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnYeni
        '
        Me.btnYeni.Location = New System.Drawing.Point(24, 261)
        Me.btnYeni.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(112, 48)
        Me.btnYeni.TabIndex = 39
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.UseVisualStyleBackColor = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.Location = New System.Drawing.Point(159, 629)
        Me.btnGuncelle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(112, 48)
        Me.btnGuncelle.TabIndex = 38
        Me.btnGuncelle.Text = "Guncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(871, 285)
        Me.DataGridView1.TabIndex = 37
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(24, 629)
        Me.btnKaydet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(112, 48)
        Me.btnKaydet.TabIndex = 36
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'lblIsciSure
        '
        Me.lblIsciSure.AutoSize = True
        Me.lblIsciSure.Location = New System.Drawing.Point(289, 142)
        Me.lblIsciSure.Name = "lblIsciSure"
        Me.lblIsciSure.Size = New System.Drawing.Size(69, 13)
        Me.lblIsciSure.TabIndex = 35
        Me.lblIsciSure.Text = "Isci Sure (dk)"
        '
        'txtIsciSure
        '
        Me.txtIsciSure.Location = New System.Drawing.Point(399, 139)
        Me.txtIsciSure.Name = "txtIsciSure"
        Me.txtIsciSure.Size = New System.Drawing.Size(100, 20)
        Me.txtIsciSure.TabIndex = 34
        Me.txtIsciSure.Text = " "
        '
        'lblMakineSure
        '
        Me.lblMakineSure.AutoSize = True
        Me.lblMakineSure.Location = New System.Drawing.Point(20, 184)
        Me.lblMakineSure.Name = "lblMakineSure"
        Me.lblMakineSure.Size = New System.Drawing.Size(88, 13)
        Me.lblMakineSure.TabIndex = 33
        Me.lblMakineSure.Text = "Makine Sure (dk)"
        '
        'txtMakineSure
        '
        Me.txtMakineSure.Location = New System.Drawing.Point(130, 181)
        Me.txtMakineSure.Name = "txtMakineSure"
        Me.txtMakineSure.Size = New System.Drawing.Size(100, 20)
        Me.txtMakineSure.TabIndex = 32
        '
        'lblCelikFiyat
        '
        Me.lblCelikFiyat.AutoSize = True
        Me.lblCelikFiyat.Location = New System.Drawing.Point(289, 78)
        Me.lblCelikFiyat.Name = "lblCelikFiyat"
        Me.lblCelikFiyat.Size = New System.Drawing.Size(94, 13)
        Me.lblCelikFiyat.TabIndex = 31
        Me.lblCelikFiyat.Text = "Celik Fiyat (TL/kg)"
        '
        'txtCelikFiyat
        '
        Me.txtCelikFiyat.Location = New System.Drawing.Point(399, 75)
        Me.txtCelikFiyat.Name = "txtCelikFiyat"
        Me.txtCelikFiyat.Size = New System.Drawing.Size(100, 20)
        Me.txtCelikFiyat.TabIndex = 30
        '
        'lblCelikMiktar
        '
        Me.lblCelikMiktar.AutoSize = True
        Me.lblCelikMiktar.Location = New System.Drawing.Point(289, 20)
        Me.lblCelikMiktar.Name = "lblCelikMiktar"
        Me.lblCelikMiktar.Size = New System.Drawing.Size(80, 13)
        Me.lblCelikMiktar.TabIndex = 29
        Me.lblCelikMiktar.Text = "Celik Miktar (gr)"
        '
        'txtCelik
        '
        Me.txtCelik.Location = New System.Drawing.Point(399, 17)
        Me.txtCelik.Name = "txtCelik"
        Me.txtCelik.Size = New System.Drawing.Size(100, 20)
        Me.txtCelik.TabIndex = 28
        '
        'lblMakFiyat
        '
        Me.lblMakFiyat.AutoSize = True
        Me.lblMakFiyat.Location = New System.Drawing.Point(0, 142)
        Me.lblMakFiyat.Name = "lblMakFiyat"
        Me.lblMakFiyat.Size = New System.Drawing.Size(124, 13)
        Me.lblMakFiyat.TabIndex = 27
        Me.lblMakFiyat.Text = "Makine Saatlik Fiyat (TL)"
        '
        'txtMakineFiyat
        '
        Me.txtMakineFiyat.Location = New System.Drawing.Point(130, 139)
        Me.txtMakineFiyat.Name = "txtMakineFiyat"
        Me.txtMakineFiyat.Size = New System.Drawing.Size(100, 20)
        Me.txtMakineFiyat.TabIndex = 26
        '
        'lblPlastikFiyat
        '
        Me.lblPlastikFiyat.AutoSize = True
        Me.lblPlastikFiyat.Location = New System.Drawing.Point(20, 74)
        Me.lblPlastikFiyat.Name = "lblPlastikFiyat"
        Me.lblPlastikFiyat.Size = New System.Drawing.Size(102, 13)
        Me.lblPlastikFiyat.TabIndex = 25
        Me.lblPlastikFiyat.Text = "Plastik Fiyat (TL/kg)"
        '
        'txtPlastikFiyat
        '
        Me.txtPlastikFiyat.Location = New System.Drawing.Point(130, 71)
        Me.txtPlastikFiyat.Name = "txtPlastikFiyat"
        Me.txtPlastikFiyat.Size = New System.Drawing.Size(100, 20)
        Me.txtPlastikFiyat.TabIndex = 24
        '
        'lblPlastik
        '
        Me.lblPlastik.AutoSize = True
        Me.lblPlastik.Location = New System.Drawing.Point(20, 20)
        Me.lblPlastik.Name = "lblPlastik"
        Me.lblPlastik.Size = New System.Drawing.Size(88, 13)
        Me.lblPlastik.TabIndex = 23
        Me.lblPlastik.Text = "Plastik Miktar (gr)"
        '
        'txtPlastik
        '
        Me.txtPlastik.Location = New System.Drawing.Point(130, 17)
        Me.txtPlastik.Name = "txtPlastik"
        Me.txtPlastik.Size = New System.Drawing.Size(100, 20)
        Me.txtPlastik.TabIndex = 22
        '
        'btnHesapla
        '
        Me.btnHesapla.Location = New System.Drawing.Point(159, 261)
        Me.btnHesapla.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHesapla.Name = "btnHesapla"
        Me.btnHesapla.Size = New System.Drawing.Size(112, 48)
        Me.btnHesapla.TabIndex = 21
        Me.btnHesapla.Text = "Hesapla"
        Me.btnHesapla.UseVisualStyleBackColor = True
        '
        'lblIsciFiyat
        '
        Me.lblIsciFiyat.AutoSize = True
        Me.lblIsciFiyat.Location = New System.Drawing.Point(289, 184)
        Me.lblIsciFiyat.Name = "lblIsciFiyat"
        Me.lblIsciFiyat.Size = New System.Drawing.Size(86, 13)
        Me.lblIsciFiyat.TabIndex = 43
        Me.lblIsciFiyat.Text = "Isci Fiyat (TL/sa)"
        '
        'TxtIsciFiyat
        '
        Me.TxtIsciFiyat.Location = New System.Drawing.Point(399, 181)
        Me.TxtIsciFiyat.Name = "TxtIsciFiyat"
        Me.TxtIsciFiyat.Size = New System.Drawing.Size(100, 20)
        Me.TxtIsciFiyat.TabIndex = 42
        Me.TxtIsciFiyat.Text = " "
        '
        'lblIsci2Fiyat
        '
        Me.lblIsci2Fiyat.AutoSize = True
        Me.lblIsci2Fiyat.Location = New System.Drawing.Point(289, 261)
        Me.lblIsci2Fiyat.Name = "lblIsci2Fiyat"
        Me.lblIsci2Fiyat.Size = New System.Drawing.Size(92, 13)
        Me.lblIsci2Fiyat.TabIndex = 47
        Me.lblIsci2Fiyat.Text = "Isci2 Fiyat (TL/sa)"
        '
        'TxtIsci2Fiyat
        '
        Me.TxtIsci2Fiyat.Location = New System.Drawing.Point(399, 258)
        Me.TxtIsci2Fiyat.Name = "TxtIsci2Fiyat"
        Me.TxtIsci2Fiyat.Size = New System.Drawing.Size(100, 20)
        Me.TxtIsci2Fiyat.TabIndex = 46
        Me.TxtIsci2Fiyat.Text = " "
        '
        'lblIsci2Sure
        '
        Me.lblIsci2Sure.AutoSize = True
        Me.lblIsci2Sure.Location = New System.Drawing.Point(289, 219)
        Me.lblIsci2Sure.Name = "lblIsci2Sure"
        Me.lblIsci2Sure.Size = New System.Drawing.Size(75, 13)
        Me.lblIsci2Sure.TabIndex = 45
        Me.lblIsci2Sure.Text = "Isci2 Sure (dk)"
        '
        'TxtIsci2Sure
        '
        Me.TxtIsci2Sure.Location = New System.Drawing.Point(399, 216)
        Me.TxtIsci2Sure.Name = "TxtIsci2Sure"
        Me.TxtIsci2Sure.Size = New System.Drawing.Size(100, 20)
        Me.TxtIsci2Sure.TabIndex = 44
        Me.TxtIsci2Sure.Text = " "
        '
        'lblCalisanMaas
        '
        Me.lblCalisanMaas.AutoSize = True
        Me.lblCalisanMaas.Location = New System.Drawing.Point(558, 15)
        Me.lblCalisanMaas.Name = "lblCalisanMaas"
        Me.lblCalisanMaas.Size = New System.Drawing.Size(81, 13)
        Me.lblCalisanMaas.TabIndex = 49
        Me.lblCalisanMaas.Text = "Calisanlar Maas"
        '
        'txtCalisanMaas
        '
        Me.txtCalisanMaas.Location = New System.Drawing.Point(668, 12)
        Me.txtCalisanMaas.Name = "txtCalisanMaas"
        Me.txtCalisanMaas.Size = New System.Drawing.Size(100, 20)
        Me.txtCalisanMaas.TabIndex = 48
        Me.txtCalisanMaas.Text = " "
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(0, 7)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 51
        Me.lblID.Text = "ID"
        '
        'btnMail
        '
        Me.btnMail.Location = New System.Drawing.Point(561, 629)
        Me.btnMail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(112, 48)
        Me.btnMail.TabIndex = 52
        Me.btnMail.Text = "Mail"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 698)
        Me.Controls.Add(Me.btnMail)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCalisanMaas)
        Me.Controls.Add(Me.txtCalisanMaas)
        Me.Controls.Add(Me.lblIsci2Fiyat)
        Me.Controls.Add(Me.TxtIsci2Fiyat)
        Me.Controls.Add(Me.lblIsci2Sure)
        Me.Controls.Add(Me.TxtIsci2Sure)
        Me.Controls.Add(Me.lblIsciFiyat)
        Me.Controls.Add(Me.TxtIsciFiyat)
        Me.Controls.Add(Me.btnAktar)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnYeni)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.lblIsciSure)
        Me.Controls.Add(Me.txtIsciSure)
        Me.Controls.Add(Me.lblMakineSure)
        Me.Controls.Add(Me.txtMakineSure)
        Me.Controls.Add(Me.lblCelikFiyat)
        Me.Controls.Add(Me.txtCelikFiyat)
        Me.Controls.Add(Me.lblCelikMiktar)
        Me.Controls.Add(Me.txtCelik)
        Me.Controls.Add(Me.lblMakFiyat)
        Me.Controls.Add(Me.txtMakineFiyat)
        Me.Controls.Add(Me.lblPlastikFiyat)
        Me.Controls.Add(Me.txtPlastikFiyat)
        Me.Controls.Add(Me.lblPlastik)
        Me.Controls.Add(Me.txtPlastik)
        Me.Controls.Add(Me.btnHesapla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAktar As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnYeni As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnKaydet As Button
    Friend WithEvents lblIsciSure As Label
    Friend WithEvents txtIsciSure As TextBox
    Friend WithEvents lblMakineSure As Label
    Friend WithEvents txtMakineSure As TextBox
    Friend WithEvents lblCelikFiyat As Label
    Friend WithEvents txtCelikFiyat As TextBox
    Friend WithEvents lblCelikMiktar As Label
    Friend WithEvents txtCelik As TextBox
    Friend WithEvents lblMakFiyat As Label
    Friend WithEvents txtMakineFiyat As TextBox
    Friend WithEvents lblPlastikFiyat As Label
    Friend WithEvents txtPlastikFiyat As TextBox
    Friend WithEvents lblPlastik As Label
    Friend WithEvents txtPlastik As TextBox
    Friend WithEvents btnHesapla As Button
    Friend WithEvents lblIsciFiyat As Label
    Friend WithEvents TxtIsciFiyat As TextBox
    Friend WithEvents lblIsci2Fiyat As Label
    Friend WithEvents TxtIsci2Fiyat As TextBox
    Friend WithEvents lblIsci2Sure As Label
    Friend WithEvents TxtIsci2Sure As TextBox
    Friend WithEvents lblCalisanMaas As Label
    Friend WithEvents txtCalisanMaas As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnMail As Button
End Class
