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
        public NsHTTPResult result;
        private int timeout;
        private bool keepalive;
        CookieContainer cookie;

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


        
    }
    
}