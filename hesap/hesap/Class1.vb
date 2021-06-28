Public Class Hesap
    Dim urunSonuc As Double
    Dim makineSonuc As Double
    Dim iscilikSonuc As Double
    Dim toplamSonuc As Double
    Dim urunIsciMaliyet As Double
    Function urunMaliyet(ByVal celikMiktar As Double, ByVal celikFiyat As Double, ByVal plastikMiktar As Double, ByVal plastikFiyat As Double)
        celikMiktar = celikMiktar / 1000
        plastikMiktar = plastikMiktar / 1000
        urunSonuc = (celikMiktar * celikFiyat) + (plastikMiktar * plastikFiyat)
        Return urunSonuc
    End Function

    Function makineMaliyet(ByVal makineFiyat As Double, ByVal islemeSuresi As Double)
        islemeSuresi = islemeSuresi / 60
        makineSonuc = (makineFiyat * islemeSuresi)
        Return makineSonuc
    End Function

    Function iscilikMaliyet(ByVal ucret As Double, ByVal calismaSuresi As Double)
        calismaSuresi = calismaSuresi / 60
        iscilikSonuc = (ucret * calismaSuresi)
        Return iscilikSonuc
    End Function

    Function toplamMaliyet(ByVal urunSonuc As Double, ByVal makineSonuc As Double, ByVal iscilikSonuc As Double, ByVal isciMaas As Double)
        urunIsciMaliyet = isciMaas / 1000
        toplamSonuc = urunSonuc + makineSonuc + iscilikSonuc + urunIsciMaliyet
        Return toplamSonuc
    End Function
End Class
