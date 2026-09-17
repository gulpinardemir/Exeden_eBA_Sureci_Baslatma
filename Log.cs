using System;
using System.Configuration;
using System.IO;

namespace EbaSurecBaslatma
{
    class Log
    {
        public static void Yaz(string mesaj)
        {
            string klasor = ConfigurationManager.AppSettings["LogPath"];
            if (!Directory.Exists(klasor))
            {
                Directory.CreateDirectory(klasor);
            }

            string dosya = Path.Combine(klasor, DateTime.Now.ToString("yyyyMMdd") + "_SurecBaslatma.txt");
            string satir = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " | " + mesaj;
            File.AppendAllText(dosya, satir + Environment.NewLine);
            Console.WriteLine(satir);
        }
    }
}
