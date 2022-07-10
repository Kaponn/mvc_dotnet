using Microsoft.EntityFrameworkCore;
using StudentsAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAppMVC.Data
{
    public class MvcStudentsContext : DbContext
    {
        public MvcStudentsContext(DbContextOptions<MvcStudentsContext> options) : base(options)
        {
        }

        public DbSet<StudentModel> Students { get; set; }
    }
}
