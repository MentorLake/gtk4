using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkBoolFilterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bool_filter_get_expression")]
	internal static extern GtkExpressionHandle gtk_bool_filter_get_expression(this GtkBoolFilterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bool_filter_set_expression")]
	internal static extern void gtk_bool_filter_set_expression(this GtkBoolFilterHandle self, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bool_filter_get_invert")]
	internal static extern int gtk_bool_filter_get_invert(this GtkBoolFilterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_bool_filter_set_invert")]
	internal static extern void gtk_bool_filter_set_invert(this GtkBoolFilterHandle self, int invert);
}
