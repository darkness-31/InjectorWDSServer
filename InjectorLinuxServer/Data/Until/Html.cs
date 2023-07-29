using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using HtmlAgilityPack;

namespace InjectorLinuxServer.Data.Until
{
    internal class Html
    {
        public string Site { get; set; }

        public Html(string url)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(url);

            Site = httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        public string[] GetNode(string node)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(Site);
            var nodes = htmlDocument.DocumentNode.SelectNodes(node);
            string[] str = new string[nodes.Count];

            for (int i = 0; i < nodes.Count; i++)
            {
                str[i] = htmlDocument.DocumentNode.SelectNodes(node)[i].InnerText;
            }

            return str;
        }
    }
}
