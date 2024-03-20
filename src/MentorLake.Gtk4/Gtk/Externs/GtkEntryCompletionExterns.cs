using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEntryCompletionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_entry")]
    internal static extern GtkWidgetHandle gtk_entry_completion_get_entry(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_model")]
    internal static extern void gtk_entry_completion_set_model(this GtkEntryCompletionHandle completion, GtkTreeModelHandle model);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_model")]
    internal static extern GtkTreeModelHandle gtk_entry_completion_get_model(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_match_func")]
    internal static extern void gtk_entry_completion_set_match_func(this GtkEntryCompletionHandle completion, GtkEntryCompletionMatchFunc func, IntPtr func_data, GDestroyNotify func_notify);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_minimum_key_length")]
    internal static extern void gtk_entry_completion_set_minimum_key_length(this GtkEntryCompletionHandle completion, int length);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_minimum_key_length")]
    internal static extern int gtk_entry_completion_get_minimum_key_length(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_compute_prefix")]
    internal static extern string gtk_entry_completion_compute_prefix(this GtkEntryCompletionHandle completion, string key);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_complete")]
    internal static extern void gtk_entry_completion_complete(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_insert_prefix")]
    internal static extern void gtk_entry_completion_insert_prefix(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_inline_completion")]
    internal static extern void gtk_entry_completion_set_inline_completion(this GtkEntryCompletionHandle completion, int inline_completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_inline_completion")]
    internal static extern int gtk_entry_completion_get_inline_completion(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_inline_selection")]
    internal static extern void gtk_entry_completion_set_inline_selection(this GtkEntryCompletionHandle completion, int inline_selection);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_inline_selection")]
    internal static extern int gtk_entry_completion_get_inline_selection(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_popup_completion")]
    internal static extern void gtk_entry_completion_set_popup_completion(this GtkEntryCompletionHandle completion, int popup_completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_popup_completion")]
    internal static extern int gtk_entry_completion_get_popup_completion(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_popup_set_width")]
    internal static extern void gtk_entry_completion_set_popup_set_width(this GtkEntryCompletionHandle completion, int popup_set_width);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_popup_set_width")]
    internal static extern int gtk_entry_completion_get_popup_set_width(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_popup_single_match")]
    internal static extern void gtk_entry_completion_set_popup_single_match(this GtkEntryCompletionHandle completion, int popup_single_match);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_popup_single_match")]
    internal static extern int gtk_entry_completion_get_popup_single_match(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_completion_prefix")]
    internal static extern string gtk_entry_completion_get_completion_prefix(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_set_text_column")]
    internal static extern void gtk_entry_completion_set_text_column(this GtkEntryCompletionHandle completion, int column);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_entry_completion_get_text_column")]
    internal static extern int gtk_entry_completion_get_text_column(this GtkEntryCompletionHandle completion);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEntryCompletionHandle gtk_entry_completion_new();
}
