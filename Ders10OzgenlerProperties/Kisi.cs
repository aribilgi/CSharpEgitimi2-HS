using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10OzgenlerProperties
{
    public class Kisi
    {
        private int yas;
        private string dogumyeri;
        private string meslek;
        private double maas;

        public double Maas
        {
            get { return maas; }
            set
            {
                if (value <= 2825)
                {
                    maas = 2825;
                }
                else maas = value;
            }
        }

        public int Yas
        {
            get { return yas; }
            set
            {//set bloğunda dışarıdan gelen value değerine göre işlem yaptırabiliriz
                if (value <= 65 && value >= 18) yas = value;
                else yas = 18;
            }
        }

        public string DogumYeri
        {
            get { return dogumyeri; }
            set { dogumyeri = value; }
        }

    }
}
