using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entities
{
	internal class Instructor
	{
		public int ID { get; set; }	
		public string Name { get; set; } 
		public decimal Bouns { get; set; }
		public decimal Salary { get; set; }
		public string Adress { get; set; }
		public decimal HourRate { get; set; }
		public int Dept_ID { get; set; }

		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }

	}
}
