using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//sql kütüphanemizi projemize dahil ettik
namespace EtutOtomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(AppSettings.BaglantiCumlesiniGetir("veritabaniAdresi"));//sql bağlantı cümlemizi oluşturduk
            baglanti.Open();//bağlantıyı açtık
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();//açık kalan vs bağlantıları temizledik
            return (baglanti);//bağlantıyı gönderdik
        }
    }
}