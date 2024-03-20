using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkOrientableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_orientable_set_orientation")]
	internal static extern void gtk_orientable_set_orientation(this GtkOrientableHandle orientable, GtkOrientation orientation);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_orientable_get_orientation")]
	internal static extern GtkOrientation gtk_orientable_get_orientation(this GtkOrientableHandle orientable);
}
