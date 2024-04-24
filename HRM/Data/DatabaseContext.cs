using Microsoft.EntityFrameworkCore;
using HRMS.Models;
using Microsoft.AspNetCore.Identity;

namespace HRMS.Models
{
	public class DatabaseContext :DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{

		}
		public DbSet<Country> countries { get; set; }
		public DbSet<Departemement> departemements { get; set; }
		public DbSet<Designation> designations { get; set; }
		public DbSet<Religion> religions { get; set; }
		public DbSet<Employee> employees { get; set; }
		public DbSet<EmployeeEducation> empeducation { get; set; }

    }

}
