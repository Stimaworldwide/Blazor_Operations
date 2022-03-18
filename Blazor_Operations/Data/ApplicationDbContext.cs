using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Operations.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Operationsclass> OperationsTable { get; set; }
        public DbSet<Device> DevicesTable { get; set; }
        //public DbSet<DeviceType> Devices { get; set; }
    }
}
