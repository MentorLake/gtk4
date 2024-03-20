using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCellRendererToggleExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_toggle_get_radio")]
	internal static extern int gtk_cell_renderer_toggle_get_radio(this GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_toggle_set_radio")]
	internal static extern void gtk_cell_renderer_toggle_set_radio(this GtkCellRendererToggleHandle toggle, int radio);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_toggle_get_active")]
	internal static extern int gtk_cell_renderer_toggle_get_active(this GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_toggle_set_active")]
	internal static extern void gtk_cell_renderer_toggle_set_active(this GtkCellRendererToggleHandle toggle, int setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_toggle_get_activatable")]
	internal static extern int gtk_cell_renderer_toggle_get_activatable(this GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_toggle_set_activatable")]
	internal static extern void gtk_cell_renderer_toggle_set_activatable(this GtkCellRendererToggleHandle toggle, int setting);
}
