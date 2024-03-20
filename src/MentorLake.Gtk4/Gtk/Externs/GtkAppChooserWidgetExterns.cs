using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkAppChooserWidgetExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_set_show_default")]
    internal static extern void gtk_app_chooser_widget_set_show_default(this GtkAppChooserWidgetHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_get_show_default")]
    internal static extern int gtk_app_chooser_widget_get_show_default(this GtkAppChooserWidgetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_set_show_recommended")]
    internal static extern void gtk_app_chooser_widget_set_show_recommended(this GtkAppChooserWidgetHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_get_show_recommended")]
    internal static extern int gtk_app_chooser_widget_get_show_recommended(this GtkAppChooserWidgetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_set_show_fallback")]
    internal static extern void gtk_app_chooser_widget_set_show_fallback(this GtkAppChooserWidgetHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_get_show_fallback")]
    internal static extern int gtk_app_chooser_widget_get_show_fallback(this GtkAppChooserWidgetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_set_show_other")]
    internal static extern void gtk_app_chooser_widget_set_show_other(this GtkAppChooserWidgetHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_get_show_other")]
    internal static extern int gtk_app_chooser_widget_get_show_other(this GtkAppChooserWidgetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_set_show_all")]
    internal static extern void gtk_app_chooser_widget_set_show_all(this GtkAppChooserWidgetHandle self, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_get_show_all")]
    internal static extern int gtk_app_chooser_widget_get_show_all(this GtkAppChooserWidgetHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_set_default_text")]
    internal static extern void gtk_app_chooser_widget_set_default_text(this GtkAppChooserWidgetHandle self, string text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_widget_get_default_text")]
    internal static extern string gtk_app_chooser_widget_get_default_text(this GtkAppChooserWidgetHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkAppChooserWidgetHandle gtk_app_chooser_widget_new(string content_type);
}
