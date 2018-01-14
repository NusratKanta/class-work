using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace udp_server2
{
    class server
    {
        public void Listen()
        {

            UdpClient listener = new UdpClient(904);

            IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 904);

            while (true)
            {

                byte[] data = listener.Receive(ref serverEP);
                RaiseDataReceived(new ReceivedDataArgs(serverEP.Address,serverEP.Port,data));
            }
        }


        public delegate void DataReceived(object sender, ReceivedDataArgs arges);

        public event DataReceived DataReceivedEvent;

        private void RaiseDataReceived(ReceivedDataArgs args) {

            if(DataReceivedEvent != null)
                DataReceivedEvent(this,args);
        }

    }

    public class ReceivedDataArgs
    {

        public IPAddress IpAddress { get; set; }
        public int Port { get; set; }
        public byte[] ReceivedBytes;

        public ReceivedDataArgs(IPAddress ip, int port, byte[] data) {

            this.IpAddress = ip;
            this.Port = port;
            this.ReceivedBytes = data;

        }

    }
}
