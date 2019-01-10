using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent.Models;
using System.Data.Entity;

namespace ClassStudent.DataAccessLayer
{
    public class ClassContext:DbContext
    {
        public DbSet<Class> ClassA { get; set; }
        public DbSet<Student> StudentA { get; set; }
    }
}
