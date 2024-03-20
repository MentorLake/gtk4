using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPrintOperationExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_default_page_setup")]
    internal static extern void gtk_print_operation_set_default_page_setup(this GtkPrintOperationHandle op, GtkPageSetupHandle default_page_setup);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_default_page_setup")]
    internal static extern GtkPageSetupHandle gtk_print_operation_get_default_page_setup(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_print_settings")]
    internal static extern void gtk_print_operation_set_print_settings(this GtkPrintOperationHandle op, GtkPrintSettingsHandle print_settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_print_settings")]
    internal static extern GtkPrintSettingsHandle gtk_print_operation_get_print_settings(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_job_name")]
    internal static extern void gtk_print_operation_set_job_name(this GtkPrintOperationHandle op, string job_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_n_pages")]
    internal static extern void gtk_print_operation_set_n_pages(this GtkPrintOperationHandle op, int n_pages);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_current_page")]
    internal static extern void gtk_print_operation_set_current_page(this GtkPrintOperationHandle op, int current_page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_use_full_page")]
    internal static extern void gtk_print_operation_set_use_full_page(this GtkPrintOperationHandle op, int full_page);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_unit")]
    internal static extern void gtk_print_operation_set_unit(this GtkPrintOperationHandle op, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_export_filename")]
    internal static extern void gtk_print_operation_set_export_filename(this GtkPrintOperationHandle op, string filename);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_track_print_status")]
    internal static extern void gtk_print_operation_set_track_print_status(this GtkPrintOperationHandle op, int track_status);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_show_progress")]
    internal static extern void gtk_print_operation_set_show_progress(this GtkPrintOperationHandle op, int show_progress);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_allow_async")]
    internal static extern void gtk_print_operation_set_allow_async(this GtkPrintOperationHandle op, int allow_async);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_custom_tab_label")]
    internal static extern void gtk_print_operation_set_custom_tab_label(this GtkPrintOperationHandle op, string label);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_run")]
    internal static extern GtkPrintOperationResult gtk_print_operation_run(this GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_error")]
    internal static extern void gtk_print_operation_get_error(this GtkPrintOperationHandle op, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_status")]
    internal static extern GtkPrintStatus gtk_print_operation_get_status(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_status_string")]
    internal static extern string gtk_print_operation_get_status_string(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_is_finished")]
    internal static extern int gtk_print_operation_is_finished(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_cancel")]
    internal static extern void gtk_print_operation_cancel(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_draw_page_finish")]
    internal static extern void gtk_print_operation_draw_page_finish(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_defer_drawing")]
    internal static extern void gtk_print_operation_set_defer_drawing(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_support_selection")]
    internal static extern void gtk_print_operation_set_support_selection(this GtkPrintOperationHandle op, int support_selection);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_support_selection")]
    internal static extern int gtk_print_operation_get_support_selection(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_has_selection")]
    internal static extern void gtk_print_operation_set_has_selection(this GtkPrintOperationHandle op, int has_selection);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_has_selection")]
    internal static extern int gtk_print_operation_get_has_selection(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_set_embed_page_setup")]
    internal static extern void gtk_print_operation_set_embed_page_setup(this GtkPrintOperationHandle op, int embed);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_embed_page_setup")]
    internal static extern int gtk_print_operation_get_embed_page_setup(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_get_n_pages_to_print")]
    internal static extern int gtk_print_operation_get_n_pages_to_print(this GtkPrintOperationHandle op);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPrintOperationHandle gtk_print_operation_new();
}
