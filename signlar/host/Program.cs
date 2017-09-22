using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:8080/"))
            {
                Console.WriteLine("Server running at http://localhost:8080/");
                Console.ReadLine();
            }

        }

        [HubName("CustomHub")]
        public class MyHub : Hub
        {
            public string Send(string message)
            {
                return message;
            }

            public void DoSomething(string param)
            {
                Console.WriteLine(param);
                Clients.All.addMessage(param);
            }
        }
    }
}
