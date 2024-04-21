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

public class GThreadHandle : BaseSafeHandle
{
	public static GThreadHandle New(string name, GThreadFunc func, IntPtr data)
	{
		return GThreadExterns.g_thread_new(name, func, data);
	}

	public static GThreadHandle TryNew(string name, GThreadFunc func, IntPtr data, out GErrorHandle error)
	{
		return GThreadExterns.g_thread_try_new(name, func, data, out error);
	}

}

internal class GThreadExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_new(string name, GThreadFunc func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_try_new(string name, GThreadFunc func, IntPtr data, out GErrorHandle error);

}

public struct GThread
{
}
