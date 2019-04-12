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
            byte[] re= get.GetAsync(url).Result;
            return re;
        }
        #endregion
    }
    
}
  