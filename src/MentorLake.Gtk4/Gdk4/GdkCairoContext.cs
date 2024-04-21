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

public class GdkCairoContextHandle : GdkDrawContextHandle
{
}

public static class GdkCairoContextHandleExtensions
{
	public static cairo_tHandle CairoCreate(this GdkCairoContextHandle self)
	{
		return GdkCairoContextExterns.gdk_cairo_context_cairo_create(self);
	}

}

internal class GdkCairoContextExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_tHandle gdk_cairo_context_cairo_create(GdkCairoContextHandle self);

}
