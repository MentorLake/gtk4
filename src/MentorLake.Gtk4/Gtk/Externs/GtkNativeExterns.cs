using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gsk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkNativeExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_realize")]
	internal static extern void gtk_native_realize(this GtkNativeHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_unrealize")]
	internal static extern void gtk_native_unrealize(this GtkNativeHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_get_surface")]
	internal static extern GdkSurfaceHandle gtk_native_get_surface(this GtkNativeHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_get_renderer")]
	internal static extern GskRendererHandle gtk_native_get_renderer(this GtkNativeHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_native_get_surface_transform")]
	internal static extern void gtk_native_get_surface_transform(this GtkNativeHandle self, out double x, out double y);
}
