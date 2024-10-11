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
                // Define the binding to use (Named Pipes)
                NetNamedPipeBinding binding = new NetNamedPipeBinding();

                // Add the service endpoint with the contract and binding
                host.AddServiceEndpoint(typeof(IAstroContract), binding, "AstroPipe");

                try
                {
                    // Open the service host to start listening for incoming requests
                    host.Open();
                    Console.WriteLine("WCF Service is running at: " + baseAddress);
                    Console.WriteLine("Press Enter to stop the service...");

                    // Wait for the user to press Enter to terminate the service
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur while starting the service
                    Console.WriteLine("Error starting the service: " + ex.Message);
                }
                finally
                {
                    // Ensure the service host is closed properly when done
                    if (host.State == CommunicationState.Faulted)
                    {
                        host.Abort();  // Forcefully close the service if it is in a faulted state
                        Console.WriteLine("Service aborted due to an error.");
                    }
                    else
                    {
                        host.Close();  // Gracefully close the service
                        Console.WriteLine("Service stopped.");
                    }
                }
            }
        }
    }
}
