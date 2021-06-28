using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Model;

namespace DBSAPI.Data
{
    public class CustomerContext : DbContext
    {
        //private const string connectionString = "Server=.;Database=DBSystem;Trusted_Connection=True;";


        public CustomerContext()
        { }
        public CustomerContext(DbContextOptions options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
         
        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }

        public DbSet<BookingStatus> BookingStatus { get; set; }

    }
}
