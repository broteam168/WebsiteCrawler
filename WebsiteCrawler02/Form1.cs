using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using WebsiteCrawler02.Controller;
using WebsiteCrawler02.Libs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WebsiteCrawler02
{
    public partial class frmMain : Form
    {
        main_controller cls;
        const string CrawlLink = "https://trangvangvietnam.com/categories/200710/nha-hang.html?page=";
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "index.html");
        private List<Restaurant> listResult=new List<Restaurant>();

        public frmMain()
        {
            InitializeComponent();
            cls = new main_controller();
        }
        public int indexRow = 0;
        private void queryNode(HtmlNode node)
        {
            string Email = "";
            string name = node.DescendantNodes().Where(x => x.HasClass("company_name")).First().InnerText;
            string address = node.DescendantNodes().Where(x => x.HasClass("diachisection")).Last().InnerText;
            string PhoneNum = node.DescendantNodes().Where(x => x.HasClass("thoaisection")).First().InnerText;
            try
            {
                Email = node.DescendantNodes().Where(x => x.HasClass("email_text")).First().ChildNodes.First().Attributes["title"].Value;
            }catch(Exception ex) { }
            string link = node.DescendantNodes().Where(x => x.HasClass("buttonMoreDetails")).First().Attributes["href"].Value;
            
            listResult.Add(new Restaurant(name, address, PhoneNum, Email, link));


            int firstDisplayed = datMain.FirstDisplayedScrollingRowIndex;
            int displayed = datMain.DisplayedRowCount(true);
            int lastVisible = (firstDisplayed + displayed) - 1;
            int lastIndex = datMain.RowCount - 1;

            string[] row = new string[] { (datMain.RowCount).ToString(), name, address, PhoneNum, Email, link };
            datMain.Rows.Add(row);

            if (lastVisible == lastIndex)
            {
                datMain.FirstDisplayedScrollingRowIndex = firstDisplayed + 1;
            }
            datMain.Update();
            txt_Log.Text +=Environment.NewLine+ "    Add " + datMain.RowCount;
            txt_Log.Refresh();
            txt_Log.SelectionLength = 0;
            txt_Log.SelectionStart = txt_Log.Text.Length;
            txt_Log.Focus();
            txt_Log.ScrollToCaret();


        }
        private void queryPage(HtmlDocument doc)
        {
            List<HtmlNode> listNodes = doc.DocumentNode.SelectNodes("//div").Where(x => x.Id == "listingsearch").First().SelectNodes("//div").Where(x => x.HasClass("boxlistings")).ToList();
            foreach (var item in listNodes)
            {
                queryNode(item);
               
            }
            
          
        }
        private void CrawlAction(object sender, EventArgs e)
        {
            progressMain.Value = 0;
            
            for (int i = 1; i <=41; i++)
            {
                progressMain.Value+=2;
                if (cls.GetHtmlToFile(CrawlLink + i, path))
                {
                    txt_Log.Text += Environment.NewLine + "Request the data page "+i+" file successfully with GET function";
                    txt_Log.Update();
                }
                else
                {
                    txt_Log.Text += Environment.NewLine + "Request error";
                    goto Endp;
                }
            queryPage(cls.getHtmlDoc(path));
            }

        Endp:
                progressMain.Value = 100;
                MessageBox.Show("Your task running is complete !", "Notification");
        }

        private void btn_choosePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_Path.Text = fbd.SelectedPath;
                }
            }
        }
        public void CreateExcel(string path)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Số thứ tự";
            xlWorkSheet.Cells[1, 2] = "Tên";
            xlWorkSheet.Cells[1, 3] = "Địa chỉ";
            xlWorkSheet.Cells[1, 4] = "Số điện thoại";
            xlWorkSheet.Cells[1, 5] = "Email";
            xlWorkSheet.Cells[1, 6] = "Link";
            int index = 1;
            foreach (var item in listResult)
            {
                index++;
                xlWorkSheet.Cells[index, 1] = index-1;
                xlWorkSheet.Cells[index, 2] = item.Name;
                xlWorkSheet.Cells[index, 3] = item.Address;
                xlWorkSheet.Cells[index, 4] = item.PhoneNum;
                xlWorkSheet.Cells[index, 5] = item.Email;
                xlWorkSheet.Cells[index, 6] = item.Link;
            }
            //Here saving the file in xlsx
            xlWorkBook.SaveAs(path+"\\Output.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
            misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);


            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file "+path);
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            CreateExcel(txt_Path.Text);
        }

        private void llb_copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CopyRight frm =new CopyRight();
            frm.ShowDialog();
        }
    }
}
