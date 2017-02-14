using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace iHealthwoo.WeChat.Utility
{
    /// <summary>
    /// 校验微信消息是否来自微信服务器
    /// </summary>
    public class CheckWeChatSignature
    {

        public static bool CheckSignature(string signature, string timestamp, string nonce, string token)
        {

            //string signature = "a948c4f99d23c1b6ef78204c1eb867166e2276e8";//context.Request.QueryString["signature"];
            //string timestamp = "1405665299";//context.Request.QueryString["timestamp"];
            //string nonce = "42752994";//context.Request.QueryString["nonce"];
            //string token = "Topevery";

            File.AppendAllText("C:\\TokenLog.txt", "开始记录验证日志\n");
            File.AppendAllText("C:\\TokenLog.txt", string.Format("token:{0}\n\n", token));
            File.AppendAllText("C:\\TokenLog.txt", string.Format("timestamp:{0}\n", timestamp));
            File.AppendAllText("C:\\TokenLog.txt", string.Format("nonce:{0}\n", nonce));
            List<string> list = new List<string>();

            list.Add(token);
            list.Add(timestamp);
            list.Add(nonce);
            list.Sort();
            string res = string.Join("", list.ToArray());
            byte[] dataToHash = Encoding.ASCII.GetBytes(res);
            byte[] hashValue = ((HashAlgorithm)CryptoConfig.CreateFromName("SHA1")).ComputeHash(dataToHash);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashValue)
            {
                sb.Append(b.ToString("x2"));
            }
            File.AppendAllText("C:\\TokenLog.txt", string.Format("signature:{0}\n", signature));
            File.AppendAllText("C:\\TokenLog.txt", string.Format("转成:{0}\n", sb.ToString()));
            //string s = BitConverter.ToString(hashvalue1).Replace("-", string.Empty).ToLower();
            return signature == sb.ToString();
            //if (signature == sb.ToString())
            //{
            //    Console.Write("OK");
            //}
            //else
            //{
            //    Console.Write("Fail");
            //}
        }
    }
}

