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

namespace MentorLake.Gtk4.Gtk4;

public class GtkBoxLayoutHandle : GtkLayoutManagerHandle, GtkOrientableHandle
{
	public static GtkBoxLayoutHandle New(GtkOrientation orientation)
	{
		return GtkBoxLayoutExterns.gtk_box_layout_new(orientation);
	}

}

public static class GtkBoxLayoutHandleExtensions
{
	public static int GetBaselineChild(this GtkBoxLayoutHandle box_layout)
	{
		return GtkBoxLayoutExterns.gtk_box_layout_get_baseline_child(box_layout);
	}

	public static GtkBaselinePosition GetBaselinePosition(this GtkBoxLayoutHandle box_layout)
	{
		return GtkBoxLayoutExterns.gtk_box_layout_get_baseline_position(box_layout);
	}

	public static bool GetHomogeneous(this GtkBoxLayoutHandle box_layout)
	{
		return GtkBoxLayoutExterns.gtk_box_layout_get_homogeneous(box_layout);
	}

	public static uint GetSpacing(this GtkBoxLayoutHandle box_layout)
	{
		return GtkBoxLayoutExterns.gtk_box_layout_get_spacing(box_layout);
	}

	public static GtkBoxLayoutHandle SetBaselineChild(this GtkBoxLayoutHandle box_layout, int child)
	{
		GtkBoxLayoutExterns.gtk_box_layout_set_baseline_child(box_layout, child);
		return box_layout;
	}

	public static GtkBoxLayoutHandle SetBaselinePosition(this GtkBoxLayoutHandle box_layout, GtkBaselinePosition position)
	{
		GtkBoxLayoutExterns.gtk_box_layout_set_baseline_position(box_layout, position);
		return box_layout;
	}

	public static GtkBoxLayoutHandle SetHomogeneous(this GtkBoxLayoutHandle box_layout, bool homogeneous)
	{
		GtkBoxLayoutExterns.gtk_box_layout_set_homogeneous(box_layout, homogeneous);
		return box_layout;
	}

	public static GtkBoxLayoutHandle SetSpacing(this GtkBoxLayoutHandle box_layout, uint spacing)
	{
		GtkBoxLayoutExterns.gtk_box_layout_set_spacing(box_layout, spacing);
		return box_layout;
	}

}

internal class GtkBoxLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBoxLayoutHandle gtk_box_layout_new(GtkOrientation orientation);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_box_layout_get_baseline_child(GtkBoxLayoutHandle box_layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBaselinePosition gtk_box_layout_get_baseline_position(GtkBoxLayoutHandle box_layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_box_layout_get_homogeneous(GtkBoxLayoutHandle box_layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_box_layout_get_spacing(GtkBoxLayoutHandle box_layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_layout_set_baseline_child(GtkBoxLayoutHandle box_layout, int child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_layout_set_baseline_position(GtkBoxLayoutHandle box_layout, GtkBaselinePosition position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_layout_set_homogeneous(GtkBoxLayoutHandle box_layout, bool homogeneous);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_layout_set_spacing(GtkBoxLayoutHandle box_layout, uint spacing);

}
