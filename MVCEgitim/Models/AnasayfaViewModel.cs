namespace MVCEgitim.Models
{
    public class AnasayfaViewModel // Sayfada birden fazla class ı model olarak kullanmak istersek bu şekilde ayrı bir class oluşturup içine kullanmak istediğimiz class ları aşağıdaki gibi property olarak vermemiz gerekiyor.
    {
        public Kullanici Kullanici { get; set; }
        public Adres Adres { get; set; }
    }
}