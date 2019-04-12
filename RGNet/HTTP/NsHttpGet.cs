using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;

namespace RGNet
{
    class NsHttpGet
    {
        HttpClient hc;
        public NsHttpGet(HttpClient temp)
        {
            hc = temp;
        }
        public async Task<byte[]> GetAsync(string url)
        {
            HttpResponseMessage hrm = await hc.GetAsync(url);
            return await hrm.Content.ReadAsByteArrayAsync();
        }
    }
}
