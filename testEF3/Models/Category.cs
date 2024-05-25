using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testEF3.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [Display(Name ="Category Name")]
        public String CategoryName { get; set; }
        public String Note { get; set; }

    }
}