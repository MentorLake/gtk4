using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWindowExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_title")]
    internal static extern void gtk_window_set_title(this GtkWindowHandle window, string title);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_title")]
    internal static extern string gtk_window_get_title(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_startup_id")]
    internal static extern void gtk_window_set_startup_id(this GtkWindowHandle window, string startup_id);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_focus")]
    internal static extern void gtk_window_set_focus(this GtkWindowHandle window, GtkWidgetHandle focus);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_focus")]
    internal static extern GtkWidgetHandle gtk_window_get_focus(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_default_widget")]
    internal static extern void gtk_window_set_default_widget(this GtkWindowHandle window, GtkWidgetHandle default_widget);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_default_widget")]
    internal static extern GtkWidgetHandle gtk_window_get_default_widget(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_transient_for")]
    internal static extern void gtk_window_set_transient_for(this GtkWindowHandle window, GtkWindowHandle parent);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_transient_for")]
    internal static extern GtkWindowHandle gtk_window_get_transient_for(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_destroy_with_parent")]
    internal static extern void gtk_window_set_destroy_with_parent(this GtkWindowHandle window, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_destroy_with_parent")]
    internal static extern int gtk_window_get_destroy_with_parent(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_hide_on_close")]
    internal static extern void gtk_window_set_hide_on_close(this GtkWindowHandle window, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_hide_on_close")]
    internal static extern int gtk_window_get_hide_on_close(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_mnemonics_visible")]
    internal static extern void gtk_window_set_mnemonics_visible(this GtkWindowHandle window, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_mnemonics_visible")]
    internal static extern int gtk_window_get_mnemonics_visible(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_focus_visible")]
    internal static extern void gtk_window_set_focus_visible(this GtkWindowHandle window, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_focus_visible")]
    internal static extern int gtk_window_get_focus_visible(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_resizable")]
    internal static extern void gtk_window_set_resizable(this GtkWindowHandle window, int resizable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_resizable")]
    internal static extern int gtk_window_get_resizable(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_display")]
    internal static extern void gtk_window_set_display(this GtkWindowHandle window, GdkDisplayHandle display);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_is_active")]
    internal static extern int gtk_window_is_active(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_decorated")]
    internal static extern void gtk_window_set_decorated(this GtkWindowHandle window, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_decorated")]
    internal static extern int gtk_window_get_decorated(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_deletable")]
    internal static extern void gtk_window_set_deletable(this GtkWindowHandle window, int setting);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_deletable")]
    internal static extern int gtk_window_get_deletable(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_icon_name")]
    internal static extern void gtk_window_set_icon_name(this GtkWindowHandle window, string name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_icon_name")]
    internal static extern string gtk_window_get_icon_name(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_modal")]
    internal static extern void gtk_window_set_modal(this GtkWindowHandle window, int modal);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_modal")]
    internal static extern int gtk_window_get_modal(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_present")]
    internal static extern void gtk_window_present(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_present_with_time")]
    internal static extern void gtk_window_present_with_time(this GtkWindowHandle window, uint timestamp);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_minimize")]
    internal static extern void gtk_window_minimize(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_unminimize")]
    internal static extern void gtk_window_unminimize(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_maximize")]
    internal static extern void gtk_window_maximize(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_unmaximize")]
    internal static extern void gtk_window_unmaximize(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_fullscreen")]
    internal static extern void gtk_window_fullscreen(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_unfullscreen")]
    internal static extern void gtk_window_unfullscreen(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_fullscreen_on_monitor")]
    internal static extern void gtk_window_fullscreen_on_monitor(this GtkWindowHandle window, GdkMonitorHandle monitor);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_close")]
    internal static extern void gtk_window_close(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_default_size")]
    internal static extern void gtk_window_set_default_size(this GtkWindowHandle window, int width, int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_default_size")]
    internal static extern void gtk_window_get_default_size(this GtkWindowHandle window, out int width, out int height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_group")]
    internal static extern GtkWindowGroupHandle gtk_window_get_group(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_has_group")]
    internal static extern int gtk_window_has_group(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_application")]
    internal static extern GtkApplicationHandle gtk_window_get_application(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_application")]
    internal static extern void gtk_window_set_application(this GtkWindowHandle window, GtkApplicationHandle application);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_child")]
    internal static extern void gtk_window_set_child(this GtkWindowHandle window, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_child")]
    internal static extern GtkWidgetHandle gtk_window_get_child(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_titlebar")]
    internal static extern void gtk_window_set_titlebar(this GtkWindowHandle window, GtkWidgetHandle titlebar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_titlebar")]
    internal static extern GtkWidgetHandle gtk_window_get_titlebar(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_is_maximized")]
    internal static extern int gtk_window_is_maximized(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_is_fullscreen")]
    internal static extern int gtk_window_is_fullscreen(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_destroy")]
    internal static extern void gtk_window_destroy(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_set_handle_menubar_accel")]
    internal static extern void gtk_window_set_handle_menubar_accel(this GtkWindowHandle window, int handle_menubar_accel);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_get_handle_menubar_accel")]
    internal static extern int gtk_window_get_handle_menubar_accel(this GtkWindowHandle window);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_show_about_dialog")]
    internal static extern void gtk_show_about_dialog(this GtkWindowHandle parent, string first_property_name, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_dialog_new")]
    internal static extern GtkAppChooserDialogHandle gtk_app_chooser_dialog_new(this GtkWindowHandle parent, GtkDialogFlags flags, GFileHandle file);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_app_chooser_dialog_new_for_content_type")]
    internal static extern GtkAppChooserDialogHandle gtk_app_chooser_dialog_new_for_content_type(this GtkWindowHandle parent, GtkDialogFlags flags, string content_type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_message_dialog_new")]
    internal static extern GtkMessageDialogHandle gtk_message_dialog_new(this GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_message_dialog_new_with_markup")]
    internal static extern GtkMessageDialogHandle gtk_message_dialog_new_with_markup(this GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_mount_operation_new")]
    internal static extern GMountOperationHandle gtk_mount_operation_new(this GtkWindowHandle parent);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_run_page_setup_dialog")]
    internal static extern GtkPageSetupHandle gtk_print_run_page_setup_dialog(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_run_page_setup_dialog_async")]
    internal static extern void gtk_print_run_page_setup_dialog_async(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings, GtkPageSetupDoneFunc done_cb, IntPtr data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_show_uri_full")]
    internal static extern void gtk_show_uri_full(this GtkWindowHandle parent, string uri, uint timestamp, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_show_uri_full_finish")]
    internal static extern int gtk_show_uri_full_finish(this GtkWindowHandle parent, GAsyncResultHandle result, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_show_uri")]
    internal static extern void gtk_show_uri(this GtkWindowHandle parent, string uri, uint timestamp);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_handle_get_child")]
    internal static extern GtkWidgetHandle gtk_window_handle_get_child(GtkWindowHandleHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_window_handle_set_child")]
    internal static extern void gtk_window_handle_set_child(GtkWindowHandleHandle self, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkWindowHandle gtk_window_new();
}
