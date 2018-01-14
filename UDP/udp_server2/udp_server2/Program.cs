using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace udp_server2
{
    class Program
    {
        static void Main(string[] args)
        {

            server server = new server();
            HandleDataClass hdc = new HandleDataClass();

            //start server thread 
            Thread serverThread = new Thread(()=>server.Listen());
            serverThread.Start();

            //start Handler thread
            Thread dataHandlerThread = new Thread(() => hdc.SubscribeToEvent(server));
            dataHandlerThread.Start();




            //Do other things
            while(true)
            {
                Thread.Sleep(100);
            }
        }
    }
}
