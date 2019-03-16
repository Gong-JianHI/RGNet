using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RGNet.HTTP
{
    public class  NsSession
    {
        public NsSession()
        {

        }
        private string userAgent;
        private string accept;
        private string method;
        private int timeout;
        private bool keepalive;
        public Stream ResponseStream;
        CookieContainer cookie;
        private HttpWebResponse response;

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

        public CookieContainer Cookie { get => cookie; set => cookie = value; }
        
        public HttpWebResponse Response { get => response; set => response = value; }

        public string getStreamString()
        {
            string temp;
            using (StreamReader sr = new StreamReader(ResponseStream))
            {
                temp = sr.ReadToEnd();
            }
            return temp;
        }
    }
    
}
