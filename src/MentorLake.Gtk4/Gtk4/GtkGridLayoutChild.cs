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

public class GtkGridLayoutChildHandle : GtkLayoutChildHandle
{
}

public static class GtkGridLayoutChildHandleExtensions
{
	public static int GetColumn(this GtkGridLayoutChildHandle child)
	{
		return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_column(child);
	}

	public static int GetColumnSpan(this GtkGridLayoutChildHandle child)
	{
		return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_column_span(child);
	}

	public static int GetRow(this GtkGridLayoutChildHandle child)
	{
		return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_row(child);
	}

	public static int GetRowSpan(this GtkGridLayoutChildHandle child)
	{
		return GtkGridLayoutChildExterns.gtk_grid_layout_child_get_row_span(child);
	}

	public static GtkGridLayoutChildHandle SetColumn(this GtkGridLayoutChildHandle child, int column)
	{
		GtkGridLayoutChildExterns.gtk_grid_layout_child_set_column(child, column);
		return child;
	}

	public static GtkGridLayoutChildHandle SetColumnSpan(this GtkGridLayoutChildHandle child, int span)
	{
		GtkGridLayoutChildExterns.gtk_grid_layout_child_set_column_span(child, span);
		return child;
	}

	public static GtkGridLayoutChildHandle SetRow(this GtkGridLayoutChildHandle child, int row)
	{
		GtkGridLayoutChildExterns.gtk_grid_layout_child_set_row(child, row);
		return child;
	}

	public static GtkGridLayoutChildHandle SetRowSpan(this GtkGridLayoutChildHandle child, int span)
	{
		GtkGridLayoutChildExterns.gtk_grid_layout_child_set_row_span(child, span);
		return child;
	}

}

internal class GtkGridLayoutChildExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_grid_layout_child_get_column(GtkGridLayoutChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_grid_layout_child_get_column_span(GtkGridLayoutChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_grid_layout_child_get_row(GtkGridLayoutChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_grid_layout_child_get_row_span(GtkGridLayoutChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_child_set_column(GtkGridLayoutChildHandle child, int column);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_child_set_column_span(GtkGridLayoutChildHandle child, int span);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_child_set_row(GtkGridLayoutChildHandle child, int row);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_layout_child_set_row_span(GtkGridLayoutChildHandle child, int span);

}
