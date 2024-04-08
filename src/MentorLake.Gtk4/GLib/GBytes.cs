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

public class GBytesHandle : BaseSafeHandle
{
	public static GBytesHandle New(IntPtr data, int size)
	{
		return GBytesExterns.g_bytes_new(data, size);
	}

	public static GBytesHandle NewStatic(IntPtr data, int size)
	{
		return GBytesExterns.g_bytes_new_static(data, size);
	}

	public static GBytesHandle NewTake(IntPtr data, int size)
	{
		return GBytesExterns.g_bytes_new_take(data, size);
	}

	public static GBytesHandle NewWithFreeFunc(IntPtr data, int size, GDestroyNotify free_func, IntPtr user_data)
	{
		return GBytesExterns.g_bytes_new_with_free_func(data, size, free_func, user_data);
	}

}

internal class GBytesExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new(IntPtr data, int size);
	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new_static(IntPtr data, int size);
	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new_take(IntPtr data, int size);
	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_bytes_new_with_free_func(IntPtr data, int size, GDestroyNotify free_func, IntPtr user_data);
}

public struct GBytes
{
}
