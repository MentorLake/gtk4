using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCellRendererTextExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_renderer_text_set_fixed_height_from_font")]
	internal static extern void gtk_cell_renderer_text_set_fixed_height_from_font(this GtkCellRendererTextHandle renderer, int number_of_rows);
}
