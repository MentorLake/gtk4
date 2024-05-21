namespace MentorLake.Gtk4.Gio;

public class GDBusSignalInfoHandle : BaseSafeHandle
{
}


public static class GDBusSignalInfoHandleExtensions
{
	public static GDBusSignalInfoHandle GDbusSignalInfoRef(this GDBusSignalInfoHandle info)
	{
		return GDBusSignalInfoExterns.g_dbus_signal_info_ref(info);
	}

	public static GDBusSignalInfoHandle GDbusSignalInfoUnref(this GDBusSignalInfoHandle info)
	{
		GDBusSignalInfoExterns.g_dbus_signal_info_unref(info);
		return info;
	}

}
internal class GDBusSignalInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusSignalInfoHandle g_dbus_signal_info_ref(GDBusSignalInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_signal_info_unref(GDBusSignalInfoHandle info);

}

public struct GDBusSignalInfo
{
	public int ref_count;
	public string name;
	public GDBusArgInfoHandle[] args;
	public GDBusAnnotationInfoHandle[] annotations;
}
