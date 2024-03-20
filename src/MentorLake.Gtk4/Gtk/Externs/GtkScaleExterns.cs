using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScaleExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_set_digits")]
    internal static extern void gtk_scale_set_digits(this GtkScaleHandle scale, int digits);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_get_digits")]
    internal static extern int gtk_scale_get_digits(this GtkScaleHandle scale);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_set_draw_value")]
    internal static extern void gtk_scale_set_draw_value(this GtkScaleHandle scale, int draw_value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_get_draw_value")]
    internal static extern int gtk_scale_get_draw_value(this GtkScaleHandle scale);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_set_has_origin")]
    internal static extern void gtk_scale_set_has_origin(this GtkScaleHandle scale, int has_origin);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_get_has_origin")]
    internal static extern int gtk_scale_get_has_origin(this GtkScaleHandle scale);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_set_value_pos")]
    internal static extern void gtk_scale_set_value_pos(this GtkScaleHandle scale, GtkPositionType pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_get_value_pos")]
    internal static extern GtkPositionType gtk_scale_get_value_pos(this GtkScaleHandle scale);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_get_layout")]
    internal static extern PangoLayoutHandle gtk_scale_get_layout(this GtkScaleHandle scale);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_get_layout_offsets")]
    internal static extern void gtk_scale_get_layout_offsets(this GtkScaleHandle scale, out int x, out int y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_add_mark")]
    internal static extern void gtk_scale_add_mark(this GtkScaleHandle scale, double value, GtkPositionType position, string markup);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_clear_marks")]
    internal static extern void gtk_scale_clear_marks(this GtkScaleHandle scale);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_scale_set_format_value_func")]
    internal static extern void gtk_scale_set_format_value_func(this GtkScaleHandle scale, GtkScaleFormatValueFunc func, IntPtr user_data, GDestroyNotify destroy_notify);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkScaleHandle gtk_scale_new(GtkOrientation orientation, GtkAdjustmentHandle adjustment);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkScaleHandle gtk_scale_new_with_range(GtkOrientation orientation, double min, double max, double step);
}
