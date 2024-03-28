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

public class GTestDBusHandle : GObjectHandle
{
	public static GTestDBusHandle GTestDbusNew(GTestDBusFlags flags)
	{
		return GTestDBusExterns.g_test_dbus_new(flags);
	}
}

public static class GTestDBusSignals
{
}

public static class GTestDBusHandleExtensions
{
	public static GTestDBusHandle GTestDbusAddServiceDir(this GTestDBusHandle self, string path)
	{
		GTestDBusExterns.g_test_dbus_add_service_dir(self, path);
		return self;
	}

	public static GTestDBusHandle GTestDbusDown(this GTestDBusHandle self)
	{
		GTestDBusExterns.g_test_dbus_down(self);
		return self;
	}

	public static string GTestDbusGetBusAddress(this GTestDBusHandle self)
	{
		return GTestDBusExterns.g_test_dbus_get_bus_address(self);
	}

	public static GTestDBusFlags GTestDbusGetFlags(this GTestDBusHandle self)
	{
		return GTestDBusExterns.g_test_dbus_get_flags(self);
	}

	public static GTestDBusHandle GTestDbusStop(this GTestDBusHandle self)
	{
		GTestDBusExterns.g_test_dbus_stop(self);
		return self;
	}

	public static GTestDBusHandle GTestDbusUp(this GTestDBusHandle self)
	{
		GTestDBusExterns.g_test_dbus_up(self);
		return self;
	}

	public static void GTestDbusUnset()
	{
		GTestDBusExterns.g_test_dbus_unset();
	}

}

internal class GTestDBusExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_add_service_dir(GTestDBusHandle self, string path);
	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_down(GTestDBusHandle self);
	[DllImport(Libraries.Gio)]
	internal static extern string g_test_dbus_get_bus_address(GTestDBusHandle self);
	[DllImport(Libraries.Gio)]
	internal static extern GTestDBusFlags g_test_dbus_get_flags(GTestDBusHandle self);
	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_stop(GTestDBusHandle self);
	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_up(GTestDBusHandle self);
	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_unset();
	[DllImport(Libraries.Gio)]
	internal static extern GTestDBusHandle g_test_dbus_new(GTestDBusFlags flags);
}
