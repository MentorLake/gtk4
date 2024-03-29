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

public class GDBusProxyHandle : GObjectHandle
{
	public static GDBusProxyHandle GDbusProxyNewFinish(GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_new_finish(res, out error);
	}

	public static GDBusProxyHandle GDbusProxyNewForBusFinish(GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_new_for_bus_finish(res, out error);
	}

	public static GDBusProxyHandle GDbusProxyNewForBusSync(GBusType bus_type, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_new_for_bus_sync(bus_type, flags, info, name, object_path, interface_name, cancellable, out error);
	}

	public static GDBusProxyHandle GDbusProxyNewSync(GDBusConnectionHandle connection, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_new_sync(connection, flags, info, name, object_path, interface_name, cancellable, out error);
	}

	public static void GDbusProxyNew(GDBusConnectionHandle connection, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyExterns.g_dbus_proxy_new(connection, flags, info, name, object_path, interface_name, cancellable, callback, user_data);
	}

	public static void GDbusProxyNewForBus(GBusType bus_type, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyExterns.g_dbus_proxy_new_for_bus(bus_type, flags, info, name, object_path, interface_name, cancellable, callback, user_data);
	}

}

public class GDBusProxySignal
{
	public string Value { get; set; }
	public GDBusProxySignal(string value) => Value = value;
}

public static class GDBusProxySignals
{
	public static GDBusProxySignal GPropertiesChanged = new("g-properties-changed");
	public static GDBusProxySignal GSignal = new("g-signal");
}

public static class GDBusProxyHandleExtensions
{
	public static GDBusProxyHandle GDbusProxyCall(this GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyExterns.g_dbus_proxy_call(proxy, method_name, parameters, flags, timeout_msec, cancellable, callback, user_data);
		return proxy;
	}

	public static GVariantHandle GDbusProxyCallFinish(this GDBusProxyHandle proxy, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_call_finish(proxy, res, out error);
	}

	public static GVariantHandle GDbusProxyCallSync(this GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_call_sync(proxy, method_name, parameters, flags, timeout_msec, cancellable, out error);
	}

	public static GDBusProxyHandle GDbusProxyCallWithUnixFdList(this GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusProxyExterns.g_dbus_proxy_call_with_unix_fd_list(proxy, method_name, parameters, flags, timeout_msec, fd_list, cancellable, callback, user_data);
		return proxy;
	}

	public static GVariantHandle GDbusProxyCallWithUnixFdListFinish(this GDBusProxyHandle proxy, out GUnixFDListHandle out_fd_list, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_call_with_unix_fd_list_finish(proxy, out out_fd_list, res, out error);
	}

	public static GVariantHandle GDbusProxyCallWithUnixFdListSync(this GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, out GUnixFDListHandle out_fd_list, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusProxyExterns.g_dbus_proxy_call_with_unix_fd_list_sync(proxy, method_name, parameters, flags, timeout_msec, fd_list, out out_fd_list, cancellable, out error);
	}

	public static GVariantHandle GDbusProxyGetCachedProperty(this GDBusProxyHandle proxy, string property_name)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_cached_property(proxy, property_name);
	}

	public static string[] GDbusProxyGetCachedPropertyNames(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_cached_property_names(proxy);
	}

	public static GDBusConnectionHandle GDbusProxyGetConnection(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_connection(proxy);
	}

	public static int GDbusProxyGetDefaultTimeout(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_default_timeout(proxy);
	}

	public static GDBusProxyFlags GDbusProxyGetFlags(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_flags(proxy);
	}

	public static GDBusInterfaceInfoHandle GDbusProxyGetInterfaceInfo(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_interface_info(proxy);
	}

	public static string GDbusProxyGetInterfaceName(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_interface_name(proxy);
	}

	public static string GDbusProxyGetName(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_name(proxy);
	}

	public static string GDbusProxyGetNameOwner(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_name_owner(proxy);
	}

	public static string GDbusProxyGetObjectPath(this GDBusProxyHandle proxy)
	{
		return GDBusProxyExterns.g_dbus_proxy_get_object_path(proxy);
	}

	public static GDBusProxyHandle GDbusProxySetCachedProperty(this GDBusProxyHandle proxy, string property_name, GVariantHandle value)
	{
		GDBusProxyExterns.g_dbus_proxy_set_cached_property(proxy, property_name, value);
		return proxy;
	}

	public static GDBusProxyHandle GDbusProxySetDefaultTimeout(this GDBusProxyHandle proxy, int timeout_msec)
	{
		GDBusProxyExterns.g_dbus_proxy_set_default_timeout(proxy, timeout_msec);
		return proxy;
	}

	public static GDBusProxyHandle GDbusProxySetInterfaceInfo(this GDBusProxyHandle proxy, GDBusInterfaceInfoHandle info)
	{
		GDBusProxyExterns.g_dbus_proxy_set_interface_info(proxy, info);
		return proxy;
	}

	public static GDBusProxyHandle Connect(this GDBusProxyHandle instance, GDBusProxySignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GDBusProxyExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusProxyHandle g_dbus_proxy_new_finish(GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusProxyHandle g_dbus_proxy_new_for_bus_finish(GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusProxyHandle g_dbus_proxy_new_for_bus_sync(GBusType bus_type, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusProxyHandle g_dbus_proxy_new_sync(GDBusConnectionHandle connection, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_proxy_call(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_proxy_call_finish(GDBusProxyHandle proxy, GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_proxy_call_sync(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_proxy_call_with_unix_fd_list(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_proxy_call_with_unix_fd_list_finish(GDBusProxyHandle proxy, out GUnixFDListHandle out_fd_list, GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_proxy_call_with_unix_fd_list_sync(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, out GUnixFDListHandle out_fd_list, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_proxy_get_cached_property(GDBusProxyHandle proxy, string property_name);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_dbus_proxy_get_cached_property_names(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_proxy_get_connection(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern int g_dbus_proxy_get_default_timeout(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusProxyFlags g_dbus_proxy_get_flags(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceInfoHandle g_dbus_proxy_get_interface_info(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_proxy_get_interface_name(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_proxy_get_name(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_proxy_get_name_owner(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_proxy_get_object_path(GDBusProxyHandle proxy);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_proxy_set_cached_property(GDBusProxyHandle proxy, string property_name, GVariantHandle value);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_proxy_set_default_timeout(GDBusProxyHandle proxy, int timeout_msec);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_proxy_set_interface_info(GDBusProxyHandle proxy, GDBusInterfaceInfoHandle info);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_proxy_new(GDBusConnectionHandle connection, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_proxy_new_for_bus(GBusType bus_type, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
}
