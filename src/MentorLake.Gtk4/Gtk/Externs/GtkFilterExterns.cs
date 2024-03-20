using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkFilterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_match")]
	internal static extern int gtk_filter_match(this GtkFilterHandle self, IntPtr item);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_get_strictness")]
	internal static extern GtkFilterMatch gtk_filter_get_strictness(this GtkFilterHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_filter_changed")]
	internal static extern void gtk_filter_changed(this GtkFilterHandle self, GtkFilterChange change);
}
