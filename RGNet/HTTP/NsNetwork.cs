using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace RGNet.HTTP
{
    public class NsNetwork
    {
        private  NetSpiderBase nsb = new NetSpiderBase();
        
        public  void GetHtml(NsManager nsm, string url)
        {
            HttpWebResponse hwp = nsb.getRequestResponse(url, nsm.Keepalive, nsm.Timeout, nsm.Method, nsm.Accept, nsm.UserAgent);
            nsm.streamh = hwp.GetResponseStream();
            return;
        }
        public HttpWebResponse GetResponse(NsManager nsm, string url)
        {
            HttpWebResponse hwp = nsb.getRequestResponse(url, nsm.Keepalive, nsm.Timeout, nsm.Method, nsm.Accept, nsm.UserAgent);
            return  hwp;
        }
        public void GetHtmlWithCookie(NsManager nsm,string url)
        {
            HttpWebRequest req =(HttpWebRequest)WebRequest.Create(url);
            req.KeepAlive = nsm.Keepalive;
            req.Timeout = nsm.Timeout;
            req.Method = nsm.Method;
            req.Accept = nsm.Accept;
            req.UserAgent = nsm.UserAgent;
            req.CookieContainer = nsm.Cookie;
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            if (res.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("获取失败");
            }
            nsm.streamh = res.GetResponseStream();
            return;
        }
        public void GetHtmlWithCookie(NsManager nsm, string url,string message)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.KeepAlive = nsm.Keepalive;
            req.Timeout = nsm.Timeout;
            req.Method = nsm.Method;
            req.Accept = nsm.Accept;
            req.UserAgent = nsm.UserAgent;
            req.CookieContainer = nsm.Cookie;
            using(StreamWriter sw=new StreamWriter(req.GetRequestStream()))
            {
                sw.Write(message);
                sw.Flush();
            }
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            if (res.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("获取失败");
            }
            nsm.streamh = res.GetResponseStream();
            return;
        }
    }
    /*
    class NsPost
    {
        public NsPost()
        {

        }
        private void PostWebRequest(NsManager nsm, string postUrl, string paramData, Encoding dataEncode)
        {
            string ret = string.Empty;
            byte[] byteArray = dataEncode.GetBytes(paramData); //转化
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(postUrl));
            webReq.Method = "POST";
            webReq.ContentType = "application/x-www-form-urlencoded";
            webReq.KeepAlive = nsm.Keepalive;
            webReq.Timeout = nsm.Timeout;
            webReq.Accept = nsm.Accept;
            webReq.UserAgent = nsm.UserAgent;

            webReq.ContentLength = byteArray.Length;
            Stream newStream = webReq.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);//写入参数
            newStream.Close();
            HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
            nsm.streamh = response.GetResponseStream();
            return;
        }

    }
    */
}
