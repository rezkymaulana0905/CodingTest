using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssetInventoryAPI.Model;

namespace AssetInventoryAPI.Data
{
    public class AssetInventoryAPIContext : DbContext
    {
        public AssetInventoryAPIContext (DbContextOptions<AssetInventoryAPIContext> options)
            : base(options)
        {
        }

        public DbSet<AssetInventoryAPI.Model.UserMaster> UserMaster { get; set; } = default!;
    }
}
