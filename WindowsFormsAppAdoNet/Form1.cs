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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KategoriDAL kategoriDAL = new KategoriDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvKategoriler.DataSource = kategoriDAL.GetAllDataTable();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var sonuc = kategoriDAL.Add(new Kategori
            {
                Durum = cbDurum.Checked,
                KategoriAdi = txtKategoriAdi.Text
            });
            if (sonuc > 0)
            {
                MessageBox.Show("Kategori Eklendi");
                DgvKategoriler.DataSource = kategoriDAL.GetAllDataTable();
            }
        }

        private void DgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = DgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(DgvKategoriler.CurrentRow.Cells[2].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var sonuc = kategoriDAL.Update(new Kategori
            {
                Id = Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value),
                Durum = cbDurum.Checked,
                KategoriAdi = txtKategoriAdi.Text
            });
            if (sonuc > 0)
            {
                MessageBox.Show("Kategori Güncellendi");
                DgvKategoriler.DataSource = kategoriDAL.GetAllDataTable();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = kategoriDAL.Delete(Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value));
            if (sonuc > 0)
            {
                MessageBox.Show("Kategori Silindi");
                DgvKategoriler.DataSource = kategoriDAL.GetAllDataTable();
            }
        }
    }
}
