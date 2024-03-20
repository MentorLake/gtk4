using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDrawingAreaExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drawing_area_set_content_width")]
    internal static extern void gtk_drawing_area_set_content_width(this GtkDrawingAreaHandle self, int width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drawing_area_get_content_width")]
    internal static extern int gtk_drawing_area_get_content_width(this GtkDrawingAreaHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drawing_area_set_content_height")]
    internal static extern void gtk_drawing_area_set_content_height(this GtkDrawingAreaHandle self, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drawing_area_get_content_height")]
    internal static extern int gtk_drawing_area_get_content_height(this GtkDrawingAreaHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drawing_area_set_draw_func")]
    internal static extern void gtk_drawing_area_set_draw_func(this GtkDrawingAreaHandle self, GtkDrawingAreaDrawFunc draw_func, IntPtr user_data, GDestroyNotify destroy);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDrawingAreaHandle gtk_drawing_area_new();
}
