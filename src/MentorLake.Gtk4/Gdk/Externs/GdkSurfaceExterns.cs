using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkSurfaceExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_drag_begin")]
    internal static extern GdkDragHandle gdk_drag_begin(this GdkSurfaceHandle surface, GdkDeviceHandle device, GdkContentProviderHandle content, GdkDragAction actions, double dx, double dy);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_new_popup")]
    internal static extern GdkSurfaceHandle gdk_surface_new_popup(this GdkSurfaceHandle parent, int autohide);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_destroy")]
    internal static extern void gdk_surface_destroy(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_is_destroyed")]
    internal static extern int gdk_surface_is_destroyed(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_display")]
    internal static extern GdkDisplayHandle gdk_surface_get_display(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_hide")]
    internal static extern void gdk_surface_hide(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_set_input_region")]
    internal static extern void gdk_surface_set_input_region(this GdkSurfaceHandle surface, cairo_regionHandle region);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_mapped")]
    internal static extern int gdk_surface_get_mapped(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_set_cursor")]
    internal static extern void gdk_surface_set_cursor(this GdkSurfaceHandle surface, GdkCursorHandle cursor);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_cursor")]
    internal static extern GdkCursorHandle gdk_surface_get_cursor(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_set_device_cursor")]
    internal static extern void gdk_surface_set_device_cursor(this GdkSurfaceHandle surface, GdkDeviceHandle device, GdkCursorHandle cursor);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_device_cursor")]
    internal static extern GdkCursorHandle gdk_surface_get_device_cursor(this GdkSurfaceHandle surface, GdkDeviceHandle device);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_width")]
    internal static extern int gdk_surface_get_width(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_height")]
    internal static extern int gdk_surface_get_height(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_translate_coordinates")]
    internal static extern int gdk_surface_translate_coordinates(this GdkSurfaceHandle from, GdkSurfaceHandle to, ref double x, ref double y);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_scale_factor")]
    internal static extern int gdk_surface_get_scale_factor(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_device_position")]
    internal static extern int gdk_surface_get_device_position(this GdkSurfaceHandle surface, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_create_similar_surface")]
    internal static extern cairo_surfaceHandle gdk_surface_create_similar_surface(this GdkSurfaceHandle surface, _cairo_content content, int width, int height);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_beep")]
    internal static extern void gdk_surface_beep(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_queue_render")]
    internal static extern void gdk_surface_queue_render(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_request_layout")]
    internal static extern void gdk_surface_request_layout(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_get_frame_clock")]
    internal static extern GdkFrameClockHandle gdk_surface_get_frame_clock(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_set_opaque_region")]
    internal static extern void gdk_surface_set_opaque_region(this GdkSurfaceHandle surface, cairo_regionHandle region);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_create_cairo_context")]
    internal static extern GdkCairoContextHandle gdk_surface_create_cairo_context(this GdkSurfaceHandle surface);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_create_gl_context")]
    internal static extern GdkGLContextHandle gdk_surface_create_gl_context(this GdkSurfaceHandle surface, out GErrorHandle error);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_surface_create_vulkan_context")]
    internal static extern GdkVulkanContextHandle gdk_surface_create_vulkan_context(this GdkSurfaceHandle surface, out GErrorHandle error);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkSurfaceHandle gdk_surface_new_toplevel(GdkDisplayHandle display);
}
