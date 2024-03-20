using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDialogExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_add_action_widget")]
    internal static extern void gtk_dialog_add_action_widget(this GtkDialogHandle dialog, GtkWidgetHandle child, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_add_button")]
    internal static extern GtkWidgetHandle gtk_dialog_add_button(this GtkDialogHandle dialog, string button_text, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_add_buttons")]
    internal static extern void gtk_dialog_add_buttons(this GtkDialogHandle dialog, string first_button_text, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_set_response_sensitive")]
    internal static extern void gtk_dialog_set_response_sensitive(this GtkDialogHandle dialog, int response_id, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_set_default_response")]
    internal static extern void gtk_dialog_set_default_response(this GtkDialogHandle dialog, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_get_widget_for_response")]
    internal static extern GtkWidgetHandle gtk_dialog_get_widget_for_response(this GtkDialogHandle dialog, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_get_response_for_widget")]
    internal static extern int gtk_dialog_get_response_for_widget(this GtkDialogHandle dialog, GtkWidgetHandle widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_response")]
    internal static extern void gtk_dialog_response(this GtkDialogHandle dialog, int response_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_get_content_area")]
    internal static extern GtkWidgetHandle gtk_dialog_get_content_area(this GtkDialogHandle dialog);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_dialog_get_header_bar")]
    internal static extern GtkWidgetHandle gtk_dialog_get_header_bar(this GtkDialogHandle dialog);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDialogHandle gtk_dialog_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkDialogHandle gtk_dialog_new_with_buttons(string title, GtkWindowHandle parent, GtkDialogFlags flags, string first_button_text, IntPtr @__arglist);
}
