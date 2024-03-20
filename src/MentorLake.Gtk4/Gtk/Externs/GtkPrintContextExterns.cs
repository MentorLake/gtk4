using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;

public static class GtkPrintContextExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_cairo_context")]
	internal static extern cairoHandle gtk_print_context_get_cairo_context(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_page_setup")]
	internal static extern GtkPageSetupHandle gtk_print_context_get_page_setup(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_width")]
	internal static extern double gtk_print_context_get_width(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_height")]
	internal static extern double gtk_print_context_get_height(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_dpi_x")]
	internal static extern double gtk_print_context_get_dpi_x(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_dpi_y")]
	internal static extern double gtk_print_context_get_dpi_y(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_hard_margins")]
	internal static extern int gtk_print_context_get_hard_margins(this GtkPrintContextHandle context, out double top, out double bottom, out double left, out double right);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_get_pango_fontmap")]
	internal static extern PangoFontMapHandle gtk_print_context_get_pango_fontmap(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_create_pango_context")]
	internal static extern PangoContextHandle gtk_print_context_create_pango_context(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_create_pango_layout")]
	internal static extern PangoLayoutHandle gtk_print_context_create_pango_layout(this GtkPrintContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_context_set_cairo_context")]
	internal static extern void gtk_print_context_set_cairo_context(this GtkPrintContextHandle context, cairoHandle cr, double dpi_x, double dpi_y);
}
