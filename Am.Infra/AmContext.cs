using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Am.Infra
{
    internal class AmContext : DbContext

    { // prop + dbset
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        //override void onConfiguring 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
            Initial Catalog=AirportManagement4SE2;
            Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }


    }
}
