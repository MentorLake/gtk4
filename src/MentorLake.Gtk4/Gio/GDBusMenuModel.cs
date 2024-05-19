namespace MentorLake.Gtk4.Gio;

public class GDBusMenuModelHandle : GMenuModelHandle
{
	public static GDBusMenuModelHandle GDbusMenuModelGet(GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusMenuModelExterns.g_dbus_menu_model_get(connection, bus_name, object_path);
	}

}

public static class GDBusMenuModelHandleExtensions
{
}

internal class GDBusMenuModelExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMenuModelHandle g_dbus_menu_model_get(GDBusConnectionHandle connection, string bus_name, string object_path);

}
