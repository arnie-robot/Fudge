using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Fudge
{
    class OutputThread
    {
        /**
         * The string we are going to send
         */
        protected string output;

        /**
         * The host to send to
         */
        protected string host;

        /**
         * The port to send to
         */
        protected int port;

        public OutputThread(string host, int port, string output)
        {
            this.host = host;
            this.port = port;
            this.output = output;
        }

        /**
         * Processes and sends the data
         */
        public void process()
        {
            Socket sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint sendEndPoint = new IPEndPoint(IPAddress.Parse(this.host), this.port);
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] buffer = encoding.GetBytes(this.output);
            sendSocket.SendTo(buffer, buffer.Length, SocketFlags.None, sendEndPoint);
        }
    }
}