using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStyleContextAdaptors
{
    public static GtkStyleContextHandle GtkRenderCheck(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_check(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderOption(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_option(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderArrow(this GtkStyleContextHandle context, cairoHandle cr, double angle, double x, double y, double size)
    {
        GtkStyleContextExterns.gtk_render_arrow(context, cr, angle, x, y, size);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderBackground(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_background(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderFrame(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_frame(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderExpander(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_expander(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderFocus(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_focus(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderLayout(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, PangoLayoutHandle layout)
    {
        GtkStyleContextExterns.gtk_render_layout(context, cr, x, y, layout);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderLine(this GtkStyleContextHandle context, cairoHandle cr, double x0, double y0, double x1, double y1)
    {
        GtkStyleContextExterns.gtk_render_line(context, cr, x0, y0, x1, y1);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderHandle(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_handle(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderActivity(this GtkStyleContextHandle context, cairoHandle cr, double x, double y, double width, double height)
    {
        GtkStyleContextExterns.gtk_render_activity(context, cr, x, y, width, height);
        return context;
    }

    public static GtkStyleContextHandle GtkRenderIcon(this GtkStyleContextHandle context, cairoHandle cr, GdkTextureHandle texture, double x, double y)
    {
        GtkStyleContextExterns.gtk_render_icon(context, cr, texture, x, y);
        return context;
    }

    public static GtkStyleContextHandle AddProvider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider, uint priority)
    {
        GtkStyleContextExterns.gtk_style_context_add_provider(context, provider, priority);
        return context;
    }

    public static GtkStyleContextHandle RemoveProvider(this GtkStyleContextHandle context, GtkStyleProviderHandle provider)
    {
        GtkStyleContextExterns.gtk_style_context_remove_provider(context, provider);
        return context;
    }

    public static GtkStyleContextHandle Save(this GtkStyleContextHandle context)
    {
        GtkStyleContextExterns.gtk_style_context_save(context);
        return context;
    }

    public static GtkStyleContextHandle Restore(this GtkStyleContextHandle context)
    {
        GtkStyleContextExterns.gtk_style_context_restore(context);
        return context;
    }

    public static GtkStyleContextHandle SetState(this GtkStyleContextHandle context, GtkStateFlags flags)
    {
        GtkStyleContextExterns.gtk_style_context_set_state(context, flags);
        return context;
    }

    public static GtkStateFlags GetState(this GtkStyleContextHandle context)
    {
        return GtkStyleContextExterns.gtk_style_context_get_state(context);
    }

    public static GtkStyleContextHandle SetScale(this GtkStyleContextHandle context, int scale)
    {
        GtkStyleContextExterns.gtk_style_context_set_scale(context, scale);
        return context;
    }

    public static int GetScale(this GtkStyleContextHandle context)
    {
        return GtkStyleContextExterns.gtk_style_context_get_scale(context);
    }

    public static GtkStyleContextHandle AddClass(this GtkStyleContextHandle context, string class_name)
    {
        GtkStyleContextExterns.gtk_style_context_add_class(context, class_name);
        return context;
    }

    public static GtkStyleContextHandle RemoveClass(this GtkStyleContextHandle context, string class_name)
    {
        GtkStyleContextExterns.gtk_style_context_remove_class(context, class_name);
        return context;
    }

    public static int HasClass(this GtkStyleContextHandle context, string class_name)
    {
        return GtkStyleContextExterns.gtk_style_context_has_class(context, class_name);
    }

    public static GtkStyleContextHandle SetDisplay(this GtkStyleContextHandle context, GdkDisplayHandle display)
    {
        GtkStyleContextExterns.gtk_style_context_set_display(context, display);
        return context;
    }

    public static GdkDisplayHandle GetDisplay(this GtkStyleContextHandle context)
    {
        return GtkStyleContextExterns.gtk_style_context_get_display(context);
    }

    public static int LookupColor(this GtkStyleContextHandle context, string color_name, GdkRGBAHandle color)
    {
        return GtkStyleContextExterns.gtk_style_context_lookup_color(context, color_name, color);
    }

    public static GtkStyleContextHandle GetColor(this GtkStyleContextHandle context, GdkRGBAHandle color)
    {
        GtkStyleContextExterns.gtk_style_context_get_color(context, color);
        return context;
    }

    public static GtkStyleContextHandle GetBorder(this GtkStyleContextHandle context, GtkBorderHandle border)
    {
        GtkStyleContextExterns.gtk_style_context_get_border(context, border);
        return context;
    }

    public static GtkStyleContextHandle GetPadding(this GtkStyleContextHandle context, GtkBorderHandle padding)
    {
        GtkStyleContextExterns.gtk_style_context_get_padding(context, padding);
        return context;
    }

    public static GtkStyleContextHandle GetMargin(this GtkStyleContextHandle context, GtkBorderHandle margin)
    {
        GtkStyleContextExterns.gtk_style_context_get_margin(context, margin);
        return context;
    }

    public static string ToString(this GtkStyleContextHandle context, GtkStyleContextPrintFlags flags)
    {
        return GtkStyleContextExterns.gtk_style_context_to_string(context, flags);
    }
}
