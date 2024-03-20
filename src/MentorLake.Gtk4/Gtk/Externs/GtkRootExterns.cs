using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkRootExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_root_get_display")]
	internal static extern GdkDisplayHandle gtk_root_get_display(this GtkRootHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_root_set_focus")]
	internal static extern void gtk_root_set_focus(this GtkRootHandle self, GtkWidgetHandle focus);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_root_get_focus")]
	internal static extern GtkWidgetHandle gtk_root_get_focus(this GtkRootHandle self);
}
