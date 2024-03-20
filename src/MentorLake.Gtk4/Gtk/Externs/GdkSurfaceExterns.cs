using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GdkSurfaceExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_get_for_surface")]
	internal static extern GtkNativeHandle gtk_native_get_for_surface(this GdkSurfaceHandle surface);
}
