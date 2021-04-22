using CovidTest.API.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTest.API.Models
{
	public class Patient
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string FullName { get; set; }
		public string NIC { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public DistrictEnum District { get; set; }
	}
}
