using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGLAreaExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_set_use_es")]
    internal static extern void gtk_gl_area_set_use_es(this GtkGLAreaHandle area, int use_es);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_get_use_es")]
    internal static extern int gtk_gl_area_get_use_es(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_set_required_version")]
    internal static extern void gtk_gl_area_set_required_version(this GtkGLAreaHandle area, int major, int minor);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_get_required_version")]
    internal static extern void gtk_gl_area_get_required_version(this GtkGLAreaHandle area, out int major, out int minor);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_get_has_depth_buffer")]
    internal static extern int gtk_gl_area_get_has_depth_buffer(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_set_has_depth_buffer")]
    internal static extern void gtk_gl_area_set_has_depth_buffer(this GtkGLAreaHandle area, int has_depth_buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_get_has_stencil_buffer")]
    internal static extern int gtk_gl_area_get_has_stencil_buffer(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_set_has_stencil_buffer")]
    internal static extern void gtk_gl_area_set_has_stencil_buffer(this GtkGLAreaHandle area, int has_stencil_buffer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_get_auto_render")]
    internal static extern int gtk_gl_area_get_auto_render(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_set_auto_render")]
    internal static extern void gtk_gl_area_set_auto_render(this GtkGLAreaHandle area, int auto_render);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_queue_render")]
    internal static extern void gtk_gl_area_queue_render(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_get_context")]
    internal static extern GdkGLContextHandle gtk_gl_area_get_context(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_make_current")]
    internal static extern void gtk_gl_area_make_current(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_attach_buffers")]
    internal static extern void gtk_gl_area_attach_buffers(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_set_error")]
    internal static extern void gtk_gl_area_set_error(this GtkGLAreaHandle area, GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gl_area_get_error")]
    internal static extern GErrorHandle gtk_gl_area_get_error(this GtkGLAreaHandle area);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGLAreaHandle gtk_gl_area_new();
}
