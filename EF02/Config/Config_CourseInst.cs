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
	internal class Config_CourseInst : IEntityTypeConfiguration<Coures_inst>
	{
		public void Configure(EntityTypeBuilder<Coures_inst> builder)
		{
			builder.ToTable("CourseInst");

			builder.HasKey(Ci => new { Ci.inst_ID, Ci.Coures_ID });

			builder.Property(ci => ci.evaluate)
				   .HasMaxLength(50);
		}
	}
}
