using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoCoverageAdaptors
{
	public static PangoCoverageHandle Ref(this PangoCoverageHandle coverage)
	{
		return PangoCoverageExterns.pango_coverage_ref(coverage);
	}

	public static PangoCoverageHandle Unref(this PangoCoverageHandle coverage)
	{
		PangoCoverageExterns.pango_coverage_unref(coverage);
		return coverage;
	}

	public static PangoCoverageHandle Copy(this PangoCoverageHandle coverage)
	{
		return PangoCoverageExterns.pango_coverage_copy(coverage);
	}

	public static PangoCoverageLevel Get(this PangoCoverageHandle coverage, int index_)
	{
		return PangoCoverageExterns.pango_coverage_get(coverage, index_);
	}

	public static PangoCoverageHandle Set(this PangoCoverageHandle coverage, int index_, PangoCoverageLevel level)
	{
		PangoCoverageExterns.pango_coverage_set(coverage, index_, level);
		return coverage;
	}

	public static PangoCoverageHandle Max(this PangoCoverageHandle coverage, PangoCoverageHandle other)
	{
		PangoCoverageExterns.pango_coverage_max(coverage, other);
		return coverage;
	}

	public static PangoCoverageHandle ToBytes(this PangoCoverageHandle coverage, byte[] bytes, out int n_bytes)
	{
		PangoCoverageExterns.pango_coverage_to_bytes(coverage, bytes, out n_bytes);
		return coverage;
	}
}
