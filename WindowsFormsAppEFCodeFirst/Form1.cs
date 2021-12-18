using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppEFCodeFirst.Entites;

namespace WindowsFormsAppEFCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext(); // Veritabanındaki tablolarımızı dbset ler ile tutan class tan nesne oluşturduk
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvKategoriler.DataSource = context.Kategoriler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.Kategoriler.Add(new Kategori
            {
                Durum = cbDurum.Checked,
                KategoriAdi = txtKategoriAdi.Text
            });
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Kategori Eklendi");
                DgvKategoriler.DataSource = context.Kategoriler.ToList();
            }
        }
    }
}
