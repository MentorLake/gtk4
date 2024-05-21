namespace MentorLake.Gtk4.Gio;

public class GDBusAnnotationInfoHandle : BaseSafeHandle
{
}


public static class GDBusAnnotationInfoHandleExtensions
{
	public static GDBusAnnotationInfoHandle GDbusAnnotationInfoRef(this GDBusAnnotationInfoHandle info)
	{
		return GDBusAnnotationInfoExterns.g_dbus_annotation_info_ref(info);
	}

	public static GDBusAnnotationInfoHandle GDbusAnnotationInfoUnref(this GDBusAnnotationInfoHandle info)
	{
		GDBusAnnotationInfoExterns.g_dbus_annotation_info_unref(info);
		return info;
	}

}
internal class GDBusAnnotationInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusAnnotationInfoHandle g_dbus_annotation_info_ref(GDBusAnnotationInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_annotation_info_unref(GDBusAnnotationInfoHandle info);

}

public struct GDBusAnnotationInfo
{
	public int ref_count;
	public string key;
	public string value;
	public GDBusAnnotationInfoHandle[] annotations;
}
