using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppAdoNet
{
    public class KategoriDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=.; initial catalog=UrunYonetimiAdoNet; Integrated security=True"); // SqlConnection Sql server a bağlanmamızı sağlar - initial catalog veritabanı ismi

        void ConnectionKontrol() //Veritabanı bağlantısının açık olup olmadığını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed) //Yukardaki _connection bağlantı nesnemizin durumu bağlantı durumlarından kapalıya eşitse
            {
                _connection.Open(); // Bağlantıyı aç
            }
        }

        public DataTable GetAllDataTable()
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from kategoriler", _connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            _connection.Close();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }

        public int Add(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Insert into Kategoriler values (@KategoriAdi,@Durum)", _connection);
            command.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", kategori.Durum);
            var sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Update(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Update Kategoriler set KategoriAdi= @KategoriAdi, Durum = @Durum where Id=@Id", _connection);
            command.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", kategori.Durum);
            command.Parameters.AddWithValue("@Id", kategori.Id);
            var sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Delete from Kategoriler where Id=@Id", _connection);
            
            command.Parameters.AddWithValue("@Id", id);
            var sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

    }
}
