using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsAppEFCodeFirst.Entites
{
    [Table("Kategoriler")]
    public class Kategori // Entity
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public bool Durum { get; set; }
    }
}
