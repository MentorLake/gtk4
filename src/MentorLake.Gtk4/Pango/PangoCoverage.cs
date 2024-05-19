using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Pango;

public class PangoCoverageHandle : GObjectHandle
{
	public static PangoCoverageHandle New()
	{
		return PangoCoverageExterns.pango_coverage_new();
	}

	public static PangoCoverageHandle FromBytes(string bytes, int n_bytes)
	{
		return PangoCoverageExterns.pango_coverage_from_bytes(bytes, n_bytes);
	}

}

public static class PangoCoverageHandleExtensions
{
	public static PangoCoverageHandle Copy(this PangoCoverageHandle coverage)
	{
		return PangoCoverageExterns.pango_coverage_copy(coverage);
	}

	public static PangoCoverageLevel Get(this PangoCoverageHandle coverage, int index_)
	{
		return PangoCoverageExterns.pango_coverage_get(coverage, index_);
	}

	public static PangoCoverageHandle Max(this PangoCoverageHandle coverage, PangoCoverageHandle other)
	{
		PangoCoverageExterns.pango_coverage_max(coverage, other);
		return coverage;
	}

	public static PangoCoverageHandle Ref(this PangoCoverageHandle coverage)
	{
		return PangoCoverageExterns.pango_coverage_ref(coverage);
	}

	public static PangoCoverageHandle Set(this PangoCoverageHandle coverage, int index_, PangoCoverageLevel level)
	{
		PangoCoverageExterns.pango_coverage_set(coverage, index_, level);
		return coverage;
	}

	public static PangoCoverageHandle ToBytes(this PangoCoverageHandle coverage, out string bytes, out int n_bytes)
	{
		PangoCoverageExterns.pango_coverage_to_bytes(coverage, out bytes, out n_bytes);
		return coverage;
	}

	public static PangoCoverageHandle Unref(this PangoCoverageHandle coverage)
	{
		PangoCoverageExterns.pango_coverage_unref(coverage);
		return coverage;
	}

}

internal class PangoCoverageExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_new();

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_copy(PangoCoverageHandle coverage);

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageLevel pango_coverage_get(PangoCoverageHandle coverage, int index_);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_max(PangoCoverageHandle coverage, PangoCoverageHandle other);

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_ref(PangoCoverageHandle coverage);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_set(PangoCoverageHandle coverage, int index_, PangoCoverageLevel level);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_to_bytes(PangoCoverageHandle coverage, out string bytes, out int n_bytes);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_unref(PangoCoverageHandle coverage);

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_from_bytes(string bytes, int n_bytes);

}
