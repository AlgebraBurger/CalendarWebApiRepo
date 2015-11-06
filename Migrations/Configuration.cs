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
                new Event { id=1,  start=DateTime.Parse("2015-11-10"), title="Event 1" , description="desc 1", link="http://philippinebestwebdesign.com" },
                new Event { id=2,  start=DateTime.Parse("2015-11-9") , title="Event 2", description="desc 2", link="http://philippinebestwebdesign.com" },
                new Event { id=3,  start=DateTime.Parse("2015-11-8") , title="Event 3", description="desc 3", link="http://philippinebestwebdesign.com"  },
                new Event { id=4,  start=DateTime.Parse("2015-11-7") , title="Event 4", description="desc 4", link="http://philippinebestwebdesign.com"  },
                new Event { id=5,  start=DateTime.Parse("2015-11-6") , title="Event 5", description="desc 5", link="http://philippinebestwebdesign.com"  },
                new Event { id=6,  start=DateTime.Parse("2015-11-5") , title="Event 6", description="desc 6", link="http://philippinebestwebdesign.com"  },
                new Event { id=7,  start=DateTime.Parse("2015-11-4") , title="Event 7", description="desc 7", link="http://philippinebestwebdesign.com" },
                new Event { id=8,  start=DateTime.Parse("2015-11-3") , title="Event 8", description="desc 8", link="http://philippinebestwebdesign.com" },
                new Event { id=9,  start=DateTime.Parse("2015-11-2") , title="Event 9", description="desc 9", link="http://philippinebestwebdesign.com" },
                new Event { id=10, start=DateTime.Parse("2015-11-1") , title="Event 10", description="desc 10", link="http://philippinebestwebdesign.com" }
            };
            events.ForEach(x => context.Events.AddOrUpdate(y => y.id,x));
            context.SaveChanges();
        }
    }
}
