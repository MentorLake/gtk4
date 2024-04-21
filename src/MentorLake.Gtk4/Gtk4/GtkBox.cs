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

public class GtkBoxHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkBoxHandle New(GtkOrientation orientation, int spacing)
	{
		return GtkBoxExterns.gtk_box_new(orientation, spacing);
	}

}

public static class GtkBoxHandleExtensions
{
	public static GtkBoxHandle Append(this GtkBoxHandle box, GtkWidgetHandle child)
	{
		GtkBoxExterns.gtk_box_append(box, child);
		return box;
	}

	public static int GetBaselineChild(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_baseline_child(box);
	}

	public static GtkBaselinePosition GetBaselinePosition(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_baseline_position(box);
	}

	public static bool GetHomogeneous(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_homogeneous(box);
	}

	public static int GetSpacing(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_spacing(box);
	}

	public static GtkBoxHandle InsertChildAfter(this GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling)
	{
		GtkBoxExterns.gtk_box_insert_child_after(box, child, sibling);
		return box;
	}

	public static GtkBoxHandle Prepend(this GtkBoxHandle box, GtkWidgetHandle child)
	{
		GtkBoxExterns.gtk_box_prepend(box, child);
		return box;
	}

	public static GtkBoxHandle Remove(this GtkBoxHandle box, GtkWidgetHandle child)
	{
		GtkBoxExterns.gtk_box_remove(box, child);
		return box;
	}

	public static GtkBoxHandle ReorderChildAfter(this GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling)
	{
		GtkBoxExterns.gtk_box_reorder_child_after(box, child, sibling);
		return box;
	}

	public static GtkBoxHandle SetBaselineChild(this GtkBoxHandle box, int child)
	{
		GtkBoxExterns.gtk_box_set_baseline_child(box, child);
		return box;
	}

	public static GtkBoxHandle SetBaselinePosition(this GtkBoxHandle box, GtkBaselinePosition position)
	{
		GtkBoxExterns.gtk_box_set_baseline_position(box, position);
		return box;
	}

	public static GtkBoxHandle SetHomogeneous(this GtkBoxHandle box, bool homogeneous)
	{
		GtkBoxExterns.gtk_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static GtkBoxHandle SetSpacing(this GtkBoxHandle box, int spacing)
	{
		GtkBoxExterns.gtk_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBoxHandle gtk_box_new(GtkOrientation orientation, int spacing);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_append(GtkBoxHandle box, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_box_get_baseline_child(GtkBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBaselinePosition gtk_box_get_baseline_position(GtkBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_box_get_homogeneous(GtkBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_box_get_spacing(GtkBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_insert_child_after(GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_prepend(GtkBoxHandle box, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_remove(GtkBoxHandle box, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_reorder_child_after(GtkBoxHandle box, GtkWidgetHandle child, GtkWidgetHandle sibling);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_set_baseline_child(GtkBoxHandle box, int child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_set_baseline_position(GtkBoxHandle box, GtkBaselinePosition position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_set_homogeneous(GtkBoxHandle box, bool homogeneous);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_box_set_spacing(GtkBoxHandle box, int spacing);

}
