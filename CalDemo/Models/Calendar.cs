using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalDemo.Models
{
    public class Calendar
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubscriberCount { get; set; }
        public byte[] Image { get; set; }
    }
}