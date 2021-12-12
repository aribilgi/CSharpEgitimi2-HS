using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEFDbFirst
{
    //ORM  https://api.nuget.org/v3/index.json
    //Yaklaşımlar
    /*
     * 1-Model First
     * 2-Database First
     * 3-Code First
     * 4-Code First (Var olan veritabanını kullanarak)
     */
    // Ef ü projeye yüklemek için
    // Solution explorer dan projeye sağ tıkladık, manage nuget packages menüsü tıkladık, açılan pencereden brows a tıkladık, oradan entity framework ü seçip install dedik, açılan uyarı pencerelerine ok ve ı accept i seçerek kabul ettik.

    // Ef db first modeli oluşturma
    /* Projeye sağ tık add new item dan açılan pencereden data sekmesini seçip en üst menüdeki entity data model seçeneğini seçtik
     * Burada oluşacak modele bir isim verdik ve add dedik
     * Açılan pencerede DbFirs kullanacağımız için ilk seçenek olan Ef designer from database i seçip next dedik
     * Açılan pencerede new connection butonuna tıklayıp bağlanacağımız server ı yazıp ilgili veritabanını seçtik ve ok diyerek bitirdik
     * Db seçiminden sonra next diyerek ilerledik
     * Gelen pencerede Tables e tik koyduk altındaki tüm tabloları seçtik ve finish e basıp bitirdik
     * Seçtiğimiz tablolar model olarak önümüze geldi ve üst menüden save butonuna tıklayıp işlemlerin bitmesini bekledik, kayıt bitince pencereyi kapadık.
     * */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunYonetimiAdoNet urunYonetimi = new UrunYonetimiAdoNet();
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvKategoriler.DataSource = urunYonetimi.Kategoriler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            urunYonetimi.Kategoriler.Add(new Kategoriler
            {
                Durum = cbDurum.Checked,
                KategoriAdi = txtKategoriAdi.Text
            });
            var sonuc = urunYonetimi.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Kategori Eklendi");
                DgvKategoriler.DataSource = urunYonetimi.Kategoriler.ToList();
            }
        }
    }
}
