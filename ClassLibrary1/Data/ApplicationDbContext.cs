using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
		public DbSet<Segment> Segments => Set<Segment>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Segment>().HasData(
				new Segment { Id = 1, Name = "{en: 'Segment 1', ar: 'الجزء 1'}" },
				new Segment { Id = 2, Name = "{en: 'Segment 2', ar: 'الجزء 2'}" }
			);
			//Remaining of the code...
		}
    }
}