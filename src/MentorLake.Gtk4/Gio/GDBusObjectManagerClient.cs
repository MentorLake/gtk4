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

public class GDBusObjectManagerClientHandle : GObjectHandle
{
	public static GDBusObjectManagerClientHandle GDbusObjectManagerClientNewFinish(GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_new_finish(res, out error);
	}
	public static GDBusObjectManagerClientHandle GDbusObjectManagerClientNewForBusFinish(GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_new_for_bus_finish(res, out error);
	}
	public static GDBusObjectManagerClientHandle GDbusObjectManagerClientNewForBusSync(GBusType bus_type, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_new_for_bus_sync(bus_type, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, out error);
	}
	public static GDBusObjectManagerClientHandle GDbusObjectManagerClientNewSync(GDBusConnectionHandle connection, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_new_sync(connection, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, out error);
	}
}

public class GDBusObjectManagerClientSignal
{
	public string Value { get; set; }
	public GDBusObjectManagerClientSignal(string value) => Value = value;
}

public static class GDBusObjectManagerClientSignals
{
	public static GDBusObjectManagerClientSignal InterfaceProxyPropertiesChanged = new("interface-proxy-properties-changed");
	public static GDBusObjectManagerClientSignal InterfaceProxySignal = new("interface-proxy-signal");
}

public static class GDBusObjectManagerClientHandleExtensions
{
	public static GDBusConnectionHandle GDbusObjectManagerClientGetConnection(this GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_get_connection(manager);
	}

	public static GDBusObjectManagerClientFlags GDbusObjectManagerClientGetFlags(this GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_get_flags(manager);
	}

	public static string GDbusObjectManagerClientGetName(this GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_get_name(manager);
	}

	public static string GDbusObjectManagerClientGetNameOwner(this GDBusObjectManagerClientHandle manager)
	{
		return GDBusObjectManagerClientExterns.g_dbus_object_manager_client_get_name_owner(manager);
	}

	public static GDBusObjectManagerClientHandle Connect(this GDBusObjectManagerClientHandle instance, GDBusObjectManagerClientSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GDBusObjectManagerClientExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_object_manager_client_get_connection(GDBusObjectManagerClientHandle manager);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientFlags g_dbus_object_manager_client_get_flags(GDBusObjectManagerClientHandle manager);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_object_manager_client_get_name(GDBusObjectManagerClientHandle manager);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_object_manager_client_get_name_owner(GDBusObjectManagerClientHandle manager);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_finish(GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_finish(GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_sync(GBusType bus_type, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_sync(GDBusConnectionHandle connection, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error);
}
