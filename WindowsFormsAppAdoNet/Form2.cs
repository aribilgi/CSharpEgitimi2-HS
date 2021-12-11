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

        }
    }
}
