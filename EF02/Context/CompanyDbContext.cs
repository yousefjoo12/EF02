using C42_G01_EF01.Entities;
using EF02.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Context
{
	internal class CompanyDbContext: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = . ; Database = ITI02; Trusted_Connection = True ; Encrypt=false"); 
		}
		public DbSet<Stud_Course> Stud_Course { get; set; }
		public DbSet<Coures_inst> Coures_inst { get; set; }
		public DbSet<Department> Department { get; set; }
		public DbSet<Instructor> Instructor { get; set; }
		public DbSet<Topic> Topic { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new Config_Course());
			modelBuilder.ApplyConfiguration(new Config_Student()); 
		}
	}
}
