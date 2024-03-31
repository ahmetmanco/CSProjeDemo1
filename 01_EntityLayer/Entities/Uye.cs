using _01_CSProjeDemo1.Concrete;
using _01_CSProjeDemo1.Enum;
namespace _01_CSProjeDemo1.Entities
{
    public class Uye : IUye
    {
        public int UyeNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Kitap> OduncKitaplari { get; set; }

        public Uye(string ad, string soyad, int uyeNo)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNo = uyeNo;
        }

        public void KitapOdunc(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlinabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                OduncKitaplari.Add(kitap);
                Console.WriteLine(kitap.Baslik + "kitabını ödünç aldı");
            }
            else if (kitap.Durum == Durum.MevcutDegil)
            {
                Console.WriteLine("Kitap şu an mevcut değil");
            }
        }

        public void KitapTeslim(Kitap kitap)
        {
            if (OduncKitaplari.Contains(kitap))
            {
                kitap.Durum = Durum.OduncAlinabilir;
                OduncKitaplari.Remove(kitap);
                Console.WriteLine(kitap.Baslik + "kitabı iade edilmiştir");
            }
            else
            {
                Console.WriteLine("kitap sizde değil");
            }
        }
    }
}
