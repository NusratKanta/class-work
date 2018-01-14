using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace udp_server2
{
    class HandleDataClass
    {

        public void SubscribeToEvent(server server)
        {
            server.DataReceivedEvent += Server_DataReceivedEvent;
        }

         void Server_DataReceivedEvent(object sender, ReceivedDataArgs arges)
        {
            Console.WriteLine("Received Massege Form [{0}:{1}]:\r\n{2}",
                arges.IpAddress.ToString(),arges.Port.ToString(),
                Encoding.ASCII.GetString(arges.ReceivedBytes));
        }


    }
}
