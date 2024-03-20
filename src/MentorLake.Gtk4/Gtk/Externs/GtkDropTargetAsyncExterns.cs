using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDropTargetAsyncExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_async_set_formats")]
    internal static extern void gtk_drop_target_async_set_formats(this GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_async_get_formats")]
    internal static extern GdkContentFormatsHandle gtk_drop_target_async_get_formats(this GtkDropTargetAsyncHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_async_set_actions")]
    internal static extern void gtk_drop_target_async_set_actions(this GtkDropTargetAsyncHandle self, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_async_get_actions")]
    internal static extern GdkDragAction gtk_drop_target_async_get_actions(this GtkDropTargetAsyncHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_async_reject_drop")]
    internal static extern void gtk_drop_target_async_reject_drop(this GtkDropTargetAsyncHandle self, GdkDropHandle drop);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDropTargetAsyncHandle gtk_drop_target_async_new(GdkContentFormatsHandle formats, GdkDragAction actions);
}
