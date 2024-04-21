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

public class GNativeSocketAddressHandle : GSocketAddressHandle, GSocketConnectableHandle
{
	public static GNativeSocketAddressHandle New(IntPtr native, int len)
	{
		return GNativeSocketAddressExterns.g_native_socket_address_new(native, len);
	}

}

public static class GNativeSocketAddressHandleExtensions
{
}

internal class GNativeSocketAddressExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GNativeSocketAddressHandle g_native_socket_address_new(IntPtr native, int len);

}
