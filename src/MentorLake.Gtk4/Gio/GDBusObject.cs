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

public interface GDBusObjectHandle
{
}

internal class GDBusObjectHandleImpl : BaseSafeHandle, GDBusObjectHandle
{
}

public static class GDBusObjectHandleExtensions
{
	public static GDBusInterfaceHandle GDbusObjectGetInterface(this GDBusObjectHandle @object, string interface_name)
	{
		return GDBusObjectExterns.g_dbus_object_get_interface(@object, interface_name);
	}

	public static GListHandle GDbusObjectGetInterfaces(this GDBusObjectHandle @object)
	{
		return GDBusObjectExterns.g_dbus_object_get_interfaces(@object);
	}

	public static string GDbusObjectGetObjectPath(this GDBusObjectHandle @object)
	{
		return GDBusObjectExterns.g_dbus_object_get_object_path(@object);
	}

}

internal class GDBusObjectExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceHandle g_dbus_object_get_interface(GDBusObjectHandle @object, string interface_name);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_dbus_object_get_interfaces(GDBusObjectHandle @object);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_object_get_object_path(GDBusObjectHandle @object);

}
