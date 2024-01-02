﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXDatalaag
{
    public class DatabaseVeilingContext:DbContext
    {
        public DatabaseVeilingContext(DbContextOptions options) : base(options) { }
        public DbSet<Veiling> Veiling { get; set; }
        public DbSet<Veilingstuk> Veilingstuk { get; set; }

        public DbSet<Account> Account { get; set; }
        public DbSet<Bod> Bod { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Other configurations...

            // Add the following line to enable retry on failure
            optionsBuilder.UseSqlServer("your_connection_string", options =>
                options.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null)
            );
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiling>()
                 .HasOne(v=> v.Veilingstuk)
                 .WithMany()
                 .HasForeignKey(v => v.VeilingstukId)
                 .IsRequired();

            modelBuilder.Entity<Bod>()
                 .HasOne(v => v.Account)
                 .WithMany()
                 .HasForeignKey(v => v.AccountId)
                 .IsRequired();

            modelBuilder.Entity<Bod>()
                 .HasOne(v => v.Veiling)
                 .WithMany()
                 .HasForeignKey(v => v.VeilingId)
                 .IsRequired();

          
               
           




           
        }

    }


}
