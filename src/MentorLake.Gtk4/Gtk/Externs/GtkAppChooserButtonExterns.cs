using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAppChooserButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_append_separator")]
    internal static extern void gtk_app_chooser_button_append_separator(this GtkAppChooserButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_append_custom_item")]
    internal static extern void gtk_app_chooser_button_append_custom_item(this GtkAppChooserButtonHandle self, string name, string label, GIconHandle icon);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_set_active_custom_item")]
    internal static extern void gtk_app_chooser_button_set_active_custom_item(this GtkAppChooserButtonHandle self, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_set_show_dialog_item")]
    internal static extern void gtk_app_chooser_button_set_show_dialog_item(this GtkAppChooserButtonHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_get_show_dialog_item")]
    internal static extern int gtk_app_chooser_button_get_show_dialog_item(this GtkAppChooserButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_set_heading")]
    internal static extern void gtk_app_chooser_button_set_heading(this GtkAppChooserButtonHandle self, string heading);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_get_heading")]
    internal static extern string gtk_app_chooser_button_get_heading(this GtkAppChooserButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_set_show_default_item")]
    internal static extern void gtk_app_chooser_button_set_show_default_item(this GtkAppChooserButtonHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_get_show_default_item")]
    internal static extern int gtk_app_chooser_button_get_show_default_item(this GtkAppChooserButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_get_modal")]
    internal static extern int gtk_app_chooser_button_get_modal(this GtkAppChooserButtonHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_button_set_modal")]
    internal static extern void gtk_app_chooser_button_set_modal(this GtkAppChooserButtonHandle self, int modal);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkAppChooserButtonHandle gtk_app_chooser_button_new(string content_type);
}
