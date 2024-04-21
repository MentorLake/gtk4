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

public interface GDBusInterfaceHandle
{
}

public static class GDBusInterfaceHandleExtensions
{
	public static GDBusObjectHandle GDbusInterfaceDupObject(this GDBusInterfaceHandle interface_)
	{
		return GDBusInterfaceExterns.g_dbus_interface_dup_object(interface_);
	}

	public static GDBusInterfaceInfoHandle GDbusInterfaceGetInfo(this GDBusInterfaceHandle interface_)
	{
		return GDBusInterfaceExterns.g_dbus_interface_get_info(interface_);
	}

	public static GDBusObjectHandle GDbusInterfaceGetObject(this GDBusInterfaceHandle interface_)
	{
		return GDBusInterfaceExterns.g_dbus_interface_get_object(interface_);
	}

	public static GDBusInterfaceHandle GDbusInterfaceSetObject(this GDBusInterfaceHandle interface_, GDBusObjectHandle @object)
	{
		GDBusInterfaceExterns.g_dbus_interface_set_object(interface_, @object);
		return interface_;
	}

}

internal class GDBusInterfaceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectHandle g_dbus_interface_dup_object(GDBusInterfaceHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceInfoHandle g_dbus_interface_get_info(GDBusInterfaceHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectHandle g_dbus_interface_get_object(GDBusInterfaceHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_set_object(GDBusInterfaceHandle interface_, GDBusObjectHandle @object);

}
