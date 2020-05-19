using System;
using System.IO;
using System.Net;
using System.Text;

namespace AmosHttpRequest
{
    public class RestClient
    {
        private string BaseUri;
        public RestClient(string baseUri)
        {
            this.BaseUri = baseUri;
        }

        public string DoWebRequestByGet(string url)
        {
            string result = "";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                result = sr.ReadToEnd();
                Console.WriteLine("AmosDemo Read From Server:{0}", result);
                return result;
            }
            return result;
        }
       
        public string HttpPost(string url, string postDataStr)
        {
            string strReturn;
            //在转换字节时指定编码格式
            byte[] byteData = Encoding.UTF8.GetBytes(postDataStr);
            //配置Http协议头
            HttpWebRequest resquest = (HttpWebRequest)WebRequest.Create(url);
            resquest.Method = "POST";
            resquest.ContentType = "application/x-www-form-urlencoded;charset=utf8"; 
            resquest.ContentLength = byteData.Length;
            //发送数据
            using (Stream resquestStream = resquest.GetRequestStream())
            {
                resquestStream.Write(byteData, 0, byteData.Length);
            }

            //接受并解析信息
            using (WebResponse response = resquest.GetResponse())
            {
                //解决乱码：utf-8 + streamreader.readToEnd
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                strReturn = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }

            return strReturn;
        }
    }

}