using ClassLibrary1.Models;

namespace ClassLibrary1.Interfaces
{
	public interface ISegmentService
	{
		Task<IEnumerable<Segment>> GetSegmentsAsync(int? id);
	}
}
