using System.Configuration;

namespace EtutOtomasyonu
{
    public static class AppSettings
    {
        private static Configuration Konfigurasyon;

        static AppSettings()
        {
            Konfigurasyon = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public static string BaglantiCumlesiniGetir(string key)
        {
            return Konfigurasyon.ConnectionStrings.ConnectionStrings[key].ToString();
        }
    }
}