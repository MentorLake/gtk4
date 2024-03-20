using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextChildAnchorExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_child_anchor_get_widgets")]
    internal static extern GtkWidgetHandle[] gtk_text_child_anchor_get_widgets(this GtkTextChildAnchorHandle anchor, out uint out_len);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_text_child_anchor_get_deleted")]
    internal static extern int gtk_text_child_anchor_get_deleted(this GtkTextChildAnchorHandle anchor);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTextChildAnchorHandle gtk_text_child_anchor_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTextChildAnchorHandle gtk_text_child_anchor_new_with_replacement(string character);
}
