using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashProject.Models
{
    public class CustomerDayViewModel
    {
    
       
    }

    public class AddAddressViewModel
    {
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

    }
   
    internal class PickUpOption
    {
        public object Day { get; set; }
    }
}

