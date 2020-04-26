using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace MyPCTool
{
  public  static class Weather
    {
        public static void ParseWebsite(string url)
        {
            string html = Weather.GetHtml(url);
            var links = Weather.ParseLink(html);
            foreach (var link in links)
            {
                url = "http://www.tianqihoubao.com" + link;
                html = Weather.GetHtml(url);
                Weather.ParseDailyWeather(html);
            }
        }
        public static void ParseDailyWeather(string html)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var rows = doc.DocumentNode.SelectNodes("//tr");
            StringBuilder sb = new StringBuilder();
            rows.RemoveAt(0);
            foreach (var row in rows)
            {
                var cols = row.SelectNodes("td");
                foreach (var col in cols)
                {
                    string temp = col.InnerText.Replace("\r\n", "").Replace(" ", "").Trim();
                    sb.Append(temp + ",");
                }
                sb.Append("\r\n");
            }
            FileStream fs = new FileStream("output.csv", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gbk"));
            sw.WriteLine(sb);
            sw.Close();
            fs.Close();
        }

        public static string GetHtml(string url)
        {
            string res = "";
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url);
            StreamReader sr = new StreamReader(stream, Encoding.Default);
            res = sr.ReadToEnd();
            sr.Close();
            client.Dispose();
            return res;
        }
        public static List<string> ParseLink(string html)
        {
            List<string> res = new List<string>();
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var linkNodes = doc.DocumentNode.SelectNodes("//a[@href]");
            foreach (var linkNode in linkNodes)
            {
                string link = linkNode.GetAttributeValue("href", "");
                if (link.StartsWith("/lishi/beijing/month"))
                {
                    res.Add(link);
                }
            }
            return res;
        }
    }
}
