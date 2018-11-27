using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPServerLib;
using HttpServer;
using HttpServer.ProtocolDistribute;
using redisServer;
using Keep.DBData.Proto;

namespace HTTPServerLib
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleServer server = new ExampleServer("192.168.126.102", 4050);
            server.SetRoot(@"D:\Hexo\public");
            server.Logger = new ConsoleLogger();
            server.Start();
            
        }
    }
}
