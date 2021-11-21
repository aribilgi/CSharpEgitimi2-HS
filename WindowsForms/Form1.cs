using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Uygulama çalıştığında form load olayı tetiklenir
            //Burada pencere yüklenirken yaptırmak istediklerimizi gerçekleştirebiliriz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeniForm = new Form2();
            //yeniForm.Show();//Çağırılan form Show metoduyla gösterilirse, tüm formlara erişim sağlanabilir
            yeniForm.ShowDialog(); //Çağırılan form ShowDialog metoduyla gösterilirse, üstteki form kapatılana kadar alttaki forma erişim engellenir
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();//Bulunulan formu kapat, aşağıdaki kod ya da bu kod kullanılabilir
            //AnaEkran.ActiveForm.Close();//Form1 nesnesini kapat
            Application.Exit();//Uygulamadan çık
        }
    }
}
