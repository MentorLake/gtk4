namespace MentorLake.Gtk4.Gio;

public class GDBusErrorEntryHandle : BaseSafeHandle
{
}

internal class GDBusErrorEntryExterns
{
}

public struct GDBusErrorEntry
{
	public int error_code;
	public string dbus_error_name;
}
