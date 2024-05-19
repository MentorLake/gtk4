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

namespace MentorLake.Gtk4.Gdk4;

public interface GdkPaintableHandle
{
}

internal class GdkPaintableHandleImpl : BaseSafeHandle, GdkPaintableHandle
{
}

public static class GdkPaintableHandleExtensions
{
	public static GdkPaintableHandle ComputeConcreteSize(this GdkPaintableHandle paintable, double specified_width, double specified_height, double default_width, double default_height, out double concrete_width, out double concrete_height)
	{
		GdkPaintableExterns.gdk_paintable_compute_concrete_size(paintable, specified_width, specified_height, default_width, default_height, out concrete_width, out concrete_height);
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

	public static double GetIntrinsicAspectRatio(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_intrinsic_aspect_ratio(paintable);
	}

	public static int GetIntrinsicHeight(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_intrinsic_height(paintable);
	}

	public static int GetIntrinsicWidth(this GdkPaintableHandle paintable)
	{
		return GdkPaintableExterns.gdk_paintable_get_intrinsic_width(paintable);
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

	public static GdkPaintableHandle Snapshot(this GdkPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height)
	{
		GdkPaintableExterns.gdk_paintable_snapshot(paintable, snapshot, width, height);
		return paintable;
	}

}

internal class GdkPaintableExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_paintable_compute_concrete_size(GdkPaintableHandle paintable, double specified_width, double specified_height, double default_width, double default_height, out double concrete_width, out double concrete_height);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPaintableHandle gdk_paintable_get_current_image(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPaintableFlags gdk_paintable_get_flags(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gdk4)]
	internal static extern double gdk_paintable_get_intrinsic_aspect_ratio(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_paintable_get_intrinsic_height(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_paintable_get_intrinsic_width(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_paintable_invalidate_contents(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_paintable_invalidate_size(GdkPaintableHandle paintable);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_paintable_snapshot(GdkPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height);

}
