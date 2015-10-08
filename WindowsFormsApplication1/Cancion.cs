using CsQuery;
using System;
using System.Net;

namespace Sonar
{
    public class Cancion
    {
        internal string titulo;
        internal string url;

        public Cancion(string title, string link)
        {
            titulo = title;
            url = link;

        }

        public string generaLinkDescarga()
        {
            string link ="";

            if (!url.Contains(".mp3"))
            {
                try
                {
                    var dom = CQ.CreateFromUrl(url).Select("head").First();

                    link = CQ.Create(dom).Select("script").Last().Text();
                    link = link.Trim();
                    link = link.Replace("var my_data = '\"", "");
                    link = link.Replace("\"';", "");
                    link = link.Replace("\\/", "/");

                    var request = (HttpWebRequest)WebRequest.Create(link);
                    request.Timeout = 5000;
                    request.AllowAutoRedirect = false;

                    var response = (HttpWebResponse)request.GetResponse();
                    

                }
                catch (Exception e)
                {
                    return url;
                }
           
                url = link;
            }

            return url;

        }
    }
}