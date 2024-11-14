using AssetSync.BrandshareDAM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AssetSync.BrandshareDAM.Repositories
{
    public class BrandshareDAMDBContext : DbContext
    {
        public DbSet<SyncJob> SyncJobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=brandsharedam.db");
        }
    }
}
