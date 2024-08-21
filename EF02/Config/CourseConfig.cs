using C42_G01_EF01.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Config
{
	internal class CourseConfig : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.ToTable("courses", "dbo");

			builder.HasKey(c => c.ID);

			builder.Property(c => c.Name)
				   .IsRequired();

			builder.Property(c => c.Duration)
				   .IsRequired();

			builder.Property(c => c.Description);
		}
		 
	}
}
