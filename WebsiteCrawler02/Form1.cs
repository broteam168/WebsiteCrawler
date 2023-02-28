using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using WebsiteCrawler02.Controller;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WebsiteCrawler02
{
    public partial class frmMain : Form
    {
        main_controller cls;
        const string CrawlLink = "https://trangvangvietnam.com/categories/200710/nha-hang.html";
        public frmMain()
        {
            InitializeComponent();
            cls = new main_controller();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrawlAction(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "index.html");
            Console.WriteLine(cls.GetHtmlToFile(CrawlLink, path));
            HtmlDocument doc = new HtmlDocument();
            doc.OptionDefaultStreamEncoding = Encoding.UTF8;
            MessageBox.Show(doc.DetectEncoding(path).EncodingName);
            doc.DetectEncodingAndLoad(path);
            HtmlNode testNode = doc.DocumentNode.SelectNodes("//div").Where(x => x.Id == "listingsearch").First().SelectNodes("//div").Where(x => x.HasClass("boxlistings")).First();
            String name = (testNode.SelectNodes("//h2").Where(x => x.HasClass("company_name")).First().InnerText);
            Console.WriteLine(testNode.SelectNodes("//p").Where(x => x.HasClass("diachisection")).Last().InnerText);
            Console.WriteLine(testNode.SelectNodes("//p").Where(x => x.HasClass("thoaisection")).First().InnerText);
            Console.WriteLine(testNode.SelectNodes("//div").Where(x => x.HasClass("email_text")).First().ChildNodes.First().Attributes["title"].Value);
            Console.WriteLine(testNode.SelectNodes("//a").Where(x => x.HasClass("buttonMoreDetails")).First().Attributes["href"].Value);
            MessageBox.Show(name, "a");
        }
    }
}
