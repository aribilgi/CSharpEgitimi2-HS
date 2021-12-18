using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEFDbFirst
{
    public partial class Form2UrunYonetimi : Form
    {
        public Form2UrunYonetimi()
        {
            InitializeComponent();
        }
        UrunYonetimiAdoNet urunYonetimi = new UrunYonetimiAdoNet();
        private void Form2UrunYonetimi_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = urunYonetimi.Urunler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunYonetimi.Urunler.Add(new Urunler
            {
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });

            var islemSonucu = urunYonetimi.SaveChanges();//SaveChanges metodu yukardaki products tablosu üzerine eklenen ürünün veritabanına kaydedilmesini sağlar ve int türünde etkilenen kayıt sayısını döndürür

            if (islemSonucu > 0)
            {
                dgvUrunler.DataSource = urunYonetimi.Urunler.ToList();
                MessageBox.Show("Ürün Başarıyla Eklendi");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            urunYonetimi.Urunler.AddOrUpdate(new Urunler
            {
                Id = (int)dgvUrunler.CurrentRow.Cells[0].Value,
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });

            var islemSonucu = urunYonetimi.SaveChanges();

            if (islemSonucu > 0)
            {
                dgvUrunler.DataSource = urunYonetimi.Urunler.ToList();
                MessageBox.Show("Ürün Başarıyla Güncellendi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekKayit = urunYonetimi.Urunler.Find((int)dgvUrunler.CurrentRow.Cells[0].Value);
            urunYonetimi.Urunler.Remove(silinecekKayit);
            var sonuc = urunYonetimi.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt Silindi!");
                dgvUrunler.DataSource = urunYonetimi.Urunler.ToList();
            }
        }
    }
}
