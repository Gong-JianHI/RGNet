using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RGNet.HTTP
{
    public class  NsSession
    {
        public NsSession()
        {

        }
        private string userAgent;
        private string accept;
        

        public HttpRequestHeaders header ;
        
        public void Set(string key,List<string> value)
        {
            if (header.Contains(key))
            {
                header.Remove(key);
            }
            header.Add(key, value);
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

        

    }
    
}
