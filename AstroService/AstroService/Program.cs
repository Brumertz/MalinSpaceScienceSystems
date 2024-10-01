using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using AstroMaths;

namespace AstroService
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("net.pipe://localhost/AstroService");

            using (ServiceHost host = new ServiceHost(typeof(AstroServer), baseAddress))
            {
                NetNamedPipeBinding binding = new NetNamedPipeBinding();
                host.AddServiceEndpoint(typeof(IAstroContract), binding, "AstroPipe");

                try
                {
                    host.Open();
                    Console.WriteLine("Servicio WCF en ejecución...");
                    Console.WriteLine("Presione Enter para finalizar el servicio.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al iniciar el servicio: " + ex.Message);
                }
            }
        }
    }
}
