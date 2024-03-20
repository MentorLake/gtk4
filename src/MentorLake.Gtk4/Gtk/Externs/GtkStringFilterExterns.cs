using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkStringFilterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_get_search")]
	internal static extern string gtk_string_filter_get_search(this GtkStringFilterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_set_search")]
	internal static extern void gtk_string_filter_set_search(this GtkStringFilterHandle self, string search);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_get_expression")]
	internal static extern GtkExpressionHandle gtk_string_filter_get_expression(this GtkStringFilterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_set_expression")]
	internal static extern void gtk_string_filter_set_expression(this GtkStringFilterHandle self, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_get_ignore_case")]
	internal static extern int gtk_string_filter_get_ignore_case(this GtkStringFilterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_set_ignore_case")]
	internal static extern void gtk_string_filter_set_ignore_case(this GtkStringFilterHandle self, int ignore_case);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_get_match_mode")]
	internal static extern GtkStringFilterMatchMode gtk_string_filter_get_match_mode(this GtkStringFilterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_set_match_mode")]
	internal static extern void gtk_string_filter_set_match_mode(this GtkStringFilterHandle self, GtkStringFilterMatchMode mode);
}
