using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkStringSorterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_sorter_get_expression")]
	internal static extern GtkExpressionHandle gtk_string_sorter_get_expression(this GtkStringSorterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_sorter_set_expression")]
	internal static extern void gtk_string_sorter_set_expression(this GtkStringSorterHandle self, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_sorter_get_ignore_case")]
	internal static extern int gtk_string_sorter_get_ignore_case(this GtkStringSorterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_string_sorter_set_ignore_case")]
	internal static extern void gtk_string_sorter_set_ignore_case(this GtkStringSorterHandle self, int ignore_case);
}
