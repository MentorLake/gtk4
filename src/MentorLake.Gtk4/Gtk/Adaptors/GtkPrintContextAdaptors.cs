using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPrintContextAdaptors
{
    public static cairoHandle GetCairoContext(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_get_cairo_context(context);
    }

    public static GtkPageSetupHandle GetPageSetup(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_get_page_setup(context);
    }

    public static double GetWidth(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_get_width(context);
    }

    public static double GetHeight(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_get_height(context);
    }

    public static double GetDpiX(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_get_dpi_x(context);
    }

    public static double GetDpiY(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_get_dpi_y(context);
    }

    public static int GetHardMargins(this GtkPrintContextHandle context, out double top, out double bottom, out double left, out double right)
    {
        return GtkPrintContextExterns.gtk_print_context_get_hard_margins(context, out top, out bottom, out left, out right);
    }

    public static PangoFontMapHandle GetPangoFontmap(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_get_pango_fontmap(context);
    }

    public static PangoContextHandle CreatePangoContext(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_create_pango_context(context);
    }

    public static PangoLayoutHandle CreatePangoLayout(this GtkPrintContextHandle context)
    {
        return GtkPrintContextExterns.gtk_print_context_create_pango_layout(context);
    }

    public static GtkPrintContextHandle SetCairoContext(this GtkPrintContextHandle context, cairoHandle cr, double dpi_x, double dpi_y)
    {
        GtkPrintContextExterns.gtk_print_context_set_cairo_context(context, cr, dpi_x, dpi_y);
        return context;
    }
}
