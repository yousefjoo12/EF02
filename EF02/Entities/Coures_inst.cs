using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entities
{

	internal class Coures_inst
	{

		[Required] 
		public int inst_ID { get; set; }

		[Required] 
		public int Coures_ID { get; set; }

		public string Evaluate { get; set; }

	}
}
