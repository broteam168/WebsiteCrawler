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
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WebsiteCrawler02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            HtmlDocument doc = new HtmlDocument();
            WebClient client = new WebClient();
            string html = client.DownloadString("https://trangvangvietnam.com/cateprovinces/200710/nh%C3%A0-h%C3%A0ng-%E1%BB%9F-t%E1%BA%A1i-tp.-h%E1%BB%93-ch%C3%AD-minh-(tphcm).html");
            doc.OptionDefaultStreamEncoding= Encoding.UTF8;
            Console.WriteLine(doc.DetectEncodingHtml(html));
            doc.DetectEncodingAndLoad("C:\\Users\\SON\\Desktop\\index.html");
            HtmlNode testNode = doc.DocumentNode.SelectNodes("//div").Where(x => x.Id == "listingsearch").First().SelectNodes("//div").Where(x => x.HasClass("boxlistings")).First();
            String name=(testNode.SelectNodes("//h2").Where(x => x.HasClass("company_name")).First().InnerText);
            Console.WriteLine(testNode.SelectNodes("//p").Where(x => x.HasClass("diachisection")).Last().InnerText);
            Console.WriteLine(testNode.SelectNodes("//p").Where(x => x.HasClass("thoaisection")).First().InnerText);
            Console.WriteLine(testNode.SelectNodes("//div").Where(x => x.HasClass("email_text")).First().ChildNodes.First().Attributes["title"].Value);
            Console.WriteLine(testNode.SelectNodes("//a").Where(x => x.HasClass("buttonMoreDetails")).First().Attributes["href"].Value);
            MessageBox.Show(name, "a");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
