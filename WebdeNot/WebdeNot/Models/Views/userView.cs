using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebdeNot.Models.Views
{
    public class userView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public DateTime BirtDate { get; set; }
    }
}