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

namespace MentorLake.Gtk4.Gio;

public interface GDebugControllerHandle
{
}

public static class GDebugControllerHandleExtensions
{
	public static bool GetDebugEnabled(this GDebugControllerHandle self)
	{
		return GDebugControllerExterns.g_debug_controller_get_debug_enabled(self);
	}

	public static GDebugControllerHandle SetDebugEnabled(this GDebugControllerHandle self, bool debug_enabled)
	{
		GDebugControllerExterns.g_debug_controller_set_debug_enabled(self, debug_enabled);
		return self;
	}

}

internal class GDebugControllerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_debug_controller_get_debug_enabled(GDebugControllerHandle self);
	[DllImport(Libraries.Gio)]
	internal static extern void g_debug_controller_set_debug_enabled(GDebugControllerHandle self, bool debug_enabled);
}
