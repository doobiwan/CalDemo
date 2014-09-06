using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalDemo.Models.ViewModels
{
    public class CalendarViewModel
    {
        [Required]
        [StringLength(48)]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int SubscriberCount { get; set; }
        [Required]
        public HttpPostedFileBase File { get; set; }
    }
}