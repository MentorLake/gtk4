using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkBuildableParseContextExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_buildable_parse_context_push")]
	internal static extern void gtk_buildable_parse_context_push(this GtkBuildableParseContextHandle context, GtkBuildableParserHandle parser, IntPtr user_data);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_buildable_parse_context_pop")]
	internal static extern IntPtr gtk_buildable_parse_context_pop(this GtkBuildableParseContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_buildable_parse_context_get_element")]
	internal static extern string gtk_buildable_parse_context_get_element(this GtkBuildableParseContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_buildable_parse_context_get_element_stack")]
	internal static extern GPtrArrayHandle gtk_buildable_parse_context_get_element_stack(this GtkBuildableParseContextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_buildable_parse_context_get_position")]
	internal static extern void gtk_buildable_parse_context_get_position(this GtkBuildableParseContextHandle context, out int line_number, out int char_number);
}
