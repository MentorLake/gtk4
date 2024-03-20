using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDisplayManagerExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_manager_get_default_display")]
	internal static extern GdkDisplayHandle gdk_display_manager_get_default_display(this GdkDisplayManagerHandle manager);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_manager_set_default_display")]
	internal static extern void gdk_display_manager_set_default_display(this GdkDisplayManagerHandle manager, GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_manager_list_displays")]
	internal static extern GSListHandle gdk_display_manager_list_displays(this GdkDisplayManagerHandle manager);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_manager_open_display")]
	internal static extern GdkDisplayHandle gdk_display_manager_open_display(this GdkDisplayManagerHandle manager, string name);
}
