using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMicroService.Models
{
    public class UserContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP-6QCUS0H\ODARSQL;initial catalog=UserMicroserv;persist security info=True; user id =sa;password=ouss521232; ");
        }
    }
}
