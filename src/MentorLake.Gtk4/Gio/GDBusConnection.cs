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

public class GDBusConnectionHandle : GObjectHandle
{
	public static GDBusConnectionHandle GDbusConnectionNewFinish(GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_new_finish(res, out error);
	}
	public static GDBusConnectionHandle GDbusConnectionNewForAddressFinish(GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_new_for_address_finish(res, out error);
	}
	public static GDBusConnectionHandle GDbusConnectionNewForAddressSync(string address, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_new_for_address_sync(address, flags, observer, cancellable, out error);
	}
	public static GDBusConnectionHandle GDbusConnectionNewSync(GIOStreamHandle stream, string guid, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_new_sync(stream, guid, flags, observer, cancellable, out error);
	}
}

public class GDBusConnectionSignal
{
	public string Value { get; set; }
	public GDBusConnectionSignal(string value) => Value = value;
}

public static class GDBusConnectionSignals
{
	public static GDBusConnectionSignal Closed = new("closed");
}

public static class GDBusConnectionHandleExtensions
{
	public static uint GDbusConnectionAddFilter(this GDBusConnectionHandle connection, GDBusMessageFilterFunction filter_function, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		return GDBusConnectionExterns.g_dbus_connection_add_filter(connection, filter_function, user_data, user_data_free_func);
	}

	public static GDBusConnectionHandle GDbusConnectionCall(this GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionExterns.g_dbus_connection_call(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, cancellable, callback, user_data);
		return connection;
	}

	public static GVariantHandle GDbusConnectionCallFinish(this GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_call_finish(connection, res, out error);
	}

	public static GVariantHandle GDbusConnectionCallSync(this GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_call_sync(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, cancellable, out error);
	}

	public static GDBusConnectionHandle GDbusConnectionCallWithUnixFdList(this GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionExterns.g_dbus_connection_call_with_unix_fd_list(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, fd_list, cancellable, callback, user_data);
		return connection;
	}

	public static GVariantHandle GDbusConnectionCallWithUnixFdListFinish(this GDBusConnectionHandle connection, out GUnixFDListHandle out_fd_list, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_call_with_unix_fd_list_finish(connection, out out_fd_list, res, out error);
	}

	public static GVariantHandle GDbusConnectionCallWithUnixFdListSync(this GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, out GUnixFDListHandle out_fd_list, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_call_with_unix_fd_list_sync(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, fd_list, out out_fd_list, cancellable, out error);
	}

