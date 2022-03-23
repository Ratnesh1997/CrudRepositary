using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudRepositary.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudRepositary.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
     public DbSet<Emp>emps { get; set; }
    }
}
