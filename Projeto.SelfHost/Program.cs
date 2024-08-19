using Microsoft.Owin.Hosting;
using System;

namespace Projeto.SelfHost
{
    internal class Program
    {
        protected Program()
        { }

        private static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host for Web API
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Web API running at " + baseAddress);
                Console.WriteLine("Press Enter to stop the server.");
                Console.ReadLine();
            }
        }
    }
}
