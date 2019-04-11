using System;
using Microsoft.EntityFrameworkCore;
using WebAPICore.Common;
using WebAPICore.DataModel.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebAPICore.DataAccess
{
    public class MainContext : DbContext
    {
        public MainContext() { }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        public virtual DbSet<AuditTrail> AuditTrails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
