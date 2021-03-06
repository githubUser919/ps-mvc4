using Videos.Models;

namespace Videos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Videos.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VideoDb context)
        {
            context.Videos.AddOrUpdate(v => v.Title,
                new Video() { Title = "MVC", Length = 120 },
                new Video() { Title = "LINQ", Length = 200 }
                );

        }
    }
}
