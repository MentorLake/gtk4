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

public class GtkPrintContextHandle : GObjectHandle
{
}

public static class GtkPrintContextSignals
{
}

public static class GtkPrintContextHandleExtensions
{
	public static PangoContextHandle CreatePangoContext(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_create_pango_context(context);
	}

	public static PangoLayoutHandle CreatePangoLayout(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_create_pango_layout(context);
	}

	public static cairo_tHandle GetCairoContext(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_get_cairo_context(context);
	}

	public static double GetDpiX(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_get_dpi_x(context);
	}

	public static double GetDpiY(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_get_dpi_y(context);
	}

	public static bool GetHardMargins(this GtkPrintContextHandle context, out double top, out double bottom, out double left, out double right)
	{
		return GtkPrintContextExterns.gtk_print_context_get_hard_margins(context, out top, out bottom, out left, out right);
	}

	public static double GetHeight(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_get_height(context);
	}

	public static GtkPageSetupHandle GetPageSetup(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_get_page_setup(context);
	}

	public static PangoFontMapHandle GetPangoFontmap(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_get_pango_fontmap(context);
	}

	public static double GetWidth(this GtkPrintContextHandle context)
	{
		return GtkPrintContextExterns.gtk_print_context_get_width(context);
	}

	public static GtkPrintContextHandle SetCairoContext(this GtkPrintContextHandle context, cairo_tHandle cr, double dpi_x, double dpi_y)
	{
		GtkPrintContextExterns.gtk_print_context_set_cairo_context(context, cr, dpi_x, dpi_y);
		return context;
	}

}

internal class GtkPrintContextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoContextHandle gtk_print_context_create_pango_context(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLayoutHandle gtk_print_context_create_pango_layout(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern cairo_tHandle gtk_print_context_get_cairo_context(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_context_get_dpi_x(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_context_get_dpi_y(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_context_get_hard_margins(GtkPrintContextHandle context, out double top, out double bottom, out double left, out double right);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_context_get_height(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_print_context_get_page_setup(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontMapHandle gtk_print_context_get_pango_fontmap(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_context_get_width(GtkPrintContextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_context_set_cairo_context(GtkPrintContextHandle context, cairo_tHandle cr, double dpi_x, double dpi_y);
}
