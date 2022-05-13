using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UpdProjectServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            UdpClient client = new UdpClient(11000);
            string receiveString = null;
            byte[] receiveData = null;

            IPEndPoint remotePoint = new IPEndPoint(IPAddress.Any, 0);
            Console.WriteLine("正在准备接收数据...");

            while (true)
            {
                receiveData = client.Receive(ref remotePoint);
                receiveString = Encoding.Default.GetString(receiveData);
                Console.WriteLine(receiveString);
                if (result == 50) 
                {
                    break;
                }

                result++;
            }
            client.Close();
            Console.WriteLine("");
            Console.WriteLine("数据接收完毕, 按任意建退出...");
            System.Console.ReadKey();

        }
    }
}
