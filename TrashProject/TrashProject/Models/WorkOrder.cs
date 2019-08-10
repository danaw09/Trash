using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashProject.Models
{
    public class WorkOrder
    {
        public int Id { get; set; }

        public DateTime SubmittedDateTime { get; set; }

        public DateTime ScheduledDate { get; set; }

    
        public string WorkOrderType { get; set; }

        public int StatusId { get; set; }
        public string WorkOrderStatus { get; set; }

        [Required]
        [StringLength(128)]
        public string CustomerUserId { get; set; }
        public Customer Customer { get; set; }

        public int ServiceAddressId { get; set; }
        public string Address { get; set; }

        public DateTime? CompletionDateTime { get; set; }

        [StringLength(128)]
        public string CompletedById { get; set; }
    }
}