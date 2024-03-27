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

public class GBytesIconHandle : GObjectHandle
{
	public static GBytesIconHandle New(GBytesHandle bytes)
	{
		return GBytesIconExterns.g_bytes_icon_new(bytes);
	}
}

public static class GBytesIconSignals
{
}

public static class GBytesIconHandleExtensions
{
	public static GBytesHandle GetBytes(this GBytesIconHandle icon)
	{
		return GBytesIconExterns.g_bytes_icon_get_bytes(icon);
	}

}

internal class GBytesIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_bytes_icon_get_bytes(GBytesIconHandle icon);
	[DllImport(Libraries.Gio)]
	internal static extern GBytesIconHandle g_bytes_icon_new(GBytesHandle bytes);
}
