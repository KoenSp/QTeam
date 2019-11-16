using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; 
using System;
using System.Collections.Generic;
using System.Text;
using QTeam_DAL.Models;
using System.IO; 

namespace QTeam_DAL
{
    public class QTeamContext : DbContext
    {
        public QTeamContext() { }
        public QTeamContext(DbContextOptions<QTeamContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QTeamForm>(); 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = ConnectionString;
            optionsBuilder.UseSqlServer(connString); 
        }
        private static string ConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                var config = builder.Build();

                string connstr = config.GetConnectionString("DefaultConnection");
                return connstr;
            }
        }
        public DbSet<QTeamForm> QTeamFormDb { get; set; }
    }
}
