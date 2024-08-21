using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entities
{
	internal class Department
	{
		[Key]
		public int ID { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		[Required]
		public DateTime HiringDate { get; set; }
	
		public int Ins_ID { get; set; }

		// Collection navigation 
		public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

		public ICollection<Student> Students { get; set; } = new HashSet<Student>();
	}
}
