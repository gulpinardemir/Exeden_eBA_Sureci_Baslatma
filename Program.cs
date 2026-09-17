using System;

namespace EbaSurecBaslatma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eBA Süreç Başlatma");
            Console.WriteLine("***********************************************");

            try
            {
                int processId = SurecBaslatService.Baslat();
                Log.Yaz("Süreç başladı. ProcessId=" + processId);
            }
            catch (Exception ex)
            {
                Log.Yaz("Hata: " + ex.Message);
            }

            Console.WriteLine("***********************************************");
        }
    }
}
