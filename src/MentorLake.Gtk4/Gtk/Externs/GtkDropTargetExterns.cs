using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDropTargetExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_set_gtypes")]
    internal static extern void gtk_drop_target_set_gtypes(this GtkDropTargetHandle self, GTypeHandle types, nuint n_types);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_get_gtypes")]
    internal static extern GTypeHandle gtk_drop_target_get_gtypes(this GtkDropTargetHandle self, out nuint n_types);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_get_formats")]
    internal static extern GdkContentFormatsHandle gtk_drop_target_get_formats(this GtkDropTargetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_set_actions")]
    internal static extern void gtk_drop_target_set_actions(this GtkDropTargetHandle self, GdkDragAction actions);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_get_actions")]
    internal static extern GdkDragAction gtk_drop_target_get_actions(this GtkDropTargetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_set_preload")]
    internal static extern void gtk_drop_target_set_preload(this GtkDropTargetHandle self, int preload);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_get_preload")]
    internal static extern int gtk_drop_target_get_preload(this GtkDropTargetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_get_drop")]
    internal static extern GdkDropHandle gtk_drop_target_get_drop(this GtkDropTargetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_get_current_drop")]
    internal static extern GdkDropHandle gtk_drop_target_get_current_drop(this GtkDropTargetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_get_value")]
    internal static extern GValueHandle gtk_drop_target_get_value(this GtkDropTargetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_drop_target_reject")]
    internal static extern void gtk_drop_target_reject(this GtkDropTargetHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDropTargetHandle gtk_drop_target_new(GType type, GdkDragAction actions);
}
