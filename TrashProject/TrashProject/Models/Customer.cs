using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashProject.Models
{
    public class Customer
    {
        [Required]
        [StringLength(128)]
        [Key]
        public string UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string NameLast { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }

        public string NameFirstLast
        {
            get { return NameFirst + " " + NameLast; }
        }

        public string NameLastFirst
        {
            get { return NameLast + ", " + NameFirst; }
        }

        [Required]
        public int AddressId { get; set; }
        public string Address { get; set; }

        public string WeeklyPickupDayId { get; set; }
        public string WeeklyPickupDay { get; set; }
        public int PostalCode { get; set; }
    }
}