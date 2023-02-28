using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteCrawler02.Libs
{
    internal class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Link { get; set; }
        public Restaurant(string Name, string Address, string PhoneNum, string Email, string Link)
        {
            this.Name = Name;
            this.Address = Address;
            this.PhoneNum = PhoneNum;
            this.Email = Email;
            this.Link = Link;
        } 

    }
}
