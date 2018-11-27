using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPServerLib;
using System.IO;
using Net;
using HttpServer.ProtocolDistribute;


namespace HttpServer
{
    public class ExampleServer : HTTPServerLib.HttpServer
    {
        private NetMgr m_netMgr;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ipAddress">IP地址</param>
        /// <param name="port">端口号</param>
        public ExampleServer(string ipAddress, int port)
            : base(ipAddress, port)
        {
            m_netMgr=new NetMgr();
        }

        public override void OnPost(HttpRequest request, HttpResponse response)
        {
            Console.WriteLine("some post: "+request.Body);

            //获取客户端传递的参数
            string data = request.Params == null ? "" : string.Join(";", request.Params.Select(x => x.Key + "=" + x.Value).ToArray());
            
            //设置返回信息
            string content = string.Format("这是通过Post方式返回的数据:{0}", data);

            //构造响应报文
            response.SetContent("first data");
            response.Content_Encoding = "utf-8";
            response.StatusCode = "200";
            response.Content_Type = "text/html; charset=UTF-8";
            //response.Headers["Server"] = "ExampleServer";

            //发送响应
            response.Send();
        }

        
        public override void OnGet(HttpRequest request, HttpResponse response)
        {
            //string str = request.GetRequestData(stream);
            Console.WriteLine("some one: "+request.Body);

            //// 链接形式1:"http://localhost:4050/assets/styles/style.css"表示访问指定文件资源，
            //// 此时读取服务器目录下的 / assets / styles / style.css文件。

            //// 链接形式1:"http://localhost:4050/assets/styles/"表示访问指定页面资源，
            //// 此时读取服务器目录下的 / assets / styles / style.index文件。

            //发送HTTP响应
            response.SetContent(Encoding.UTF8.GetBytes("no problem"));
            response.Content_Encoding = "utf-8";
            response.StatusCode = "200";
            response.Content_Type = "text/html; charset=UTF-8";
            response.Send();
        }

        public override void OnPut(HttpRequest request, HttpResponse response)
        {
            Console.WriteLine("length:"+request.Body.Length);
            ParseBodyData(request.bytedatas,response);

            ////发送HTTP响应
            //response.SetContent("no problem");
            //response.Send();
        }

        private void ParseBodyData(byte[] bytes,HttpResponse resp)
        {

            Console.WriteLine("origin: "+bytes.Length);

            ByteBuffer buffer = new ByteBuffer(bytes);
            int protoid = buffer.ReadInt();
            byte[] data = buffer.ReadBytes();

            m_netMgr.SendServer(protoid, data,resp);
        }


        public override void OnDefault(HttpRequest request, HttpResponse response)
        {

        }

        private string ConvertPath(string[] urls)
        {
            string html = string.Empty;
            int length = ServerRoot.Length;
            foreach (var url in urls)
            {
                var s = url.StartsWith("..") ? url : url.Substring(length).TrimEnd('\\');
                html += String.Format("<li><a href=\"{0}\">{0}</a></li>", s);
            }

            return html;
        }

        private string ListDirectory(string requestDirectory, string requestURL)
        {
            //列举子目录
            var folders = requestURL.Length > 1 ? new string[] { "../" } : new string[] { };
            folders = folders.Concat(Directory.GetDirectories(requestDirectory)).ToArray();
            var foldersList = ConvertPath(folders);

            //列举文件
            var files = Directory.GetFiles(requestDirectory);
            var filesList = ConvertPath(files);

            //构造HTML
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("<html><head><title>{0}</title></head>", requestDirectory));
            builder.Append(string.Format("<body><h1>{0}</h1><br/><ul>{1}{2}</ul></body></html>",
                 requestURL, filesList, foldersList));

            return builder.ToString();
        }
    }
}
