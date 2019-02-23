using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace RGNet.NetSpider
{
    class NsManager
    {
        public NsManager()
        {

        }
        private string userAgent;
        private string accept;
        private string method;
        private int timeout;
        private bool keepalive;
        public Stream streamh;
        string cookie;

        public string Cookie
        {
            get
            {
                return cookie;
            }
            set
            {
                cookie = value;
            }
        }

        public bool Keepalive
        {
            get
            {
                return keepalive;
            }
            set
            {
                keepalive = value;
            }
        }

        public string UserAgent
        {
            get
            {
                return userAgent;
            }
            set
            {
                accept = value;
            }
        }
        public string Accept
        {
            get
            {
                return accept;
            }
            set
            {
                userAgent = value;
            }
        }

        public string Method
        {
            get
            {
                return method;
            }
            set
            {
                method = value;
            }
        }

        public int Timeout
        {
            get
            {
                return timeout;
            }
            set
            {
                timeout = value;
            }
        }
        public string getString()
        {
            string temp;
            StreamReader s = new StreamReader(streamh);
            temp = s.ReadToEnd();
            return temp;
        }
    }
    class NsmHelp
    {
        public NsmHelp()
        {

        }

    }
}
