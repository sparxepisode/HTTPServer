using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System.Threading;
using Keep.DBData.Proto;
using Keep.NetProtocol.Proto;
using redisServer;
using HTTPServerLib;
using Net;

namespace HttpServer.ProtocolDistribute
{
    class NetMgr
    {
        public static Dictionary<int, MessageDescriptor> desDic = new Dictionary<int, MessageDescriptor> {
            { (int)net_server_type.AvatarCreateNewReq,game_avatar_create_new_req.Descriptor},
            { (int)net_server_type.AvatarNicknameSetReq,game_avatar_nickname_set_req.Descriptor},
            { (int)net_server_type.AvatarLoginReq,game_avatar_login_req.Descriptor},
        };


        public NetMgr()
        {
            Start();
        }



        public delegate void delByte(int protoid, byte[] tor, HttpResponse resp);
        public Dictionary<MessageDescriptor, delByte> methodDic = new Dictionary<MessageDescriptor, delByte>();


        private void Start()
        {
            AddListener(game_avatar_create_new_req.Descriptor, event_game_avatar_create_new_req);
            AddListener(game_avatar_nickname_set_req.Descriptor, event_game_avatar_nickname_set_req);
            AddListener(game_avatar_login_req.Descriptor, event_game_avatar_nickname_set_req);

        }


        private void AddListener(MessageDescriptor des, delByte del)
        {
            if (methodDic.ContainsKey(des))
            {
                methodDic[des] += del;
            }
            else
            {
                methodDic.Add(des, del);
            }
        }

        private void event_game_avatar_create_new_req(int protoid, byte[] bytes, HttpResponse resp)
        {
            game_avatar_create_new_req e = game_avatar_create_new_req.Parser.ParseFrom(bytes);
            Console.WriteLine(protoid + e.ToString());

            int user_count = RedisDBHelper.mInstance.userCount;

            game_avatar_create_new_rep rep = new game_avatar_create_new_rep();
            rep.UserId = 100;
            rep.Code = game_result_code.CodeSuccess;

            SendHttpCallback<game_avatar_create_new_rep>(protoid, rep, resp);

        }

        private void event_game_avatar_nickname_set_req(int protoid, byte[] bytes, HttpResponse resp)
        {
            game_avatar_nickname_set_req e = game_avatar_nickname_set_req.Parser.ParseFrom(bytes);
            Console.WriteLine(protoid + e.ToString());
        }

        private void event_game_avatar_login_req(int protoid, byte[] bytes, HttpResponse resp)
        {
            game_avatar_login_req e = game_avatar_login_req.Parser.ParseFrom(bytes);
            Console.WriteLine(protoid + e.ToString());
        }


        public void SendServer(int proto, byte[] bytes, HttpResponse resp)
        {
            MessageDescriptor des = desDic[proto];
            delByte handler;
            if (methodDic.TryGetValue(des, out handler))
            {
                handler(proto, bytes, resp);
            }
            else
            {
                Console.WriteLine("error: proto not exist: " + proto);
            }

        }


        public void SendHttpCallback<T>(int protoid,T t,HttpResponse resp)where T:IMessage
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteInt(protoid);
            byte[] bytes = t.ToByteArray();
            buffer.WriteInt(bytes.Length);
            buffer.WriteBytes(bytes);
            bytes = buffer.ToBytes();
            Console.WriteLine(bytes.Length);

            resp.SetContent(bytes);
            resp.Send();

        }
    }


   
}
