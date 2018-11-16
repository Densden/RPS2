using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ConsoleTelnet
{
    public class TestConnect
    {
        public TcpClient tc { get; set; }

        public TestConnect(string login, string password)
        {
            StringBuilder sb = new StringBuilder();
            IPAddress adress = IPAddress.Parse("192.168.9.200");  //ip куда подключаться
            IPEndPoint host = new IPEndPoint(adress, 23);
            TcpClient tcpClientt = new TcpClient();
            tcpClientt.Connect(host);
            Authorize(login, password);
            Thread.Sleep(100);
        }

        public string GetAnswer()
        {
            NetworkStream netStream = tc.GetStream();
            byte[] bytes = new byte[tc.ReceiveBufferSize];
            netStream.Read(bytes, 0, (int)tc.ReceiveBufferSize);
            string returndata = Encoding.ASCII.GetString(bytes);
            return (returndata);
           // return "test";
        }

        public void Authorize(string login, string password)
        {
            SendCmd(login);
            SendCmd(password);
        }
        public void SendCmd(string cmd)
        {
            NetworkStream netStream = tc.GetStream();
            if (netStream.CanWrite)
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes(cmd + "\r");
                netStream.Write(sendBytes, 0, sendBytes.Length);
            }
            Thread.Sleep(1000);
        }
    }
}