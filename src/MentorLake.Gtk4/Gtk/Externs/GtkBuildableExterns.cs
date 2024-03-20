using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkBuildableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_buildable_get_buildable_id")]
	internal static extern string gtk_buildable_get_buildable_id(this GtkBuildableHandle buildable);
}
