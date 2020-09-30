using Board.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Board.Services
{
    public class DatabaseService : DbContext
    {
        public DbSet<Advert> Adverts { get; set; }
    }

    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseService>
    {
        public static DatabaseInitializer Instance =  new DatabaseInitializer();

        private DatabaseInitializer() {}
    }
}