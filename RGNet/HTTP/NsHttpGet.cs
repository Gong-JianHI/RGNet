using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Net.Http.Headers;


namespace RGNet.HTTP
{
    class NsHttpGet
    {
        HttpClient hc;
        public NsHttpGet(HttpClient temp)
        {
            hc = temp;
        }
        public async Task<byte[]> GetAsyncToBytes(string url)
        {
            HttpResponseMessage hrm = await hc.GetAsync(url);
            return await hrm.Content.ReadAsByteArrayAsync();
        }
        public async Task<string> GetAsyncToString(string url)
        {
            HttpResponseMessage hrm = await hc.GetAsync(url);
            return await hrm.Content.ReadAsStringAsync();
        }
        /*
        public async Task<string> GetAsyncWithProperty(string url,NsSession session)
        {
            HttpRequestHeaders keys = session.header;
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,url);
            HttpResponseMessage hrm = await hc.SendAsync();
        }
        */
    }
}
