using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkToplevelLayoutExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_ref")]
    internal static extern GdkToplevelLayoutHandle gdk_toplevel_layout_ref(this GdkToplevelLayoutHandle layout);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_unref")]
    internal static extern void gdk_toplevel_layout_unref(this GdkToplevelLayoutHandle layout);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_copy")]
    internal static extern GdkToplevelLayoutHandle gdk_toplevel_layout_copy(this GdkToplevelLayoutHandle layout);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_equal")]
    internal static extern int gdk_toplevel_layout_equal(this GdkToplevelLayoutHandle layout, GdkToplevelLayoutHandle other);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_set_maximized")]
    internal static extern void gdk_toplevel_layout_set_maximized(this GdkToplevelLayoutHandle layout, int maximized);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_set_fullscreen")]
    internal static extern void gdk_toplevel_layout_set_fullscreen(this GdkToplevelLayoutHandle layout, int fullscreen, GdkMonitorHandle monitor);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_get_maximized")]
    internal static extern int gdk_toplevel_layout_get_maximized(this GdkToplevelLayoutHandle layout, out bool maximized);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_get_fullscreen")]
    internal static extern int gdk_toplevel_layout_get_fullscreen(this GdkToplevelLayoutHandle layout, out bool fullscreen);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_get_fullscreen_monitor")]
    internal static extern GdkMonitorHandle gdk_toplevel_layout_get_fullscreen_monitor(this GdkToplevelLayoutHandle layout);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_set_resizable")]
    internal static extern void gdk_toplevel_layout_set_resizable(this GdkToplevelLayoutHandle layout, int resizable);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_toplevel_layout_get_resizable")]
    internal static extern int gdk_toplevel_layout_get_resizable(this GdkToplevelLayoutHandle layout);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkToplevelLayoutHandle gdk_toplevel_layout_new();
}