	public static GDBusConnectionHandle GDbusConnectionClose(this GDBusConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionExterns.g_dbus_connection_close(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool GDbusConnectionCloseFinish(this GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_close_finish(connection, res, out error);
	}

	public static bool GDbusConnectionCloseSync(this GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_close_sync(connection, cancellable, out error);
	}

	public static bool GDbusConnectionEmitSignal(this GDBusConnectionHandle connection, string destination_bus_name, string object_path, string interface_name, string signal_name, GVariantHandle parameters, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_emit_signal(connection, destination_bus_name, object_path, interface_name, signal_name, parameters, out error);
	}

	public static uint GDbusConnectionExportActionGroup(this GDBusConnectionHandle connection, string object_path, GActionGroupHandle action_group, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_export_action_group(connection, object_path, action_group, out error);
	}

	public static uint GDbusConnectionExportMenuModel(this GDBusConnectionHandle connection, string object_path, GMenuModelHandle menu, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_export_menu_model(connection, object_path, menu, out error);
	}

	public static GDBusConnectionHandle GDbusConnectionFlush(this GDBusConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionExterns.g_dbus_connection_flush(connection, cancellable, callback, user_data);
		return connection;
	}

	public static bool GDbusConnectionFlushFinish(this GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_flush_finish(connection, res, out error);
	}

	public static bool GDbusConnectionFlushSync(this GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_flush_sync(connection, cancellable, out error);
	}

	public static GDBusCapabilityFlags GDbusConnectionGetCapabilities(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_capabilities(connection);
	}

	public static bool GDbusConnectionGetExitOnClose(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_exit_on_close(connection);
	}

	public static GDBusConnectionFlags GDbusConnectionGetFlags(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_flags(connection);
	}

	public static string GDbusConnectionGetGuid(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_guid(connection);
	}

	public static uint GDbusConnectionGetLastSerial(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_last_serial(connection);
	}

	public static GCredentialsHandle GDbusConnectionGetPeerCredentials(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_peer_credentials(connection);
	}

	public static GIOStreamHandle GDbusConnectionGetStream(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_stream(connection);
	}

	public static string GDbusConnectionGetUniqueName(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_get_unique_name(connection);
	}

	public static bool GDbusConnectionIsClosed(this GDBusConnectionHandle connection)
	{
		return GDBusConnectionExterns.g_dbus_connection_is_closed(connection);
	}

	public static uint GDbusConnectionRegisterObject(this GDBusConnectionHandle connection, string object_path, GDBusInterfaceInfoHandle interface_info, GDBusInterfaceVTableHandle vtable, IntPtr user_data, GDestroyNotify user_data_free_func, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_register_object(connection, object_path, interface_info, vtable, user_data, user_data_free_func, out error);
	}

	public static uint GDbusConnectionRegisterObjectWithClosures(this GDBusConnectionHandle connection, string object_path, GDBusInterfaceInfoHandle interface_info, GClosureHandle method_call_closure, GClosureHandle get_property_closure, GClosureHandle set_property_closure, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_register_object_with_closures(connection, object_path, interface_info, method_call_closure, get_property_closure, set_property_closure, out error);
	}

	public static uint GDbusConnectionRegisterSubtree(this GDBusConnectionHandle connection, string object_path, GDBusSubtreeVTableHandle vtable, GDBusSubtreeFlags flags, IntPtr user_data, GDestroyNotify user_data_free_func, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_register_subtree(connection, object_path, vtable, flags, user_data, user_data_free_func, out error);
	}

	public static GDBusConnectionHandle GDbusConnectionRemoveFilter(this GDBusConnectionHandle connection, uint filter_id)
	{
		GDBusConnectionExterns.g_dbus_connection_remove_filter(connection, filter_id);
		return connection;
	}

	public static bool GDbusConnectionSendMessage(this GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, out uint out_serial, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_send_message(connection, message, flags, out out_serial, out error);
	}

	public static GDBusConnectionHandle GDbusConnectionSendMessageWithReply(this GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionExterns.g_dbus_connection_send_message_with_reply(connection, message, flags, timeout_msec, out out_serial, cancellable, callback, user_data);
		return connection;
	}

	public static GDBusMessageHandle GDbusConnectionSendMessageWithReplyFinish(this GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_send_message_with_reply_finish(connection, res, out error);
	}

	public static GDBusMessageHandle GDbusConnectionSendMessageWithReplySync(this GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDBusConnectionExterns.g_dbus_connection_send_message_with_reply_sync(connection, message, flags, timeout_msec, out out_serial, cancellable, out error);
	}

	public static GDBusConnectionHandle GDbusConnectionSetExitOnClose(this GDBusConnectionHandle connection, bool exit_on_close)
	{
		GDBusConnectionExterns.g_dbus_connection_set_exit_on_close(connection, exit_on_close);
		return connection;
	}

	public static uint GDbusConnectionSignalSubscribe(this GDBusConnectionHandle connection, string sender, string interface_name, string member, string object_path, string arg0, GDBusSignalFlags flags, GDBusSignalCallback callback, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		return GDBusConnectionExterns.g_dbus_connection_signal_subscribe(connection, sender, interface_name, member, object_path, arg0, flags, callback, user_data, user_data_free_func);
	}

	public static GDBusConnectionHandle GDbusConnectionSignalUnsubscribe(this GDBusConnectionHandle connection, uint subscription_id)
	{
		GDBusConnectionExterns.g_dbus_connection_signal_unsubscribe(connection, subscription_id);
		return connection;
	}

	public static GDBusConnectionHandle GDbusConnectionStartMessageProcessing(this GDBusConnectionHandle connection)
	{
		GDBusConnectionExterns.g_dbus_connection_start_message_processing(connection);
		return connection;
	}

	public static GDBusConnectionHandle GDbusConnectionUnexportActionGroup(this GDBusConnectionHandle connection, uint export_id)
	{
		GDBusConnectionExterns.g_dbus_connection_unexport_action_group(connection, export_id);
		return connection;
	}

	public static GDBusConnectionHandle GDbusConnectionUnexportMenuModel(this GDBusConnectionHandle connection, uint export_id)
	{
		GDBusConnectionExterns.g_dbus_connection_unexport_menu_model(connection, export_id);
		return connection;
	}

	public static bool GDbusConnectionUnregisterObject(this GDBusConnectionHandle connection, uint registration_id)
	{
		return GDBusConnectionExterns.g_dbus_connection_unregister_object(connection, registration_id);
	}

	public static bool GDbusConnectionUnregisterSubtree(this GDBusConnectionHandle connection, uint registration_id)
	{
		return GDBusConnectionExterns.g_dbus_connection_unregister_subtree(connection, registration_id);
	}

	public static GDBusConnectionHandle GDbusConnectionNew(this GDBusConnectionHandle @handle, GIOStreamHandle stream, string guid, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionExterns.g_dbus_connection_new(stream, guid, flags, observer, cancellable, callback, user_data);
		return @handle;
	}

	public static void GDbusConnectionNewForAddress(this string address, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionExterns.g_dbus_connection_new_for_address(address, flags, observer, cancellable, callback, user_data);
	}

	public static uint GBusOwnNameOnConnectionWithClosures(this GDBusConnectionHandle connection, string name, GBusNameOwnerFlags flags, GClosureHandle name_acquired_closure, GClosureHandle name_lost_closure)
	{
		return GDBusConnectionExterns.g_bus_own_name_on_connection_with_closures(connection, name, flags, name_acquired_closure, name_lost_closure);
	}

	public static uint GBusWatchNameOnConnection(this GDBusConnectionHandle connection, string name, GBusNameWatcherFlags flags, GBusNameAppearedCallback name_appeared_handler, GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		return GDBusConnectionExterns.g_bus_watch_name_on_connection(connection, name, flags, name_appeared_handler, name_vanished_handler, user_data, user_data_free_func);
	}

	public static uint GBusOwnNameOnConnection(this GDBusConnectionHandle connection, string name, GBusNameOwnerFlags flags, GBusNameAcquiredCallback name_acquired_handler, GBusNameLostCallback name_lost_handler, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		return GDBusConnectionExterns.g_bus_own_name_on_connection(connection, name, flags, name_acquired_handler, name_lost_handler, user_data, user_data_free_func);
	}

	public static uint GBusWatchNameOnConnectionWithClosures(this GDBusConnectionHandle connection, string name, GBusNameWatcherFlags flags, GClosureHandle name_appeared_closure, GClosureHandle name_vanished_closure)
	{
		return GDBusConnectionExterns.g_bus_watch_name_on_connection_with_closures(connection, name, flags, name_appeared_closure, name_vanished_closure);
	}

	public static GDBusConnectionHandle Connect(this GDBusConnectionHandle instance, GDBusConnectionSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GDBusConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_add_filter(GDBusConnectionHandle connection, GDBusMessageFilterFunction filter_function, IntPtr user_data, GDestroyNotify user_data_free_func);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_call(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_connection_call_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_connection_call_sync(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_call_with_unix_fd_list(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_connection_call_with_unix_fd_list_finish(GDBusConnectionHandle connection, out GUnixFDListHandle out_fd_list, GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_connection_call_with_unix_fd_list_sync(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, out GUnixFDListHandle out_fd_list, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_close(GDBusConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_close_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_close_sync(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_emit_signal(GDBusConnectionHandle connection, string destination_bus_name, string object_path, string interface_name, string signal_name, GVariantHandle parameters, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_export_action_group(GDBusConnectionHandle connection, string object_path, GActionGroupHandle action_group, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_export_menu_model(GDBusConnectionHandle connection, string object_path, GMenuModelHandle menu, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_flush(GDBusConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_flush_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_flush_sync(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusCapabilityFlags g_dbus_connection_get_capabilities(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_get_exit_on_close(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionFlags g_dbus_connection_get_flags(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_connection_get_guid(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_get_last_serial(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_dbus_connection_get_peer_credentials(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern GIOStreamHandle g_dbus_connection_get_stream(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_connection_get_unique_name(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_is_closed(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_register_object(GDBusConnectionHandle connection, string object_path, GDBusInterfaceInfoHandle interface_info, GDBusInterfaceVTableHandle vtable, IntPtr user_data, GDestroyNotify user_data_free_func, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_register_object_with_closures(GDBusConnectionHandle connection, string object_path, GDBusInterfaceInfoHandle interface_info, GClosureHandle method_call_closure, GClosureHandle get_property_closure, GClosureHandle set_property_closure, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_register_subtree(GDBusConnectionHandle connection, string object_path, GDBusSubtreeVTableHandle vtable, GDBusSubtreeFlags flags, IntPtr user_data, GDestroyNotify user_data_free_func, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_remove_filter(GDBusConnectionHandle connection, uint filter_id);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_send_message(GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, out uint out_serial, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_send_message_with_reply(GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_connection_send_message_with_reply_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_connection_send_message_with_reply_sync(GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_set_exit_on_close(GDBusConnectionHandle connection, bool exit_on_close);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_connection_signal_subscribe(GDBusConnectionHandle connection, string sender, string interface_name, string member, string object_path, string arg0, GDBusSignalFlags flags, GDBusSignalCallback callback, IntPtr user_data, GDestroyNotify user_data_free_func);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_signal_unsubscribe(GDBusConnectionHandle connection, uint subscription_id);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_start_message_processing(GDBusConnectionHandle connection);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_unexport_action_group(GDBusConnectionHandle connection, uint export_id);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_unexport_menu_model(GDBusConnectionHandle connection, uint export_id);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_unregister_object(GDBusConnectionHandle connection, uint registration_id);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_connection_unregister_subtree(GDBusConnectionHandle connection, uint registration_id);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_new(GIOStreamHandle stream, string guid, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_connection_new_for_address(string address, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_bus_own_name_on_connection_with_closures(GDBusConnectionHandle connection, string name, GBusNameOwnerFlags flags, GClosureHandle name_acquired_closure, GClosureHandle name_lost_closure);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_bus_watch_name_on_connection(GDBusConnectionHandle connection, string name, GBusNameWatcherFlags flags, GBusNameAppearedCallback name_appeared_handler, GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, GDestroyNotify user_data_free_func);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_bus_own_name_on_connection(GDBusConnectionHandle connection, string name, GBusNameOwnerFlags flags, GBusNameAcquiredCallback name_acquired_handler, GBusNameLostCallback name_lost_handler, IntPtr user_data, GDestroyNotify user_data_free_func);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_bus_watch_name_on_connection_with_closures(GDBusConnectionHandle connection, string name, GBusNameWatcherFlags flags, GClosureHandle name_appeared_closure, GClosureHandle name_vanished_closure);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_connection_new_finish(GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_connection_new_for_address_finish(GAsyncResultHandle res, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_connection_new_for_address_sync(string address, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_connection_new_sync(GIOStreamHandle stream, string guid, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error);
}
