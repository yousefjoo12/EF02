using C42_G01_EF01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Config
{
	internal class Config_Student : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.ToTable("Students", "dbo");

			builder.HasKey(t => t.Id);

			builder.Property(t => t.FName)
				   .IsRequired()
				   .HasMaxLength(20);

			builder.Property(t => t.LName)
				   .IsRequired()
				   .HasMaxLength(50);

			builder.Property(t => t.Address)
				   .IsRequired()
				   .HasMaxLength(70);

			builder.Property(t => t.Age)
				   .IsRequired();

		}
	}
}
