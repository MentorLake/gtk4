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

namespace MentorLake.Gtk4.Gdk4;

public class GdkDragSurfaceHandle  : GdkSurfaceHandle
{
}

public static class GdkDragSurfaceHandleExtensions
{
	public static bool Present(this GdkDragSurfaceHandle drag_surface, int width, int height)
	{
		return GdkDragSurfaceExterns.gdk_drag_surface_present(drag_surface, width, height);
	}

}

internal class GdkDragSurfaceExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_drag_surface_present(GdkDragSurfaceHandle drag_surface, int width, int height);
}
