using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_Request
{
    public class HttpRequest
    {
        public void loadRequest() 
        {
            string url = $@"https://v0.yiketianqi.com/api?appid=34145136&appsecret=36a62uFc&version=v61";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Method = "GET";

            string responseContent = "";
            using (WebResponse response = req.GetResponse())
            {
                if (response != null)
                {
                    Stream resStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(resStream);
                    responseContent = reader.ReadToEnd().ToString();
                }

            }
        
        }

    }
}
