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

public class GtkCellAreaBoxHandle : GtkCellAreaHandle
{
	public static GtkCellAreaBoxHandle New()
	{
		return GtkCellAreaBoxExterns.gtk_cell_area_box_new();
	}
}

public static class GtkCellAreaBoxSignals
{
}

public static class GtkCellAreaBoxHandleExtensions
{
	public static int GetSpacing(this GtkCellAreaBoxHandle box)
	{
		return GtkCellAreaBoxExterns.gtk_cell_area_box_get_spacing(box);
	}

	public static GtkCellAreaBoxHandle PackEnd(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed)
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_pack_end(box, renderer, expand, align, @fixed);
		return box;
	}

	public static GtkCellAreaBoxHandle PackStart(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed)
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_pack_start(box, renderer, expand, align, @fixed);
		return box;
	}

	public static GtkCellAreaBoxHandle SetSpacing(this GtkCellAreaBoxHandle box, int spacing)
	{
		GtkCellAreaBoxExterns.gtk_cell_area_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkCellAreaBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_cell_area_box_get_spacing(GtkCellAreaBoxHandle box);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_box_pack_end(GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_box_pack_start(GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_area_box_set_spacing(GtkCellAreaBoxHandle box, int spacing);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellAreaBoxHandle gtk_cell_area_box_new();
}
