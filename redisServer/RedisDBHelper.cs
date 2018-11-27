using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using ServiceStack.Redis;


namespace redisServer
{

    public class RedisDBHelper
    {
        private static RedisDBHelper _mInstace;

        public static RedisDBHelper mInstance
        {
            get
            {
                if (_mInstace == null)
                    _mInstace = new RedisDBHelper();
                return _mInstace;
            }
        }



        public const string url = "localhost";
        public const int port_avatar = 6379;
        public const int port_achievement = 6380;

        public const string str_user_count = "user_count";

        private int user_count = 0;
        public int userCount { get { return user_count; } }

        public RedisDBHelper()
        {
            user_count = client_avatar.Get<int>(str_user_count);
        }

        #region avatar
        private RedisClient _client_avatar;
        public RedisClient client_avatar
        {
            get
            {
                if (_client_avatar == null)
                    _client_avatar = new RedisClient(url, port_avatar);
                return _client_avatar;
            }
        }

        public T getData_avatar<T>(int user_id) where T : IMessage
        {
            T rtn = client_avatar.Get<T>(user_id.ToString());
            return rtn;

        }

        public void setData_avatar<T>(int user_id, T t) where T : IMessage
        {
            client_avatar.Set<T>(user_id.ToString(), t);

            user_count++;
            client_avatar.Set<int>(str_user_count, user_count);
        }

        #endregion

        #region achievement
        private RedisClient _client_achievement;
        public RedisClient client_achievement
        {
            get
            {
                if (_client_achievement == null)
                    _client_achievement = new RedisClient(url, port_achievement);
                return _client_achievement;
            }

        }

        public T getData_achievement<T>(int user_id) where T : IMessage
        {
            T rtn = client_achievement.Get<T>(user_id.ToString());
            return rtn;

        }

        public void setData_achievemenet<T>(int user_id, T t)
        {
            client_achievement.Set<T>(user_id.ToString(), t);
        }
        
        #endregion

        public void save()
        {
            client_avatar.Save();
            client_achievement.Save();
            Console.WriteLine("redis avae success!");
        }
    }


}
