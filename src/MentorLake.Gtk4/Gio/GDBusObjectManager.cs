using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public interface GDBusObjectManagerHandle
{
}

internal class GDBusObjectManagerHandleImpl : BaseSafeHandle, GDBusObjectManagerHandle
{
}

public static class GDBusObjectManagerHandleExtensions
{
	public static GDBusInterfaceHandle GDbusObjectManagerGetInterface(this GDBusObjectManagerHandle manager, string object_path, string interface_name)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_interface(manager, object_path, interface_name);
	}

	public static GDBusObjectHandle GDbusObjectManagerGetObject(this GDBusObjectManagerHandle manager, string object_path)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_object(manager, object_path);
	}

	public static string GDbusObjectManagerGetObjectPath(this GDBusObjectManagerHandle manager)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_object_path(manager);
	}

	public static GListHandle GDbusObjectManagerGetObjects(this GDBusObjectManagerHandle manager)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_objects(manager);
	}

}

internal class GDBusObjectManagerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceHandle g_dbus_object_manager_get_interface(GDBusObjectManagerHandle manager, string object_path, string interface_name);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectHandle g_dbus_object_manager_get_object(GDBusObjectManagerHandle manager, string object_path);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_object_manager_get_object_path(GDBusObjectManagerHandle manager);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_dbus_object_manager_get_objects(GDBusObjectManagerHandle manager);

}
