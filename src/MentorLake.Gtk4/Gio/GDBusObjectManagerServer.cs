namespace MentorLake.Gtk4.Gio;

public class GDBusObjectManagerServerHandle : GObjectHandle, GDBusObjectManagerHandle
{
	public static GDBusObjectManagerServerHandle GDbusObjectManagerServerNew(string object_path)
	{
		return GDBusObjectManagerServerExterns.g_dbus_object_manager_server_new(object_path);
	}

}

public static class GDBusObjectManagerServerHandleExtensions
{
	public static GDBusObjectManagerServerHandle GDbusObjectManagerServerExport(this GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object)
	{
		GDBusObjectManagerServerExterns.g_dbus_object_manager_server_export(manager, @object);
		return manager;
	}

	public static GDBusObjectManagerServerHandle GDbusObjectManagerServerExportUniquely(this GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object)
	{
		GDBusObjectManagerServerExterns.g_dbus_object_manager_server_export_uniquely(manager, @object);
		return manager;
	}

	public static GDBusConnectionHandle GDbusObjectManagerServerGetConnection(this GDBusObjectManagerServerHandle manager)
	{
		return GDBusObjectManagerServerExterns.g_dbus_object_manager_server_get_connection(manager);
	}

	public static bool GDbusObjectManagerServerIsExported(this GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object)
	{
		return GDBusObjectManagerServerExterns.g_dbus_object_manager_server_is_exported(manager, @object);
	}

	public static GDBusObjectManagerServerHandle GDbusObjectManagerServerSetConnection(this GDBusObjectManagerServerHandle manager, GDBusConnectionHandle connection)
	{
		GDBusObjectManagerServerExterns.g_dbus_object_manager_server_set_connection(manager, connection);
		return manager;
	}

	public static bool GDbusObjectManagerServerUnexport(this GDBusObjectManagerServerHandle manager, string object_path)
	{
		return GDBusObjectManagerServerExterns.g_dbus_object_manager_server_unexport(manager, object_path);
	}

}

internal class GDBusObjectManagerServerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectManagerServerHandle g_dbus_object_manager_server_new(string object_path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_manager_server_export(GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_manager_server_export_uniquely(GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_object_manager_server_get_connection(GDBusObjectManagerServerHandle manager);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_object_manager_server_is_exported(GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_object_manager_server_set_connection(GDBusObjectManagerServerHandle manager, GDBusConnectionHandle connection);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_object_manager_server_unexport(GDBusObjectManagerServerHandle manager, string object_path);

}
