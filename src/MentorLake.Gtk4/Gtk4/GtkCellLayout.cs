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

public interface GtkCellLayoutHandle
{
}

public static class GtkCellLayoutHandleExtensions
{
	public static GtkCellLayoutHandle AddAttribute(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, string attribute, int column)
	{
		GtkCellLayoutExterns.gtk_cell_layout_add_attribute(cell_layout, cell, attribute, column);
		return cell_layout;
	}

	public static GtkCellLayoutHandle Clear(this GtkCellLayoutHandle cell_layout)
	{
		GtkCellLayoutExterns.gtk_cell_layout_clear(cell_layout);
		return cell_layout;
	}

	public static GtkCellLayoutHandle ClearAttributes(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell)
	{
		GtkCellLayoutExterns.gtk_cell_layout_clear_attributes(cell_layout, cell);
		return cell_layout;
	}

	public static GtkCellAreaHandle GetArea(this GtkCellLayoutHandle cell_layout)
	{
		return GtkCellLayoutExterns.gtk_cell_layout_get_area(cell_layout);
	}

	public static GListHandle GetCells(this GtkCellLayoutHandle cell_layout)
	{
		return GtkCellLayoutExterns.gtk_cell_layout_get_cells(cell_layout);
	}

	public static GtkCellLayoutHandle PackEnd(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, bool expand)
	{
		GtkCellLayoutExterns.gtk_cell_layout_pack_end(cell_layout, cell, expand);
		return cell_layout;
	}

	public static GtkCellLayoutHandle PackStart(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, bool expand)
	{
		GtkCellLayoutExterns.gtk_cell_layout_pack_start(cell_layout, cell, expand);
		return cell_layout;
	}

	public static GtkCellLayoutHandle Reorder(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int position)
	{
		GtkCellLayoutExterns.gtk_cell_layout_reorder(cell_layout, cell, position);
		return cell_layout;
	}

	public static GtkCellLayoutHandle SetAttributes(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		GtkCellLayoutExterns.gtk_cell_layout_set_attributes(cell_layout, cell, @__arglist);
		return cell_layout;
	}

	public static GtkCellLayoutHandle SetCellDataFunc(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, GtkCellLayoutDataFunc func, IntPtr func_data, GDestroyNotify destroy)
	{
		GtkCellLayoutExterns.gtk_cell_layout_set_cell_data_func(cell_layout, cell, func, func_data, destroy);
		return cell_layout;
	}

}

internal class GtkCellLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_add_attribute(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, string attribute, int column);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_clear(GtkCellLayoutHandle cell_layout);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_clear_attributes(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellAreaHandle gtk_cell_layout_get_area(GtkCellLayoutHandle cell_layout);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_cell_layout_get_cells(GtkCellLayoutHandle cell_layout);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_pack_end(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, bool expand);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_pack_start(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, bool expand);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_reorder(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_set_attributes(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_layout_set_cell_data_func(GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, GtkCellLayoutDataFunc func, IntPtr func_data, GDestroyNotify destroy);
}
