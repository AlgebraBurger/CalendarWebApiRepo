namespace CalendarWebApi.Migrations
{
    using Areas.Events.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CalendarWebApi.Infrastructure.ApiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CalendarWebApi.Infrastructure.ApiDbContext context)
        {
            var events = new List<Event>()
            {
                new Event { id=1,  start=DateTime.Parse("2015-11-10"), title="Event 1" },
                new Event { id=2,  start=DateTime.Parse("2015-11-9") , title="Event 2" },
                new Event { id=3,  start=DateTime.Parse("2015-11-8") , title="Event 3"  },
                new Event { id=4,  start=DateTime.Parse("2015-11-7") , title="Event 4"  },
                new Event { id=5,  start=DateTime.Parse("2015-11-6") , title="Event 5"  },
                new Event { id=6,  start=DateTime.Parse("2015-11-5") , title="Event 6"  },
                new Event { id=7,  start=DateTime.Parse("2015-11-4") , title="Event 7" },
                new Event { id=8,  start=DateTime.Parse("2015-11-3") , title="Event 8" },
                new Event { id=9,  start=DateTime.Parse("2015-11-2") , title="Event 9" },
                new Event { id=10, start=DateTime.Parse("2015-11-1") , title="Event 10" }
            };
            events.ForEach(x => context.Events.AddOrUpdate(y => y.id,x));
            context.SaveChanges();
        }
    }
}
