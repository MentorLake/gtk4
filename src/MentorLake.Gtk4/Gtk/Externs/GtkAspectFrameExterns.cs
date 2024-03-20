using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAspectFrameExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_set_xalign")]
    internal static extern void gtk_aspect_frame_set_xalign(this GtkAspectFrameHandle self, float xalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_get_xalign")]
    internal static extern float gtk_aspect_frame_get_xalign(this GtkAspectFrameHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_set_yalign")]
    internal static extern void gtk_aspect_frame_set_yalign(this GtkAspectFrameHandle self, float yalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_get_yalign")]
    internal static extern float gtk_aspect_frame_get_yalign(this GtkAspectFrameHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_set_ratio")]
    internal static extern void gtk_aspect_frame_set_ratio(this GtkAspectFrameHandle self, float ratio);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_get_ratio")]
    internal static extern float gtk_aspect_frame_get_ratio(this GtkAspectFrameHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_set_obey_child")]
    internal static extern void gtk_aspect_frame_set_obey_child(this GtkAspectFrameHandle self, int obey_child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_get_obey_child")]
    internal static extern int gtk_aspect_frame_get_obey_child(this GtkAspectFrameHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_set_child")]
    internal static extern void gtk_aspect_frame_set_child(this GtkAspectFrameHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_aspect_frame_get_child")]
    internal static extern GtkWidgetHandle gtk_aspect_frame_get_child(this GtkAspectFrameHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkAspectFrameHandle gtk_aspect_frame_new(float xalign, float yalign, float ratio, int obey_child);
}
