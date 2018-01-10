using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebdeNot.Models.Views
{
    public class NoteViews
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReminderDate { get; set; }
        public string Description { get; set; }
        public int İmportantyDegree { get; set; }
        public int UserID { get; set; }
        public DateTime WritingDate { get; set; }
    }
}