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

public class GSocketControlMessageHandle : GObjectHandle
{
	public static GSocketControlMessageHandle Deserialize(int level, int type, int size, IntPtr data)
	{
		return GSocketControlMessageExterns.g_socket_control_message_deserialize(level, type, size, data);
	}

}

public static class GSocketControlMessageHandleExtensions
{
	public static int GetLevel(this GSocketControlMessageHandle message)
	{
		return GSocketControlMessageExterns.g_socket_control_message_get_level(message);
	}

	public static int GetMsgType(this GSocketControlMessageHandle message)
	{
		return GSocketControlMessageExterns.g_socket_control_message_get_msg_type(message);
	}

	public static int GetSize(this GSocketControlMessageHandle message)
	{
		return GSocketControlMessageExterns.g_socket_control_message_get_size(message);
	}

	public static GSocketControlMessageHandle Serialize(this GSocketControlMessageHandle message, IntPtr data)
	{
		GSocketControlMessageExterns.g_socket_control_message_serialize(message, data);
		return message;
	}

}

internal class GSocketControlMessageExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_control_message_get_level(GSocketControlMessageHandle message);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_control_message_get_msg_type(GSocketControlMessageHandle message);
	[DllImport(Libraries.Gio)]
	internal static extern int g_socket_control_message_get_size(GSocketControlMessageHandle message);
	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_control_message_serialize(GSocketControlMessageHandle message, IntPtr data);
	[DllImport(Libraries.Gio)]
	internal static extern GSocketControlMessageHandle g_socket_control_message_deserialize(int level, int type, int size, IntPtr data);
}
