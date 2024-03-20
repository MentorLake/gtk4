using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCellAreaBoxExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_box_pack_start")]
	internal static extern void gtk_cell_area_box_pack_start(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, int expand, int align, int @fixed);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_box_pack_end")]
	internal static extern void gtk_cell_area_box_pack_end(this GtkCellAreaBoxHandle box, GtkCellRendererHandle renderer, int expand, int align, int @fixed);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_box_get_spacing")]
	internal static extern int gtk_cell_area_box_get_spacing(this GtkCellAreaBoxHandle box);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_box_set_spacing")]
	internal static extern void gtk_cell_area_box_set_spacing(this GtkCellAreaBoxHandle box, int spacing);
}
