using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFrameExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_set_label")]
    internal static extern void gtk_frame_set_label(this GtkFrameHandle frame, string label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_get_label")]
    internal static extern string gtk_frame_get_label(this GtkFrameHandle frame);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_set_label_widget")]
    internal static extern void gtk_frame_set_label_widget(this GtkFrameHandle frame, GtkWidgetHandle label_widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_get_label_widget")]
    internal static extern GtkWidgetHandle gtk_frame_get_label_widget(this GtkFrameHandle frame);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_set_label_align")]
    internal static extern void gtk_frame_set_label_align(this GtkFrameHandle frame, float xalign);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_get_label_align")]
    internal static extern float gtk_frame_get_label_align(this GtkFrameHandle frame);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_set_child")]
    internal static extern void gtk_frame_set_child(this GtkFrameHandle frame, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_frame_get_child")]
    internal static extern GtkWidgetHandle gtk_frame_get_child(this GtkFrameHandle frame);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkFrameHandle gtk_frame_new(string label);
}
