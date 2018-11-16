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

        public TestConnect(string login, string password, string comand)
        {
            StringBuilder sb = new StringBuilder();
            IPAddress adress = IPAddress.Parse("192.168.9.200");  //ip куда подключаться
            IPEndPoint host = new IPEndPoint(adress, 23);
            tc = new TcpClient();
            tc.Connect(host);
            Authorize(login, password, comand);
            Thread.Sleep(100);
        }

        public string GetAnswer()
        {
            var res = new StringBuilder();
            NetworkStream netStream = tc.GetStream();
            do
            {
                byte[] bytes = new byte[tc.ReceiveBufferSize];
                netStream.Read(bytes, 0, (int)tc.ReceiveBufferSize);
                res.AppendLine( Encoding.ASCII.GetString(bytes));
                Thread.Sleep(50);

            } while (netStream.DataAvailable);

            return (res.ToString());
         
        }

        public void Authorize(string login, string password, string comand)
        {
            SendCmd(login);
            SendCmd(password);
            SendCmd(comand);

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