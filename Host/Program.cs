using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Services.Implementations;
using Database.Model;

namespace Host
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(Services.Implementations.AccountService)))
            {
                
                serviceHost.Open();

                Console.WriteLine("Servidor WCF en ejecución. Presiona Enter para detenerlo.");
                Console.ReadLine();
                
            }
        }
    }
}
