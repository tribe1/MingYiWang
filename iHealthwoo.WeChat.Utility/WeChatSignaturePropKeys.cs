using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iHealthwoo.WeChat.Utility
{
    public class WeChatSignaturePropKeys
    {
        /// <summary>
        /// 签名
        /// </summary>
        public const string SignatureKey = "signature";

        /// <summary>
        /// 时间戳
        /// </summary>
        public const string TimestampKey = "timestamp";

        public const string NonceKey = "nonce";

        /// <summary>
        /// Token
        /// </summary>
        public const string TokenKey = "token";

        /// <summary>
        /// 回显值
        /// </summary>

        public const string EchoStrKey = "echostr";
    }
}
