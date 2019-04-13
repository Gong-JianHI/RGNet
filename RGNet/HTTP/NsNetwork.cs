using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Http;

namespace RGNet.HTTP
{
    public class NsNetwork
    {
        HttpClient httpClient=new HttpClient();
        public NsNetwork()
        {
            
        }
        ~NsNetwork()
        {
            httpClient.Dispose();
        }
        #region GET方法
        public byte[] GetHTTPToBytes(string url)
        {
            NsHttpGet get = new NsHttpGet(httpClient);
            byte[] re= get.GetAsyncToBytes(url).Result;
            return re;
        }
        public string GetHTTPToString(string url)
        {
            NsHttpGet get = new NsHttpGet(httpClient);
            string result = get.GetAsyncToString(url).Result;
            return result;
        }
        
        #endregion
    }
    
}
  