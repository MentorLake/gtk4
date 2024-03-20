using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkMultiFilterExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_multi_filter_append")]
	internal static extern void gtk_multi_filter_append(this GtkMultiFilterHandle self, GtkFilterHandle filter);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_multi_filter_remove")]
	internal static extern void gtk_multi_filter_remove(this GtkMultiFilterHandle self, uint position);
}
