namespace _01_CSProjeDemo1.Entities
{
    public abstract class Kitap
    {
        public int ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public DateTime YayinYili { get; set; }
    }
}
