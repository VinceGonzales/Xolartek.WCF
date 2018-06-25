using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Xolartek.Services;

namespace Xolartek.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(XolarService));
            /*
            host.AddServiceEndpoint(typeof(IEvalService),
                new BasicHttpBinding(),
                "http://localhost:8080/evals/basic");
            host.AddServiceEndpoint(typeof(IEvalService),
                new WSHttpBinding(),
                "http://localhost:8080/evals/ws");
            host.AddServiceEndpoint(typeof(IEvalService),
                new NetTcpBinding(),
                "net.tcp://localhost:8081/evals");
            */

            try
            {
                host.Open();
                PrintServiceInfo(host);
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                host.Abort();
            }
        }
        static void PrintServiceInfo(ServiceHost host)
        {
            Console.WriteLine("{0} is up and running with these endpoints:",
                host.Description.ServiceType);
            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine(se.Address);
        }
    }
}
