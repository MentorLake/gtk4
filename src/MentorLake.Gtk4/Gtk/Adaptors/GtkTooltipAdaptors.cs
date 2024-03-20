using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTooltipAdaptors
{
    public static GtkTooltipHandle SetMarkup(this GtkTooltipHandle tooltip, string markup)
    {
        GtkTooltipExterns.gtk_tooltip_set_markup(tooltip, markup);
        return tooltip;
    }

    public static GtkTooltipHandle SetText(this GtkTooltipHandle tooltip, string text)
    {
        GtkTooltipExterns.gtk_tooltip_set_text(tooltip, text);
        return tooltip;
    }

    public static GtkTooltipHandle SetIcon(this GtkTooltipHandle tooltip, GdkPaintableHandle paintable)
    {
        GtkTooltipExterns.gtk_tooltip_set_icon(tooltip, paintable);
        return tooltip;
    }

    public static GtkTooltipHandle SetIconFromIconName(this GtkTooltipHandle tooltip, string icon_name)
    {
        GtkTooltipExterns.gtk_tooltip_set_icon_from_icon_name(tooltip, icon_name);
        return tooltip;
    }

    public static GtkTooltipHandle SetIconFromGicon(this GtkTooltipHandle tooltip, GIconHandle gicon)
    {
        GtkTooltipExterns.gtk_tooltip_set_icon_from_gicon(tooltip, gicon);
        return tooltip;
    }

    public static GtkTooltipHandle SetCustom(this GtkTooltipHandle tooltip, GtkWidgetHandle custom_widget)
    {
        GtkTooltipExterns.gtk_tooltip_set_custom(tooltip, custom_widget);
        return tooltip;
    }

    public static GtkTooltipHandle SetTipArea(this GtkTooltipHandle tooltip, GdkRectangleHandle rect)
    {
        GtkTooltipExterns.gtk_tooltip_set_tip_area(tooltip, rect);
        return tooltip;
    }
}
