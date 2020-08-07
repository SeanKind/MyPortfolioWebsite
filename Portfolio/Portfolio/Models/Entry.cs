using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Entry
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        public string Name { get; set; }
        public string Message { get; set; }
        [Required(ErrorMessage = "Please enter an email address")]
        public string Email { get; set; }
        public DateTime Date { get; set; }

    }
}