using System.Configuration;
using eBAPI.Connection;

namespace EbaSurecBaslatma
{
    class SurecBaslatService
    {
        public static int Baslat()
        {
            eBAConnection con = new eBAConnection();
            con.Server = ConfigurationManager.AppSettings["eBAServer"];
            con.UserID = ConfigurationManager.AppSettings["eBAUser"];
            con.Password = ConfigurationManager.AppSettings["eBAPass"];
            con.Open();
            con.Impersonate(ConfigurationManager.AppSettings["eBAUser"]);

            var process = con.WorkflowManager.CreateProcess(ConfigurationManager.AppSettings["ProcessName"]);
            process.Parameters.Add("vrbText1", "Gül Pýnar Demir");
            process.Parameters.Update();
            process.Start();

            int processId = process.ProcessId;
            con.Close();
            return processId;
        }
    }
}
