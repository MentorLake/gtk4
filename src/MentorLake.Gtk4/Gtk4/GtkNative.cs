using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public interface GtkNativeHandle
{
}

internal class GtkNativeHandleImpl : BaseSafeHandle, GtkNativeHandle
{
}

public static class GtkNativeHandleExtensions
{
	public static GskRendererHandle GetRenderer(this GtkNativeHandle self)
	{
		return GtkNativeExterns.gtk_native_get_renderer(self);
	}

	public static GdkSurfaceHandle GetSurface(this GtkNativeHandle self)
	{
		return GtkNativeExterns.gtk_native_get_surface(self);
	}

	public static GtkNativeHandle GetSurfaceTransform(this GtkNativeHandle self, out double x, out double y)
	{
		GtkNativeExterns.gtk_native_get_surface_transform(self, out x, out y);
		return self;
	}

	public static GtkNativeHandle Realize(this GtkNativeHandle self)
	{
		GtkNativeExterns.gtk_native_realize(self);
		return self;
	}

	public static GtkNativeHandle Unrealize(this GtkNativeHandle self)
	{
		GtkNativeExterns.gtk_native_unrealize(self);
		return self;
	}

}

internal class GtkNativeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GskRendererHandle gtk_native_get_renderer(GtkNativeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkSurfaceHandle gtk_native_get_surface(GtkNativeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_get_surface_transform(GtkNativeHandle self, out double x, out double y);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_realize(GtkNativeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_native_unrealize(GtkNativeHandle self);

}
