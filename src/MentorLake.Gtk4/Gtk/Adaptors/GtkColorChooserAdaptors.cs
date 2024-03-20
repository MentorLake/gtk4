using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkColorChooserAdaptors
{
    public static GtkColorChooserHandle GetRgba(this GtkColorChooserHandle chooser, GdkRGBAHandle color)
    {
        GtkColorChooserExterns.gtk_color_chooser_get_rgba(chooser, color);
        return chooser;
    }

    public static GtkColorChooserHandle SetRgba(this GtkColorChooserHandle chooser, GdkRGBAHandle color)
    {
        GtkColorChooserExterns.gtk_color_chooser_set_rgba(chooser, color);
        return chooser;
    }

    public static int GetUseAlpha(this GtkColorChooserHandle chooser)
    {
        return GtkColorChooserExterns.gtk_color_chooser_get_use_alpha(chooser);
    }

    public static GtkColorChooserHandle SetUseAlpha(this GtkColorChooserHandle chooser, int use_alpha)
    {
        GtkColorChooserExterns.gtk_color_chooser_set_use_alpha(chooser, use_alpha);
        return chooser;
    }

    public static GtkColorChooserHandle AddPalette(this GtkColorChooserHandle chooser, GtkOrientation orientation, int colors_per_line, int n_colors, GdkRGBAHandle colors)
    {
        GtkColorChooserExterns.gtk_color_chooser_add_palette(chooser, orientation, colors_per_line, n_colors, colors);
        return chooser;
    }
}
