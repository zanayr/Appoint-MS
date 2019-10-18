using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace c969_Fickenscher
{
    public static class IPLocation
    {
        private static Dictionary<string, string> ParseJSON(string json)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            MatchCollection matches = new Regex("\\\"(.+?)\\\"").Matches(json);
            for (int i = 0; i < matches.Count / 2; i++)
            {
                dictionary.Add(Convert.ToString(matches[i * 2]).TrimStart('"').TrimEnd('"'), Convert.ToString(matches[(i * 2) + 1]).TrimStart('"').TrimEnd('"'));
            }
            return dictionary;
        }

        private static string GetIP()
        {
            return Convert.ToString((new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}")).Matches((new WebClient()).DownloadString("http://ipinfo.io/"))[0]);
        }

        private static Dictionary<string, string> GetInfo()
        {
            string json = "";
            WebRequest request = WebRequest.Create("http://ipinfo.io/" + GetIP());
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        json += line;
                    }
                }
            }
            return ParseJSON(json); ;
        }

        public static void Set()
        {
            foreach (KeyValuePair<string, string> entry in IPLocation.GetInfo())
            {
                if (entry.Key == "country")
                {
                    Global.ChangeLanguage(entry.Value);
                }
            }
        }
    }
}
