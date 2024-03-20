using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gsk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkFixedLayoutChildExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_layout_child_set_transform")]
	internal static extern void gtk_fixed_layout_child_set_transform(this GtkFixedLayoutChildHandle child, GskTransformHandle transform);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_fixed_layout_child_get_transform")]
	internal static extern GskTransformHandle gtk_fixed_layout_child_get_transform(this GtkFixedLayoutChildHandle child);
}
