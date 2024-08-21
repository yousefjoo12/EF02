using C42_G01_EF01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Config
{
	internal class Config_StudCourse : IEntityTypeConfiguration<Stud_Course>
	{
		public void Configure(EntityTypeBuilder<Stud_Course> builder)
		{
			builder.ToTable("StudCourse");
			builder.HasKey(Sc => new { Sc.stud_ID, Sc.Course_ID });
			builder.Property(S => S.Grade)
				.HasColumnType("money");
		}
	}
}
