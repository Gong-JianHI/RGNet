using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace RGNet.HTTP
{
    public class NetSpiderBase
    {

        public HttpWebResponse getRequestResponse(string URL, bool keepAlive, int timeOut, string method, string accept, string userAgent)
        {
            HttpWebRequest mywr = (HttpWebRequest)WebRequest.Create(URL);
            mywr.KeepAlive = keepAlive;
            mywr.Timeout = timeOut;
            mywr.Method = method;
            mywr.Accept = accept;
            mywr.UserAgent = userAgent;
            HttpWebResponse myrp = (HttpWebResponse)mywr.GetResponse();
            if (myrp.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }
            else
            {
                return myrp;
            }
        }

        public HttpWebRequest createPostRequest(string URL, bool keepAlive, int timeOut, string accept, string userAgent)
        {
            HttpWebRequest mywr = (HttpWebRequest)WebRequest.Create(URL);
            mywr.KeepAlive = keepAlive;
            mywr.Timeout = timeOut;
            mywr.Method = "POST";
            mywr.Accept = accept;
            mywr.UserAgent = userAgent;
            return mywr;
        }
    }
}
