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

public class GDBusActionGroupHandle : GObjectHandle
{
	public static GDBusActionGroupHandle GDbusActionGroupGet(GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusActionGroupExterns.g_dbus_action_group_get(connection, bus_name, object_path);
	}

}

public static class GDBusActionGroupHandleExtensions
{
}

internal class GDBusActionGroupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusActionGroupHandle g_dbus_action_group_get(GDBusConnectionHandle connection, string bus_name, string object_path);
}
