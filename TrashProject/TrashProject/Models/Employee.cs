using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashProject.Models
{
    public class Employee
    {
        [Required]
      
        [Key]
        public string UserId { get; set; }

        [Required]
        
        [Display(Name = "Last Name")]
        public string NameLast { get; set; }

        [Required]
       
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }

        public int? ServicePostalCodeId { get; set; }
        public string ServicePostalCode { get; set; }
    }
}