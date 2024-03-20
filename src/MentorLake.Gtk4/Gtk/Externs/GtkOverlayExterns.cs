using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkOverlayExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_add_overlay")]
    internal static extern void gtk_overlay_add_overlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_remove_overlay")]
    internal static extern void gtk_overlay_remove_overlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_set_child")]
    internal static extern void gtk_overlay_set_child(this GtkOverlayHandle overlay, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_get_child")]
    internal static extern GtkWidgetHandle gtk_overlay_get_child(this GtkOverlayHandle overlay);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_get_measure_overlay")]
    internal static extern int gtk_overlay_get_measure_overlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_set_measure_overlay")]
    internal static extern void gtk_overlay_set_measure_overlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget, int measure);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_get_clip_overlay")]
    internal static extern int gtk_overlay_get_clip_overlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_overlay_set_clip_overlay")]
    internal static extern void gtk_overlay_set_clip_overlay(this GtkOverlayHandle overlay, GtkWidgetHandle widget, int clip_overlay);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkOverlayHandle gtk_overlay_new();
}
