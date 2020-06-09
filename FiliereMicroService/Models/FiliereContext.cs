using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiliereMicroService.Models
{
    public class FiliereContext:DbContext
    {
        public DbSet<Filiere> Filieres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP-6QCUS0H\ODARSQL;initial catalog=FiliereMicroservice;persist security info=True; user id =sa;password=ouss521232; ");
        }
    }
}
