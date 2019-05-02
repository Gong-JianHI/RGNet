using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RGNet.HTTP
{
     public  class NsHTTPResult
    {
        private HttpWebResponse response=null;
        public Stream responseStream=null;
        private string Text;

        public string ResponseText { get => Text; set => Text = value; }

        public NsHTTPResult(HttpWebResponse res)
        {
            response = res;
            responseStream = res.GetResponseStream();
        }
 
        public void GetAllText()
        {
            if (responseStream == null)
            {
                if (response == null)
                {
                    throw new InvalidDataException();
                }
                else
                {
                    responseStream = response.GetResponseStream();
                }
            }
            using (StreamReader reader =new StreamReader(responseStream))
            {
                Text = reader.ReadToEnd();
            }
        }
    }
}
