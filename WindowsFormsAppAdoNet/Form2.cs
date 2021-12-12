using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        UrunDAL urunDAL = new UrunDAL();
        private void Form2_Load(object sender, EventArgs e)
        {
            DgvUrunler.DataSource = urunDAL.GetAllDataTable();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var sonuc = urunDAL.Add(new Urun
            {
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });
            if (sonuc > 0)
            {
                DgvUrunler.DataSource = urunDAL.GetAllDataTable();
                MessageBox.Show("Ürün eklendi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var sonuc = urunDAL.Update(new Urun
            {
                Id = Convert.ToInt32(DgvUrunler.CurrentRow.Cells[0].Value),
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });
            if (sonuc > 0)
            {
                DgvUrunler.DataSource = urunDAL.GetAllDataTable();
                MessageBox.Show("Ürün Güncellendi!");
            }
        }

        private void DgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = DgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyati.Text = DgvUrunler.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = DgvUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = urunDAL.Delete(Convert.ToInt32(DgvUrunler.CurrentRow.Cells[0].Value));
            if (sonuc > 0)
            {
                DgvUrunler.DataSource = urunDAL.GetAllDataTable();
                MessageBox.Show("Ürün Silindi");
            }
        }
    }
}
