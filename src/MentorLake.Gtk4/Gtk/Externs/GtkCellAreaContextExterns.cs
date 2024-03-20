using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCellAreaContextExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_get_area")]
	internal static extern GtkCellAreaHandle gtk_cell_area_context_get_area(this GtkCellAreaContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_allocate")]
	internal static extern void gtk_cell_area_context_allocate(this GtkCellAreaContextHandle context, int width, int height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_reset")]
	internal static extern void gtk_cell_area_context_reset(this GtkCellAreaContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_get_preferred_width")]
	internal static extern void gtk_cell_area_context_get_preferred_width(this GtkCellAreaContextHandle context, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_get_preferred_height")]
	internal static extern void gtk_cell_area_context_get_preferred_height(this GtkCellAreaContextHandle context, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_get_preferred_height_for_width")]
	internal static extern void gtk_cell_area_context_get_preferred_height_for_width(this GtkCellAreaContextHandle context, int width, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_get_preferred_width_for_height")]
	internal static extern void gtk_cell_area_context_get_preferred_width_for_height(this GtkCellAreaContextHandle context, int height, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_get_allocation")]
	internal static extern void gtk_cell_area_context_get_allocation(this GtkCellAreaContextHandle context, out int width, out int height);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_push_preferred_width")]
	internal static extern void gtk_cell_area_context_push_preferred_width(this GtkCellAreaContextHandle context, int minimum_width, int natural_width);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_context_push_preferred_height")]
	internal static extern void gtk_cell_area_context_push_preferred_height(this GtkCellAreaContextHandle context, int minimum_height, int natural_height);
}
