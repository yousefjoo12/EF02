using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entities
{
	internal class Coures_inst
	{
		[Key]
		public int inst_ID { get; set; }
		public int Coures_ID { get; set; } 
		public string evaluate { get; set; }

	}
}
