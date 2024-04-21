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

namespace MentorLake.Gtk4.GLib;

public class GMainContextHandle : BaseSafeHandle
{
	public static GMainContextHandle New()
	{
		return GMainContextExterns.g_main_context_new();
	}

	public static GMainContextHandle NewWithFlags(GMainContextFlags flags)
	{
		return GMainContextExterns.g_main_context_new_with_flags(flags);
	}

}

internal class GMainContextExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_context_new();

	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_context_new_with_flags(GMainContextFlags flags);

}

public struct GMainContext
{
}
