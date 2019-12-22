using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Script.Serialization;

namespace HWP.WebCrawler.Middleware
{
    public static class CrawlHelper
    {

        public static string ReadJsonFile(string fileloc)
        {
            using(StreamReader sr = new StreamReader(fileloc))
            {
                var json = sr.ReadToEnd();
                dynamic ary = JsonConvert.DeserializeObject(json);
                return json;                
            }
        }

        public static T JsonToObject<T>(string fileloc)
        {
            return AsObject<T>(ReadJsonFile(fileloc));
        }

        public static string AsJsonList<T>(List<T> tt)
        {
            return new JavaScriptSerializer().Serialize(tt);
        }
        public static string AsJson<T>(T t)
        {
            return new JavaScriptSerializer().Serialize(t);
        }
        public static List<T> AsObjectList<T>(string tt)
        {
            return new JavaScriptSerializer().Deserialize<List<T>>(tt);
        }
        public static T AsObject<T>(string t)
        {
            return new JavaScriptSerializer().Deserialize<T>(t);
        }

        public static string GetPageContent(string url)
        {
            string retval = string.Empty;
            WebRequest request;
            WebResponse response;

            request = WebRequest.Create(url);
            response = request.GetResponse(); //Returns a response from an Internet resource
            Stream strm = response.GetResponseStream();

            //return the data stream from the internet
            using (StreamReader sr = new StreamReader(strm))
            {
                retval = sr.ReadToEnd();//reads it to the end                 
                strm.Close();
                sr.Close();
                response.Close();
            }

            return retval;
        }

        public static ISet<string> GetPageLinks(string content)
        {
            Regex regexLink = new Regex("(?<=<a\\s*?href=(?:'|\"))[^'\"]*?(?=(?:'|\"))");

            ISet<string> newLinks = new HashSet<string>();
            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }
    }
}
