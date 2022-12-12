using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmployeeName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.MailId)
                .IsUnicode(false);
        }
    }
}
