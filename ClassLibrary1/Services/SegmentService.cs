using ClassLibrary1.Data;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
	public class SegmentService : ISegmentService
	{
		private readonly ApplicationDbContext _dbContext;

		/*public AccountService()
		{
		}*/
		public SegmentService(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<IEnumerable<Segment>> GetSegmentsAsync(int? id)
		{
			var segments = await _dbContext.Segments.OrderBy(x => x.Id)
									.ToListAsync();
			return segments ?? Enumerable.Empty<Segment>();
		}
	}
}