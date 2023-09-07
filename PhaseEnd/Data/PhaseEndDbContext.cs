using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhaseEnd.Model;

namespace PhaseEnd.Data
{
    public class PhaseEndDbContext : DbContext
    {
        public PhaseEndDbContext (DbContextOptions<PhaseEndDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhaseEnd.Model.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<PhaseEnd.Model.EmpProfile>? EmpProfile { get; set; }
    }
}
