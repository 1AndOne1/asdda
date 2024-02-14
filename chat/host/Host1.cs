using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace host
{
    internal class Host1
    {
        static async void Main(string[] args)
        {
                TcpListener server = new TcpListener(IPAddress.Any, 3000);
                server.Start();
                while (true)
                {
                    try
                    {
                        TcpClient client = await server.AcceptTcpClientAsync();
                        NetworkStream stream = client.GetStream();
                    }
                    catch
                    {
                        server.Stop();
                        break;
                    }
                }
                if (!true)
                {
                    server.Stop();
                }
        }
    }
}
