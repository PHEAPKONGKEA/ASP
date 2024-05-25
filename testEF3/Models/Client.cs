using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testEF3.Models
{
    public class Client
    {
        [Key]
        public int Clientid { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Client Name")]
        public String ClientName { get; set; }
        public int PhoneNumber { get; set; }
        public string Addess { get; set; }

    }
}