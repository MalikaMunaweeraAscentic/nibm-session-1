using CovidTest.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTest.API.Data
{
	public class CovidTestContext: DbContext
	{
		public CovidTestContext(DbContextOptions<CovidTestContext> options)
		:base(options)
		{
		}

		public DbSet<Patient> Patients { get; set; }
	}
}
