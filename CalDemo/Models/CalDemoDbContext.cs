using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CalDemo.Models
{
    public class CalDemoDbContext: DbContext
    {
        public CalDemoDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Calendar> Calendars { get; set; } 
    }
}