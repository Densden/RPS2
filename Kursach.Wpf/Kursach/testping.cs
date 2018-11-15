using System;

public class PN
{
	public PN()
	{
        System.Net.NetworkInformation.Ping ping =  new System.Net.NetworkInformation.Ping();
        System.Net.NetworkInformation.PingReply pingReply = ping.Send("192.168.9.200"); //адрес куда надо отправить
        Console.WriteLine(pingReply.RoundtripTime); //время ответа
        Console.WriteLine(pingReply.Status);        //статус
        Console.WriteLine(pingReply.Address);       //IP
       // Console.ReadKey(true);
    }
}
