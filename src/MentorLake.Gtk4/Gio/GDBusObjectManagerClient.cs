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

public class GDBusObjectManagerClientHandle : GObjectHandle, GAsyncInitableHandle, GDBusObjectManagerHandle, GInitableHandle
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

	public static void GDbusObjectManagerClientNew(GDBusConnectionHandle connection, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusObjectManagerClientExterns.g_dbus_object_manager_client_new(connection, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, callback, user_data);
	}

	public static void GDbusObjectManagerClientNewForBus(GBusType bus_type, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusObjectManagerClientExterns.g_dbus_object_manager_client_new_for_bus(bus_type, flags, name, object_path, get_proxy_type_func, get_proxy_type_user_data, get_proxy_type_destroy_notify, cancellable, callback, user_data);
	}

}

public static class GDBusObjectManagerClientSignalExtensions
{
	public static GDBusObjectManagerClientHandle Signal_InterfaceProxyPropertiesChanged(this GDBusObjectManagerClientHandle instance, GDBusObjectManagerClientSignalDelegates.InterfaceProxyPropertiesChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "interface_proxy_properties_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GDBusObjectManagerClientHandle Signal_InterfaceProxySignal(this GDBusObjectManagerClientHandle instance, GDBusObjectManagerClientSignalDelegates.InterfaceProxySignal handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "interface_proxy_signal", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GDBusObjectManagerClientSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void InterfaceProxyPropertiesChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusObjectManagerClientHandle>))] GDBusObjectManagerClientHandle self, GDBusObjectProxyHandle object_proxy, GDBusProxyHandle interface_proxy, GVariantHandle changed_properties, string[] invalidated_properties, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void InterfaceProxySignal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusObjectManagerClientHandle>))] GDBusObjectManagerClientHandle self, GDBusObjectProxyHandle object_proxy, GDBusProxyHandle interface_proxy, string sender_name, string signal_name, GVariantHandle parameters, IntPtr user_data);
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

}

internal class GDBusObjectManagerClientExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_finish(GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_finish(GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_for_bus_sync(GBusType bus_type, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientHandle g_dbus_object_manager_client_new_sync(GDBusConnectionHandle connection, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_object_manager_client_get_connection(GDBusObjectManagerClientHandle manager);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerClientFlags g_dbus_object_manager_client_get_flags(GDBusObjectManagerClientHandle manager);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_object_manager_client_get_name(GDBusObjectManagerClientHandle manager);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_object_manager_client_get_name_owner(GDBusObjectManagerClientHandle manager);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_manager_client_new(GDBusConnectionHandle connection, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_manager_client_new_for_bus(GBusType bus_type, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

}
