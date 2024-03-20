using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkInfoBarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_add_action_widget")]
    internal static extern void gtk_info_bar_add_action_widget(this GtkInfoBarHandle info_bar, GtkWidgetHandle child, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_remove_action_widget")]
    internal static extern void gtk_info_bar_remove_action_widget(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_add_button")]
    internal static extern GtkWidgetHandle gtk_info_bar_add_button(this GtkInfoBarHandle info_bar, string button_text, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_add_buttons")]
    internal static extern void gtk_info_bar_add_buttons(this GtkInfoBarHandle info_bar, string first_button_text, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_add_child")]
    internal static extern void gtk_info_bar_add_child(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_remove_child")]
    internal static extern void gtk_info_bar_remove_child(this GtkInfoBarHandle info_bar, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_set_response_sensitive")]
    internal static extern void gtk_info_bar_set_response_sensitive(this GtkInfoBarHandle info_bar, int response_id, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_set_default_response")]
    internal static extern void gtk_info_bar_set_default_response(this GtkInfoBarHandle info_bar, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_response")]
    internal static extern void gtk_info_bar_response(this GtkInfoBarHandle info_bar, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_set_message_type")]
    internal static extern void gtk_info_bar_set_message_type(this GtkInfoBarHandle info_bar, GtkMessageType message_type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_get_message_type")]
    internal static extern GtkMessageType gtk_info_bar_get_message_type(this GtkInfoBarHandle info_bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_set_show_close_button")]
    internal static extern void gtk_info_bar_set_show_close_button(this GtkInfoBarHandle info_bar, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_get_show_close_button")]
    internal static extern int gtk_info_bar_get_show_close_button(this GtkInfoBarHandle info_bar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_set_revealed")]
    internal static extern void gtk_info_bar_set_revealed(this GtkInfoBarHandle info_bar, int revealed);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_info_bar_get_revealed")]
    internal static extern int gtk_info_bar_get_revealed(this GtkInfoBarHandle info_bar);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkInfoBarHandle gtk_info_bar_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkInfoBarHandle gtk_info_bar_new_with_buttons(string first_button_text, IntPtr @__arglist);
}
