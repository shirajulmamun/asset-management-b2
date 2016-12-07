using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.Context
{
    public class AssetDBContext:DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationBranch> OrganizationBranches { get; set; }
    }
}
