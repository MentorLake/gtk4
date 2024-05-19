namespace MentorLake.Gtk4.Gio;

public class GDBusActionGroupHandle : GObjectHandle, GActionGroupHandle, GRemoteActionGroupHandle
{
	public static GDBusActionGroupHandle GDbusActionGroupGet(GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusActionGroupExterns.g_dbus_action_group_get(connection, bus_name, object_path);
	}

}

public static class GDBusActionGroupHandleExtensions
{
}

internal class GDBusActionGroupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusActionGroupHandle g_dbus_action_group_get(GDBusConnectionHandle connection, string bus_name, string object_path);

}
