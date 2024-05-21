namespace MentorLake.Gtk4.Gio;

public class GDBusPropertyInfoHandle : BaseSafeHandle
{
}


public static class GDBusPropertyInfoHandleExtensions
{
	public static GDBusPropertyInfoHandle GDbusPropertyInfoRef(this GDBusPropertyInfoHandle info)
	{
		return GDBusPropertyInfoExterns.g_dbus_property_info_ref(info);
	}

	public static GDBusPropertyInfoHandle GDbusPropertyInfoUnref(this GDBusPropertyInfoHandle info)
	{
		GDBusPropertyInfoExterns.g_dbus_property_info_unref(info);
		return info;
	}

}
internal class GDBusPropertyInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusPropertyInfoHandle g_dbus_property_info_ref(GDBusPropertyInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_property_info_unref(GDBusPropertyInfoHandle info);

}

public struct GDBusPropertyInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public GDBusPropertyInfoFlags flags;
	public GDBusAnnotationInfoHandle[] annotations;
}
