using _01_CSProjeDemo1.Concrete;
using _01_CSProjeDemo1.Enum;

namespace _01_CSProjeDemo1.Entities
{
    public abstract class Kitap : IKitap
    {
        public int Id { get ; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int YayinYili { get; set; }
        public Durum Durum { get; set; }
    }
}
