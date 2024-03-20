using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkPaintableAdaptors
{
	public static GdkPaintableHandle Snapshot(this GdkPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height)
	{
		GdkPaintableExterns.gdk_paintable_snapshot(paintable, snapshot, width, height);
		return paintable;
	}

	public static GdkPaintableHandle GetCurrentImage(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_current_image(paintable);
	}

	public static GdkPaintableFlags GetFlags(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_flags(paintable);
	}

	public static int GetIntrinsicWidth(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_intrinsic_width(paintable);
	}

	public static int GetIntrinsicHeight(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_intrinsic_height(paintable);
	}

	public static double GetIntrinsicAspectRatio(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_intrinsic_aspect_ratio(paintable);
	}

	public static GdkPaintableHandle ComputeConcreteSize(this GdkPaintableHandle paintable, double specified_width, double specified_height, double default_width, double default_height, out double concrete_width, out double concrete_height)
	{
		GdkPaintableExterns.gdk_paintable_compute_concrete_size(paintable, specified_width, specified_height, default_width, default_height, out concrete_width, out concrete_height);
		return paintable;
	}

	public static GdkPaintableHandle InvalidateContents(this GdkPaintableHandle paintable)
	{
		GdkPaintableExterns.gdk_paintable_invalidate_contents(paintable);
		return paintable;
	}

	public static GdkPaintableHandle InvalidateSize(this GdkPaintableHandle paintable)
	{
		GdkPaintableExterns.gdk_paintable_invalidate_size(paintable);
		return paintable;
	}
}
