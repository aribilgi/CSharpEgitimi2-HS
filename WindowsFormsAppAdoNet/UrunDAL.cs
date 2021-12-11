using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAdoNet
{
    public class UrunDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=.; initial catalog=UrunYonetimiAdoNet; Integrated security=True");
        void ConnectionKontrol()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open(); // Bağlantıyı aç
            }
        }
        public DataTable GetAllDataTable()
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from urunler", _connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            _connection.Close();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }

    }
}
