using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UpdProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("按下任意按键开始发送...");
            Console.ReadKey();

            UdpClient client = new UdpClient();
            IPAddress remoteIP = IPAddress.Parse("127.0.0.1");
            int remotePort = 11000;
            IPEndPoint remotePoint = new IPEndPoint(remoteIP, remotePort);

            for (int i = 1; i < 50; i++)
            {
                string sendString = null;
                sendString += "测试UDP 发送消息 " + i;

                byte[] sendData = null;
                sendData = Encoding.Default.GetBytes(sendString);

                client.Send(sendData, sendData.Length, remotePoint);
            }

            client.Close();

            Console.WriteLine("");
            Console.WriteLine("数据发送成功, 按任意键退出...");
            System.Console.ReadKey();

        }
    }
}
