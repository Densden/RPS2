using System;

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
    public  class Program1
    {
        public static string GetAnswer(TcpClient tc)
        {
            NetworkStream netStream = tc.GetStream();
            byte[] bytes = new byte[tc.ReceiveBufferSize];
            netStream.Read(bytes, 0, (int)tc.ReceiveBufferSize);
            string returndata = Encoding.ASCII.GetString(bytes);
            return (returndata);
        }

        static void SendCmd(TcpClient tc, string cmd)
        {
            NetworkStream netStream = tc.GetStream();
            if (netStream.CanWrite)
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes(cmd + "\r");
                netStream.Write(sendBytes, 0, sendBytes.Length);
            }
            Thread.Sleep(1000);
        }


        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            IPAddress adress = IPAddress.Parse("192.168.9.200");  //ip куда подключаться
            IPEndPoint host = new IPEndPoint(adress, 23);
            TcpClient tcpClientt = new TcpClient();
            tcpClientt.Connect(host);
            Thread.Sleep(100);

            Console.WriteLine(Program1.GetAnswer(tcpClientt));
            SendCmd(tcpClientt, "sergey"); //login
            Console.WriteLine(Program1.GetAnswer(tcpClientt));
            SendCmd(tcpClientt, "Mirage"); //parol
            Console.WriteLine(Program1.GetAnswer(tcpClientt));
            SendCmd(tcpClientt, "sh run"); //task
            Console.WriteLine(Program1.GetAnswer(tcpClientt));
            Console.ReadLine();
        }
    }
}