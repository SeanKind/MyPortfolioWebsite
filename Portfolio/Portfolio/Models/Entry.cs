using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

    }
}