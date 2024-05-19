namespace MentorLake.Gtk4.Gio;

public class GDBusObjectProxyHandle : GObjectHandle, GDBusObjectHandle
{
	public static GDBusObjectProxyHandle GDbusObjectProxyNew(GDBusConnectionHandle connection, string object_path)
	{
		return GDBusObjectProxyExterns.g_dbus_object_proxy_new(connection, object_path);
	}

}

public static class GDBusObjectProxyHandleExtensions
{
	public static GDBusConnectionHandle GDbusObjectProxyGetConnection(this GDBusObjectProxyHandle proxy)
	{
		return GDBusObjectProxyExterns.g_dbus_object_proxy_get_connection(proxy);
	}

}

internal class GDBusObjectProxyExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectProxyHandle g_dbus_object_proxy_new(GDBusConnectionHandle connection, string object_path);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_object_proxy_get_connection(GDBusObjectProxyHandle proxy);

}
