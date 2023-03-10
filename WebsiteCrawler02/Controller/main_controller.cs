using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WebsiteCrawler02.Controller
{
    internal class main_controller
    {
        public bool GetHtmlToFile(string url,string path)
        {
            try
            {
                WebClient client = new WebClient();
                var result = client.DownloadData(url);
                return (WriteToFile(Encoding.UTF8.GetString(result), path));
              
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool WriteToFile(string content,string path)
        {
            try
            {
                FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                StreamWriter sw = new System.IO.StreamWriter(fs, new UTF8Encoding(true));
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex) { return false; }
        return true;
        }
        public HtmlDocument getHtmlDoc(string path)
        {
            try
            {
                var doc = new HtmlDocument();
                doc.OptionDefaultStreamEncoding = Encoding.UTF8;
                doc.DetectEncodingAndLoad(path);
                return doc;
            }
            catch (Exception ex) { return null; }

        }
    }
}
