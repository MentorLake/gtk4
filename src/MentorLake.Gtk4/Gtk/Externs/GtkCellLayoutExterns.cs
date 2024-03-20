using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCellLayoutExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_pack_start")]
	internal static extern void gtk_cell_layout_pack_start(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int expand);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_pack_end")]
	internal static extern void gtk_cell_layout_pack_end(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int expand);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_get_cells")]
	internal static extern GListHandle gtk_cell_layout_get_cells(this GtkCellLayoutHandle cell_layout);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_clear")]
	internal static extern void gtk_cell_layout_clear(this GtkCellLayoutHandle cell_layout);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_set_attributes")]
	internal static extern void gtk_cell_layout_set_attributes(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_add_attribute")]
	internal static extern void gtk_cell_layout_add_attribute(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, string attribute, int column);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_set_cell_data_func")]
	internal static extern void gtk_cell_layout_set_cell_data_func(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, GtkCellLayoutDataFunc func, IntPtr func_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_clear_attributes")]
	internal static extern void gtk_cell_layout_clear_attributes(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_reorder")]
	internal static extern void gtk_cell_layout_reorder(this GtkCellLayoutHandle cell_layout, GtkCellRendererHandle cell, int position);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_layout_get_area")]
	internal static extern GtkCellAreaHandle gtk_cell_layout_get_area(this GtkCellLayoutHandle cell_layout);
}
