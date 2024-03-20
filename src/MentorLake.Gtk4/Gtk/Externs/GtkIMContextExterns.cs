using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIMContextExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_set_client_widget")]
    internal static extern void gtk_im_context_set_client_widget(this GtkIMContextHandle context, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_get_preedit_string")]
    internal static extern void gtk_im_context_get_preedit_string(this GtkIMContextHandle context, string[] str, out PangoAttrListHandle attrs, out int cursor_pos);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_filter_keypress")]
    internal static extern int gtk_im_context_filter_keypress(this GtkIMContextHandle context, GdkEventHandle @event);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_filter_key")]
    internal static extern int gtk_im_context_filter_key(this GtkIMContextHandle context, int press, GdkSurfaceHandle surface, GdkDeviceHandle device, uint time, uint keycode, GdkModifierType state, int group);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_focus_in")]
    internal static extern void gtk_im_context_focus_in(this GtkIMContextHandle context);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_focus_out")]
    internal static extern void gtk_im_context_focus_out(this GtkIMContextHandle context);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_reset")]
    internal static extern void gtk_im_context_reset(this GtkIMContextHandle context);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_set_cursor_location")]
    internal static extern void gtk_im_context_set_cursor_location(this GtkIMContextHandle context, GdkRectangleHandle area);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_set_use_preedit")]
    internal static extern void gtk_im_context_set_use_preedit(this GtkIMContextHandle context, int use_preedit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_set_surrounding")]
    [Obsolete]
    internal static extern void gtk_im_context_set_surrounding(this GtkIMContextHandle context, string text, int len, int cursor_index);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_get_surrounding")]
    [Obsolete]
    internal static extern int gtk_im_context_get_surrounding(this GtkIMContextHandle context, string[] text, out int cursor_index);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_set_surrounding_with_selection")]
    internal static extern void gtk_im_context_set_surrounding_with_selection(this GtkIMContextHandle context, string text, int len, int cursor_index, int anchor_index);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_get_surrounding_with_selection")]
    internal static extern int gtk_im_context_get_surrounding_with_selection(this GtkIMContextHandle context, string[] text, out int cursor_index, out int anchor_index);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_delete_surrounding")]
    internal static extern int gtk_im_context_delete_surrounding(this GtkIMContextHandle context, int offset, int n_chars);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkIMContextHandle gtk_im_context_simple_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkIMContextHandle gtk_im_multicontext_new();
}
