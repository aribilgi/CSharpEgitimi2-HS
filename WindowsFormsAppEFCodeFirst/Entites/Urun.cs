using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsAppEFCodeFirst.Entites
{
    [Table("Urunler")] // veritabanında oluşacak ismi table ile belirleyebiliyoruz Uruns yerine Urunler olması için
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int StokMiktari { get; set; }
    }
}
