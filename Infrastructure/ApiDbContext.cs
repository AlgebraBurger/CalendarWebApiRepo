using CalendarWebApi.Areas.Events.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarWebApi.Infrastructure
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}
