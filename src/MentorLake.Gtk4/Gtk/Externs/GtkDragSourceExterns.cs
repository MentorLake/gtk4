using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDragSourceExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_source_set_content")]
    internal static extern void gtk_drag_source_set_content(this GtkDragSourceHandle source, GdkContentProviderHandle content);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_source_get_content")]
    internal static extern GdkContentProviderHandle gtk_drag_source_get_content(this GtkDragSourceHandle source);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_source_set_actions")]
    internal static extern void gtk_drag_source_set_actions(this GtkDragSourceHandle source, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_source_get_actions")]
    internal static extern GdkDragAction gtk_drag_source_get_actions(this GtkDragSourceHandle source);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_source_set_icon")]
    internal static extern void gtk_drag_source_set_icon(this GtkDragSourceHandle source, GdkPaintableHandle paintable, int hot_x, int hot_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_source_drag_cancel")]
    internal static extern void gtk_drag_source_drag_cancel(this GtkDragSourceHandle source);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_source_get_drag")]
    internal static extern GdkDragHandle gtk_drag_source_get_drag(this GtkDragSourceHandle source);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDragSourceHandle gtk_drag_source_new();
}
