﻿using System;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace App.Infraestructure.Data
{
    public class AppoinmentContext : DbContext
    {
        public AppoinmentContext(DbContextOptions<AppoinmentContext> options) : base(options)
        {
        }

        public DbSet<Access> Access { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<ProcedureTypes> ProcedureTypes { get; set; }
        public DbSet<Doctors> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Access>()
                .HasIndex(u => u.User)
                .IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }

    public class AppoinmentContexttFactory : IDesignTimeDbContextFactory<AppoinmentContext>
    {
        public AppoinmentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppoinmentContext>();
            optionsBuilder.UseSqlServer("Data Source=142.93.12.44;Initial Catalog=APPOINMENT;User ID=sa;Password=Peru2020");

            return new AppoinmentContext(optionsBuilder.Options);
        }
    }
}
