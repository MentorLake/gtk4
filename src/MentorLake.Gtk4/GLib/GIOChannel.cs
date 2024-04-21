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

public class GIOChannelHandle : BaseSafeHandle
{
	public static GIOChannelHandle GIoChannelNewFile(string filename, string mode, out GErrorHandle error)
	{
		return GIOChannelExterns.g_io_channel_new_file(filename, mode, out error);
	}

	public static GIOChannelHandle GIoChannelUnixNew(int fd)
	{
		return GIOChannelExterns.g_io_channel_unix_new(fd);
	}

}

internal class GIOChannelExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GIOChannelHandle g_io_channel_new_file(string filename, string mode, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GIOChannelHandle g_io_channel_unix_new(int fd);

}

public struct GIOChannel
{
}
