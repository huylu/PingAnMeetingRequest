﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmoser.PingAnMeetingRequest.Common.Model
{
    public class HandlerSession
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public bool IsActive { get; set; }
        public string BaseUrl
        {
            get
            {
                return string.Format("http://{0}:{1}/svcm/servlet/", this.IP, this.Port);
            }                

        }

        private static int messageId = 0;
        private static object locker = new object();

        public int MessageId
        {
            get
            {
                lock (locker)
                {
                    messageId++;
                    return messageId;
                }
            }
        }

        public void ResetMessageId()
        {
            lock (locker)
            {
                messageId = 0;
            }

        }
    }
}