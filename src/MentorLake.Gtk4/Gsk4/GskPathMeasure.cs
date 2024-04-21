using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gsk4;

public class GskPathMeasureHandle : BaseSafeHandle
{
	public static GskPathMeasureHandle New(GskPathHandle path)
	{
		return GskPathMeasureExterns.gsk_path_measure_new(path);
	}

	public static GskPathMeasureHandle NewWithTolerance(GskPathHandle path, float tolerance)
	{
		return GskPathMeasureExterns.gsk_path_measure_new_with_tolerance(path, tolerance);
	}

}

internal class GskPathMeasureExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathMeasureHandle gsk_path_measure_new(GskPathHandle path);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathMeasureHandle gsk_path_measure_new_with_tolerance(GskPathHandle path, float tolerance);

}

public struct GskPathMeasure
{
}
