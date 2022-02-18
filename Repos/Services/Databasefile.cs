using Microsoft.EntityFrameworkCore;
using NewProject1Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NewProject1Crud.Repos.Services
{
    public class Databasefile : DbContext
    {
        public Databasefile(DbContextOptions<Databasefile> options) : base(options) { }
        public DbSet<UserData> UsersDetails { get; set; }
        public DbSet<ItemsData> ItmesDetails { get; set; }
    }
}
