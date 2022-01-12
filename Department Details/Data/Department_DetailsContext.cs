using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Department_Details.Models;

namespace Department_Details.Data
{
    public class Department_DetailsContext : DbContext
    {
        public Department_DetailsContext (DbContextOptions<Department_DetailsContext> options)
            : base(options)
        {
        }

        public DbSet<Department_Details.Models.Department> Department { get; set; }
    }
}
