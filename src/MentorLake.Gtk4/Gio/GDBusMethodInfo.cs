namespace MentorLake.Gtk4.Gio;

public class GDBusMethodInfoHandle : BaseSafeHandle
{
}


public static class GDBusMethodInfoHandleExtensions
{
	public static GDBusMethodInfoHandle GDbusMethodInfoRef(this GDBusMethodInfoHandle info)
	{
		return GDBusMethodInfoExterns.g_dbus_method_info_ref(info);
	}

	public static GDBusMethodInfoHandle GDbusMethodInfoUnref(this GDBusMethodInfoHandle info)
	{
		GDBusMethodInfoExterns.g_dbus_method_info_unref(info);
		return info;
	}

}
internal class GDBusMethodInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMethodInfoHandle g_dbus_method_info_ref(GDBusMethodInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_info_unref(GDBusMethodInfoHandle info);

}

public struct GDBusMethodInfo
{
	public int ref_count;
	public string name;
	public GDBusArgInfoHandle[] in_args;
	public GDBusArgInfoHandle[] out_args;
	public GDBusAnnotationInfoHandle[] annotations;
}
