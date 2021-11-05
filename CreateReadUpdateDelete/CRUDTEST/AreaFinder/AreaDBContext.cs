using AreaHelper.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AreaFinder
{
    public class AreaDBContext
    {
        public class MyClass : DbContext
        {
            //using (var database = new ProjeAdı())
            //{
            //    var query = from md in database.DbAdı
            //                select new TabloAdı
            //                {
            //                    id = md.id,
            //                    ...
            //                };
            //                //var query = database.DbAdı.Select(x => new MyDomain { id = x.id });
            //}

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer("server=DESKTOP-MECSTCF\\SQLEXPRESS;Database=AreaDb;Integrated Security=true;");
            }

            public DbSet<Area> areas { get; set; }
        }
    }
}
