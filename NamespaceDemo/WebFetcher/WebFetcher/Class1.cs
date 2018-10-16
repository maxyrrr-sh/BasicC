using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WebFetcher
{
    public class Fetching
    {
        public string Fetch(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            return GetFormattedText(reply);

        }

        public string GetFormattedText(string text)
        {
            return $"You formatted text: {text} !";
        }
    }
}
